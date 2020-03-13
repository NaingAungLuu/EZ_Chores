using EZChores.Network;
using EZChores.Presenters;
using EZChores.UI;
using EZChores.Views;
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

namespace EZChores
{
    public partial class LoginForm : Form , LoginFormView
    {

        private LoginFormPresenter mPresenter;

        public Color formBackground = AppConstants.Colors.colorPrimary;


        private Label minimise = new Label(); // this doesn't even have to be a label!
        private Label maximise = new Label(); // this will simulate our this.maximise box
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


        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
            lblSlogan.Text = "Another way\nto get your work done...";
            initTitleBar();
            mPresenter = new LoginFormPresenter(this);

        }



        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void initTitleBar()
        {
            //Remove Original TitleBar
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.close.Image = AppConstants.icClose; //Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
            this.close.Size = AppConstants.icClose.Size;
            this.close.Location = new Point(this.Width - 50, 30);

            this.close.ForeColor = Color.Red;
            this.close.BackColor = AppConstants.Colors.colorPrimary;
            this.Controls.Add(this.close);


            // now we need to add some functionality. First off, let's give those labels
            // MouseHover and MouseLeave events, so they change colour
            this.minimise.MouseEnter += new EventHandler(Control_MouseEnter);
            this.maximise.MouseEnter += new EventHandler(Control_MouseEnter);
            this.close.MouseEnter += new EventHandler(Control_MouseEnter);

            // and we need to do the same for MouseLeave events, to change it back
            this.minimise.MouseLeave += new EventHandler(Control_MouseLeave);
            this.maximise.MouseLeave += new EventHandler(Control_MouseLeave);
            this.close.MouseLeave += new EventHandler(Control_MouseLeave);

            // and lastly, for these controls, we need to add some functionality
            this.minimise.MouseClick += new MouseEventHandler(Control_MouseClick);
            this.maximise.MouseClick += new MouseEventHandler(Control_MouseClick);
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
            else if (sender.Equals(this.maximise))
                this.maximise.ForeColor = Color.White;
            else // it's the minimise label
                this.minimise.ForeColor = Color.White;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.close))
                this.close.Image = AppConstants.icClose;
            else if (sender.Equals(this.maximise))
                this.maximise.ForeColor = Color.Red;
            else // it's the minimise label
                this.minimise.ForeColor = Color.Red;
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(this.close))
                this.Close(); // close the form
            else if (sender.Equals(this.maximise))
            {
                if (this.maximise.Text == "Maximise")
                {
                    this.WindowState = FormWindowState.Maximized; // maximise the form
                    this.maximise.Text = "Restore"; // change the text
                    /*this.title.Width = this.Width; // stretch the title bar
*/
                }
                else // to restore
                {
                    this.WindowState = FormWindowState.Normal;
                    this.maximise.Text = "Maximise";
                }
            }
            else // it's the minimise label
                this.WindowState = FormWindowState.Minimized; // minimise the form
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            mPresenter.onPressSignUp();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            this.txtPassword.Text = "asdf";
            this.txtUserName.Focus();
        }

        void LoginFormView.showError(string msg)
        {
            this.lblMessage.ForeColor = AppConstants.Colors.colorAccent;
            this.lblMessage.Text = msg;
            this.txtPassword.Text = "";
            this.txtUserName.Text = "";
            this.txtUserName.Focus();
        }

        public void dispose()
        {
            
        }

        public void navigateToSignUpForm()
        {
            UIController.navigateToSignUpForm(this);
        }

        public void navigateToDashBoard()
        {
            UIController.navigateToDashBoardForm(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mPresenter.onPressLogin(this.txtUserName.TextName, this.txtPassword.TextName);
        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Load(object sender, EventArgs e)
        {

        }

      
    }
}
