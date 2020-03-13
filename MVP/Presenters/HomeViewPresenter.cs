using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.AppConstants;

namespace EZChores.MVP.Presenters
{
    class HomeViewPresenter : Presenter
    {
        private HomeView mView;
        public HomeViewPresenter(HomeView view)
        {
            mView = view;
        }

        public async void onFormLoad()
        {
            List<String> statistics = await dataModel.getStatistics();
            
            if (currentUser.userType == UserTypes.EMPLOYER)
            {
                mView.showEmployerStatus(statistics[0], statistics[1]);
                
            }
            else
            {
                mView.showWorkerStatus(statistics[0], statistics[1], statistics[2]);
                var jobPosts = await dataModel.getAllJobs(1);
                if (jobPosts != null)
                {
                    mView.showJobPosts(jobPosts);
                }
            }
            
        }

        public void onTapDetails(string postId)
        {
            mView.navigateToDetailScreen(postId);
        }

    }
}
