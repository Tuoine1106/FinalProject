using System;
using System.Windows.Forms;
using FinalProject.BLL;

namespace FinalProject
{
    public partial class FormManagerLogin : Form
    {
        private QuanLyCuaHangBLL quanLyCuaHangBLL = new QuanLyCuaHangBLL();

        public FormManagerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int idQuanLy = int.Parse(txtIdQuanLy.Text);
            string soDienThoai = txtSoDienThoai.Text;

            if (quanLyCuaHangBLL.ValidateLoginByIdAndPhone(idQuanLy, soDienThoai))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SystemUserMainForm systemUserMainForm = new SystemUserMainForm();
                systemUserMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
