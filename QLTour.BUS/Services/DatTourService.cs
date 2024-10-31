using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS
{
    public class DatTourService
    {
        private ModelTourDB db;

        public DatTourService()
        {
            db = new ModelTourDB();
        }


        public List<ChiTietDatTour> GetAllChiTietDatTour()
        {
            return db.ChiTietDatTours.ToList(); // Hoặc thực hiện truy vấn cần thiết
        }
    }
}
