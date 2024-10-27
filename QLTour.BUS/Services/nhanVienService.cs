using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS.Services
{
    public class nhanVienService
    {
        ModelTourDB db = new ModelTourDB();
        public List<NhanVien> GetAll()
        {
            return db.NhanViens.ToList();
        }
        public NhanVien GetByID(int id)
        {
            return db.NhanViens.FirstOrDefault(nv => nv.NhanVienID == id);
        }
    }
}
