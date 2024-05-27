namespace FinalProject
{
    partial class FormManagerLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdQuanLy;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdQuanLy = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Quản Lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Điện Thoại";
            // 
            // txtIdQuanLy
            // 
            this.txtIdQuanLy.Location = new System.Drawing.Point(95, 6);
            this.txtIdQuanLy.Name = "txtIdQuanLy";
            this.txtIdQuanLy.Size = new System.Drawing.Size(100, 20);
            this.txtIdQuanLy.TabIndex = 2;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(95, 45);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(95, 80);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 120);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtIdQuanLy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManagerLogin";
            this.Text = "Manager Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
