using EZChores.MVP.Presenters;
using EZChores.MVP.Views;
using EZChores.UI;
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
using static EZChores.AppConstants;
using static EZChores.Data.DataVO;

namespace EZChores
{
    public partial class SignUpForm
        : Form , SignUpFormView
    {

        public Color formBackground = AppConstants.Colors.colorPrimary;


        private SignUpFormPresenter mPresenter;
        private PictureBox close = new PictureBox(); // simulates the this.close box

        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving
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


        public SignUpForm()
        {
            initPresenter();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblSlogan.Text = "Fill up the form to start enjoying our services....";
            initTitleBar();

        }

        private void initPresenter()
        {
            mPresenter = new SignUpFormPresenter(this);
        }
        private void initTitleBar()
        {
            //Remove Original TitleBar
            this.FormBorderStyle = FormBorderStyle.None;
            this.close.Image = AppConstants.icClose; //Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
            this.close.Size = AppConstants.icClose.Size;
            this.close.Location = new Point(this.Width - 50, 30);

            this.close.ForeColor = Color.Red;
            this.close.BackColor = AppConstants.Colors.colorPrimary;
            this.Controls.Add(this.close);

            this.close.MouseEnter += new EventHandler(Control_MouseEnter);
            this.close.MouseLeave += new EventHandler(Control_MouseLeave);
            this.close.MouseClick += new MouseEventHandler(Control_MouseClick);

            this.imgWork.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.imgWork.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.imgWork.MouseMove += new MouseEventHandler(Title_MouseMove);

            this.pnlLoginRight.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.pnlLoginRight.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.pnlLoginRight.MouseMove += new MouseEventHandler(Title_MouseMove);

            this.pnlLoginRight.Parent = this.pnlMain;
            this.close.BringToFront();
            /*this.close.Parent = this.pnlLoginRight;*/

        }
        void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(this.close))
                this.close.Image = AppConstants.icCloseActive;
            
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.close))
                this.close.Image = AppConstants.icClose;
            
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(this.close))
                this.Close(); // close the form
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if(fieldsAreNotEmpty())
            {
                SignUpData data = new SignUpData(
                    this.txtUserName.TextName,
                    this.txtFullName.TextName,
                    this.txtPassword.TextName,
                    this.rdoWorker.Checked? UserTypes.WORKER : UserTypes.EMPLOYER);
                mPresenter.onPressSignUp(data);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mPresenter.onPressCancel();
        }

        private Boolean fieldsAreNotEmpty(){
            return (this.txtUserName.TextName != "" && this.txtPassword.TextName != "" && this.txtConfirmPassword.TextName != "");  
        }




        public void navigateToLogin()
        {
            UIController.navigateToLoginForm(this);
        }

        public void showError(string msg)
        {
            MessageBox.Show(msg);
        }

        public void navigateToDashBoard()
        {
            UIController.navigateToDashBoardForm(this);
        }

        
    }
    }
