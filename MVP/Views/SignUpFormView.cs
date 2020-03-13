using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Views
{
    public interface SignUpFormView
    {
        void navigateToLogin();

        void navigateToDashBoard();

        void showError(string msg);
    }
}
