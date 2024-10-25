﻿using QLTour.DAL.Entities;
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
                existingTour.HuongDanVienID = updatedTour.HuongDanVienID;


                // Save the changes to the database
                db.SaveChanges();
            }
        }
    }
}