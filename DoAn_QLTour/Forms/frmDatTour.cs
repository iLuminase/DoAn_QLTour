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

using System.Data.SqlClient;
using QLTour.BUS;
using static DoAn_QLTour.Forms.frmDangNhap;

namespace DoAn_QLTour.Forms
{
    public partial class frmDatTour : Form
    {
        private DatTourBUS datTourBUS = new DatTourBUS();
        private readonly TourService tourService = new TourService();
        ModelTourDB db = new ModelTourDB();
        public frmDatTour()
        {
            InitializeComponent();
            setGridViewStyle(dgvDatTour);
            var listTour = tourService.GetAll();
            BindGrid(listTour);
        }

        private void BindGrid(List<Tour> listTour)
        {
            dgvDatTour.Rows.Clear();
            foreach (var item in listTour)
            {
                int index = dgvDatTour.Rows.Add();
                dgvDatTour.Rows[index].Cells[0].Value = item.MaTour;
                dgvDatTour.Rows[index].Cells[1].Value = item.TenTour;
                dgvDatTour.Rows[index].Cells[2].Value = item.LichTrinh;
                dgvDatTour.Rows[index].Cells[3].Value = item.GiaTien;
                dgvDatTour.Rows[index].Cells[4].Value = item.MoTa;
                //dgvTour.Rows[index].Cells[5].Value = item.NgayBatDau != null
                //     ? item.NgayBatDau.Value.ToString("dd/MM/yyyy")
                //     : string.Empty;

                //dgvTour.Rows[index].Cells[6].Value = item.NgayKetThuc != null
                //    ? item.NgayKetThuc.Value.ToString("dd/MM/yyyy")
                //    : string.Empty;
                
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

        private void dgvDatTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDatTour.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvDatTour.Rows[e.RowIndex];
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
        private void btnDatTour_Click(object sender, EventArgs e)
        {
            string maTour = txtMaTour.Text;
            int soLuong = int.TryParse(txtNhapSoNguoi.Text, out int temp) ? temp : 0;

            if (string.IsNullOrEmpty(maTour) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng chọn Tourn và nhập số lượng người hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string email = CurrentSession.LoggedInUserEmail; // Thay currentUserEmail bằng email người dùng hiện tại
            bool result = datTourBUS.DatTour(maTour, email, soLuong);

            if (result)
            {
                MessageBox.Show("Đặt tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQRThanhToan frmQRThanhToan = new frmQRThanhToan();
                frmQRThanhToan.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đặt tour thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //string email = CurrentSession.LoggedInUserEmail; // Thay currentUserEmail bằng email người dùng hiện tại
        private void btnDong_Click_1(object sender, EventArgs e)
        {

            this.Hide();
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

        private void dgvDatTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

