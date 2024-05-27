using System;

namespace FinalProject.Entities
{
    public class ThongKeSoLieu
    {
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int IdSanPham { get; set; }
        public float DoanhThu { get; set; }
        public int SoLuongBanRa { get; set; }
        public string SanPhamBanChayNhat { get; set; }
        public int TongDonHang { get; set; }
    }
}
