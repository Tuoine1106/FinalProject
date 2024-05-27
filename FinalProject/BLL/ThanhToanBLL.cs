using System;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class ThanhToanBLL
    {
        private ThanhToanDAL thanhToanDAL = new ThanhToanDAL();

        public void AddThanhToan(ThanhToan thanhToan)
        {
            thanhToanDAL.AddThanhToan(thanhToan);
        }
    }
}
