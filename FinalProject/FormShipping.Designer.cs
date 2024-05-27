namespace FinalProject
{
    partial class FormShipping
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnConfirmShipping;

        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnConfirmShipping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 38);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "Phone";
            // 
            // btnConfirmShipping
            // 
            this.btnConfirmShipping.Location = new System.Drawing.Point(12, 64);
            this.btnConfirmShipping.Name = "btnConfirmShipping";
            this.btnConfirmShipping.Size = new System.Drawing.Size(200, 23);
            this.btnConfirmShipping.TabIndex = 2;
            this.btnConfirmShipping.Text = "Confirm Shipping";
            this.btnConfirmShipping.UseVisualStyleBackColor = true;
            this.btnConfirmShipping.Click += new System.EventHandler(this.btnConfirmShipping_Click);
            // 
            // FormShipping
            // 
            this.ClientSize = new System.Drawing.Size(224, 101);
            this.Controls.Add(this.btnConfirmShipping);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Name = "FormShipping";
            this.Text = "Shipping Details";
            this.Load += new System.EventHandler(this.FormShipping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
