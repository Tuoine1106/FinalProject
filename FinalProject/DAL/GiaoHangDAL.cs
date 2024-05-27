using System;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class GiaoHangDAL
    {
        private string connectionString;

        public GiaoHangDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public void AddGiaoHang(GiaoHang giaoHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO GiaoHang (NgayGiaoHang, TinhTrang, IdDonHang) VALUES (@NgayGiaoHang, @TinhTrang, @IdDonHang)", conn);
                cmd.Parameters.AddWithValue("@NgayGiaoHang", giaoHang.NgayGiaoHang);
                cmd.Parameters.AddWithValue("@TinhTrang", giaoHang.TinhTrang);
                cmd.Parameters.AddWithValue("@IdDonHang", giaoHang.IdDonHang);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public GiaoHang GetGiaoHangByOrderId(int orderId)
        {
            GiaoHang giaoHang = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM GiaoHang WHERE IdDonHang = @OrderId", conn);
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    giaoHang = new GiaoHang
                    {
                        IdGiaoHang = (int)reader["IdGiaoHang"],
                        NgayGiaoHang = (DateTime)reader["NgayGiaoHang"],
                        TinhTrang = reader["TinhTrang"].ToString(),
                        IdDonHang = (int)reader["IdDonHang"]
                    };
                }
            }
            return giaoHang;
        }
    }
}
