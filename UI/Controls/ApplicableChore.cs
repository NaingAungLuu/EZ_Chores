using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZChores.UI.Controls;
using EZChores.MVP.Views;
using EZChores.Data;
using static EZChores.Data.DataVO;
using EZChores.Network;
using static EZChores.AppConstants;

namespace EZChores.UI
{
    public partial class ApplicableChore : UserControl
    {
        private string mEmployer;
        private string mJobTitle;
        private string area;
        private string mDate;
        private string mTime;
        private string mDuration;
        private string mPayment;
        private string postId;
        private JobPost mData;

        private JobPostDelegate mDelegate;

        /*
         * Data Properties
         */
         //Date
        [Description("Date"), Category("Data")]
        public string Date
        {
            get { return mDate; }
            set { mDate = value; this.lblDate.Text = value; }
        }

        public string PostID
        {
            get { return postId; }
            set { this.postId = value; }
        }

        //Employer
        [Description("UploadedUser"), Category("Data")]
        public string UploadedUser
        {
            get { return mEmployer; }
            set { mEmployer = value; this.lblEmployer.Text = value; this.Invalidate(); }
        }

        //Job Title
        [Description("JobTitle"), Category("Data")]
        public string JobTitle
        {
            get { return mJobTitle; }
            set { mJobTitle = value; this.lblJobTitle.Text = value; this.Invalidate(); }
        }

        //Time
        [Description("Time"), Category("Data")]
        public string Time
        {
            get { return mTime; }
            set { mTime = value; this.lblTime.Text = value; this.Invalidate(); }
        }

        //Duration
        [Description("Duration"), Category("Data")]
        public string Duration
        {
            get { return mDuration; }
            set { mDuration = value; this.lblDuration.Text = value; this.Invalidate(); }
        }

        //Payment
        [Description("Payment"), Category("Data")]
        public string Payments
        {
            get { return mPayment; }
            set { mPayment = value; this.lblPayment.Text = value; this.Invalidate(); }
        }

        //Payment
        [Description("Delegate"), Category("Behaviour")]
        public JobPostDelegate Delegate
        {
            get { return mDelegate; }
            set { mDelegate = value; this.Invalidate(); }
        }

        //Payment
        [Description("Area"), Category("Behaviour")]
        public string Area
        {
            get { return area; }
            set { area = value; this.lblArea.Text = value; this.Invalidate(); }
        }


        public ApplicableChore()
        {
            InitializeComponent();
        }

        public void initData(JobPost job)
        {
            this.mData = job;
            this.PostID = job.postId;
            this.Margin = new Padding(30, 30, 30, 30);
            this.JobTitle = job.info.title;
            this.UploadedUser = (job.info.uploadedUser.fullName == null) ? "" : job.info.uploadedUser.fullName;
            this.Duration = job.info.duration.ToString();
            this.Time = job.info.startTime;
            this.Area = job.info.area;
            if (job.info.date != null) this.Date = job.info.date;
            this.Payments = job.info.payment.ToString() + " MMK";
            
        }

        public void init(JobPostDelegate jobPostDelegate)
        {
            this.Delegate = jobPostDelegate;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            mDelegate.onTapDetails(mData.postId);
        }


        public void navigateToDetailScreen(string postId)
        {
            UIController.navigateToJobDetail(postId);
        }

      

    }
}
