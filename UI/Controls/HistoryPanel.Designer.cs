namespace EZChores.UI.Controls
{
    partial class HistoryPanel
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
            this.pageController = new EZChores.UI.Controls.PageController();
            this.pnlMyChores = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMyChores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageController
            // 
            this.pageController.BackColor = System.Drawing.Color.Gainsboro;
            this.pageController.Location = new System.Drawing.Point(253, 3);
            this.pageController.MinimumSize = new System.Drawing.Size(200, 50);
            this.pageController.Name = "pageController";
            this.pageController.OnClickNext = null;
            this.pageController.OnClickPrevious = null;
            this.pageController.Payments = 1;
            this.pageController.Size = new System.Drawing.Size(200, 56);
            this.pageController.TabIndex = 12;
            this.pageController.OnClickNext = this.onClickNextPage;
            this.pageController.OnClickPrevious = this.onClickPreviousPage;
            // 
            // pnlMyChores
            // 
            this.pnlMyChores.AutoScroll = true;
            this.pnlMyChores.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMyChores.Controls.Add(this.pageController);
            this.pnlMyChores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyChores.Location = new System.Drawing.Point(0, 0);
            this.pnlMyChores.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.pnlMyChores.Name = "pnlMyChores";
            this.pnlMyChores.Padding = new System.Windows.Forms.Padding(250, 0, 0, 0);
            this.pnlMyChores.Size = new System.Drawing.Size(1043, 589);
            this.pnlMyChores.TabIndex = 2;
            // 
            // HistoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMyChores);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Name = "HistoryPanel";
            this.Size = new System.Drawing.Size(1043, 589);
            this.pnlMyChores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PageController pageController;
        private System.Windows.Forms.FlowLayoutPanel pnlMyChores;
    }
}
