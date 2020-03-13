using EZChores.MVP.Views;
using EZChores.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZChores.MVP.Presenters
{
    class DashBoardFormPresenter : Presenter
    {
        private DashBoardFormView mView;
        public void onLoadForm()
        {
            
            mView.initUserData(FirebaseModel.currentUser);
        }

        public DashBoardFormPresenter(DashBoardFormView view)
        {
            this.mView = view;
        }

        public void onTapLogOut()
        {
            mView.navigateToLogInScreen();
        }
    }
}
