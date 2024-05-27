namespace FinalProject
{
    partial class SystemUserMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.Button btnManageStores;

        private void InitializeComponent()
        {
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.btnManageStores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(12, 12);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(150, 23);
            this.btnManageProducts.TabIndex = 0;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(12, 41);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(150, 23);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(12, 70);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(150, 23);
            this.btnViewStatistics.TabIndex = 2;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // btnManageStores
            // 
            this.btnManageStores.Location = new System.Drawing.Point(12, 99);
            this.btnManageStores.Name = "btnManageStores";
            this.btnManageStores.Size = new System.Drawing.Size(150, 23);
            this.btnManageStores.TabIndex = 3;
            this.btnManageStores.Text = "Manage Stores";
            this.btnManageStores.UseVisualStyleBackColor = true;
            this.btnManageStores.Click += new System.EventHandler(this.btnManageStores_Click);
            // 
            // SystemUserMainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.btnManageStores);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageProducts);
            this.Name = "SystemUserMainForm";
            this.Text = "System User Main Form";
            this.Load += new System.EventHandler(this.SystemUserMainForm_Load);
            this.ResumeLayout(false);
        }
    }
}
