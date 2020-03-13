using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using static EZChores.AppConstants;

namespace EZChores.Data
{
    public class DataVO
    {
        public class User
        {
            public string userName { get; set; }
            public string password { get; set; }
            public string fullName { get; set; }
            public string userType { get; set; }

            public int rating { get; set; }
            public User()
            {
                this.userName = "";
                this.password = "";
                this.fullName = "";
                this.userType = UserTypes.WORKER;
            }
        }

        public class SignUpData
        {
            public string userName { get; set; }
            public string fullName { get; set; }
            public string password { get; set; }
            public string userType { get; set; }
            public SignUpData()
            {
                this.userName = "";
                this.fullName = "";
                this.password = "";
                this.userType = UserTypes.WORKER;
            }
            public SignUpData(string userName , string fullName , string password , string userType)
            {
                this.userName = userName;
                this.fullName = fullName;
                this.password = password;
                this.userType = userType;
            }
            
        }

        public class JobPost
        {
            public string postId { get; set; }
            public JobPostInfo info { get; set; }
            public List<string> categories { get; set; }
            [JsonIgnore]
            public List<User> appliedUsers { get; set; }

            [JsonIgnore]
            public Boolean applied { get; set; }
            public User employedUser { get; set; }
            public string jobStatus { get; set; }

            public JobPost()
            {
                this.categories = new List<string>(0);
                this.appliedUsers = new List<User>();
                this.appliedUsers.Add(new User());
            }
        }

        public class JobPostInfo
        {
            public string uploadedTime { get; set; }
            public User uploadedUser { get; set; }
            public string choreType { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string area { get; set; }
            public int duration { get; set; }
            public string startTime { get; set; }

            public string date { get; set; }
            public int payment { get; set; }
            
            public JobPostInfo()
            {
                this.uploadedTime = "";
                this.uploadedUser = null;
                this.choreType = ChoreTypes.HOUSE_KEEPING;
                this.title = "";
                this.description = "";
                this.area = "";
                this.duration = 0;
                this.startTime = "";
                this.payment = 0;
                this.date = "";
            }
        }

        public class Worker : User
        {
            public List<CompletedChore> completedChores;
            public double rating;
            public double earnedMoney;
            public string description;
            
            public Worker()
            {
                this.completedChores = new List<CompletedChore>();
                this.rating = 0;
                this.earnedMoney = 0;
            }
        }

        public class Employer : User
        {
            public List<CompletedChore> appliedChores;
            public double amountSpend;

            public Employer()
            {
                this.appliedChores = new List<CompletedChore>();
                this.amountSpend = 0;
            }
        }

        public class CompletedChore
        {
            public string title;
            public string description;
            public string area;
            public string duration;
            public string payment;

            public CompletedChore()
            {
                this.title = "";
                this.description = "";
                this.area = "";
                this.duration = "";
                this.payment = "";
            }
        }
    }
}
