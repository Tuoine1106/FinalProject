using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class MucDonHangDAL
    {
        private string connectionString;

        public MucDonHangDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["FoodOrderingSystemDB"].ConnectionString;
        }

        public List<MucDonHang> GetMucDonHangByOrderId(int orderId)
        {
            List<MucDonHang> mucDonHangs = new List<MucDonHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MucDonHang WHERE IdDonHang = @OrderId", conn);
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MucDonHang mucDonHang = new MucDonHang
                    {
                        IdMucDonHang = reader["IdMucDonHang"] != DBNull.Value ? Convert.ToInt32(reader["IdMucDonHang"]) : 0,
                        IdDonHang = reader["IdDonHang"] != DBNull.Value ? Convert.ToInt32(reader["IdDonHang"]) : 0,
                        IdSanPham = reader["IdSanPham"] != DBNull.Value ? Convert.ToInt32(reader["IdSanPham"]) : 0,
                        SoLuong = reader["SoLuong"] != DBNull.Value ? Convert.ToInt32(reader["SoLuong"]) : 0,
                        DonGia = reader["DonGia"] != DBNull.Value ? Convert.ToSingle(reader["DonGia"]) : 0f,
                        ThanhTien = reader["ThanhTien"] != DBNull.Value ? Convert.ToSingle(reader["ThanhTien"]) : 0f
                    };
                    mucDonHangs.Add(mucDonHang);
                }
            }
            return mucDonHangs;
        }

        public void AddMucDonHang(MucDonHang mucDonHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO MucDonHang (IdDonHang, IdSanPham, SoLuong, DonGia, ThanhTien) VALUES (@IdDonHang, @IdSanPham, @SoLuong, @DonGia, @ThanhTien)", conn);
                cmd.Parameters.AddWithValue("@IdDonHang", mucDonHang.IdDonHang);
                cmd.Parameters.AddWithValue("@IdSanPham", mucDonHang.IdSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", mucDonHang.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", mucDonHang.DonGia);
                cmd.Parameters.AddWithValue("@ThanhTien", mucDonHang.ThanhTien);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
