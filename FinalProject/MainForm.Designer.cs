namespace FinalProject
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnTrackOrders;

        private void InitializeComponent()
        {
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnTrackOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(12, 12);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(100, 23);
            this.btnViewProducts.TabIndex = 0;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(12, 41);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(100, 23);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(12, 70);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(100, 23);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnTrackOrders
            // 
            this.btnTrackOrders.Location = new System.Drawing.Point(12, 99);
            this.btnTrackOrders.Name = "btnTrackOrders";
            this.btnTrackOrders.Size = new System.Drawing.Size(100, 23);
            this.btnTrackOrders.TabIndex = 3;
            this.btnTrackOrders.Text = "Track Orders";
            this.btnTrackOrders.UseVisualStyleBackColor = true;
            this.btnTrackOrders.Click += new System.EventHandler(this.btnTrackOrders_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrackOrders);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnViewProducts);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }
    }
}
