using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class GiaoHangBLL
    {
        private GiaoHangDAL dal = new GiaoHangDAL();

        public void AddGiaoHang(GiaoHang giaoHang)
        {
            dal.AddGiaoHang(giaoHang);
        }

        public GiaoHang GetGiaoHangByOrderId(int orderId)
        {
            return dal.GetGiaoHangByOrderId(orderId);
        }
    }
}
