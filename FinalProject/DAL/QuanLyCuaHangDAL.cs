using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;
using System;

namespace FinalProject.DAL
{
    public class QuanLyCuaHangDAL
    {
        private string connectionString;

        public QuanLyCuaHangDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<QuanLyCuaHang> GetStores()
        {
            List<QuanLyCuaHang> list = new List<QuanLyCuaHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLyCuaHang", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    QuanLyCuaHang store = new QuanLyCuaHang
                    {
                        IdQuanLy = reader["IdQuanLy"] != DBNull.Value ? Convert.ToInt32(reader["IdQuanLy"]) : 0,
                        TenQuanLy = reader["TenQuanLy"] != DBNull.Value ? reader["TenQuanLy"].ToString() : string.Empty,
                        SoDienThoai = reader["SoDienThoai"] != DBNull.Value ? reader["SoDienThoai"].ToString() : string.Empty
                    };
                    list.Add(store);
                }
            }
            return list;
        }

        public void AddStore(QuanLyCuaHang store)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO QuanLyCuaHang (TenQuanLy, SoDienThoai) VALUES (@TenQuanLy, @SoDienThoai)", conn);
                cmd.Parameters.AddWithValue("@TenQuanLy", store.TenQuanLy);
                cmd.Parameters.AddWithValue("@SoDienThoai", store.SoDienThoai);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool ValidateLoginByIdAndPhone(int idQuanLy, string soDienThoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM QuanLyCuaHang WHERE IdQuanLy = @IdQuanLy AND SoDienThoai = @SoDienThoai", conn);
                cmd.Parameters.AddWithValue("@IdQuanLy", idQuanLy);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
