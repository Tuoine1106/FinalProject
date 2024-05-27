using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.BLL;
using FinalProject.Entities;

namespace FinalProject
{
    public partial class FormTrackOrder : Form
    {
        private DonHangBLL donHangBLL = new DonHangBLL();
        private GiaoHangBLL giaoHangBLL = new GiaoHangBLL();

        public FormTrackOrder()
        {
            InitializeComponent();
        }

        private void FormTrackOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            List<DonHang> orders = donHangBLL.GetDonHangs();
            List<OrderTrackingViewModel> orderTracking = new List<OrderTrackingViewModel>();

            foreach (var order in orders)
            {
                GiaoHang giaoHang = giaoHangBLL.GetGiaoHangByOrderId(order.IdDonHang);
                orderTracking.Add(new OrderTrackingViewModel
                {
                    OrderId = order.IdDonHang,
                    OrderDate = order.NgayDatHang,
                    TotalAmount = order.TongTien,
                    ShippingDate = giaoHang?.NgayGiaoHang,
                    ShippingStatus = giaoHang?.TinhTrang
                });
            }

            dataGridViewOrders.DataSource = orderTracking;
        }
    }

    public class OrderTrackingViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string ShippingStatus { get; set; }
    }
}
