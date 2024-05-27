using System;

namespace FinalProject.Entities
{
    public class DonHang
    {
        public int IdDonHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public float TongTien { get; set; }
        public int IdKhachHang { get; set; }
    }
}
