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
using System.Data.Entity.Migrations;
using QLTour.BUS.Properties;
namespace DoAn_QLTour.Forms
{
    public partial class frmQLTour : Form
    {
        private readonly TourService tourService = new TourService();
        ModelTourDB db = new ModelTourDB();
        public frmQLTour()
        {
            InitializeComponent();
            setGridViewStyle(dgvTour);
            var listTour = tourService.GetAll();
            BindGrid(listTour);
        }

        private void BindGrid(List<Tour> listTour)
        {
            dgvTour.Rows.Clear();
            foreach (var item in listTour)
            {
                int index = dgvTour.Rows.Add();
                dgvTour.Rows[index].Cells[0].Value = item.MaTour;
                dgvTour.Rows[index].Cells[1].Value = item.TenTour;
                dgvTour.Rows[index].Cells[2].Value = item.LichTrinh;
                dgvTour.Rows[index].Cells[3].Value = item.GiaTien;
                dgvTour.Rows[index].Cells[4].Value = item.MoTa;
                //dgvTour.Rows[index].Cells[5].Value = item.NgayBatDau != null
                //     ? item.NgayBatDau.Value.ToString("dd/MM/yyyy")
                //     : string.Empty;

                //dgvTour.Rows[index].Cells[6].Value = item.NgayKetThuc != null
                //    ? item.NgayKetThuc.Value.ToString("dd/MM/yyyy")
                //    : string.Empty;
                dgvTour.Rows[index].Cells[5].Value = item.TinhTrang;
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

        private void setNull()
        {
            txtTenTour.Text = "";

            txtMaTour.Text = "";

        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];
                txtMaTour.Text = row.Cells[0].Value.ToString();
                txtTenTour.Text = row.Cells[1].Value.ToString();

                //// Ép kiểu datetime từ csdl vào dtp
                //dtpNgayBD.Value = DateTime.ParseExact(row.Cells[5].Value.ToString(), "dd/MM/yyyy", null);
                //dtpNgayKT.Value = DateTime.ParseExact(row.Cells[6].Value.ToString(), "dd/MM/yyyy", null);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query = db.Tours.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtMaTour.Text))
            {
                query = query.Where(t => t.MaTour.ToString().Contains(txtMaTour.Text.Trim()));
            }
            if (!string.IsNullOrWhiteSpace(txtTenTour.Text))
            {
                query = query.Where(t => t.TenTour.Contains(txtTenTour.Text.Trim()));
            }

            //// Parse the dates from the date pickers
            //DateTime? ngayBatDau = dtpNgayBD.Checked ? (DateTime?)dtpNgayBD.Value : null;
            //DateTime? ngayKetThuc = dtpNgayKT.Checked ? (DateTime?)dtpNgayKT.Value : null;

            //// Add conditions to filter by date range
            //if (ngayBatDau.HasValue)
            //{
            //    query = query.Where(t => t.NgayBatDau >= ngayBatDau.Value);
            //}
            //if (ngayKetThuc.HasValue)
            //{
            //    query = query.Where(t => t.NgayKetThuc <= ngayKetThuc.Value);
            //}

            var listTour = query.ToList();
            BindGrid(listTour);
        }

        //Su kien them tour
        private void hideForm()
        {
            panel1.Visible = false;
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }
        private void btnThemHoacSua_Click(object sender, EventArgs e)
        {
            frmThemHoacSuaTour frm = new frmThemHoacSuaTour();
            frm.Show();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
            // Đóng tất cả các form con & cha
            //Environment.Exit(0);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            setNull();
            var listTour = db.Tours.ToList();
            BindGrid(listTour);
        }

        private void frmQLTour_Load(object sender, EventArgs e)
        {

        }
    }
}

