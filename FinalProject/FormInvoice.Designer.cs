namespace FinalProject
{
    partial class FormInvoice
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblShippingDate;
        private System.Windows.Forms.Label lblShippingStatus;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;

        private void InitializeComponent()
        {
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblShippingDate = new System.Windows.Forms.Label();
            this.lblShippingStatus = new System.Windows.Forms.Label();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(12, 9);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(50, 13);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 32);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 1;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(12, 55);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(73, 13);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblShippingDate
            // 
            this.lblShippingDate.AutoSize = true;
            this.lblShippingDate.Location = new System.Drawing.Point(12, 78);
            this.lblShippingDate.Name = "lblShippingDate";
            this.lblShippingDate.Size = new System.Drawing.Size(76, 13);
            this.lblShippingDate.TabIndex = 3;
            this.lblShippingDate.Text = "Shipping Date:";
            // 
            // lblShippingStatus
            // 
            this.lblShippingStatus.AutoSize = true;
            this.lblShippingStatus.Location = new System.Drawing.Point(12, 101);
            this.lblShippingStatus.Name = "lblShippingStatus";
            this.lblShippingStatus.Size = new System.Drawing.Size(82, 13);
            this.lblShippingStatus.TabIndex = 4;
            this.lblShippingStatus.Text = "Shipping Status:";
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewOrderItems.TabIndex = 5;
            // 
            // FormInvoice
            // 
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Controls.Add(this.lblShippingStatus);
            this.Controls.Add(this.lblShippingDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblOrderId);
            this.Name = "FormInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
