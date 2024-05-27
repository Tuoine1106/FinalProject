namespace FinalProject
{
    partial class FormViewStatistics
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;

        private void InitializeComponent()
        {
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewStatistics.TabIndex = 0;
            // 
            // FormViewStatistics
            // 
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Name = "FormViewStatistics";
            this.Text = "View Statistics";
            this.Load += new System.EventHandler(this.FormViewStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
