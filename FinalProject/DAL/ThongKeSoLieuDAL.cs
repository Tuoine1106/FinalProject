using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class ThongKeSoLieuDAL
    {
        private string connectionString;

        public ThongKeSoLieuDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<ThongKeSoLieu> GetStatistics()
        {
            List<ThongKeSoLieu> thongKeSoLieus = new List<ThongKeSoLieu>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ThongKeSoLieu", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ThongKeSoLieu thongKeSoLieu = new ThongKeSoLieu
                    {
                        NgayBatDau = reader["NgayBatDau"] != DBNull.Value ? Convert.ToDateTime(reader["NgayBatDau"]) : DateTime.MinValue,
                        NgayKetThuc = reader["NgayKetThuc"] != DBNull.Value ? Convert.ToDateTime(reader["NgayKetThuc"]) : DateTime.MinValue,
                        IdSanPham = reader["IdSanPham"] != DBNull.Value ? Convert.ToInt32(reader["IdSanPham"]) : 0,
                        DoanhThu = reader["DoanhThu"] != DBNull.Value ? Convert.ToSingle(reader["DoanhThu"]) : 0,
                        SoLuongBanRa = reader["SoLuongBanRa"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongBanRa"]) : 0,
                        SanPhamBanChayNhat = reader["SanPhamBanChayNhat"] != DBNull.Value ? reader["SanPhamBanChayNhat"].ToString() : "",
                        TongDonHang = reader["TongDonHang"] != DBNull.Value ? Convert.ToInt32(reader["TongDonHang"]) : 0
                    };
                    thongKeSoLieus.Add(thongKeSoLieu);
                }
            }
            return thongKeSoLieus;
        }
    }
}
