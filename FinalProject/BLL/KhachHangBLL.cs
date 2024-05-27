using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHang> GetKhachHangs()
        {
            return dal.GetKhachHangs();
        }

        public KhachHang GetKhachHangByEmail(string email)
        {
            return dal.GetKhachHangByEmail(email);
        }

        public KhachHang GetKhachHangById(int id)
        {
            return dal.GetKhachHangById(id);
        }

        public void AddKhachHang(KhachHang kh)
        {
            dal.AddKhachHang(kh);
        }

        public void UpdateKhachHang(KhachHang kh)
        {
            dal.UpdateKhachHang(kh);
        }

        public bool ValidateLogin(string email, string matKhau)
        {
            return dal.ValidateLogin(email, matKhau);
        }
    }
}
