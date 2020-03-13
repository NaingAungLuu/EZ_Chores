namespace EZChores.UI.Controls
{
    partial class PageController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageController));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblPageNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnNextPage = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevPage = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevPage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 50;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.lblPageNo);
            this.bunifuCards1.Controls.Add(this.btnNextPage);
            this.bunifuCards1.Controls.Add(this.btnPrevPage);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(200, 80);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lblPageNo
            // 
            this.lblPageNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageNo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageNo.Location = new System.Drawing.Point(54, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(92, 80);
            this.lblPageNo.TabIndex = 3;
            this.lblPageNo.Text = "1";
            this.lblPageNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.White;
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageActive = null;
            this.btnNextPage.Location = new System.Drawing.Point(146, 0);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 80);
            this.btnNextPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.TabStop = false;
            this.btnNextPage.Zoom = 10;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.White;
            this.btnPrevPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevPage.Image")));
            this.btnPrevPage.ImageActive = null;
            this.btnPrevPage.Location = new System.Drawing.Point(30, 0);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(24, 80);
            this.btnPrevPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevPage.TabIndex = 1;
            this.btnPrevPage.TabStop = false;
            this.btnPrevPage.Zoom = 10;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // PageController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuCards1);
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name = "PageController";
            this.Size = new System.Drawing.Size(200, 80);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNextPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPageNo;
        private Bunifu.Framework.UI.BunifuImageButton btnNextPage;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevPage;
    }
}
