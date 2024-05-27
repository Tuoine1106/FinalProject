namespace FinalProject
{
    partial class FormPlaceOrder
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;
        private System.Windows.Forms.DataGridView dataGridViewPromoCodes;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPromoCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnApplyPromoCode;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotalPrice;

        private void InitializeComponent()
        {
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewPromoCodes = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPromoCode = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnApplyPromoCode = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromoCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(12, 250);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewOrderItems.TabIndex = 1;
            // 
            // dataGridViewPromoCodes
            // 
            this.dataGridViewPromoCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromoCodes.Location = new System.Drawing.Point(450, 12);
            this.dataGridViewPromoCodes.Name = "dataGridViewPromoCodes";
            this.dataGridViewPromoCodes.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewPromoCodes.TabIndex = 2;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(450, 180);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.Text = "Product ID";
            this.txtProductId.Enter += new System.EventHandler(this.txtProductId_Enter);
            this.txtProductId.Leave += new System.EventHandler(this.txtProductId_Leave);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(450, 210);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Location = new System.Drawing.Point(450, 240);
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Size = new System.Drawing.Size(100, 20);
            this.txtPromoCode.TabIndex = 5;
            this.txtPromoCode.Text = "Promo Code";
            this.txtPromoCode.Enter += new System.EventHandler(this.txtPromoCode_Enter);
            this.txtPromoCode.Leave += new System.EventHandler(this.txtPromoCode_Leave);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(450, 270);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(100, 23);
            this.btnAddToOrder.TabIndex = 6;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnApplyPromoCode
            // 
            this.btnApplyPromoCode.Location = new System.Drawing.Point(450, 300);
            this.btnApplyPromoCode.Name = "btnApplyPromoCode";
            this.btnApplyPromoCode.Size = new System.Drawing.Size(100, 23);
            this.btnApplyPromoCode.TabIndex = 7;
            this.btnApplyPromoCode.Text = "Apply Promo Code";
            this.btnApplyPromoCode.UseVisualStyleBackColor = true;
            this.btnApplyPromoCode.Click += new System.EventHandler(this.btnApplyPromoCode_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(450, 330);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(100, 23);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(450, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(450, 370);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(34, 13);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total:";
            // 
            // FormPlaceOrder
            // 
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnApplyPromoCode);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.dataGridViewPromoCodes);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "FormPlaceOrder";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.FormPlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromoCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
