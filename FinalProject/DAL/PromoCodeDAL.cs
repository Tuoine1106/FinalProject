using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class PromoCodeDAL
    {
        private string connectionString;

        public PromoCodeDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<PromoCode> GetAllPromoCodes()
        {
            List<PromoCode> promoCodes = new List<PromoCode>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhuyenMai", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PromoCode promoCode = new PromoCode
                    {
                        Code = reader["MaKhuyenMai"].ToString(),
                        DiscountPercentage = Convert.ToSingle(reader["TyLeKhuyenMai"])
                    };
                    promoCodes.Add(promoCode);
                }
            }
            return promoCodes;
        }

        public PromoCode GetPromoCodeByCode(string code)
        {
            PromoCode promoCode = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhuyenMai WHERE MaKhuyenMai = @Code", conn);
                cmd.Parameters.AddWithValue("@Code", code);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    promoCode = new PromoCode
                    {
                        Code = reader["MaKhuyenMai"].ToString(),
                        DiscountPercentage = Convert.ToSingle(reader["TyLeKhuyenMai"])
                    };
                }
            }
            return promoCode;
        }
    }
}
