using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.AppConstants;
using static EZChores.Data.DataVO;

namespace EZChores.Network
{
    class DataModel : FirebaseModel
    {
        private static DataModel instance = null;
        private static String lastJobPost = null;
        
        public static DataModel Instance()
        {
            if(instance == null)
            {
                instance = new DataModel();
            }
            return instance;
        }
        public async Task getData()
        {

            var firebaseClient = new FirebaseClient(DataPoints.BASEURL);

            var dinos = await firebaseClient
                    .Child(DataPoints.USERS)
                    .OrderByKey()
                    .StartAt("user1")
                    .LimitToFirst(2)
                    .OnceAsync<User>();

            Console.WriteLine("Hello");

            foreach (var user in dinos)
            {
                Console.WriteLine("Key = " + user.Key);
                Console.WriteLine("userame = " + user.Object.userName);
                Console.WriteLine("password = " + user.Object.password);
            }

        }

        public async Task<List<JobPost>> getJobPostsByUser(int pageNo)
        {
            List<JobPost> posts = new List<JobPost>();
            if (lastJobPost == null || pageNo == 1)
            {
                var jobPosts = await Client
                     .Child(DataPoints.USERS)
                     .Child(currentUser.userName)
                     .Child(DataPoints.ACTIVE_JOBS)
                     .OrderByKey()
                     .OnceAsync<JobPost>();

                if (jobPosts.Count > 0) { 
                    lastJobPost = jobPosts.Last().Key;

                    foreach (var jobPost in jobPosts)
                    {
                        posts.Add(jobPost.Object);
                    } 
                }
                else
                {
                return null;
                }
            }
            else
            {
                var jobPosts = await Client
                    .Child(DataPoints.USERS)
                    .Child(currentUser.userName)
                    .Child(DataPoints.JOB_POSTS)
                    .OrderByKey()
                    .StartAt(lastJobPost)
                    .LimitToLast(10)
                    .OnceAsync<JobPost>();
                if (jobPosts != null)
                {
                    foreach (var jobPost in jobPosts)
                    {
                        posts.Add(jobPost.Object);
                    }
                }
                else
                {
                    return null;
                }
            }
            return posts;
        }


        public async Task<List<JobPost>> getAllJobs(int pageNo)
        {
            List<JobPost> posts = new List<JobPost>();

            var jobPosts = await Client
                     .Child(DataPoints.CHORES)
                     .OrderByKey()
                     .OnceAsync<JobPost>();

            if (jobPosts.Count > 0)
            {
                lastJobPost = jobPosts.Last().Key;

                foreach (var jobPost in jobPosts)
                {
                    if(jobPost.Object.jobStatus == JobStatus.APPLICABLE)
                    posts.Add(jobPost.Object);
                }
            }
            else
            {
                return null;
            }

            return posts;
        }

        public async Task<List<JobPost>> getHistory(int pageNo)
        {
            List<JobPost> posts = new List<JobPost>();
            if (lastJobPost == null || pageNo == 1)
            {
                var jobPosts = await Client
                     .Child(DataPoints.USERS)
                     .Child(currentUser.userName)
                     .Child(DataPoints.HISTORY)
                     .OrderByKey()
                     .LimitToFirst(10)
                     .OnceAsync<JobPost>();

                if (jobPosts.Count > 0)
                {
                    lastJobPost = jobPosts.Last().Key;

                    foreach (var jobPost in jobPosts)
                    {
                        posts.Add(jobPost.Object);
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                var jobPosts = await Client
                    .Child(DataPoints.USERS)
                    .Child(currentUser.userName)
                    .Child(DataPoints.JOB_POSTS)
                    .OrderByKey()
                    .StartAt(lastJobPost)
                    .LimitToLast(10)
                    .OnceAsync<JobPost>();
                if (jobPosts != null)
                {
                    foreach (var jobPost in jobPosts)
                    {
                        posts.Add(jobPost.Object);
                    }
                }
                else
                {
                    return null;
                }
            }
            return posts;
        }

        public async Task uploadJobPost(JobPostInfo data)
        {
            string timeStamp = DateTime.Now.ToFileTime().ToString();
            JobPost post = new JobPost();
            post.info = data;
            post.postId = timeStamp;
            post.info.uploadedTime = timeStamp;
            post.info.uploadedUser = currentUser;
            post.jobStatus = AppConstants.JobStatus.APPLICABLE;

            //Upload Job Post to CHORES
            await Client.Child(DataPoints.CHORES)
                .Child(timeStamp)
                .PutAsync(post);

            //Add Job Post to employer's active jobs
            await Client.Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.ACTIVE_JOBS)
                .Child(data.uploadedTime)
                .PutAsync(post);

        }

        public async Task applyJob(JobPost jobPost)
        {
            //Add worker to applied users list of the jobpost
            await Client.Child(DataPoints.CHORES)
                .Child(jobPost.postId)
                .Child(DataPoints.APPLIED_USERS)
                .Child(currentUser.userName)
                .PutAsync(currentUser);

            //Add Job Post to worker's applied List
            await Client.Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.APPLIED_JOBS)
                .Child(jobPost.postId)
                .PutAsync(jobPost);
        }

