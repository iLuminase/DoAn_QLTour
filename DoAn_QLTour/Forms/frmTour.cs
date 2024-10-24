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
    public partial class frmTour : MaterialSkin.Controls.MaterialForm
    {
        private readonly TourService tourService = new TourService();
        ModelTourDB db = new ModelTourDB();
        public frmTour()
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
                dgvTour.Rows[index].Cells[5].Value = item.NgayBatDau;
                dgvTour.Rows[index].Cells[6].Value = item.NgayKetThuc;
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

        //private void btnThemHoacSua_Click(object sender, EventArgs e)
        //{
        //    // Kiểm tra dữ liệu đầu vào
        //    if (string.IsNullOrWhiteSpace(txtTenTour.Text) || string.IsNullOrWhiteSpace(txtLichTrinh.Text) ||
        //        string.IsNullOrEmpty(txtGiaTien.Text) || string.IsNullOrEmpty(txtMoTa.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin Tour.");
        //        return;
        //    }

        //    DateTime ngayBatDau = DateTime.Parse(dtpNgayBD.Text);
        //    DateTime ngayKetThuc = DateTime.Parse(dtpNgayKT.Text);

        //    // Kiểm tra ngày kết thúc phải lớn hơn ngày bắt đầu
        //    if (ngayKetThuc <= ngayBatDau)
        //    {
        //        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dtpNgayKT.Focus();
        //        return;
        //    }

        //    Tour t = db.Tours.FirstOrDefault(tr => tr.MaTour.ToString().CompareTo(txtMaTour.Text.Trim()) == 0);
        //    if (t != null)
        //    {
        //        t.TenTour = txtTenTour.Text;
        //        t.LichTrinh = txtLichTrinh.Text;
        //        t.MoTa = txtMoTa.Text;
        //        t.GiaTien = decimal.Parse(txtGiaTien.Text);
        //        t.NgayBatDau = DateTime.Parse(dtpNgayBD.Text);
        //        t.NgayKetThuc = DateTime.Parse(dtpNgayKT.Text);

        //        db.Tours.AddOrUpdate(t);
        //        db.SaveChanges();
        //        MessageBox.Show($"Cập nhật tour {txtTenTour.Text} thành công!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        Tour tour = new Tour()
        //        {
        //            TenTour = txtTenTour.Text,
        //            LichTrinh = txtLichTrinh.Text,
        //            MoTa = txtMoTa.Text,
        //            GiaTien = int.Parse(txtGiaTien.Text),
        //            NgayBatDau = DateTime.Parse(dtpNgayBD.Text),
        //            NgayKetThuc = DateTime.Parse(dtpNgayKT.Text)
        //        };
        //        db.Tours.Add(tour);
        //        db.SaveChanges();
        //        MessageBox.Show($"Thêm thông tin cho tour {txtTenTour.Text} thành công!", "Thông báo");
        //    }

        //    // Lấy danh sách tour mới nhất từ cơ sở dữ liệu và cập nhật DataGridView
        //    var listTour = db.Tours.ToList();
        //    BindGrid(listTour);
        //    setNull();
        //}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTour.Text))
            {
                MessageBox.Show("Vui lòng chọn tour để xóa.");
                return;
            }

            Tour t = db.Tours.FirstOrDefault(tr => tr.MaTour.ToString().CompareTo(txtMaTour.Text.Trim()) == 0);
            if (t != null)
            {
                db.Tours.Remove(t);
                db.SaveChanges();
                MessageBox.Show($"Xóa tour {txtTenTour.Text} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lấy danh sách tour mới nhất từ cơ sở dữ liệu và cập nhật DataGridView
                var listTour = db.Tours.ToList();
                BindGrid(listTour);
                setNull();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tour để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void setNull()
        {
            txtTenTour.Text = "";
        
            txtMaTour.Text = "";
            dtpNgayBD.Text = "";
            dtpNgayKT.Text = "";
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTour.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvTour.Rows[e.RowIndex];
                txtMaTour.Text = row.Cells[0].Value.ToString();
                txtTenTour.Text = row.Cells[1].Value.ToString();
            
                dtpNgayBD.Text = row.Cells[5].Value.ToString();
                dtpNgayKT.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            var listTour = db.Tours.ToList();
            BindGrid(listTour);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
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

    }
}

