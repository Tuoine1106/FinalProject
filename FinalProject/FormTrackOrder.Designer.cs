namespace FinalProject
{
    partial class FormTrackOrder
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrders;

        private void InitializeComponent()
        {
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // FormTrackOrder
            // 
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormTrackOrder";
            this.Text = "Track Orders";
            this.Load += new System.EventHandler(this.FormTrackOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
