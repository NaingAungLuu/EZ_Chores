using EZChores.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Presenters
{
    class Presenter
    {
        protected User currentUser { get { return FirebaseModel.currentUser; } }
        protected AuthenticationModel authenticationModel = AuthenticationModel.Instance();
        protected DataModel dataModel = DataModel.Instance();
        
    }
}
