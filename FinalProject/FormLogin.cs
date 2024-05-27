using System;
using System.Windows.Forms;
using FinalProject.BLL;

namespace FinalProject
{
    public partial class FormLogin : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string matKhau = txtMatKhau.Text;

            if (khachHangBLL.ValidateLogin(email, matKhau))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            FormManagerLogin formManagerLogin = new FormManagerLogin();
            formManagerLogin.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Add any initialization code here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add code for label1 click event here
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Add code for label3 click event here
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Add code for txtEmail text changed event here
        }
    }
}
