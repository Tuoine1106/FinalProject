using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FinalProject.Entities;

namespace FinalProject.DAL
{
    public class ThanhToanDAL
    {
        private string connectionString = "your_connection_string_here";

        public void AddThanhToan(ThanhToan thanhToan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO ThanhToan (SoTienThanhToan, NgayThanhToan, IdHoaDon) VALUES (@SoTienThanhToan, @NgayThanhToan, @IdHoaDon)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoTienThanhToan", thanhToan.SoTienThanhToan);
                command.Parameters.AddWithValue("@NgayThanhToan", thanhToan.NgayThanhToan);
                command.Parameters.AddWithValue("@IdHoaDon", thanhToan.IdHoaDon);
                command.ExecuteNonQuery();
            }
        }
    }
}
