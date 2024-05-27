namespace FinalProject
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMatKhau;

        private void InitializeComponent()
        {
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(12, 9);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(97, 13);
            this.lblTenKhachHang.TabIndex = 6;
            this.lblTenKhachHang.Text = "Tên Khách Hàng:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 39);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 13);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(12, 69);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(76, 13);
            this.lblSoDienThoai.TabIndex = 8;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(12, 129);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(61, 13);
            this.lblMatKhau.TabIndex = 10;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(115, 6);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(200, 20);
            this.txtTenKhachHang.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(115, 36);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(115, 66);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(115, 126);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(200, 20);
            this.txtMatKhau.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(125, 160);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormRegister
            // 
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnRegister);
            this.Name = "FormRegister";
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
