using QLTour.BUS.Services;
using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTour.Forms
{
    public partial class frmThemTour : Form
    {
        // Khai bao su kien TourUpdated
        public event EventHandler TourUpdated;
        private readonly nhanVienService nhanVienService = new nhanVienService();
        public frmThemTour()
        {
            InitializeComponent();
        }

        ModelTourDB db = new ModelTourDB();

        private void btnThemHoacSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenTour.Text) || string.IsNullOrWhiteSpace(txtLichTrinh.Text) ||
                string.IsNullOrEmpty(txtGiaTien.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Tour.");
                return;
            }

            // kiem tra neu TenTour da ton tai thi cap nhat lai thong tin
            Tour t = db.Tours.FirstOrDefault(tr => tr.TenTour.ToString().CompareTo(txtTenTour.Text.Trim()) == 0);
            if (t != null)
            {
                t.TenTour = txtTenTour.Text;
                t.LichTrinh = txtLichTrinh.Text;
                t.MoTa = txtMoTa.Text;
                t.GiaTien = decimal.Parse(txtGiaTien.Text);
                t.TinhTrang = cbbTinhTrangTour.SelectedIndex;
                t.NhanVienID = (int)cbbHDV.SelectedValue;
                db.Tours.AddOrUpdate(t);
                db.SaveChanges();
                MessageBox.Show($"Cập nhật tour {txtTenTour.Text} thành công!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nguoc lai thi tao moi tour
                Tour tour = new Tour()
                {
                    TenTour = txtTenTour.Text,
                    LichTrinh = txtLichTrinh.Text,
                    MoTa = txtMoTa.Text,
                    GiaTien = int.Parse(txtGiaTien.Text),
                    TinhTrang = cbbTinhTrangTour.SelectedIndex,
                    NhanVienID = (int)cbbHDV.SelectedValue
                };
                db.Tours.Add(tour);
                db.SaveChanges();
                MessageBox.Show($"Thêm thông tin cho tour {txtTenTour.Text} thành công!", "Thông báo");
            }

            // Kích hoạt sự kiện TourUpdated
            TourUpdated?.Invoke(this, EventArgs.Empty);
        }
        public void FillCbbHDV(List<NhanVien> listNhanViens)
        {
            cbbHDV.DataSource = null;
            this.cbbHDV.DataSource = listNhanViens;
            this.cbbHDV.DisplayMember = "HoTen";
            this.cbbHDV.ValueMember = "NhanVienID";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTour_Load(object sender, EventArgs e)
        {
            var listNhanViens =  nhanVienService.GetAll();
            FillCbbHDV(listNhanViens);
        }
    }
}
