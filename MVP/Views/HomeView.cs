using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Views
{
    interface HomeView
    {
        void showJobPosts(List<JobPost> jobs);
        void showEmployerStatus(string jobsDone , string activeJobs);
        void showWorkerStatus(string jobsDone, string activeJobs, string appliedJobs);
        void navigateToDetailScreen(string postId);
    }
}
