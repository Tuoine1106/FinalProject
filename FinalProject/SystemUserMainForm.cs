using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SystemUserMainForm : Form
    {
        public SystemUserMainForm()
        {
            InitializeComponent();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            FormManageProducts formManageProducts = new FormManageProducts();
            formManageProducts.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            FormManageUsers formManageUsers = new FormManageUsers();
            formManageUsers.ShowDialog();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            FormViewStatistics formViewStatistics = new FormViewStatistics();
            formViewStatistics.ShowDialog();
        }

        private void btnManageStores_Click(object sender, EventArgs e)
        {
            FormManageStores formManageStores = new FormManageStores();
            formManageStores.ShowDialog();
        }

        private void SystemUserMainForm_Load(object sender, EventArgs e)
        {
            // Add any initialization code here if needed
        }
    }
}
