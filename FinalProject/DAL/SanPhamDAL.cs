using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;
using System;

namespace FinalProject.DAL
{
    public class SanPhamDAL
    {
        private string connectionString;

        public SanPhamDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<SanPham> GetSanPhams()
        {
            List<SanPham> list = new List<SanPham>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham
                    {
                        IdSanPham = reader["IdSanPham"] != DBNull.Value ? Convert.ToInt32(reader["IdSanPham"]) : 0,
                        TenSanPham = reader["TenSanPham"] != DBNull.Value ? reader["TenSanPham"].ToString() : string.Empty,
                        MoTa = reader["MoTa"] != DBNull.Value ? reader["MoTa"].ToString() : string.Empty,
                        DonGia = reader["DonGia"] != DBNull.Value ? Convert.ToSingle(reader["DonGia"]) : 0,
                        SoLuongTon = reader["SoLuongTon"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongTon"]) : 0
                    };
                    list.Add(sp);
                }
            }
            return list;
        }

        public void AddSanPham(SanPham sanPham)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SanPham (TenSanPham, MoTa, DonGia, SoLuongTon) VALUES (@TenSanPham, @MoTa, @DonGia, @SoLuongTon)", conn);
                cmd.Parameters.AddWithValue("@TenSanPham", sanPham.TenSanPham);
                cmd.Parameters.AddWithValue("@MoTa", sanPham.MoTa);
                cmd.Parameters.AddWithValue("@DonGia", sanPham.DonGia);
                cmd.Parameters.AddWithValue("@SoLuongTon", sanPham.SoLuongTon);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
