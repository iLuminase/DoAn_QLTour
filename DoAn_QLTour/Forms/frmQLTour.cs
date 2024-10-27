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
using QLTour.BUS;
using QLTour.BUS.Services;
namespace DoAn_QLTour.Forms
{
    public partial class frmQLTour : Form
    {
        private readonly TourService tourService = new TourService();
        private readonly nhanVienService nhanVienService = new nhanVienService();
        ModelTourDB db = new ModelTourDB();

        public frmQLTour()
        {
            InitializeComponent();
            var listTour = tourService.GetAll();
            BindGrid(listTour);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemTour frm = new frmThemTour();
            frm.TourUpdated += Frm_TourUpdated;
            frm.ShowDialog();
        }

        private void Frm_TourUpdated(object sender, EventArgs e)
        {
            // Refresh the DataGridView
            var listTour = tourService.GetAll();
            BindGrid(listTour);
        }

        public void FillCBB(List<NhanVien> lstNhanViens)
        {
            // Implementation for filling ComboBox if needed
        }

        private void BindGrid(List<Tour> listTour)
        {
            dgvTour.Rows.Clear();
            foreach (var item in listTour)
            {
                // Skip tours that are not active if the user is a customer
                if (item.TinhTrang != 1 && IsCustomerUser())
                {
                    continue;
                }

                int index = dgvTour.Rows.Add();
                dgvTour.Rows[index].Cells[0].Value = item.MaTour;
                dgvTour.Rows[index].Cells[1].Value = item.TenTour;
                dgvTour.Rows[index].Cells[2].Value = item.LichTrinh;
                dgvTour.Rows[index].Cells[3].Value = item.GiaTien;
                dgvTour.Rows[index].Cells[4].Value = item.MoTa;
                dgvTour.Rows[index].Cells[5].Value = item.TinhTrang == 1 ? "Còn Hoạt Động" : "Ngưng Hoạt Động";

                // Kiem tra ma huong dv va hien ten hdv (neu co)
                if (item.NhanVienID.HasValue)
                {
                    var huongDanVien = nhanVienService.GetByID(item.NhanVienID.Value);
                    dgvTour.Rows[index].Cells[6].Value = huongDanVien != null ? huongDanVien.HoTen : string.Empty;
                }
                else
                {
                    dgvTour.Rows[index].Cells[6].Value = string.Empty;
                }
            }
        }

        private void frmQLTour_Load(object sender, EventArgs e)
        {
            var listTour = tourService.GetAll();
            BindGrid(listTour);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTour.Text))
            {
                MessageBox.Show("Vui lòng chọn tour cần xóa");
                return;
            }
            int maTour = int.Parse(txtMaTour.Text);
            var tour = db.Tours.Find(maTour);
            if (tour != null)
            {
                db.Tours.Remove(tour);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
                var listTour = db.Tours.ToList();
                BindGrid(listTour);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            var listTour = db.Tours.ToList();
            BindGrid(listTour);
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];
                txtMaTour.Text = row.Cells[0].Value.ToString();
                txtTenTour.Text = row.Cells[1].Value.ToString();
            }
        }

        // Helper method to determine if the current user is a customer
        private bool IsCustomerUser()
        {
            // Implement your logic to determine if the current user is a customer
            // For example, you might check the user's role or permissions
            // Return true if the user is a customer, otherwise false
            return true; // Placeholder implementation
        }

        private void setNull()
        {
            txtTenTour.Text = "";
            txtMaTour.Text = "";
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

        private void dgvTour_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];
                frmEditTour editForm = new frmEditTour();

                // Pass data to the edit form using public properties
                editForm.TenTour = row.Cells[1].Value.ToString();
                editForm.LichTrinh = row.Cells[2].Value.ToString();
                editForm.GiaTien = row.Cells[3].Value.ToString();
                editForm.MoTa = row.Cells[4].Value.ToString();

                // Ensure NhanVienID is correctly retrieved and cast
                if (row.Cells[6].Value != null && int.TryParse(row.Cells[6].Value.ToString(), out int nhanVienID))
                {
                    editForm.NhanVienID = nhanVienID;
                }
                else
                {
                    editForm.NhanVienID = null;
                }

                editForm.TinhTrang = row.Cells[5].Value.ToString() == "Còn Hoạt Động" ? 0 : 1;

                // Subscribe to the TourUpdated event
                editForm.TourUpdated += Frm_TourUpdated;

                // Show the edit form
                editForm.ShowDialog();

                // Refresh the grid after editing
                var listTour = tourService.GetAll();
                BindGrid(listTour);
            }
        }
    }
}