using EZChores.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EZChores.Data.DataVO;

namespace EZChores.UI
{
    static class UIController
    {
        public static void navigateToSignUpForm(Form currentForm)
        {
            var signUpForm = UIRepository.SignUpForm();
            signUpForm.Show();
            currentForm.Hide();
            
        }

        public static void navigateToDashBoardForm(Form currentForm)
        {
            var dashBoardForm = UIRepository.DashBoardForm();
            dashBoardForm.Show();
            currentForm.Hide();
            dashBoardForm.loadForm();
        }

        public static void navigateToLoginForm(Form currentForm)
        {
            var loginForm = UIRepository.LoginForm();
            loginForm.Show();
            currentForm.Hide();
        }

        public static void navigateToHomeScreen()
        {
            var dashBoardForm = UIRepository.DashBoardForm();
            dashBoardForm.swapContentPanel(UIRepository.HomePanel());
        }

        public static void navigateToMyChores()
        {
            var dashBoardForm = UIRepository.DashBoardForm();
            dashBoardForm.swapContentPanel(UIRepository.MyChoresPanel());
        }

        public static void navigateToAddPostScreen()
        {
            var dashBoardForm = UIRepository.DashBoardForm();
            dashBoardForm.swapContentPanel(UIRepository.AddJobPanel());
        }

        public static void navigateToJobDetail(string postId)
        {
            var dashBoardForm = UIRepository.DashBoardForm();
            dashBoardForm.swapContentPanel(UIRepository.JobPostDetail(postId));
        }


        public static void navigateToHistory()
        {
            var dashBoardForm = UIRepository.DashBoardForm();
            dashBoardForm.swapContentPanel(UIRepository.HistoryPanel());
        }

        public static void openAppliedWorkersDialog(JobPost jobPost , JobPostDetailDelegate jobPostDetailDelegate)
        {
            var dialog = UIRepository.AppliedWorkersDialog(jobPost , jobPostDetailDelegate);
            dialog.ShowDialog();
        }

                    
        

    }
}
