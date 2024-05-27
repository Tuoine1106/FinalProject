using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormInvoice : Form
    {
        private int orderId;
        private DonHangBLL donHangBLL = new DonHangBLL();
        private MucDonHangBLL mucDonHangBLL = new MucDonHangBLL();
        private GiaoHangBLL giaoHangBLL = new GiaoHangBLL();

        public FormInvoice(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            DisplayInvoice();
        }

        private void DisplayInvoice()
        {
            DonHang donHang = donHangBLL.GetDonHangById(orderId);
            List<MucDonHang> orderItems = mucDonHangBLL.GetMucDonHangByOrderId(orderId);
            GiaoHang giaoHang = giaoHangBLL.GetGiaoHangByOrderId(orderId);

            lblOrderId.Text = $"Order ID: {donHang.IdDonHang}";
            lblOrderDate.Text = $"Order Date: {donHang.NgayDatHang}";
            lblTotalAmount.Text = $"Total Amount: {donHang.TongTien}";
            lblShippingDate.Text = $"Shipping Date: {giaoHang.NgayGiaoHang}";
            lblShippingStatus.Text = $"Shipping Status: {giaoHang.TinhTrang}";

            dataGridViewOrderItems.DataSource = orderItems;
        }
    }
}
