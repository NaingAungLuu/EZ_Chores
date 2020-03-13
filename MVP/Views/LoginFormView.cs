using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.Views
{
    interface LoginFormView
    {
        void showError(string msg);
        void dispose();

        void navigateToSignUpForm();

        void navigateToDashBoard();
    }
}
