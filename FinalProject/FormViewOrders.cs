using FinalProject.BLL;
using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormViewOrders : Form
    {
        private DonHangBLL donHangBLL = new DonHangBLL();

        public FormViewOrders()
        {
            InitializeComponent();
        }

        private void FormViewOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = donHangBLL.GetDonHangs();
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No orders found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewOrders.DataSource = orders;
            }
        }
    }
}
