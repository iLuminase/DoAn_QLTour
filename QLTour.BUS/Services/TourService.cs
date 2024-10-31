using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS
{
    public class TourService
    {
        ModelTourDB db = new ModelTourDB();
     
        public List<Tour> GetAll()
        {
            return db.Tours.ToList();
        }

        public void UpdateTour(Tour updatedTour)
        {
            // Tim theo ma tour
            var existingTour = db.Tours.Find(updatedTour.MaTour);
            if (existingTour != null)
            {
                // Cap nhat thong tin tour
                existingTour.TenTour = updatedTour.TenTour;
                existingTour.LichTrinh = updatedTour.LichTrinh;
                existingTour.GiaTien = updatedTour.GiaTien;
                existingTour.MoTa = updatedTour.MoTa;
                existingTour.TinhTrang = updatedTour.TinhTrang;
                existingTour.NhanVienID = updatedTour.NhanVienID;


                // Save the changes to the database
                db.SaveChanges();
            }
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
