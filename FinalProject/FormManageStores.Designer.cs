namespace FinalProject
{
    partial class FormManageStores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewStores;
        private System.Windows.Forms.TextBox txtTenQuanLy;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnAddStore;

        private void InitializeComponent()
        {
            this.dataGridViewStores = new System.Windows.Forms.DataGridView();
            this.txtTenQuanLy = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnAddStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStores
            // 
            this.dataGridViewStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStores.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStores.Name = "dataGridViewStores";
            this.dataGridViewStores.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewStores.TabIndex = 0;
            // 
            // txtTenQuanLy
            // 
            this.txtTenQuanLy.Location = new System.Drawing.Point(12, 330);
            this.txtTenQuanLy.Name = "txtTenQuanLy";
            this.txtTenQuanLy.Size = new System.Drawing.Size(100, 20);
            this.txtTenQuanLy.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(118, 330);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(224, 328);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(75, 23);
            this.btnAddStore.TabIndex = 3;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // FormManageStores
            // 
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenQuanLy);
            this.Controls.Add(this.dataGridViewStores);
            this.Name = "FormManageStores";
            this.Text = "Manage Stores";
            this.Load += new System.EventHandler(this.FormManageStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
