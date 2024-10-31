using System;
using System.Data.SqlClient;

namespace QLTour.DAL
{
    public class DatTourDAL
    {
        private readonly string connectionString = @"Data Source=DESKTOP-LSF5N86\NHAN;Initial Catalog=QuanLyTour;Integrated Security=True;"; // Chuỗi kết nối tới cơ sở dữ liệu

        public int AddDatTour(string maTour, DateTime ngayDat)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DatTour (MaTour, NgayDat) OUTPUT INSERTED.MaDatTour VALUES (@MaTour, @NgayDat)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTour", maTour);
                cmd.Parameters.AddWithValue("@NgayDat", ngayDat);

                int maDatTour = (int)cmd.ExecuteScalar();
                return maDatTour;
            }
        }

        public void AddChiTietDatTour(string maKhachHang, int maDatTour, int soLuongNguoi, decimal tienCoc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ChiTietDatTour (MaKhachHang, MaDatTour, SoLuongNguoiDat, SoTienCoc, TinhTrang) VALUES (@MaKhachHang, @MaDatTour, @SoLuongNguoiDat, @SoTienCoc, @TinhTrang)";
                //string query = "INSERT INTO ChiTietDatTour (MaKhachHang, MaDatTour, SoLuongNguoiDat) VALUES (@MaKhachHang, @MaDatTour, @SoLuongNguoiDat)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@MaDatTour", maDatTour);
                cmd.Parameters.AddWithValue("@SoLuongNguoiDat", soLuongNguoi);
                cmd.Parameters.AddWithValue("@SoTienCoc", tienCoc);
                cmd.Parameters.AddWithValue("@TinhTrang", "Đang chờ thanh toán");
                cmd.ExecuteNonQuery();
            }
        }

        public string GetCustomerIDByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaKhachHang FROM KhachHang WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                return cmd.ExecuteScalar()?.ToString();
            }
        }
        public decimal GetSoTienCocByTour(string maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT GiaTien FROM Tour WHERE MaTour = @MaTour";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTour", maTour);

                return (decimal)cmd.ExecuteScalar();
            }
        }
    }
}
