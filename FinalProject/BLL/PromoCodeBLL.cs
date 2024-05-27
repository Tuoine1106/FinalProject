using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Entities;

namespace FinalProject.BLL
{
    public class PromoCodeBLL
    {
        private PromoCodeDAL dal = new PromoCodeDAL();

        public List<PromoCode> GetAllPromoCodes()
        {
            return dal.GetAllPromoCodes();
        }

        public PromoCode GetPromoCodeByCode(string code)
        {
            return dal.GetPromoCodeByCode(code);
        }
    }
}
