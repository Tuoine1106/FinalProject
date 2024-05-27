using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class KhachHangDAL
    {
        private string connectionString;

        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<KhachHang> GetKhachHangs()
        {
            List<KhachHang> list = new List<KhachHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang
                    {
                        IdKhachHang = (int)reader["IdKhachHang"],
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString()
                    };
                    list.Add(kh);
                }
            }
            return list;
        }

        public KhachHang GetKhachHangByEmail(string email)
        {
            KhachHang kh = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    kh = new KhachHang
                    {
                        IdKhachHang = (int)reader["IdKhachHang"],
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString()
                    };
                }
            }
            return kh;
        }

        public KhachHang GetKhachHangById(int id)
        {
            KhachHang kh = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE IdKhachHang = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    kh = new KhachHang
                    {
                        IdKhachHang = (int)reader["IdKhachHang"],
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString()
                    };
                }
            }
            return kh;
        }

        public void AddKhachHang(KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang (TenKhachHang, DiaChi, SoDienThoai, Email, MatKhau) VALUES (@TenKhachHang, @DiaChi, @SoDienThoai, @Email, @MatKhau)", conn);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", kh.Email);
                cmd.Parameters.AddWithValue("@MatKhau", kh.MatKhau);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateKhachHang(KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email WHERE IdKhachHang = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", kh.IdKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", kh.Email);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool ValidateLogin(string email, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM KhachHang WHERE Email = @Email AND MatKhau = @MatKhau", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
