using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Presenters
{
    class SignUpFormPresenter : Presenter
    {
        SignUpFormView mView { get; }
        public SignUpFormPresenter(SignUpFormView view)
        {
            this.mView = view;
        }

        public async void onPressSignUp(SignUpData data )
        {
            var success = await authenticationModel.signUp(data);
            if(!success)
            {
                mView.showError("There is already a user with similar data");
            }else{
                mView.navigateToDashBoard();
            }
        }

        public void onPressCancel()
        {
            mView.navigateToLogin();
        }


    }
}
