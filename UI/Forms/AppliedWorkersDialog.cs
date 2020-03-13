using EZChores.MVP.Presenters;
using EZChores.MVP.Views;
using EZChores.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EZChores.Data.DataVO;

namespace EZChores.UI.Forms
{
    public partial class AppliedWorkersDialog : Form , WorkerItemDelegate , AppliedUsersView
    {
        private AppliedUsersPresenter mPresenter;
        private JobPost jobPost;
        private JobPostDetailDelegate mDelegate;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );



        public AppliedWorkersDialog(JobPost jobPost , JobPostDetailDelegate jobPostDetailDelegate)
        {
            this.mDelegate = jobPostDetailDelegate;
            this.mPresenter = new AppliedUsersPresenter(this);
            this.jobPost = jobPost;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.pnlWorkerList.Width =this.pnlWorkerList.Width + SystemInformation.VerticalScrollBarWidth;
            showData(jobPost.appliedUsers);
        }

        private void showData(List<User> appliedUsers )
        {
            this.pnlWorkerList.Controls.Clear();
            foreach (var job in appliedUsers)
            {
                AppliedWorkerItem item = new AppliedWorkerItem();
                item.init(job, this);
                this.pnlWorkerList.Controls.Add(item);

            }
        }

            private void pnlWorkerList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void onTapEmploy(User user)
        {
            mPresenter.employUser(user, jobPost);
        }

        public void closeDialog()
        {
            this.Close();
            mDelegate.onCloseDialog();
        }
    }
}
