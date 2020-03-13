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

namespace EZChores.UI
{
    public partial class DashBoardForm : Form , DashBoardFormView
    {
        private DashBoardFormPresenter mPresenter;
        private Label minimise = new Label(); // this doesn't even have to be a label!
        private Label maximise = new Label(); // this will simulate our this.maximise box
        private PictureBox close = new PictureBox(); // simulates the this.close box
        private AddJobButton addJobButton = new AddJobButton();//Add Job Button
        
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving

        private Control contentPanel = null;

        private int selectedItem = 0;
        private int hoveredItem = -1;

        public int SelectedItem
        {
            get { return selectedItem; }
            set { this.selectedItem = value;
                showSelection();
                setSelectedPanel();    
            }
        }

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
        public DashBoardForm()
        {
            this.mPresenter = new DashBoardFormPresenter(this);
            InitializeComponent();
            initTitleBar();
            
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
            //this.Controls.Add(this.close);


            this.btnMyChores.MouseEnter += new EventHandler(Control_MouseEnter);
            this.btnHistory.MouseEnter += new EventHandler(Control_MouseEnter);
            this.btnHome.MouseEnter += new EventHandler(Control_MouseEnter);
            this.btnClose.MouseEnter += new EventHandler(Control_MouseEnter);
            this.txtHistory.MouseEnter += new EventHandler(Control_MouseEnter);
            this.txtHome.MouseEnter += new EventHandler(Control_MouseEnter);
            this.txtMyChores.MouseEnter += new EventHandler(Control_MouseEnter);

            this.btnHome.MouseEnter += new EventHandler(Control_MouseLeave);
            this.btnMyChores.MouseLeave += new EventHandler(Control_MouseLeave);
            this.btnHistory.MouseLeave += new EventHandler(Control_MouseLeave);
            this.btnClose.MouseLeave += new EventHandler(Control_MouseLeave);
            this.txtHistory.MouseEnter += new EventHandler(Control_MouseLeave);
            this.txtHome.MouseEnter += new EventHandler(Control_MouseLeave);
            this.txtMyChores.MouseEnter += new EventHandler(Control_MouseLeave);

            // and lastly, for these controls, we need to add some functionality
            this.minimise.MouseClick += new MouseEventHandler(Control_MouseClick);
            this.maximise.MouseClick += new MouseEventHandler(Control_MouseClick);
            this.close.MouseClick += new MouseEventHandler(Control_MouseClick);
            this.btnClose.MouseClick += new MouseEventHandler(Control_MouseClick);


            this.pnlDashBoardTitle.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.pnlDashBoardTitle.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.pnlDashBoardTitle.MouseMove += new MouseEventHandler(Title_MouseMove);
            this.close.BringToFront();

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
            if (sender.Equals(this.btnClose))
            {
                this.btnClose.Image = AppConstants.icCloseActive;

            }
            else if (sender.Equals(this.btnMyChores) || sender.Equals(this.txtMyChores))
            {
                hoveredItem = 1;
                showSelection();
            }
            else if (sender.Equals(this.btnHistory) || sender.Equals(this.txtHistory))
            {
                hoveredItem = 2;
                showSelection();
            }
            else if(sender.Equals(this.btnHome) || sender.Equals(this.txtHome))
            {
                hoveredItem = 0;
                showSelection();
            }
            else
            {
                hoveredItem = -1;
                showSelection();
            }
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.btnClose))
                this.btnClose.Image = AppConstants.icClose;
            
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(this.btnClose))
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Width == 250)
            {
                pnlLeft.Width = 60;
                panelAnimator.ShowSync(pnlLeft);
                
            }
            else
            {
                pnlLeft.Width = 250;
                panelAnimator.ShowSync(pnlLeft);
                
            }
            setCenterMargin();
        }

        public void btnLogOut_Click(object sender, EventArgs e)
        {
            mPresenter.onTapLogOut();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        public void loadForm()
        {
            mPresenter.onLoadForm();
            var choresPanel = UIRepository.HomePanel();
            this.contentPanel = choresPanel;
            swapContentPanel(choresPanel);
            showSelection();
        }

        public void setSelectedPanel()
        {
            switch (selectedItem)
            {
                case 0: swapContentPanel(new HomePanel());break;
                case 1: swapContentPanel(new MyChoresPanel());break;
                case 2:swapContentPanel(new HistoryPanel());break;
            }
        }

        public void swapContentPanel(Control contentPanel)
        {
            contentPanel.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Remove(this.contentPanel);
            this.pnlContent.Controls.Add(contentPanel);
            this.contentPanel = contentPanel;
            this.contentPanel.Invalidate();
        }

        private void setCenterMargin()
        {
            
        }

        private void showSelection()
        {
            this.btnMyChores.BackColor = Color.Transparent;
            this.btnHistory.BackColor = Color.Transparent;
            this.btnHome.BackColor = Color.Transparent;
       
            switch (this.hoveredItem)
            {
                case 0:
                    this.btnHome.BackColor = AppConstants.Colors.colorPrimary;
                    break;
                case 1:
                    this.btnMyChores.BackColor = AppConstants.Colors.colorPrimary;
                    break;
                case 2:
                    this.btnHistory.BackColor = AppConstants.Colors.colorPrimary;
                    break;
                case -1: break;
            }

            switch (this.selectedItem)
            {
                case 0:
                    this.btnHome.BackColor = AppConstants.Colors.colorPrimary;
                    break;
                case 1:
                    this.btnMyChores.BackColor = AppConstants.Colors.colorPrimary;
                    break;
                case 2:
                    this.btnHistory.BackColor = AppConstants.Colors.colorPrimary;
                    break;
                case -1: break;
            }

        }


        void DashBoardFormView.initUserData(User user)
        {
            this.lblUsername.Text = user.fullName;
        }

        private void btnHome_Click(object sender , EventArgs e)
        {
            SelectedItem = 0;
            this.btnHome.BackColor = AppConstants.Colors.colorPrimary;
                        
        }

        private void btnMyChores_Click(object sender, EventArgs e)
        {
            SelectedItem = 1;
            this.btnMyChores.BackColor = AppConstants.Colors.colorPrimary;
            
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SelectedItem = 2;
            this.btnHistory.BackColor = AppConstants.Colors.colorPrimary;
            
            
        }

        public void navigateToLogInScreen()
        {
            UIController.navigateToLoginForm(this.FindForm());
        }
    }
}
