using EZChores.UI.Controls;
using EZChores.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.UI
{
      static class UIRepository
    {
        
        private static LoginForm loginForm = null;
        private static SignUpForm signUpForm = null;
        private static DashBoardForm dashBoardForm = null;
        private static AppliedWorkersDialog appliedWorkersDialog = null;
        private static AddJobPanel addJobPanel = null;
        private static HistoryPanel historyPanel = null;
        private static JobPostDetail jobPostDetail = null;
        private static MyChoresPanel myChoresPanel = null;
        private static HomePanel homePanel = null;

        public static LoginForm LoginForm()
        {
            if(loginForm == null)
            {
                loginForm = new LoginForm();
            }
            return loginForm;
        }

        public static SignUpForm SignUpForm()
        {
            if(signUpForm == null)
            {
                signUpForm = new SignUpForm();
            }
            return signUpForm;
        }

        public static DashBoardForm DashBoardForm()
        {
            if(dashBoardForm==null)
            {
                dashBoardForm = new DashBoardForm();
            }
            return dashBoardForm;
        }

        public static AppliedWorkersDialog AppliedWorkersDialog(JobPost jobPost , JobPostDetailDelegate jobPostDetailDelegate)
        {
            if (appliedWorkersDialog == null)
            {
                appliedWorkersDialog = new AppliedWorkersDialog(jobPost , jobPostDetailDelegate);
            }
            return appliedWorkersDialog;
        }

        public static AddJobPanel AddJobPanel()
        {
            if (addJobPanel == null)
            {
                addJobPanel = new AddJobPanel();
            }
            return addJobPanel;
        }
        public static HistoryPanel HistoryPanel()
        {
            if (historyPanel == null)
            {
                historyPanel = new HistoryPanel();
            }
            
            return historyPanel;
        }

        public static JobPostDetail JobPostDetail(string postId)
        {
            if (jobPostDetail == null)
            {
                jobPostDetail = new JobPostDetail(postId);
            }
            jobPostDetail.PostId = postId;
            return jobPostDetail;
        }

        public static HomePanel HomePanel()
        {
            if(homePanel == null)
            {
                homePanel = new HomePanel();
            }
            return homePanel;
        }

        public static MyChoresPanel MyChoresPanel()
        {
            if (myChoresPanel == null)
            {
                myChoresPanel = new MyChoresPanel();
            }
            return myChoresPanel;
        }


    }
}
