using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class QuanLyCuaHangBLL
    {
        private QuanLyCuaHangDAL dal = new QuanLyCuaHangDAL();

        public List<QuanLyCuaHang> GetStores()
        {
            return dal.GetStores();
        }

        public void AddStore(QuanLyCuaHang store)
        {
            dal.AddStore(store);
        }

        public bool ValidateLoginByIdAndPhone(int idQuanLy, string soDienThoai)
        {
            return dal.ValidateLoginByIdAndPhone(idQuanLy, soDienThoai);
        }
    }
}
