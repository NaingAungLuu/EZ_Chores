namespace EZChores
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtPassword = new JMaterialTextbox.JMaterialTextbox();
            this.lblMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlLoginRight = new System.Windows.Forms.Panel();
            this.txtUserName = new JMaterialTextbox.JMaterialTextbox();
            this.btnLogin = new JThinButton.JThinButton();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgWork = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSlogan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlLoginRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWork)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
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
            this.txtPassword.Location = new System.Drawing.Point(56, 267);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtPassword.OnFocusedTextColor = System.Drawing.Color.White;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(356, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextName = "Password";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(52, 82);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.lblMessage.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(171, 32);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Get Started!";
            // 
            // pnlLoginRight
            // 
            this.pnlLoginRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.pnlLoginRight.Controls.Add(this.txtUserName);
            this.pnlLoginRight.Controls.Add(this.txtPassword);
            this.pnlLoginRight.Controls.Add(this.btnLogin);
            this.pnlLoginRight.Controls.Add(this.btnSignUp);
            this.pnlLoginRight.Controls.Add(this.bunifuCustomLabel2);
            this.pnlLoginRight.Controls.Add(this.lblMessage);
            this.pnlLoginRight.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlLoginRight.Location = new System.Drawing.Point(309, 0);
            this.pnlLoginRight.Name = "pnlLoginRight";
            this.pnlLoginRight.Size = new System.Drawing.Size(479, 517);
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
            this.txtUserName.Location = new System.Drawing.Point(56, 223);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtUserName.OnFocusedTextColor = System.Drawing.Color.White;
            this.txtUserName.ReadOnly = false;
            this.txtUserName.Size = new System.Drawing.Size(356, 30);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.TextName = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.btnLogin.BorderRadius = 17;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Font_Size = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColors = System.Drawing.Color.White;
            this.btnLogin.HoverBackground = System.Drawing.Color.White;
            this.btnLogin.HoverBorder = System.Drawing.Color.White;
            this.btnLogin.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.btnLogin.LineThickness = 2;
            this.btnLogin.Location = new System.Drawing.Point(287, 322);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 37);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnSignUp.Location = new System.Drawing.Point(293, 414);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(63, 18);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(61, 414);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(226, 20);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Don\'t have an acccount yet?";
            // 
            // imgWork
            // 
            this.imgWork.BackColor = System.Drawing.Color.White;
            this.imgWork.Image = ((System.Drawing.Image)(resources.GetObject("imgWork.Image")));
            this.imgWork.Location = new System.Drawing.Point(-1, 56);
            this.imgWork.Margin = new System.Windows.Forms.Padding(30);
            this.imgWork.Name = "imgWork";
            this.imgWork.Padding = new System.Windows.Forms.Padding(100);
            this.imgWork.Size = new System.Drawing.Size(310, 239);
            this.imgWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWork.TabIndex = 9;
            this.imgWork.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.bunifuCustomLabel3);
            this.pnlMain.Controls.Add(this.lblSlogan);
            this.pnlMain.Controls.Add(this.imgWork);
            this.pnlMain.Controls.Add(this.pnlLoginRight);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(788, 517);
            this.pnlMain.TabIndex = 9;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(16, 340);
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
            this.lblSlogan.Location = new System.Drawing.Point(16, 389);
            this.lblSlogan.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Padding = new System.Windows.Forms.Padding(24, 0, 20, 20);
            this.lblSlogan.Size = new System.Drawing.Size(113, 44);
            this.lblSlogan.TabIndex = 10;
            this.lblSlogan.Text = "Text....";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 517);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 20);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.pnlLoginRight.ResumeLayout(false);
            this.pnlLoginRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWork)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblMessage;
        private System.Windows.Forms.Panel pnlLoginRight;
        private Bunifu.Framework.UI.BunifuCustomLabel btnSignUp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox imgWork;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSlogan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private JThinButton.JThinButton btnLogin;
        private JMaterialTextbox.JMaterialTextbox txtPassword;
        private JMaterialTextbox.JMaterialTextbox txtUserName;
    }
}

