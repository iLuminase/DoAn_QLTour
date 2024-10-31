using System;
using QLTour.DAL;

namespace QLTour.BUS
{
    public class DatTourBUS
    {
        private DatTourDAL datTourDAL = new DatTourDAL();

        public bool DatTour(string maTour, string emailKhachHang, int soLuong)
        {
            try
            {
                DateTime ngayDat = DateTime.Now;

                // Lấy tiền cọc từ thông tin Tour
                decimal tienCoc = datTourDAL.GetSoTienCocByTour(maTour);

                // Thêm DatTour và lấy MaDatTour vừa được thêm
                int maDatTour = datTourDAL.AddDatTour(maTour, ngayDat);

                // Lấy MaKhachHang từ email
                string maKhachHang = datTourDAL.GetCustomerIDByEmail(emailKhachHang);
                if (maKhachHang == null) return false;

                // Thêm ChiTietDatTour với Số lượng và Tiền cọc
                datTourDAL.AddChiTietDatTour(maKhachHang, maDatTour, soLuong, tienCoc);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
