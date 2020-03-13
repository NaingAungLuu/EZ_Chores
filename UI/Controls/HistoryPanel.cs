using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZChores.MVP.Views;
using EZChores.MVP.Presenters;
using static EZChores.Data.DataVO;

namespace EZChores.UI.Controls
{
    public partial class HistoryPanel : UserControl, HistoryView , JobPostDelegate
    {
        private HistoryPresenter mPresenter;

        public HistoryPanel()
        {
            this.mPresenter = new HistoryPresenter(this);
            InitializeComponent();
            initControls();
        }

        private void initControls()
        {
            this.pageController.Parent = this;
            this.pageController.Location = new Point(this.Location.X + 10, (this.Height - this.pageController.Height) - 50);
            this.pageController.BringToFront();
        }

        public void onClickNextPage(object sender, EventArgs e)
        {
            Console.WriteLine("Next Page Clicked");
        }

        public void onClickPreviousPage(object sender, EventArgs e)
        {
            Console.WriteLine("Previous Clicked");
        }

        public void showJobPosts(List<JobPost> jobs)
        {
            pnlMyChores.Controls.Clear();
            foreach (var job in jobs)
            {
                PaidChore jobPost = new PaidChore();
                jobPost.initData(job);
                jobPost.init(this);
                pnlMyChores.Controls.Add(jobPost);
            }
        }

        public void Form_Load(object sender, EventArgs e)
        {
            mPresenter.onFormLoad();
        }

        public void navigateToDetailScreen(string postId)
        {
            UIController.navigateToJobDetail(postId);
        }

        public void onTapDetails(string postId)
        {
            mPresenter.onPressDetail(postId);
        }

        public void onTapApply(string postId)
        {
            
        }
    }

    
}
