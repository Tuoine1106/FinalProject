using System;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormManageUsers : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public FormManageUsers()
        {
            InitializeComponent();
        }

        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = khachHangBLL.GetKhachHangs();
            dataGridViewUsers.DataSource = users;
        }
    }
}
