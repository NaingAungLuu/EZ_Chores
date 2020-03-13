using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.AppConstants;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Presenters
{
    class JobPostDetailPresenter :Presenter
    {
        private JobPostDetailView mView;
        public JobPostDetailPresenter(JobPostDetailView view)
        {
            this.mView = view;
        }

        public async void onFormLoad(string postId)
        {
            var jobPost = await dataModel.getJobPostDetail(postId);
            mView.showJobPostDetails(jobPost);
            mView.setUserTypeBasedView((currentUser.userType == AppConstants.UserTypes.EMPLOYER));
            mView.showAppliedView(jobPost.applied);
        }

        public async void onTapApply(JobPost jobPost)
        {
            if (currentUser.userType == UserTypes.EMPLOYER)
            {
                await dataModel.payForJob(jobPost);
            }
            else
            {
                await dataModel.applyJob(jobPost);
            }
            mView.refresh();
        }

        public void onTapAppliedUsers()
        {
            mView.openAppliedUsersDialog();
        }

        public void onTapCancel()
        {
            mView.navigateToChoresPanel();
        }

    }
}
