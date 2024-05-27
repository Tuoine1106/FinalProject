using System;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormManageProducts : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();

        public FormManageProducts()
        {
            InitializeComponent();
        }

        private void FormManageProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = sanPhamBLL.GetSanPhams();
            dataGridViewProducts.DataSource = products;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new SanPham
            {
                TenSanPham = txtTenSanPham.Text,
                MoTa = txtMoTa.Text,
                DonGia = float.Parse(txtDonGia.Text),
                SoLuongTon = int.Parse(txtSoLuongTon.Text)
            };
            sanPhamBLL.AddSanPham(product);
            LoadProducts();
        }
    }
}
