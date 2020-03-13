namespace EZChores.UI.Controls
{
    partial class AddJobPanel
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
            this.pnlAddJob = new System.Windows.Forms.FlowLayoutPanel();
            this.cardAddJob = new Bunifu.Framework.UI.BunifuCards();
            this.cboTime = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new JThinButton.JThinButton();
            this.btnPost = new JThinButton.JThinButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboCurrency = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtPrice = new JMaterialTextbox.JMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtDuration = new JMaterialTextbox.JMaterialTextbox();
            this.txtAddress = new JMaterialTextbox.JMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtJobTitle = new JMaterialTextbox.JMaterialTextbox();
            this.lblPostNewJob = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlAddJob.SuspendLayout();
            this.cardAddJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddJob
            // 
            this.pnlAddJob.AutoScroll = true;
            this.pnlAddJob.Controls.Add(this.cardAddJob);
            this.pnlAddJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddJob.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAddJob.Location = new System.Drawing.Point(0, 0);
            this.pnlAddJob.Name = "pnlAddJob";
            this.pnlAddJob.Padding = new System.Windows.Forms.Padding(350, 0, 0, 0);
            this.pnlAddJob.Size = new System.Drawing.Size(1169, 589);
            this.pnlAddJob.TabIndex = 0;
            this.pnlAddJob.WrapContents = false;
            this.pnlAddJob.SizeChanged += new System.EventHandler(this.onSizeChanged);
            this.pnlAddJob.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cardAddJob
            // 
            this.cardAddJob.BackColor = System.Drawing.Color.White;
            this.cardAddJob.BorderRadius = 50;
            this.cardAddJob.BottomSahddow = true;
            this.cardAddJob.color = System.Drawing.Color.Transparent;
            this.cardAddJob.Controls.Add(this.cboTime);
            this.cardAddJob.Controls.Add(this.bunifuCustomLabel6);
            this.cardAddJob.Controls.Add(this.btnCancel);
            this.cardAddJob.Controls.Add(this.btnPost);
            this.cardAddJob.Controls.Add(this.bunifuCustomLabel5);
            this.cardAddJob.Controls.Add(this.bunifuCustomLabel4);
            this.cardAddJob.Controls.Add(this.cboCurrency);
            this.cardAddJob.Controls.Add(this.txtPrice);
            this.cardAddJob.Controls.Add(this.bunifuCustomLabel3);
            this.cardAddJob.Controls.Add(this.bunifuCustomLabel2);
            this.cardAddJob.Controls.Add(this.cboDate);
            this.cardAddJob.Controls.Add(this.txtDuration);
            this.cardAddJob.Controls.Add(this.txtAddress);
            this.cardAddJob.Controls.Add(this.bunifuCustomLabel1);
            this.cardAddJob.Controls.Add(this.txtDescription);
            this.cardAddJob.Controls.Add(this.txtJobTitle);
            this.cardAddJob.Controls.Add(this.lblPostNewJob);
            this.cardAddJob.LeftSahddow = false;
            this.cardAddJob.Location = new System.Drawing.Point(353, 30);
            this.cardAddJob.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.cardAddJob.Name = "cardAddJob";
            this.cardAddJob.RightSahddow = true;
            this.cardAddJob.ShadowDepth = 20;
            this.cardAddJob.Size = new System.Drawing.Size(605, 714);
            this.cardAddJob.TabIndex = 0;
            // 
            // cboTime
            // 
            this.cboTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.cboTime.Location = new System.Drawing.Point(178, 359);
            this.cboTime.Name = "cboTime";
            this.cboTime.ShowUpDown = true;
            this.cboTime.Size = new System.Drawing.Size(348, 20);
            this.cboTime.TabIndex = 32;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(79, 359);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(54, 19);
            this.bunifuCustomLabel6.TabIndex = 31;
            this.bunifuCustomLabel6.Text = "Time :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderRadius = 17;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Font_Size = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColors = System.Drawing.Color.Gray;
            this.btnCancel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.btnCancel.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.btnCancel.HoverFontColor = System.Drawing.Color.White;
            this.btnCancel.LineThickness = 2;
            this.btnCancel.Location = new System.Drawing.Point(269, 648);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 37);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Transparent;
            this.btnPost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnPost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnPost.BorderRadius = 17;
            this.btnPost.ButtonText = "Post";
            this.btnPost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Font_Size = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColors = System.Drawing.Color.White;
            this.btnPost.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.btnPost.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.btnPost.HoverFontColor = System.Drawing.Color.White;
            this.btnPost.LineThickness = 2;
            this.btnPost.Location = new System.Drawing.Point(401, 647);
            this.btnPost.Margin = new System.Windows.Forms.Padding(6);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(125, 37);
            this.btnPost.TabIndex = 28;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(77, 202);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(78, 19);
            this.bunifuCustomLabel5.TabIndex = 27;
            this.bunifuCustomLabel5.Text = "Address :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(77, 413);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(55, 19);
            this.bunifuCustomLabel4.TabIndex = 26;
            this.bunifuCustomLabel4.Text = "Price :";
            // 
            // cboCurrency
            // 
            this.cboCurrency.BackColor = System.Drawing.Color.Transparent;
            this.cboCurrency.BorderRadius = 3;
            this.cboCurrency.ForeColor = System.Drawing.Color.White;
            this.cboCurrency.Items = new string[] {
        "MMK",
        "USD"};
            this.cboCurrency.Location = new System.Drawing.Point(428, 411);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.cboCurrency.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.cboCurrency.selectedIndex = -1;
            this.cboCurrency.Size = new System.Drawing.Size(98, 33);
            this.cboCurrency.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColors = System.Drawing.Color.DimGray;
            this.txtPrice.HintText = "Price";
            this.txtPrice.IsPassword = false;
            this.txtPrice.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.txtPrice.LineThickness = 2;
            this.txtPrice.Location = new System.Drawing.Point(178, 419);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.MaxLength = 57;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtPrice.OnFocusedTextColor = System.Drawing.Color.DimGray;
            this.txtPrice.ReadOnly = false;
            this.txtPrice.Size = new System.Drawing.Size(235, 25);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.TextName = "";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(77, 305);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(53, 19);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "Date :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(76, 249);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 19);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Duration :";
            // 
            // cboDate
            // 
            this.cboDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.cboDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cboDate.BorderRadius = 0;
            this.cboDate.ForeColor = System.Drawing.Color.White;
            this.cboDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cboDate.FormatCustom = null;
            this.cboDate.Location = new System.Drawing.Point(178, 297);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(348, 36);
            this.cboDate.TabIndex = 21;
            this.cboDate.Value = new System.DateTime(2020, 3, 9, 2, 8, 43, 944);
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.Transparent;
            this.txtDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColors = System.Drawing.Color.DimGray;
            this.txtDuration.HintText = "Hours";
            this.txtDuration.IsPassword = false;
            this.txtDuration.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.txtDuration.LineThickness = 2;
            this.txtDuration.Location = new System.Drawing.Point(178, 249);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuration.MaxLength = 2;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtDuration.OnFocusedTextColor = System.Drawing.Color.DimGray;
            this.txtDuration.ReadOnly = false;
            this.txtDuration.Size = new System.Drawing.Size(83, 25);
            this.txtDuration.TabIndex = 20;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDuration.TextName = "Hours";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColors = System.Drawing.Color.DimGray;
            this.txtAddress.HintText = "";
            this.txtAddress.IsPassword = false;
            this.txtAddress.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.txtAddress.LineThickness = 2;
            this.txtAddress.Location = new System.Drawing.Point(178, 196);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.MaxLength = 57;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtAddress.OnFocusedTextColor = System.Drawing.Color.DimGray;
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(348, 25);
            this.txtAddress.TabIndex = 19;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextName = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(76, 469);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 19);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Job Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(77, 500);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(30);
            this.txtDescription.MaxLength = 300;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(449, 112);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtJobTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Font_Size = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.ForeColors = System.Drawing.Color.DimGray;
            this.txtJobTitle.HintText = "Job Title";
            this.txtJobTitle.IsPassword = false;
            this.txtJobTitle.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.txtJobTitle.LineThickness = 2;
            this.txtJobTitle.Location = new System.Drawing.Point(77, 146);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJobTitle.MaxLength = 57;
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.txtJobTitle.OnFocusedTextColor = System.Drawing.Color.DimGray;
            this.txtJobTitle.ReadOnly = false;
            this.txtJobTitle.Size = new System.Drawing.Size(449, 27);
            this.txtJobTitle.TabIndex = 16;
            this.txtJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJobTitle.TextName = "Job Title";
            // 
            // lblPostNewJob
            // 
            this.lblPostNewJob.AutoSize = true;
            this.lblPostNewJob.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNewJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.lblPostNewJob.Location = new System.Drawing.Point(71, 63);
            this.lblPostNewJob.Name = "lblPostNewJob";
            this.lblPostNewJob.Size = new System.Drawing.Size(190, 32);
            this.lblPostNewJob.TabIndex = 15;
            this.lblPostNewJob.Text = "Post New Job";
            // 
            // AddJobPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddJob);
            this.Name = "AddJobPanel";
            this.Size = new System.Drawing.Size(1169, 589);
            this.pnlAddJob.ResumeLayout(false);
            this.cardAddJob.ResumeLayout(false);
            this.cardAddJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlAddJob;
        private Bunifu.Framework.UI.BunifuCards cardAddJob;
        private JThinButton.JThinButton btnPost;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDropdown cboCurrency;
        private JMaterialTextbox.JMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker cboDate;
        private JMaterialTextbox.JMaterialTextbox txtDuration;
        private JMaterialTextbox.JMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private JMaterialTextbox.JMaterialTextbox txtJobTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPostNewJob;
        private JThinButton.JThinButton btnCancel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DateTimePicker cboTime;
    }
}
