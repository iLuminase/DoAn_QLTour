using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS
{
    public class ChiTietDatTourService
    {
        ModelTourDB db = new ModelTourDB();
        public List<ChiTietDatTour> GetAll()
        {
            return db.ChiTietDatTours.ToList();
        }
    }
}
