using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class ThongKeSoLieuBLL
    {
        private ThongKeSoLieuDAL thongKeDAL = new ThongKeSoLieuDAL();

        public List<ThongKeSoLieu> GetStatistics()
        {
            return thongKeDAL.GetStatistics();
        }
    }
}
