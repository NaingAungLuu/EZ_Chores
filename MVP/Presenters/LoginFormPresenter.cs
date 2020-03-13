using EZChores.MVP.Presenters;
using EZChores.Network;
using EZChores.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZChores.Presenters
{
    class LoginFormPresenter : Presenter
    {
        private AuthenticationModel firebaseAuthenticationModel = new AuthenticationModel();
        LoginFormView mView { get; }
        public LoginFormPresenter(LoginFormView view)
        {
            this.mView = view;
        }

        public async void onPressLogin(string userName , string password)
        {
            if (userName != "" && password != "")
            {
                bool authenticated = await firebaseAuthenticationModel.authenticate(userName, password);
                if (authenticated){
                    mView.navigateToDashBoard();
                }
                else
                {
                    mView.showError("Incorrect Username or Password");
                }
            }
            else{
                mView.showError("Please Enter Every Field!");
            }

        }

        public void onPressSignUp()
        {
            mView.navigateToSignUpForm();
        }
            
    }
}
