using FinalProject.BLL;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormViewProducts : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();

        public FormViewProducts()
        {
            InitializeComponent();
        }

        private void FormViewProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = sanPhamBLL.GetSanPhams();
            if (products == null || products.Count == 0)
            {
                MessageBox.Show("No products found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewProducts.DataSource = products;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;
            var products = sanPhamBLL.GetSanPhams().Where(p => p.TenSanPham.Contains(keyword)).ToList();
            if (products == null || products.Count == 0)
            {
                MessageBox.Show("No products found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewProducts.DataSource = products;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FormPlaceOrder formPlaceOrder = new FormPlaceOrder();
            formPlaceOrder.ShowDialog();
        }
    }
}
