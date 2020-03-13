using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EZChores.Data.DataVO;
using EZChores.MVP.Presenters;
using EZChores.MVP.Views;

namespace EZChores.UI.Controls
{
    public partial class HomePanel : UserControl , HomeView , JobPostDelegate
    {
        private HomeViewPresenter mPresenter;
        public HomePanel()
        {
            mPresenter = new HomeViewPresenter(this);
            InitializeComponent();
            initControls();
        }

        private void initControls()
        {
            this.btnAddJob.Parent = this;
            this.btnAddJob.Location = new Point((this.pnlHome.Width / 2) + (660 / 2), (this.Height - this.btnAddJob.Height) - 50);
            this.btnAddJob.BringToFront();
        }

        private void onSizeChanged(object sender, EventArgs e)
        {
            int marginLeft = (this.pnlHome.Width / 2) - ((600 + 60) / 2);
            this.pnlHome.Padding = new Padding(marginLeft/*left*/ , 0/*top*/ , 0 /*right*/ , 0 /*bottom*/);
            btnAddJob.Location = new Point((this.pnlHome.Width / 2) + (660 / 2), (this.Height - this.btnAddJob.Height) - 50);
        }

        public void Form_Load(object sender, EventArgs e)
        {
            mPresenter.onFormLoad();
        }

        public void showJobPosts(List<JobPost> jobs)
        {
            foreach (var job in jobs)
            {
                ApplicableChore jobPost = new ApplicableChore();
                jobPost.initData(job);
                jobPost.init(this);
                pnlHome.Controls.Add(jobPost);
            }
        }

        public void onTapDetails(string postId)
        {
                Console.WriteLine("Post id @MyChorePanel = " + postId);
                mPresenter.onTapDetails(postId);
            
        }

        public void showWorkerStatus(string jobsDone, string activeJobs, string appliedJobs)
        {
            pnlHome.Controls.Clear();
            this.lblJobsDone_Worker.Text = jobsDone;
            this.lblActiveChores_Worker.Text = activeJobs;
            this.lblAppliedChores_Worker.Text = appliedJobs;
            pnlHome.Controls.Add(this.pnlStatus_Worker);
        }

        public void showEmployerStatus(string jobsDone, string activeJobs)
        {
            pnlHome.Controls.Clear();
            this.lblChoresDone_Employer.Text = jobsDone;
            this.lblActiveChores_Employer.Text = activeJobs;
            pnlHome.Controls.Add(this.pnlStatus_Employer);
        }

        public void navigateToDetailScreen(string postId)
        {
            UIController.navigateToJobDetail(postId);
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            UIController.navigateToAddPostScreen();
        }
    }
}
