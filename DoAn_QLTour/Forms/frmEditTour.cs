using QLTour.BUS;
using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTour.Forms
{
    public partial class frmEditTour : Form
    {
        ModelTourDB db = new ModelTourDB();
        private readonly TourService tourService = new TourService();

        public frmEditTour()
        {
            InitializeComponent();
        }

        // Public properties to access the textboxes

        public string TenTour
        {
            get => txtTenTour.Text;
            set => txtTenTour.Text = value;
        }

        public string LichTrinh
        {
            get => txtLichTrinh.Text;
            set => txtLichTrinh.Text = value;
        }

        public string GiaTien
        {
            get => txtGiaTien.Text;
            set => txtGiaTien.Text = value;
        }

        public string MoTa
        {
            get => txtMoTa.Text;
            set => txtMoTa.Text = value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Tour object with the updated data
            var updatedTour = new Tour
            {

                TenTour = TenTour,
                LichTrinh = LichTrinh,
                GiaTien = decimal.Parse(GiaTien),
                MoTa = MoTa,

                
            };

            // Update the tour in the database
            tourService.UpdateTour(updatedTour);

            // Close the edit form
            this.Close();
        }
    }
}

