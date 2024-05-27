using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormPlaceOrder : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private DonHangBLL donHangBLL = new DonHangBLL();
        private MucDonHangBLL mucDonHangBLL = new MucDonHangBLL();
        private PromoCodeBLL promoCodeBLL = new PromoCodeBLL();
        private List<SanPham> products;
        private List<MucDonHang> orderItems = new List<MucDonHang>();
        private float discount = 0;

        public FormPlaceOrder()
        {
            InitializeComponent();
        }

        private void FormPlaceOrder_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadPromoCodes();
            SetPlaceholders();
        }


        private void LoadProducts()
        {
            products = sanPhamBLL.GetSanPhams();
            dataGridViewProducts.DataSource = products;
        }

        private void LoadPromoCodes()
        {
            List<PromoCode> promoCodes = promoCodeBLL.GetAllPromoCodes();
            dataGridViewPromoCodes.DataSource = promoCodes;
        }

        private void SetPlaceholders()
        {
            SetPlaceholderText(txtProductId, "Product ID");
            SetPlaceholderText(txtQuantity, "Quantity");
            SetPlaceholderText(txtPromoCode, "Promo Code");
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductId.Text, out int productId) && int.TryParse(txtQuantity.Text, out int quantity))
            {
                var product = products.Find(p => p.IdSanPham == productId);
                if (product != null && quantity > 0 && quantity <= product.SoLuongTon)
                {
                    var orderItem = new MucDonHang
                    {
                        IdSanPham = product.IdSanPham,
                        SoLuong = quantity,
                        DonGia = product.DonGia,
                        ThanhTien = product.DonGia * quantity
                    };
                    orderItems.Add(orderItem);
                    LoadOrderItems();
                }
                else
                {
                    MessageBox.Show("Invalid product or quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Product ID and Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderItems()
        {
            dataGridViewOrderItems.DataSource = null;
            dataGridViewOrderItems.DataSource = orderItems;
            lblTotalPrice.Text = $"Total: {orderItems.Sum(item => item.ThanhTien) * (1 - discount / 100)}";
        }

        private void btnApplyPromoCode_Click(object sender, EventArgs e)
        {
            var promoCode = promoCodeBLL.GetPromoCodeByCode(txtPromoCode.Text);
            if (promoCode != null)
            {
                discount = promoCode.DiscountPercentage;
                MessageBox.Show($"Promo code applied! {discount}% discount.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrderItems();
            }
            else
            {
                MessageBox.Show("Invalid or expired promo code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            var donHang = new DonHang
            {
                NgayDatHang = DateTime.Now,
                TongTien = orderItems.Sum(item => item.ThanhTien) * (1 - discount / 100),
                IdKhachHang = 1 // Replace with actual customer ID from logged-in user
            };
            int newOrderId = donHangBLL.AddDonHang(donHang);

            foreach (var item in orderItems)
            {
                item.IdDonHang = newOrderId;
                mucDonHangBLL.AddMucDonHang(item);
            }

            MessageBox.Show("Order placed successfully! Proceeding to shipping details.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to the FormShipping with the new order ID
            FormShipping formShipping = new FormShipping(newOrderId);
            formShipping.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filteredProducts = products.Where(p => p.TenSanPham.ToLower().Contains(searchText)).ToList();
            dataGridViewProducts.DataSource = filteredProducts;
        }

        // Event handlers for txtProductId
        private void txtProductId_Enter(object sender, EventArgs e)
        {
            if (txtProductId.Text == "Product ID")
            {
                txtProductId.Text = "";
                txtProductId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtProductId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                txtProductId.Text = "Product ID";
                txtProductId.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Event handlers for txtQuantity
        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Quantity")
            {
                txtQuantity.Text = "";
                txtQuantity.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtQuantity.Text = "Quantity";
                txtQuantity.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Event handlers for txtPromoCode
        private void txtPromoCode_Enter(object sender, EventArgs e)
        {
            if (txtPromoCode.Text == "Promo Code")
            {
                txtPromoCode.Text = "";
                txtPromoCode.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPromoCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPromoCode.Text))
            {
                txtPromoCode.Text = "Promo Code";
                txtPromoCode.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
