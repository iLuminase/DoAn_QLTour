using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS
{
    public class huongDanVienService
    {
        private readonly ModelTourDB _context;

        public huongDanVienService()
        {
            _context = new ModelTourDB();
        }

        public NhanVien GetById(int id)
        {
            return _context.NhanViens.FirstOrDefault(h => h.NhanVienID == id);
        }
    }
}
