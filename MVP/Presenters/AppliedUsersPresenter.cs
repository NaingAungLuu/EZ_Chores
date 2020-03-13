using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Presenters
{
    class AppliedUsersPresenter : Presenter
    {
        private AppliedUsersView mView;
        public async void employUser(User user, JobPost jobPost)
        {
            await dataModel.employUser(user , jobPost);
            mView.closeDialog();
        }

        public AppliedUsersPresenter(AppliedUsersView view)
        {
            this.mView = view;
        }
    }
}
