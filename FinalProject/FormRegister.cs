using System;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormRegister : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                TenKhachHang = txtTenKhachHang.Text,
                DiaChi = txtDiaChi.Text,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                MatKhau = txtMatKhau.Text
            };
            khachHangBLL.AddKhachHang(kh);
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