        public async Task<JobPost> getJobPostDetail(string postId)
        {
            
            var jobPost = await Client
                .Child(DataPoints.CHORES)
                .Child(postId)
                .OnceSingleAsync<JobPost>();

            var appliedUsers = await Client.Child(DataPoints.CHORES)
                .Child(postId)
                .Child(DataPoints.APPLIED_USERS)
                .OrderByKey()
                .OnceAsync<User>();

            List<User> appliedUserList = new List<User>(appliedUsers.Count);

            foreach(var user in appliedUsers)
            {
                appliedUserList.Add(user.Object);
                jobPost.applied = (user.Object.userName == currentUser.userName);
                
            }
            jobPost.appliedUsers = appliedUserList;

            return jobPost;
        }

        public async Task payForJob(JobPost jobPost)
        {
            jobPost.jobStatus = JobStatus.DONE;

            //Update the job status of the post in CHORES
            await Client.Child(DataPoints.CHORES)
                .Child(jobPost.postId)
                .PutAsync(jobPost);

            //Remove the current post from worker's active jobs
            await Client.Child(DataPoints.USERS)
                .Child(jobPost.employedUser.userName)
                .Child(DataPoints.ACTIVE_JOBS)
                .Child(jobPost.postId)
                .DeleteAsync();

            //Remove the current post from employer's active jobs
            await Client.Child(DataPoints.USERS)
               .Child(currentUser.userName)
               .Child(DataPoints.ACTIVE_JOBS)
               .Child(jobPost.postId)
               .DeleteAsync();

            //Add the post to employer's history
            await Client.Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.HISTORY)
                .Child(jobPost.postId)
                .PutAsync(jobPost);

            //Add the post to worker's history
            await Client.Child(DataPoints.USERS)
                .Child(jobPost.employedUser.userName)
                .Child(DataPoints.HISTORY)
                .Child(jobPost.postId)
                .PutAsync(jobPost);
        }

        public async Task employUser(User user, JobPost jobPost)
        {
            jobPost.employedUser = user;
            jobPost.jobStatus = JobStatus.APPLIED;

            //Update Job status of the post in CHORES
            await Client.Child(DataPoints.CHORES)
                .Child(jobPost.postId)
                .PutAsync(jobPost);

            //Add the post to worker's active Jobs
            await Client.Child(DataPoints.USERS)
                .Child(user.userName)
                .Child(DataPoints.ACTIVE_JOBS)
                .Child(jobPost.postId)
                .PutAsync(jobPost);

            //Add the post to employer's active Jobs
            await Client.Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.ACTIVE_JOBS)
                .Child(jobPost.postId)
                .PutAsync(jobPost);

        }

        public async Task<List<String>> getStatistics()
        {
            List<String> statistics = new List<String>();

            var choresDone = await Client
                .Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.HISTORY)
                .OnceAsync<JobPost>();

            statistics.Add(choresDone.Count.ToString());

            var activeChores = await Client
                .Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.ACTIVE_JOBS)
                .OnceAsync<JobPost>();

            statistics.Add(activeChores.Count.ToString());

            if(currentUser.userType == UserTypes.WORKER)
            {
                var appliedChores = await Client
                .Child(DataPoints.USERS)
                .Child(currentUser.userName)
                .Child(DataPoints.ACTIVE_JOBS)
                .OnceAsync<JobPostInfo>();

                statistics.Add(appliedChores.Count.ToString());
            }

            return statistics;
        }

    }

    

    
}
