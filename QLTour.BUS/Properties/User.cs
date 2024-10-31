using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
namespace QLTour.BUS.Properties
{
    public class User
    {
        private string connectionString = @"Data Source=DESKTOP-LSF5N86\NHAN;Initial Catalog=QuanLyTour;Integrated Security=True;"; // Chuỗi kết nối tới cơ sở dữ liệu

        public void RegisterUser(string email, string password)
        {
            // Hash mật khẩu
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Account (Email, Password, RoleID) VALUES (@Email, @Password, @RoleID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@RoleID", 3); // 3 là User
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
