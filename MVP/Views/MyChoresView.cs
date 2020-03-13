using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Views
{
    public interface MyChoresView
    {
        void showJobPosts(List<JobPost> jobs);
        void navigateToDetailScreen(string postId);
    }
}
