namespace EZChores.UI.Controls
{
    partial class AppliedWorkerItem
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnEmploy = new JThinButton.JThinButton();
            this.rating = new Bunifu.Framework.UI.BunifuRating();
            this.lblWorkerName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 50;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.btnEmploy);
            this.bunifuCards1.Controls.Add(this.rating);
            this.bunifuCards1.Controls.Add(this.lblWorkerName);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(570, 96);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.Color.Transparent;
            this.btnEmploy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnEmploy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnEmploy.BorderRadius = 17;
            this.btnEmploy.ButtonText = "Employ";
            this.btnEmploy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploy.Font_Size = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploy.ForeColors = System.Drawing.Color.White;
            this.btnEmploy.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.btnEmploy.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(155)))));
            this.btnEmploy.HoverFontColor = System.Drawing.Color.White;
            this.btnEmploy.LineThickness = 2;
            this.btnEmploy.Location = new System.Drawing.Point(423, 28);
            this.btnEmploy.Margin = new System.Windows.Forms.Padding(6);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(125, 37);
            this.btnEmploy.TabIndex = 29;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.Enabled = false;
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.rating.Location = new System.Drawing.Point(29, 47);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(150, 29);
            this.rating.TabIndex = 22;
            this.rating.Value = 4;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblWorkerName.Location = new System.Drawing.Point(24, 19);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(177, 25);
            this.lblWorkerName.TabIndex = 21;
            this.lblWorkerName.Text = "Naing Aung Luu";
            // 
            // AppliedWorkerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.MaximumSize = new System.Drawing.Size(570, 96);
            this.MinimumSize = new System.Drawing.Size(570, 96);
            this.Name = "AppliedWorkerItem";
            this.Size = new System.Drawing.Size(570, 96);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuRating rating;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWorkerName;
        private JThinButton.JThinButton btnEmploy;
    }
}
