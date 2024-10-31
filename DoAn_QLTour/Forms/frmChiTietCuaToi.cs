using QLTour.BUS;
using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DoAn_QLTour.Forms.frmDangNhap;
namespace DoAn_QLTour.Forms
{
    public partial class frmChiTietCuaToi : MaterialSkin.Controls.MaterialForm
    {
        private readonly TourService tourService = new TourService();
        ModelTourDB db = new ModelTourDB();
        public frmChiTietCuaToi()
        {
            InitializeComponent();
            setGridViewStyle(dgvTour);
            string email = CurrentSession.LoggedInUserEmail;
            var listTour = tourService.GetChiTietDatTourByEmail(email);
            BindGrid(listTour);
        }

        private void BindGrid(List<ChiTietDatTour> listTour)
        {
            dgvTour.Rows.Clear();
            foreach (var item in listTour)
            {
                int index = dgvTour.Rows.Add();
                dgvTour.Rows[index].Cells[0].Value = item.DatTour.Tour.TenTour;
                dgvTour.Rows[index].Cells[1].Value = item.DatTour.Tour.LichTrinh;
                dgvTour.Rows[index].Cells[2].Value = item.DatTour.Tour.GiaTien;
                dgvTour.Rows[index].Cells[3].Value = item.DatTour.NgayDat;
                dgvTour.Rows[index].Cells[4].Value = item.SoTienCoc;
                dgvTour.Rows[index].Cells[5].Value = item.TinhTrang;
                dgvTour.Rows[index].Cells[6].Value = item.SoLuongNguoiDat;
            }
        }


        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.Fixed3D;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];


                //// Ép kiểu datetime từ csdl vào dtp
                //dtpNgayBD.Value = DateTime.ParseExact(row.Cells[5].Value.ToString(), "dd/MM/yyyy", null);
                //dtpNgayKT.Value = DateTime.ParseExact(row.Cells[6].Value.ToString(), "dd/MM/yyyy", null);
            }
        }

        private void frmQLTour_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

