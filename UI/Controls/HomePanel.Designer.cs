namespace EZChores.UI.Controls
{
    partial class HomePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.pnlHome = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatus_Worker = new Bunifu.Framework.UI.BunifuCards();
            this.lblAppliedChores_Worker = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblActiveChores_Worker = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblJobsDone_Worker = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnAddJob = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlStatus_Employer = new Bunifu.Framework.UI.BunifuCards();
            this.lblActiveChores_Employer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblChoresDone_Employer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlHome.SuspendLayout();
            this.pnlStatus_Worker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddJob)).BeginInit();
            this.pnlStatus_Employer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.AutoScroll = true;
            this.pnlHome.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlHome.Controls.Add(this.pnlStatus_Worker);
            this.pnlHome.Controls.Add(this.bunifuCards2);
            this.pnlHome.Controls.Add(this.btnAddJob);
            this.pnlHome.Controls.Add(this.pnlStatus_Employer);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Padding = new System.Windows.Forms.Padding(350, 0, 0, 0);
            this.pnlHome.Size = new System.Drawing.Size(1169, 589);
            this.pnlHome.TabIndex = 2;
            this.pnlHome.WrapContents = false;
            // 
            // pnlStatus_Worker
            // 
            this.pnlStatus_Worker.BackColor = System.Drawing.Color.White;
            this.pnlStatus_Worker.BorderRadius = 50;
            this.pnlStatus_Worker.BottomSahddow = true;
            this.pnlStatus_Worker.color = System.Drawing.Color.White;
            this.pnlStatus_Worker.Controls.Add(this.lblAppliedChores_Worker);
            this.pnlStatus_Worker.Controls.Add(this.bunifuCustomLabel2);
            this.pnlStatus_Worker.Controls.Add(this.bunifuSeparator2);
            this.pnlStatus_Worker.Controls.Add(this.lblActiveChores_Worker);
            this.pnlStatus_Worker.Controls.Add(this.bunifuCustomLabel10);
            this.pnlStatus_Worker.Controls.Add(this.lblJobsDone_Worker);
            this.pnlStatus_Worker.Controls.Add(this.bunifuSeparator1);
            this.pnlStatus_Worker.Controls.Add(this.bunifuCustomLabel4);
            this.pnlStatus_Worker.LeftSahddow = false;
            this.pnlStatus_Worker.Location = new System.Drawing.Point(353, 10);
            this.pnlStatus_Worker.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.pnlStatus_Worker.Name = "pnlStatus_Worker";
            this.pnlStatus_Worker.RightSahddow = true;
            this.pnlStatus_Worker.ShadowDepth = 20;
            this.pnlStatus_Worker.Size = new System.Drawing.Size(605, 157);
            this.pnlStatus_Worker.TabIndex = 40;
            // 
            // lblAppliedChores_Worker
            // 
            this.lblAppliedChores_Worker.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedChores_Worker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblAppliedChores_Worker.Location = new System.Drawing.Point(457, 70);
            this.lblAppliedChores_Worker.Name = "lblAppliedChores_Worker";
            this.lblAppliedChores_Worker.Size = new System.Drawing.Size(83, 51);
            this.lblAppliedChores_Worker.TabIndex = 30;
            this.lblAppliedChores_Worker.Text = "5";
            this.lblAppliedChores_Worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(416, 47);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(154, 23);
            this.bunifuCustomLabel2.TabIndex = 29;
            this.bunifuCustomLabel2.Text = "Applied Chores";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(388, 34);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuSeparator2.Size = new System.Drawing.Size(19, 87);
            this.bunifuSeparator2.TabIndex = 28;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // lblActiveChores_Worker
            // 
            this.lblActiveChores_Worker.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveChores_Worker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblActiveChores_Worker.Location = new System.Drawing.Point(254, 68);
            this.lblActiveChores_Worker.Name = "lblActiveChores_Worker";
            this.lblActiveChores_Worker.Size = new System.Drawing.Size(83, 51);
            this.lblActiveChores_Worker.TabIndex = 27;
            this.lblActiveChores_Worker.Text = "5";
            this.lblActiveChores_Worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(226, 45);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(139, 23);
            this.bunifuCustomLabel10.TabIndex = 26;
            this.bunifuCustomLabel10.Text = "Active Chores";
            // 
            // lblJobsDone_Worker
            // 
            this.lblJobsDone_Worker.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobsDone_Worker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblJobsDone_Worker.Location = new System.Drawing.Point(36, 68);
            this.lblJobsDone_Worker.Name = "lblJobsDone_Worker";
            this.lblJobsDone_Worker.Size = new System.Drawing.Size(118, 51);
            this.lblJobsDone_Worker.TabIndex = 21;
            this.lblJobsDone_Worker.Text = "3";
            this.lblJobsDone_Worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(183, 34);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuSeparator1.Size = new System.Drawing.Size(19, 87);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(37, 45);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(127, 23);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "Chores Done";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(353, 200);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(8, 8);
            this.bunifuCards2.TabIndex = 41;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddJob.Image = ((System.Drawing.Image)(resources.GetObject("btnAddJob.Image")));
            this.btnAddJob.ImageActive = null;
            this.btnAddJob.Location = new System.Drawing.Point(353, 214);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(71, 71);
            this.btnAddJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddJob.TabIndex = 42;
            this.btnAddJob.TabStop = false;
            this.btnAddJob.Zoom = 10;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // pnlStatus_Employer
            // 
            this.pnlStatus_Employer.BackColor = System.Drawing.Color.White;
            this.pnlStatus_Employer.BorderRadius = 50;
            this.pnlStatus_Employer.BottomSahddow = true;
            this.pnlStatus_Employer.color = System.Drawing.Color.White;
            this.pnlStatus_Employer.Controls.Add(this.lblActiveChores_Employer);
            this.pnlStatus_Employer.Controls.Add(this.bunifuCustomLabel6);
            this.pnlStatus_Employer.Controls.Add(this.lblChoresDone_Employer);
            this.pnlStatus_Employer.Controls.Add(this.bunifuSeparator4);
            this.pnlStatus_Employer.Controls.Add(this.bunifuCustomLabel8);
            this.pnlStatus_Employer.LeftSahddow = false;
            this.pnlStatus_Employer.Location = new System.Drawing.Point(353, 298);
            this.pnlStatus_Employer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.pnlStatus_Employer.Name = "pnlStatus_Employer";
            this.pnlStatus_Employer.RightSahddow = true;
            this.pnlStatus_Employer.ShadowDepth = 20;
            this.pnlStatus_Employer.Size = new System.Drawing.Size(605, 157);
            this.pnlStatus_Employer.TabIndex = 41;
            // 
            // lblActiveChores_Employer
            // 
            this.lblActiveChores_Employer.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveChores_Employer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblActiveChores_Employer.Location = new System.Drawing.Point(412, 68);
            this.lblActiveChores_Employer.Name = "lblActiveChores_Employer";
            this.lblActiveChores_Employer.Size = new System.Drawing.Size(83, 51);
            this.lblActiveChores_Employer.TabIndex = 27;
            this.lblActiveChores_Employer.Text = "5";
            this.lblActiveChores_Employer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(384, 45);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(139, 23);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Active Chores";
            // 
            // lblChoresDone_Employer
            // 
            this.lblChoresDone_Employer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoresDone_Employer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblChoresDone_Employer.Location = new System.Drawing.Point(74, 68);
            this.lblChoresDone_Employer.Name = "lblChoresDone_Employer";
            this.lblChoresDone_Employer.Size = new System.Drawing.Size(118, 51);
            this.lblChoresDone_Employer.TabIndex = 21;
            this.lblChoresDone_Employer.Text = "3";
            this.lblChoresDone_Employer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(286, 34);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuSeparator4.Size = new System.Drawing.Size(19, 87);
            this.bunifuSeparator4.TabIndex = 20;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(75, 45);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(127, 23);
            this.bunifuCustomLabel8.TabIndex = 19;
            this.bunifuCustomLabel8.Text = "Chores Done";
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHome);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(1169, 589);
            this.Load += new System.EventHandler(this.Form_Load);
            this.SizeChanged += new System.EventHandler(this.onSizeChanged);
            this.pnlHome.ResumeLayout(false);
            this.pnlStatus_Worker.ResumeLayout(false);
            this.pnlStatus_Worker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddJob)).EndInit();
            this.pnlStatus_Employer.ResumeLayout(false);
            this.pnlStatus_Employer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlHome;
        private Bunifu.Framework.UI.BunifuCards pnlStatus_Worker;
        private Bunifu.Framework.UI.BunifuCustomLabel lblJobsDone_Worker;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAppliedChores_Worker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblActiveChores_Worker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuImageButton btnAddJob;
        private Bunifu.Framework.UI.BunifuCards pnlStatus_Employer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblActiveChores_Employer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblChoresDone_Employer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
    }
}
