using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class MucDonHangBLL
    {
        private MucDonHangDAL dal = new MucDonHangDAL();

        public List<MucDonHang> GetMucDonHangByOrderId(int orderId)
        {
            return dal.GetMucDonHangByOrderId(orderId);
        }

        public void AddMucDonHang(MucDonHang mucDonHang)
        {
            dal.AddMucDonHang(mucDonHang);
        }
    }
}
