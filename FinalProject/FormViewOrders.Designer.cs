namespace FinalProject
{
    partial class FormViewOrders
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
            this.dataGridViewOrders.Size = new System.Drawing.Size(760, 337);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // FormViewOrders
            // 
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormViewOrders";
            this.Text = "View Orders";
            this.Load += new System.EventHandler(this.FormViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
