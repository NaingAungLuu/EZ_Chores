using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.AppConstants;
using static EZChores.Data.DataVO;

namespace EZChores.Network
{
    class FirebaseModel
    {

        private static FirebaseClient firebaseClient = null;
        
        
        public static Data.DataVO.User currentUser
        {
            get;
            set;
        }
    
        protected FirebaseClient Client
        {
            get 
            { 
                if(firebaseClient == null)
                {
                    firebaseClient = getNewClient();
                }
                return firebaseClient;
            }
        }

        private FirebaseClient getNewClient()
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(AppConstants.DataPoints.API_KEY));

            var auth = authProvider.SignInWithEmailAndPasswordAsync(DataPoints.ADMIN_EMAIL, DataPoints.ADMIN_PASSWORD);

            return new FirebaseClient(DataPoints.BASEURL,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(auth.Result.FirebaseToken)
                });
        }
    }
}
