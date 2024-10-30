using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS.Properties
{
    public class TourService
    {
        ModelTourDB db = new ModelTourDB();
        public List<Tour> GetAll()
        {
            return db.Tours.ToList();
        }

        public List<ChiTietDatTour> GetAllChiTietDatTour()
        {
            return new List<ChiTietDatTour>();
        }
        public List<ChiTietDatTour> GetChiTietDatTourByEmail(string email)
        {
            // Tìm MaKhachHang dựa trên email của người đăng nhập
            var khachHang = db.KhachHangs.FirstOrDefault(kh => kh.Email == email);

            if (khachHang == null)
            {
                // Nếu không tìm thấy khách hàng với email này, trả về danh sách rỗng
                return new List<ChiTietDatTour>();
            }

            // Lấy danh sách ChiTietDatTour có MaKhachHang tương ứng
            return db.ChiTietDatTours
                     .Where(ct => ct.MaKhachHang == khachHang.MaKhachHang)
                     .ToList();
        }

    }
}
