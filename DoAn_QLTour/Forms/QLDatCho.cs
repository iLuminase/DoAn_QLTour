
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
    public partial class QLDatCho : Form
    {
        private readonly TourService tourService = new TourService();
        private readonly QLTour.BUS.KhachHangService khachHangService = new QLTour.BUS.KhachHangService();
        private readonly DatTourService datTourService = new DatTourService();
        ModelTourDB db = new ModelTourDB();

        public QLDatCho()
        {
            InitializeComponent();
        }

        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvDatCho.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = dgvDatCho.Rows.Add();
                dgvDatCho.Rows[index].Cells[0].Value = item.MaKhachHang;
               
            }
        }

        private void QLDatCho_Load(object sender, EventArgs e)
        {
            var listKhachHang = khachHangService.GetAll();
            BindGrid(listKhachHang);
            // Đăng ký sự kiện CellClick
            dgvDatCho.CellClick += new DataGridViewCellEventHandler(dgvDatCho_CellClick);
           

            // Tải dữ liệu ChiTietDatTour
            LoadChiTietDatTour();

            // Đăng ký sự kiện CellClick
            dgvDatCho.CellClick += new DataGridViewCellEventHandler(dgvDatCho_CellClick);
        }
        private void LoadChiTietDatTour()
        {
            var lstTour = tourService.GetAll();
            BindGridTour(lstTour);
        }
        private void BindGridTour(List<Tour> listTour)
        {
            dgvTour.Rows.Clear();
            foreach (var item in listTour)
            {
                int index = dgvTour.Rows.Add();
                dgvTour.Rows[index].Cells[0].Value = item.MaTour;
                dgvTour.Rows[index].Cells[1].Value = item.TenTour;
                dgvTour.Rows[index].Cells[2].Value = item.LichTrinh;
                dgvTour.Rows[index].Cells[3].Value = item.GiaTien;
       

                dgvTour.Rows[index].Cells[4].Value = item.TinhTrang;
            }
        }
        private void dgvDatCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvDatCho.Rows[e.RowIndex];
                txtMaKH.Text = selectedRow.Cells[0].Value.ToString(); // Mã khách hàng
                
            }
        }
      

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            var maKH = txtMaKH.Text.Trim();
            var maTour = txtMaTour.Text.Trim();
            var soLuongNguoi = txtSoLuongNguoi.Text.Trim();

            // Kiểm tra ràng buộc
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(maTour) || string.IsNullOrWhiteSpace(soLuongNguoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã khách hàng đã tồn tại trong dgvDatCho chưa
            bool exists = false;
            foreach (DataGridViewRow row in dgvDatCho.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maKH)
                {
                    exists = true;
                    // Cập nhật thêm thông tin
                    row.Cells[1].Value = maTour; // Cập nhật tên tour
                    row.Cells[2].Value = soLuongNguoi; // Cập nhật số lượng người
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (!exists)
            {
                MessageBox.Show("Chưa có thông tin khách hàng với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Nếu khách hàng chưa tồn tại, có thể thêm mới nếu cần
                int index = dgvDatCho.Rows.Add();
                dgvDatCho.Rows[index].Cells[0].Value = maKH;
                dgvDatCho.Rows[index].Cells[1].Value = maTour; // Thêm MaTour
                dgvDatCho.Rows[index].Cells[2].Value = soLuongNguoi; // Thêm SoLuongNguoi
            }

            // Ẩn những hàng không có MaTour
            HideRowsWithoutTour();
        }

        private void HideRowsWithoutTour()
        {
            foreach (DataGridViewRow row in dgvDatCho.Rows)
            {
                // Kiểm tra nếu hàng là hàng mới (uncommitted)
                if (row.IsNewRow)
                {
                    continue; // Bỏ qua hàng mới
                }

                // Kiểm tra xem hàng có giá trị trong cột MaTour (cột 1) hay không
                if (row.Cells.Count > 1 && (row.Cells[1].Value == null || string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString())))
                {
                    row.Visible = false; // Ẩn hàng nếu không có MaTour
                }
                else
                {
                    row.Visible = true; // Hiện hàng nếu có MaTour
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            var maKH = txtMaKH.Text.Trim();
            var maTour = txtMaTour.Text.Trim();
            var soLuongNguoi = txtSoLuongNguoi.Text.Trim();

            // Kiểm tra ràng buộc
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(maTour) || string.IsNullOrWhiteSpace(soLuongNguoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm hàng tương ứng trong dgvDatCho
            bool updated = false;
            foreach (DataGridViewRow row in dgvDatCho.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maKH)
                {
                    // Cập nhật thông tin
                    row.Cells[1].Value = maTour; // Cập nhật MaTour
                    row.Cells[2].Value = soLuongNguoi; // Cập nhật SoLuongNguoi
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Ẩn những hàng không có MaTour
            HideRowsWithoutTour();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
