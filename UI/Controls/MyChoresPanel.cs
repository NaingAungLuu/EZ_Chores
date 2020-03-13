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
using EZChores.UI.Controls;

namespace EZChores.UI
{
    public partial class MyChoresPanel : UserControl , MyChoresView , JobPostDelegate
    {
        private MyChoresPresenter mPresenter;

        public MyChoresPanel()
        {
            mPresenter = new MyChoresPresenter(this);
            InitializeComponent();
            initControls();
        }

        private void onSizeChanged(object sender , EventArgs e)
        {
            int marginLeft = (this.pnlMyChores.Width / 2) - ((600 + 60) / 2);
            this.pnlMyChores.Padding = new Padding(marginLeft/*left*/ , 0/*top*/ , 0 /*right*/ , 0 /*bottom*/);
            
            this.pageController.Location = new Point((marginLeft+60)/2 -(this.pageController.Width/2) -10   , (this.Height - this.pageController.Height) - 50);
        }
        private void initControls()
        {
            this.pageController.Parent = this;
            this.pageController.Location = new Point(this.Location.X + 10 , (this.Height - this.pageController.Height) - 50);
            this.pageController.BringToFront();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            UIController.navigateToAddPostScreen();
        }

        public void showJobPosts(List<JobPost> jobs)
        {
            pnlMyChores.Controls.Clear();
            foreach (var job in jobs)
            {
                ApplicableChore jobPost = new ApplicableChore();
                jobPost.initData(job);
                jobPost.init(this);
                pnlMyChores.Controls.Add(jobPost);
            }
        }

        public void Form_Load(object sender , EventArgs e)
        {
            mPresenter.onFormLoad();
        }

        public void onClickNextPage(object sender , EventArgs e)
        {
            Console.WriteLine("Next Page Clicked");
        }

        public void onClickPreviousPage(object sender, EventArgs e)
        {
            Console.WriteLine("Previous Clicked");
        }

        public void onTapDetails(string postId)
        {
            Console.WriteLine("Post id @MyChorePanel = " + postId);
            mPresenter.onTapDetails(postId);
        }

        public void navigateToDetailScreen(string postId)
        {
            UIController.navigateToJobDetail(postId);
        }
    }
}
