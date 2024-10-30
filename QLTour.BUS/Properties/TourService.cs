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
    }
    public class KhachHangService
    {
        private readonly ModelTourDB db = new ModelTourDB();

        public void Add(KhachHang khachHang)
        {
            db.KhachHangs.Add(khachHang); // Giả sử có DbSet KhachHangs trong db
            db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        }

        public List<KhachHang> GetAll()
        {
            return db.KhachHangs.ToList();
        }
    }

}
