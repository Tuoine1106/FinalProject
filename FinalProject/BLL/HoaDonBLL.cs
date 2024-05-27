using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public void AddHoaDon(HoaDon hoaDon)
        {
            dal.AddHoaDon(hoaDon);
        }

        public HoaDon GetHoaDonById(int id)
        {
            return dal.GetHoaDonById(id);
        }
    }
}
