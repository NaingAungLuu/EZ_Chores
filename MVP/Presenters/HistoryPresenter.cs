using EZChores.MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZChores.MVP.Presenters
{
    class HistoryPresenter : Presenter
    {
        private HistoryView mView;
        public async void onFormLoad()
        {
           var jobList = await dataModel.getHistory(1);
            if(jobList != null)
            {
                mView.showJobPosts(jobList);
            }
        }

        public void onPressDetail(string postId)
        {
            mView.navigateToDetailScreen(postId);
        }

        public HistoryPresenter(HistoryView view)
        {
            this.mView = view;
        }

    }
}
