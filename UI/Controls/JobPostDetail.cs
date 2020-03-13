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
using EZChores.Data;
using EZChores.MVP.Presenters;
using static EZChores.Data.DataVO;
using static EZChores.AppConstants;

namespace EZChores.UI.Controls
{
    public partial class JobPostDetail : UserControl , JobPostDetailView , JobPostDetailDelegate
    {
        private string mPostId;
        private JobPost mData;
        public string PostId
        {
            get { return mPostId;  }
            set { mPostId = value; refresh(); }
        }
        private JobPostDetailPresenter mPresenter;
        public JobPostDetail(string postId)
        {
            
            mPresenter = new JobPostDetailPresenter(this);
            this.mPostId = postId;
            InitializeComponent();
            initListeners();
        }

        private void initListeners()
        {
            this.btnAppliedWorkers.MouseEnter += new EventHandler(this.Control_MouseEnter);
            this.btnAppliedWorkers.MouseLeave += new EventHandler(this.Control_MouseLeave);
            this.btnAppliedWorkers.MouseClick += new MouseEventHandler(this.Control_MouseClick);
        }

        private void onSizeChanged(object sender, EventArgs e)
        {
            int marginLeft = (this.pnlJobDetails.Width / 2) - 
                (((this.cardApplyJob.Width)+(this.cardApplyJob.Margin.Left+this.cardApplyJob.Margin.Right)) / 2);
            this.pnlJobDetails.Padding = new Padding(marginLeft/*left*/ , 0/*top*/ , 0 /*right*/ , 0 /*bottom*/);

        }

        private void Control_MouseLeave(object sender, EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.btnAppliedWorkers))
            {
                this.btnAppliedWorkers.BackColor = Color.White;
            }

        }

        private void Control_MouseEnter(object sender,EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.btnAppliedWorkers))
            {
                this.btnAppliedWorkers.BackColor = Color.Gainsboro;
            }

        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.btnAppliedWorkers))
            {
                mPresenter.onTapAppliedUsers();
            }

        }

        public void Form_Load(object sender  , EventArgs e)
        {
            refresh();
        }

        

        public void showJobPostDetails(DataVO.JobPost data)
        {
            this.mData = data;
            this.lblJobTitle.Text = data.info.title;
            this.lblPayment.Text = data.info.payment.ToString();
            this.lblAddress.Text = data.info.area;
            this.lblDate.Text = data.info.date;
            this.lblTime.Text = data.info.startTime;
            this.lblDuration.Text = data.info.duration.ToString();
            this.lblDescription.Text = data.info.description;
            this.lblJobStatus.Text = data.jobStatus;
            this.lblAppliedWorkers.Text = data.appliedUsers.Count.ToString();

        }

        public void setUserTypeBasedView(bool isEmployer)
        {
            if(isEmployer)
            {
                switch (mData.jobStatus)
                {
                    case "APPLICABLE": this.btnApply.ButtonText = "Apply"; this.btnApply.Enabled = false; break;
                    case "APPLIED": this.btnApply.ButtonText = "Pay"; this.btnApply.Enabled = true; this.btnAppliedWorkers.Enabled = false; break;
                    case "DONE": this.btnApply.Enabled = false;this.btnApply.ButtonText = "Paid"; break;
                    
                }
                this.btnApply.Invalidate();
            }
            else
            {
                switch (mData.jobStatus)
                {
                    case "APPLICABLE": this.btnApply.ButtonText = "Apply"; this.btnApply.Enabled = true; break;
                    case "APPLIED": this.btnApply.ButtonText = "Apply"; this.btnApply.Enabled = false ; break;
                    case "DONE": this.btnApply.Enabled = false; this.btnApply.ButtonText = "Apply"; break;

                }
                this.btnAppliedWorkers.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mPresenter.onTapCancel();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            mPresenter.onTapApply(mData);
        }

        public void navigateToChoresPanel()
        {
            UIController.navigateToHomeScreen();
        }

        public void showAppliedView(bool isApplied)
        {
           if(isApplied)
            {
                this.btnApply.Enabled = false;
                this.btnApply.ButtonText = "Applied";
            }
        }

        public void openAppliedUsersDialog()
        {
            Console.WriteLine("appliedUsers = " + mData.appliedUsers.Count.ToString() + "jobPost = " + mData.postId);
            UIController.openAppliedWorkersDialog(mData , this);
        }

        public void onCloseDialog()
        {
            refresh();
        }

        public void refresh()
        {
            mPresenter.onFormLoad(this.mPostId);
        }
    }
}
