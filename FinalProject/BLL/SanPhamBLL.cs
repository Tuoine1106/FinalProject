using FinalProject.DAL;
using FinalProject.Entities;
using System.Collections.Generic;

namespace FinalProject.BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL dal = new SanPhamDAL();

        public List<SanPham> GetSanPhams()
        {
            return dal.GetSanPhams();
        }

        public void AddSanPham(SanPham sanPham)
        {
            dal.AddSanPham(sanPham);
        }
    }
}
