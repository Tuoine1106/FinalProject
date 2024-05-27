using System;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormShipping : Form
    {
        private int orderId;
        private GiaoHangBLL giaoHangBLL = new GiaoHangBLL();
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();

        public FormShipping(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void FormShipping_Load(object sender, EventArgs e)
        {
            // Any initialization code you need when the form loads
        }

        private void btnConfirmShipping_Click(object sender, EventArgs e)
        {
            GiaoHang giaoHang = new GiaoHang
            {
                NgayGiaoHang = DateTime.Now,
                TinhTrang = "Pending",
                IdDonHang = orderId
            };

            giaoHangBLL.AddGiaoHang(giaoHang);

            HoaDon hoaDon = new HoaDon
            {
                NgayLapHoaDon = DateTime.Now,
                IdDonHang = orderId
            };

            hoaDonBLL.AddHoaDon(hoaDon);

            MessageBox.Show("Shipping details confirmed! Generating invoice.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to the FormInvoice with the new order ID
            FormInvoice formInvoice = new FormInvoice(orderId);
            formInvoice.ShowDialog();
            this.Close();
        }
    }
}
