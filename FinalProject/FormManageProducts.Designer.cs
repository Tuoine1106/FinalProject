namespace FinalProject
{
    partial class FormManageProducts
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Button btnAddProduct;

        private void InitializeComponent()
        {
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(12, 330);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(100, 20);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(118, 330);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 20);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(224, 330);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(330, 330);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongTon.TabIndex = 4;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(436, 328);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormManageProducts
            // 
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "FormManageProducts";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.FormManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
