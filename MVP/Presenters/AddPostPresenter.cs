using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Presenters
{
    class AddPostPresenter : Presenter
    {
        private AddPostView mView;

        public AddPostPresenter(AddPostView view)
        {
            this.mView = view;
        }

        public void onPressCancel()
        {
            mView.navigateToHomeScreen();
        }

        public async void onPressPost(JobPostInfo data)
        {
            await dataModel.uploadJobPost(data);
            mView.navigateToHomeScreen();
        }
    }
}
