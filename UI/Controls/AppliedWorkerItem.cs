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
    public partial class AppliedWorkerItem : UserControl
    {
        private int mRating = 0;
        private string mWorkerName = "";
        private User mData;
        private WorkerItemDelegate mDelegate;

        [Description("Rating"), Category("Data")]
        public int Rating
        {
            get { return mRating; }
            set { mRating = value; this.rating.Value = value; this.Invalidate(); }
        }

        public WorkerItemDelegate Delegate
        {
            get { return mDelegate; }
            set { mDelegate = value; this.Invalidate(); }
        }


        [Description("WorkerName"), Category("Data")]
        public string WorkerName
        {
            get { return mWorkerName; }
            set { mWorkerName = value; this.lblWorkerName.Text = value; this.Invalidate(); }
        }

        public User Data
        {
            get { return mData; }
            set { this.mData = value; }
        }
  


        public AppliedWorkerItem()
        {
            InitializeComponent();
            
        }

        public void init(User data , WorkerItemDelegate workerItemDelegate )
        {
            this.Data = data;
            this.WorkerName = data.fullName;
            this.Rating = data.rating;
            this.Delegate = workerItemDelegate;
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            mDelegate.onTapEmploy(mData);
        }
    }
}
