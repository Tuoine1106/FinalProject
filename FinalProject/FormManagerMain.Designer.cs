namespace FinalProject
{
    partial class FormManagerMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnTrackOrders;
        private System.Windows.Forms.Button btnViewStatistics;

        private void InitializeComponent()
        {
            this.btnTrackOrders = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrackOrders
            // 
            this.btnTrackOrders.Location = new System.Drawing.Point(12, 12);
            this.btnTrackOrders.Name = "btnTrackOrders";
            this.btnTrackOrders.Size = new System.Drawing.Size(100, 23);
            this.btnTrackOrders.TabIndex = 0;
            this.btnTrackOrders.Text = "Track Orders";
            this.btnTrackOrders.UseVisualStyleBackColor = true;
            this.btnTrackOrders.Click += new System.EventHandler(this.btnTrackOrders_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(12, 41);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(100, 23);
            this.btnViewStatistics.TabIndex = 1;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // FormManagerMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnTrackOrders);
            this.Name = "FormManagerMain";
            this.Text = "Manager Main";
            this.Load += new System.EventHandler(this.FormManagerMain_Load);
            this.ResumeLayout(false);
        }
    }
}
