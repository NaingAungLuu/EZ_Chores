using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZChores.UI.Controls
{
    public partial class PageController : UserControl
    {
        private int mPageNo = 1;

        private System.EventHandler onClickNext;
        [Description("OnClickNext"), Category("Control")]
        public System.EventHandler OnClickNext
        {
            get { return this.onClickNext; }
            set { this.onClickNext = value; this.Invalidate(); }
        }

        private System.EventHandler onClickPrevious;
        [Description("OnClickPrevious"), Category("Control")]
        public System.EventHandler OnClickPrevious
        {
            get { return this.onClickPrevious; }
            set { this.onClickPrevious = value; this.Invalidate(); }
        }

        [Description("PageNumber"), Category("Control")]
        public int Payments
        {
            get { return mPageNo; }
            set { mPageNo = value; this.lblPageNo.Text = value.ToString(); this.Invalidate(); }
        }
        public PageController()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            onClickNext(sender, e);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            onClickPrevious(sender, e);
        }
    }
}
