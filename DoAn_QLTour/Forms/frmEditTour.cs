using QLTour.BUS;
using QLTour.BUS.Services;
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
        private readonly TourService tourService = new TourService();
        private readonly nhanVienService nhanVienService = new nhanVienService();

        // Declare the TourUpdated event
        public event EventHandler TourUpdated;

        public frmEditTour()
        {
            InitializeComponent();
        }

        // Public properties to access the textboxes
        public int MaTour { get; set; } // Add this property to store MaTour
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

        public int? NhanVienID { get; set; }
        public int TinhTrang { get; set; }

        private void frmEditTour_Load(object sender, EventArgs e)
        {
            FillCBB();

            // Set the selected values
            if (NhanVienID.HasValue)
            {
                cbbHDV.SelectedValue = NhanVienID.Value;
            }
            else
            {
                cbbHDV.SelectedIndex = -1; // Clear selection if no NhanVienID
            }
            cbbTinhTrangTour.SelectedIndex = TinhTrang;
        }

        private void FillCBB()
        {
            // Populate the cbbHDV ComboBox
            var listNhanViens = nhanVienService.GetAll();
            cbbHDV.DataSource = listNhanViens;
            cbbHDV.DisplayMember = "HoTen"; // Ensure this property exists in the data source
            cbbHDV.ValueMember = "NhanVienID"; // Ensure this property exists in the data source

            // Populate the cbbTinhTrangTour ComboBox
            cbbTinhTrangTour.Items.Clear();
            cbbTinhTrangTour.Items.Add("Còn Hoạt Động");
            cbbTinhTrangTour.Items.Add("Ngưng Hoạt Động");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Tour object with the updated data
            var updatedTour = new Tour
            {
                MaTour = MaTour, // Ensure MaTour is set
                TenTour = TenTour,
                LichTrinh = LichTrinh,
                GiaTien = decimal.Parse(GiaTien),
                MoTa = MoTa,
                TinhTrang = cbbTinhTrangTour.SelectedIndex+1,
                NhanVienID = (int)cbbHDV.SelectedValue // Use NhanVienID here
            };

            // Update the tour in the database
            tourService.UpdateTour(updatedTour);

            // Raise the TourUpdated event
            TourUpdated?.Invoke(this, EventArgs.Empty);

      
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}

