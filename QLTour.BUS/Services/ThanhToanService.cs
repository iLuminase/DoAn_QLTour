using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTour.BUS.Services
{
    public class ThanhToanService
    {
        private ThanhToanRepository repository;

        public ThanhToanService(ThanhToanRepository repository)
        {
            this.repository = repository;
        }

        public int GetThanhToanCount()
        {
            return repository.GetThanhToanCount();
        }
    }
}