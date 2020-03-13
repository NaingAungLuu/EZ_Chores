using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using static EZChores.AppConstants;
using static EZChores.Data.DataVO;

namespace EZChores.Network
{
    class AuthenticationModel : FirebaseModel
    {
        private static AuthenticationModel instance = null;
        public static AuthenticationModel Instance()
        {
            if(instance == null)
            {
                instance = new AuthenticationModel();
            }
            return instance;
        }

        private async Task<User> getUserData(String userName)
        {

            var observable = await Client
                    .Child(DataPoints.USERS)
                    .Child(userName)
                    .OrderByKey()
                    .OnceSingleAsync<User>();

            return observable;
        }

        public async Task<Boolean> signUp(SignUpData data)
        {
            var currentUser = await Client
                .Child(DataPoints.USERS)
                .Child(data.userName)
                .OnceSingleAsync<User>();

            if(currentUser == null)
            {
                var newUser = new User();
                newUser.userName = data.userName;
                newUser.password = data.password;
                newUser.fullName = data.fullName;
                newUser.userType = data.userType;
                await Client
                    .Child(DataPoints.USERS)
                    .Child(data.userName)
                    .PutAsync(newUser);

                FirebaseModel.currentUser = newUser;

                return true;
            }
            else
            {
                return false;
            }

            
        }
        
     
        public async Task<Boolean> authenticate(string userName , string password)
        {
            
            Console.WriteLine("Entered User name = " + userName + " , password = " + password);
           
            var user = await getUserData(userName);
            if((user != null) && (password == user.password))
            {
                FirebaseModel.currentUser = user;
                return true;
            }
                return ((user != null) && (password == user.password));
            
        }
    }
}
