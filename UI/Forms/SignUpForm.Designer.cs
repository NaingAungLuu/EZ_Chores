namespace EZChores
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnlLoginRight = new System.Windows.Forms.Panel();
            this.txtUserName = new JMaterialTextbox.JMaterialTextbox();
            this.txtFullName = new JMaterialTextbox.JMaterialTextbox();
            this.txtConfirmPassword = new JMaterialTextbox.JMaterialTextbox();
            this.txtPassword = new JMaterialTextbox.JMaterialTextbox();
            this.rdoWorker = new System.Windows.Forms.RadioButton();
            this.rdoEmployer = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgWork = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSlogan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pnlLoginRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWork)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(297, 435);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(115, 40);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pnlLoginRight
            // 
            this.pnlLoginRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.pnlLoginRight.Controls.Add(this.txtUserName);
            this.pnlLoginRight.Controls.Add(this.txtFullName);
            this.pnlLoginRight.Controls.Add(this.txtConfirmPassword);
            this.pnlLoginRight.Controls.Add(this.txtPassword);
            this.pnlLoginRight.Controls.Add(this.rdoWorker);
            this.pnlLoginRight.Controls.Add(this.rdoEmployer);
            this.pnlLoginRight.Controls.Add(this.btnCancel);
            this.pnlLoginRight.Controls.Add(this.bunifuCustomLabel1);
            this.pnlLoginRight.Controls.Add(this.btnSignUp);
            this.pnlLoginRight.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlLoginRight.Location = new System.Drawing.Point(306, 33);
            this.pnlLoginRight.Name = "pnlLoginRight";
            this.pnlLoginRight.Size = new System.Drawing.Size(481, 512);
            this.pnlLoginRight.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColors = System.Drawing.Color.White;
            this.txtUserName.HintText = "Username";
            this.txtUserName.IsPassword = false;
            this.txtUserName.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.txtUserName.LineThickness = 2;
            this.txtUserName.Location = new System.Drawing.Point(56, 150);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtUserName.OnFocusedTextColor = System.Drawing.Color.White;
            this.txtUserName.ReadOnly = false;
            this.txtUserName.Size = new System.Drawing.Size(356, 30);
            this.txtUserName.TabIndex = 20;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.TextName = "Username";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColors = System.Drawing.Color.White;
            this.txtFullName.HintText = "Full Name";
            this.txtFullName.IsPassword = false;
            this.txtFullName.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.txtFullName.LineThickness = 2;
            this.txtFullName.Location = new System.Drawing.Point(58, 204);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtFullName.OnFocusedTextColor = System.Drawing.Color.White;
            this.txtFullName.ReadOnly = false;
            this.txtFullName.Size = new System.Drawing.Size(356, 30);
            this.txtFullName.TabIndex = 19;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.TextName = "Full Name";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColors = System.Drawing.Color.White;
            this.txtConfirmPassword.HintText = "Confirm Password";
            this.txtConfirmPassword.IsPassword = true;
            this.txtConfirmPassword.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.txtConfirmPassword.LineThickness = 2;
            this.txtConfirmPassword.Location = new System.Drawing.Point(56, 321);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtConfirmPassword.OnFocusedTextColor = System.Drawing.Color.White;
            this.txtConfirmPassword.ReadOnly = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(356, 30);
            this.txtConfirmPassword.TabIndex = 18;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.TextName = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColors = System.Drawing.Color.White;
            this.txtPassword.HintText = "Password";
            this.txtPassword.IsPassword = true;
            this.txtPassword.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(58, 263);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtPassword.OnFocusedTextColor = System.Drawing.Color.White;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(356, 30);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextName = "Password";
            // 
            // rdoWorker
            // 
            this.rdoWorker.AutoSize = true;
            this.rdoWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoWorker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWorker.ForeColor = System.Drawing.Color.White;
            this.rdoWorker.Location = new System.Drawing.Point(198, 376);
            this.rdoWorker.Name = "rdoWorker";
            this.rdoWorker.Size = new System.Drawing.Size(80, 23);
            this.rdoWorker.TabIndex = 15;
            this.rdoWorker.Text = "Worker";
            this.rdoWorker.UseVisualStyleBackColor = true;
            // 
            // rdoEmployer
            // 
            this.rdoEmployer.AutoSize = true;
            this.rdoEmployer.Checked = true;
            this.rdoEmployer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEmployer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEmployer.ForeColor = System.Drawing.Color.White;
            this.rdoEmployer.Location = new System.Drawing.Point(65, 376);
            this.rdoEmployer.Name = "rdoEmployer";
            this.rdoEmployer.Size = new System.Drawing.Size(100, 23);
            this.rdoEmployer.TabIndex = 14;
            this.rdoEmployer.TabStop = true;
            this.rdoEmployer.Text = "Employer";
            this.rdoEmployer.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnCancel.Location = new System.Drawing.Point(172, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, 82);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 32);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Sign Up";
            // 
            // imgWork
            // 
            this.imgWork.BackColor = System.Drawing.Color.White;
            this.imgWork.Image = ((System.Drawing.Image)(resources.GetObject("imgWork.Image")));
            this.imgWork.Location = new System.Drawing.Point(35, 142);
            this.imgWork.Margin = new System.Windows.Forms.Padding(100);
            this.imgWork.Name = "imgWork";
            this.imgWork.Padding = new System.Windows.Forms.Padding(100);
            this.imgWork.Size = new System.Drawing.Size(229, 175);
            this.imgWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWork.TabIndex = 9;
            this.imgWork.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.bunifuCustomLabel3);
            this.pnlMain.Controls.Add(this.lblSlogan);
            this.pnlMain.Controls.Add(this.imgWork);
            this.pnlMain.Controls.Add(this.pnlLoginRight);
            this.pnlMain.Location = new System.Drawing.Point(0, -33);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(787, 545);
            this.pnlMain.TabIndex = 10;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 373);
            this.bunifuCustomLabel3.MaximumSize = new System.Drawing.Size(310, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Padding = new System.Windows.Forms.Padding(24, 0, 20, 20);
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(187, 52);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "EZ Chores";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblSlogan.Location = new System.Drawing.Point(13, 422);
            this.lblSlogan.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Padding = new System.Windows.Forms.Padding(24, 0, 20, 20);
            this.lblSlogan.Size = new System.Drawing.Size(113, 44);
            this.lblSlogan.TabIndex = 10;
            this.lblSlogan.Text = "Text....";
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 509);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.pnlLoginRight.ResumeLayout(false);
            this.pnlLoginRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWork)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel pnlLoginRight;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox imgWork;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSlogan;
        private System.Windows.Forms.Button btnCancel;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.RadioButton rdoWorker;
        private System.Windows.Forms.RadioButton rdoEmployer;
        private JMaterialTextbox.JMaterialTextbox txtUserName;
        private JMaterialTextbox.JMaterialTextbox txtFullName;
        private JMaterialTextbox.JMaterialTextbox txtConfirmPassword;
        private JMaterialTextbox.JMaterialTextbox txtPassword;
    }
}