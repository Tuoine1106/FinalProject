using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            FormViewProducts formViewProducts = new FormViewProducts();
            formViewProducts.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FormPlaceOrder formPlaceOrder = new FormPlaceOrder();
            formPlaceOrder.ShowDialog();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            FormViewOrders formViewOrders = new FormViewOrders();
            formViewOrders.ShowDialog();
        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            FormTrackOrder formTrackOrder = new FormTrackOrder();
            formTrackOrder.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
