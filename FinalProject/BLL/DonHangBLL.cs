using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class DonHangBLL
    {
        private DonHangDAL dal = new DonHangDAL();

        public List<DonHang> GetDonHangs()
        {
            return dal.GetDonHangs();
        }

        public DonHang GetDonHangById(int id)
        {
            return dal.GetDonHangById(id);
        }

        public int AddDonHang(DonHang donHang)
        {
            return dal.AddDonHang(donHang);
        }
    }
}
