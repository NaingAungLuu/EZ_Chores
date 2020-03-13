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

namespace EZChores.UI.Controls
{
    public partial class PaidChore : UserControl
    {
        private string mEmployer;
        private string mJobTitle;
        private string mPayment;
        private string postId;

        private JobPostDelegate mDelegate;

        /*
         * Data Properties
         */
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
            set
            {
                mJobTitle = value; this.lblJobTitle.Text = value; this.Invalidate();
            }
        }
        //Payment
        [Description("Payment"), Category("Data")]
        public string Payment
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

        public PaidChore()
        {
            InitializeComponent();
        }

        public void initData(JobPost job)
        {
            this.PostID = job.postId;
            this.Margin = new Padding(30, 30, 30, 30);
            this.JobTitle = job.info.title;
            this.UploadedUser = (job.info.uploadedUser.fullName == null) ? "" : job.info.uploadedUser.fullName;
            this.Payment = job.info.payment.ToString() + " MMK";
        }

        public void init(JobPostDelegate jobPostDelegate)
        {
            this.mDelegate = jobPostDelegate;
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            mDelegate.onTapDetails(postId);
        }
    }
}
