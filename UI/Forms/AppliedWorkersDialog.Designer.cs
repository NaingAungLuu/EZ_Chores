namespace EZChores.UI.Forms
{
    partial class AppliedWorkersDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppliedWorkersDialog));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlWorkerList = new System.Windows.Forms.FlowLayoutPanel();
            this.appliedWorkerItem1 = new EZChores.UI.Controls.AppliedWorkerItem();
            this.appliedWorkerItem2 = new EZChores.UI.Controls.AppliedWorkerItem();
            this.appliedWorkerItem3 = new EZChores.UI.Controls.AppliedWorkerItem();
            this.appliedWorkerItem4 = new EZChores.UI.Controls.AppliedWorkerItem();
            this.appliedWorkerItem5 = new EZChores.UI.Controls.AppliedWorkerItem();
            this.appliedWorkerItem6 = new EZChores.UI.Controls.AppliedWorkerItem();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlWorkerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel12);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(623, 55);
            this.pnlHeader.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(19, 16);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(214, 25);
            this.bunifuCustomLabel12.TabIndex = 23;
            this.bunifuCustomLabel12.Text = "Applied Workers List";
            // 
            // pnlWorkerList
            // 
            this.pnlWorkerList.AutoScroll = true;
            this.pnlWorkerList.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlWorkerList.Controls.Add(this.appliedWorkerItem1);
            this.pnlWorkerList.Controls.Add(this.appliedWorkerItem2);
            this.pnlWorkerList.Controls.Add(this.appliedWorkerItem3);
            this.pnlWorkerList.Controls.Add(this.appliedWorkerItem4);
            this.pnlWorkerList.Controls.Add(this.appliedWorkerItem5);
            this.pnlWorkerList.Controls.Add(this.appliedWorkerItem6);
            this.pnlWorkerList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlWorkerList.Location = new System.Drawing.Point(0, 58);
            this.pnlWorkerList.Margin = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.pnlWorkerList.Name = "pnlWorkerList";
            this.pnlWorkerList.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnlWorkerList.Size = new System.Drawing.Size(623, 452);
            this.pnlWorkerList.TabIndex = 27;
            this.pnlWorkerList.WrapContents = false;

            // 
            // appliedWorkerItem1
            // 
            this.appliedWorkerItem1.Location = new System.Drawing.Point(18, 3);
            this.appliedWorkerItem1.MaximumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem1.MinimumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem1.Name = "appliedWorkerItem1";
            this.appliedWorkerItem1.Rating = 0;
            this.appliedWorkerItem1.Size = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem1.TabIndex = 0;
            this.appliedWorkerItem1.WorkerName = "Aung Chan Myat Phyo";
            // 
            // appliedWorkerItem2
            // 
            this.appliedWorkerItem2.Location = new System.Drawing.Point(18, 105);
            this.appliedWorkerItem2.MaximumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem2.MinimumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem2.Name = "appliedWorkerItem2";
            this.appliedWorkerItem2.Rating = 0;
            this.appliedWorkerItem2.Size = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem2.TabIndex = 1;
            this.appliedWorkerItem2.WorkerName = "";
            // 
            // appliedWorkerItem3
            // 
            this.appliedWorkerItem3.Location = new System.Drawing.Point(18, 207);
            this.appliedWorkerItem3.MaximumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem3.MinimumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem3.Name = "appliedWorkerItem3";
            this.appliedWorkerItem3.Rating = 0;
            this.appliedWorkerItem3.Size = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem3.TabIndex = 2;
            this.appliedWorkerItem3.WorkerName = "Min Thant";
            // 
            // appliedWorkerItem4
            // 
            this.appliedWorkerItem4.Location = new System.Drawing.Point(18, 309);
            this.appliedWorkerItem4.MaximumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem4.MinimumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem4.Name = "appliedWorkerItem4";
            this.appliedWorkerItem4.Rating = 0;
            this.appliedWorkerItem4.Size = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem4.TabIndex = 3;
            this.appliedWorkerItem4.WorkerName = "Ma Wint Htay";
            // 
            // appliedWorkerItem5
            // 
            this.appliedWorkerItem5.Location = new System.Drawing.Point(18, 411);
            this.appliedWorkerItem5.MaximumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem5.MinimumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem5.Name = "appliedWorkerItem5";
            this.appliedWorkerItem5.Rating = 0;
            this.appliedWorkerItem5.Size = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem5.TabIndex = 4;
            this.appliedWorkerItem5.WorkerName = "Sithu";
            // 
            // appliedWorkerItem6
            // 
            this.appliedWorkerItem6.Location = new System.Drawing.Point(18, 513);
            this.appliedWorkerItem6.MaximumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem6.MinimumSize = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem6.Name = "appliedWorkerItem6";
            this.appliedWorkerItem6.Rating = 0;
            this.appliedWorkerItem6.Size = new System.Drawing.Size(570, 96);
            this.appliedWorkerItem6.TabIndex = 5;
            this.appliedWorkerItem6.WorkerName = "Min Khant";
            // 
            // AppliedWorkersDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 510);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlWorkerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppliedWorkersDialog";
            this.Text = "AppliedWorkersDialog";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlWorkerList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.FlowLayoutPanel pnlWorkerList;
        private Controls.AppliedWorkerItem appliedWorkerItem1;
        private Controls.AppliedWorkerItem appliedWorkerItem2;
        private Controls.AppliedWorkerItem appliedWorkerItem3;
        private Controls.AppliedWorkerItem appliedWorkerItem4;
        private Controls.AppliedWorkerItem appliedWorkerItem5;
        private Controls.AppliedWorkerItem appliedWorkerItem6;
    }
}