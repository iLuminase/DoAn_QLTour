using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS.Services
{
    public class dichVuService
    {
        ModelTourDB db = new ModelTourDB();
        public dichVuService() { 
            
        }
        public List<DichVu> GetALl()
        {
            return db.DichVus.ToList();
        }
    }
}
