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
}
