using System;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormUserProfile : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private int currentUserId;

        public FormUserProfile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            KhachHang kh = khachHangBLL.GetKhachHangById(currentUserId);
            if (kh != null)
            {
                txtName.Text = kh.TenKhachHang;
                txtEmail.Text = kh.Email;
                txtAddress.Text = kh.DiaChi;
                txtPhone.Text = kh.SoDienThoai;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                IdKhachHang = currentUserId,
                TenKhachHang = txtName.Text,
                Email = txtEmail.Text,
                DiaChi = txtAddress.Text,
                SoDienThoai = txtPhone.Text
            };
            khachHangBLL.UpdateKhachHang(kh);
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
