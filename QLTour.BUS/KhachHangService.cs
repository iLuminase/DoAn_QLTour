using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS
{
    public class KhachHangService
    {
        private readonly ModelTourDB db = new ModelTourDB();

        public void Add(KhachHang khachHang)
        {
            db.KhachHangs.Add(khachHang); // Giả sử có DbSet KhachHangs trong db
            db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        }
        public void Delete(int maKhachHang)
        {
            var khachHang = db.KhachHangs.Find(maKhachHang);
            if (khachHang != null)
            {
                db.KhachHangs.Remove(khachHang);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Khách hàng không tồn tại.");
            }
        }
        public void Update(KhachHang khachHang)
        {
            db.Entry(khachHang).State = EntityState.Modified;
            db.SaveChanges();
        }
       
        public List<KhachHang> GetAll()
        {
            return db.KhachHangs.ToList();
        }
    }
}
