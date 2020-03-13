namespace EZChores.UI
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnHome = new System.Windows.Forms.Panel();
            this.icHome = new System.Windows.Forms.PictureBox();
            this.txtHome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnHistory = new System.Windows.Forms.Panel();
            this.icHistory = new System.Windows.Forms.PictureBox();
            this.txtHistory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMyChores = new System.Windows.Forms.Panel();
            this.icMyChores = new System.Windows.Forms.PictureBox();
            this.txtMyChores = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlDashBoardTitle = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavToggle = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnAddJob = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.btnLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icHome)).BeginInit();
            this.btnHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icHistory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnMyChores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icMyChores)).BeginInit();
            this.pnlDashBoardTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddJob)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.pnlLeft.Controls.Add(this.btnLogOut);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.btnHistory);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.btnMyChores);
            this.panelAnimator.SetDecoration(this.pnlLeft, BunifuAnimatorNS.DecorationType.None);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.MaximumSize = new System.Drawing.Size(250, 850);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 741);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Controls.Add(this.pictureBox2);
            this.btnLogOut.Controls.Add(this.bunifuCustomLabel1);
            this.panelAnimator.SetDecoration(this.btnLogOut, BunifuAnimatorNS.DecorationType.None);
            this.btnLogOut.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.Location = new System.Drawing.Point(-1, 681);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(253, 60);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox2
            // 
            this.panelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 12);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 29);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Log Out";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Controls.Add(this.icHome);
            this.btnHome.Controls.Add(this.txtHome);
            this.panelAnimator.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.Location = new System.Drawing.Point(1, 104);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(252, 72);
            this.btnHome.TabIndex = 14;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // icHome
            // 
            this.panelAnimator.SetDecoration(this.icHome, BunifuAnimatorNS.DecorationType.None);
            this.icHome.Image = ((System.Drawing.Image)(resources.GetObject("icHome.Image")));
            this.icHome.Location = new System.Drawing.Point(16, 25);
            this.icHome.Name = "icHome";
            this.icHome.Size = new System.Drawing.Size(24, 24);
            this.icHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icHome.TabIndex = 12;
            this.icHome.TabStop = false;
            // 
            // txtHome
            // 
            this.txtHome.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.txtHome, BunifuAnimatorNS.DecorationType.None);
            this.txtHome.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHome.ForeColor = System.Drawing.Color.White;
            this.txtHome.Location = new System.Drawing.Point(103, 21);
            this.txtHome.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(73, 29);
            this.txtHome.TabIndex = 11;
            this.txtHome.Text = "Home";
            this.txtHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.Controls.Add(this.icHistory);
            this.btnHistory.Controls.Add(this.txtHistory);
            this.panelAnimator.SetDecoration(this.btnHistory, BunifuAnimatorNS.DecorationType.None);
            this.btnHistory.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHistory.Location = new System.Drawing.Point(0, 251);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(256, 74);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // icHistory
            // 
            this.panelAnimator.SetDecoration(this.icHistory, BunifuAnimatorNS.DecorationType.None);
            this.icHistory.Image = ((System.Drawing.Image)(resources.GetObject("icHistory.Image")));
            this.icHistory.Location = new System.Drawing.Point(17, 22);
            this.icHistory.Name = "icHistory";
            this.icHistory.Size = new System.Drawing.Size(24, 24);
            this.icHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icHistory.TabIndex = 12;
            this.icHistory.TabStop = false;
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.txtHistory, BunifuAnimatorNS.DecorationType.None);
            this.txtHistory.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistory.ForeColor = System.Drawing.Color.White;
            this.txtHistory.Location = new System.Drawing.Point(104, 22);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(73, 29);
            this.txtHistory.TabIndex = 11;
            this.txtHistory.Text = "History";
            this.txtHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 73);
            this.panel1.TabIndex = 13;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.panelAnimator.SetDecoration(this.lblUsername, BunifuAnimatorNS.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(60, 22);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.lblUsername.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(155, 23);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Naing Aung Luu";
            // 
            // pictureBox1
            // 
            this.panelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnMyChores
            // 
            this.btnMyChores.Controls.Add(this.icMyChores);
            this.btnMyChores.Controls.Add(this.txtMyChores);
            this.panelAnimator.SetDecoration(this.btnMyChores, BunifuAnimatorNS.DecorationType.None);
            this.btnMyChores.Location = new System.Drawing.Point(0, 176);
            this.btnMyChores.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyChores.Name = "btnMyChores";
            this.btnMyChores.Size = new System.Drawing.Size(251, 75);
            this.btnMyChores.TabIndex = 12;
            this.btnMyChores.Click += new System.EventHandler(this.btnMyChores_Click);
            // 
            // icMyChores
            // 
            this.panelAnimator.SetDecoration(this.icMyChores, BunifuAnimatorNS.DecorationType.None);
            this.icMyChores.Image = ((System.Drawing.Image)(resources.GetObject("icMyChores.Image")));
            this.icMyChores.Location = new System.Drawing.Point(17, 24);
            this.icMyChores.Name = "icMyChores";
            this.icMyChores.Size = new System.Drawing.Size(24, 24);
            this.icMyChores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icMyChores.TabIndex = 12;
            this.icMyChores.TabStop = false;
            // 
            // txtMyChores
            // 
            this.txtMyChores.AutoSize = true;
            this.panelAnimator.SetDecoration(this.txtMyChores, BunifuAnimatorNS.DecorationType.None);
            this.txtMyChores.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyChores.ForeColor = System.Drawing.Color.White;
            this.txtMyChores.Location = new System.Drawing.Point(91, 26);
            this.txtMyChores.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.txtMyChores.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtMyChores.Name = "txtMyChores";
            this.txtMyChores.Size = new System.Drawing.Size(107, 23);
            this.txtMyChores.TabIndex = 11;
            this.txtMyChores.Text = "My Chores";
            // 
            // pnlDashBoardTitle
            // 
            this.pnlDashBoardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.pnlDashBoardTitle.Controls.Add(this.flowLayoutPanel1);
            this.pnlDashBoardTitle.Controls.Add(this.btnNavToggle);
            this.pnlDashBoardTitle.Controls.Add(this.btnClose);
            this.pnlDashBoardTitle.Controls.Add(this.bunifuCustomLabel3);
            this.panelAnimator.SetDecoration(this.pnlDashBoardTitle, BunifuAnimatorNS.DecorationType.None);
            this.pnlDashBoardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlDashBoardTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashBoardTitle.Name = "pnlDashBoardTitle";
            this.pnlDashBoardTitle.Size = new System.Drawing.Size(1342, 60);
            this.pnlDashBoardTitle.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.panelAnimator.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(545, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 741);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNavToggle
            // 
            this.panelAnimator.SetDecoration(this.btnNavToggle, BunifuAnimatorNS.DecorationType.None);
            this.btnNavToggle.Image = ((System.Drawing.Image)(resources.GetObject("btnNavToggle.Image")));
            this.btnNavToggle.Location = new System.Drawing.Point(18, 17);
            this.btnNavToggle.Name = "btnNavToggle";
            this.btnNavToggle.Size = new System.Drawing.Size(24, 24);
            this.btnNavToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNavToggle.TabIndex = 15;
            this.btnNavToggle.TabStop = false;
            this.btnNavToggle.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnClose
            // 
            this.panelAnimator.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1291, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(61, 17);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.bunifuCustomLabel3.MaximumSize = new System.Drawing.Size(200, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(99, 23);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "EZ Chores";
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation2;
            this.panelAnimator.MaxAnimationTime = 2000;
            this.panelAnimator.TimeStep = 0.002F;
            // 
            // pnlContent
            // 
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Controls.Add(this.btnAddJob);
            this.panelAnimator.SetDecoration(this.pnlContent, BunifuAnimatorNS.DecorationType.None);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 60);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlContent.Size = new System.Drawing.Size(1082, 741);
            this.pnlContent.TabIndex = 15;
            // 
            // btnAddJob
            // 
            this.panelAnimator.SetDecoration(this.btnAddJob, BunifuAnimatorNS.DecorationType.None);
            this.btnAddJob.Location = new System.Drawing.Point(918, 1881);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(100, 50);
            this.btnAddJob.TabIndex = 0;
            this.btnAddJob.TabStop = false;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1332, 801);
            this.Controls.Add(this.pnlDashBoardTitle);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(890, 561);
            this.Name = "DashBoardForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardForm";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.btnLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icHome)).EndInit();
            this.btnHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnMyChores.ResumeLayout(false);
            this.btnMyChores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icMyChores)).EndInit();
            this.pnlDashBoardTitle.ResumeLayout(false);
            this.pnlDashBoardTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnMyChores;
        private System.Windows.Forms.Panel btnHistory;
        private Bunifu.Framework.UI.BunifuCustomLabel txtHistory;
        private Bunifu.Framework.UI.BunifuCustomLabel txtMyChores;
        private System.Windows.Forms.Panel pnlDashBoardTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel btnHome;
        private Bunifu.Framework.UI.BunifuCustomLabel txtHome;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private System.Windows.Forms.PictureBox btnNavToggle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btnAddJob;
        private System.Windows.Forms.PictureBox icHome;
        private System.Windows.Forms.PictureBox icHistory;
        private System.Windows.Forms.PictureBox icMyChores;
        private System.Windows.Forms.Panel btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}