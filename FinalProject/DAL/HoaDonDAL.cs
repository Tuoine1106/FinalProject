using System;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class HoaDonDAL
    {
        private string connectionString;

        public HoaDonDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public void AddHoaDon(HoaDon hoaDon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon (NgayLapHoaDon, IdDonHang) VALUES (@NgayLapHoaDon, @IdDonHang)", conn);
                cmd.Parameters.AddWithValue("@NgayLapHoaDon", hoaDon.NgayLapHoaDon);
                cmd.Parameters.AddWithValue("@IdDonHang", hoaDon.IdDonHang);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public HoaDon GetHoaDonById(int id)
        {
            HoaDon hoaDon = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon WHERE IdHoaDon = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hoaDon = new HoaDon
                    {
                        IdHoaDon = reader["IdHoaDon"] != DBNull.Value ? Convert.ToInt32(reader["IdHoaDon"]) : 0,
                        NgayLapHoaDon = reader["NgayLapHoaDon"] != DBNull.Value ? Convert.ToDateTime(reader["NgayLapHoaDon"]) : DateTime.MinValue,
                        IdDonHang = reader["IdDonHang"] != DBNull.Value ? Convert.ToInt32(reader["IdDonHang"]) : 0
                    };
                }
            }
            return hoaDon;
        }
    }
}
