using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class DonHangDAL
    {
        private string connectionString;

        public DonHangDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<DonHang> GetDonHangs()
        {
            List<DonHang> donHangs = new List<DonHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DonHang", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DonHang donHang = new DonHang
                    {
                        IdDonHang = reader["IdDonHang"] != DBNull.Value ? Convert.ToInt32(reader["IdDonHang"]) : 0,
                        NgayDatHang = reader["NgayDatHang"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDatHang"]) : DateTime.MinValue,
                        TongTien = reader["TongTien"] != DBNull.Value ? Convert.ToSingle(reader["TongTien"]) : 0,
                        IdKhachHang = reader["IdKhachHang"] != DBNull.Value ? Convert.ToInt32(reader["IdKhachHang"]) : 0
                    };
                    donHangs.Add(donHang);
                }
            }
            return donHangs;
        }

        public DonHang GetDonHangById(int id)
        {
            DonHang donHang = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DonHang WHERE IdDonHang = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    donHang = new DonHang
                    {
                        IdDonHang = reader["IdDonHang"] != DBNull.Value ? Convert.ToInt32(reader["IdDonHang"]) : 0,
                        NgayDatHang = reader["NgayDatHang"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDatHang"]) : DateTime.MinValue,
                        TongTien = reader["TongTien"] != DBNull.Value ? Convert.ToSingle(reader["TongTien"]) : 0,
                        IdKhachHang = reader["IdKhachHang"] != DBNull.Value ? Convert.ToInt32(reader["IdKhachHang"]) : 0
                    };
                }
            }
            return donHang;
        }

        public int AddDonHang(DonHang donHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO DonHang (NgayDatHang, TongTien, IdKhachHang) OUTPUT INSERTED.IdDonHang VALUES (@NgayDatHang, @TongTien, @IdKhachHang)", conn);
                cmd.Parameters.AddWithValue("@NgayDatHang", donHang.NgayDatHang);
                cmd.Parameters.AddWithValue("@TongTien", donHang.TongTien);
                cmd.Parameters.AddWithValue("@IdKhachHang", donHang.IdKhachHang);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
