using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZChores.MVP.Presenters
{
    class MyChoresPresenter : Presenter
    {
        private MyChoresView mView;
        public MyChoresPresenter(MyChoresView view)
        {
            this.mView = view;
        }

        public async void onFormLoad()
        {
            var jobPosts = await dataModel.getJobPostsByUser(1);
            if (jobPosts != null)
            {
                mView.showJobPosts(jobPosts);
            }
        }

        public void onTapDetails(string postId) 
        {
            mView.navigateToDetailScreen(postId);
        }

    }
}
