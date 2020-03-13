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
    public partial class AddJobPanel : UserControl , AddPostView
    {
        private AddPostPresenter mPresenter;
        public AddJobPanel()
        {
            InitializeComponent();
            this.mPresenter = new AddPostPresenter(this);
        }

        private void onSizeChanged(object sender, EventArgs e)
        {
            int marginLeft = (this.pnlAddJob.Width / 2) - ((this.cardAddJob.Width) / 2);
            this.pnlAddJob.Padding = new Padding(marginLeft/*left*/ , 0/*top*/ , 0 /*right*/ , 0 /*bottom*/);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                /*Panel panel = (Panel)sender;
                Color[] shadow = new Color[3];
                shadow[0] = Color.FromArgb(181, 181, 181);
                shadow[1] = Color.FromArgb(195, 195, 195);
                shadow[2] = Color.FromArgb(211, 211, 211);
                Pen pen = new Pen(shadow[0]);
                using (pen)
                {
                    foreach (Panel p in panel.Controls.OfType<Panel>())
                    {
                        Point pt = p.Location;
                        pt.Y += p.Height;
                        for (var sp = 0; sp < 3; sp++)
                        {
                            pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + p.Width - 1 + sp, pt.Y); 
                        e.Graphics.DrawLine(pen, p.Right + sp, p.Top + sp, p.Right + sp, p.Bottom + sp);
                        pt.Y++;
                        }
                    }
                }*/
            
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            JobPostInfo data = new JobPostInfo();
            data.title = this.txtJobTitle.TextName;
            data.area = this.txtAddress.TextName;
            data.duration = Int32.Parse(this.txtDuration.TextName);
            data.payment = Int32.Parse(this.txtPrice.TextName);
            this.cboDate.Format = DateTimePickerFormat.Custom;
            this.cboDate.FormatCustom = "DD/MM/YYYY";
            data.startTime = this.cboTime.Value.ToShortTimeString();
            data.date = this.cboDate.Value.ToShortDateString();
            data.description = this.txtDescription.Text;
            mPresenter.onPressPost(data);
        }

        public void navigateToHomeScreen()
        {
            UIController.navigateToHomeScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mPresenter.onPressCancel(); 
        }
    }
}
