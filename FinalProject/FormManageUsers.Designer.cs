namespace FinalProject
{
    partial class FormManageUsers
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;

        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // FormManageUsers
            // 
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "FormManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.FormManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
