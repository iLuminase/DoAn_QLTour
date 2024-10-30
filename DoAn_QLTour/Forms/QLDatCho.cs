using QLTour.BUS.Properties;
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
                dgvDatCho.Rows[index].Cells[1].Value = item.HoTen;
                dgvDatCho.Rows[index].Cells[2].Value = item.SoDienThoai;
                dgvDatCho.Rows[index].Cells[3].Value = item.Email;
                dgvDatCho.Rows[index].Cells[4].Value = item.DiaChi;
                dgvDatCho.Rows[index].Cells[5].Value = item.CMND;


            }
        }

        private void QLDatCho_Load(object sender, EventArgs e)
        {
            var listKhachHang = khachHangService.GetAll();
            BindGrid(listKhachHang);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            var maKhachHang = txtMaKH.Text.Trim();
            var hoTen = txtHoTen.Text.Trim();
            var soDienThoai = txtSDT.Text.Trim();
            var email = txtEmail.Text.Trim();
            var diaChi = txtDiaChi.Text.Trim();
            var cmnd = txtCMND.Text.Trim();

            // Kiểm tra ràng buộc
            if (string.IsNullOrWhiteSpace(maKhachHang) ||
                string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(soDienThoai) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(cmnd))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            // Kiểm tra số điện thoại
            if (soDienThoai.Length != 10 || !soDienThoai.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số và bắt đầu bằng số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng KhachHang
            var khachHang = new KhachHang
            {
                MaKhachHang = int.Parse(maKhachHang),
                HoTen = hoTen,
                SoDienThoai = soDienThoai,
                Email = email,
                DiaChi = diaChi,
                CMND = cmnd
            };

            // Gọi phương thức thêm khách hàng từ dịch vụ
            try
            {
                khachHangService.Add(khachHang);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại Grid
                var listKhachHang = khachHangService.GetAll();
                BindGrid(listKhachHang);

                // Xóa thông tin trong các TextBox
                txtMaKH.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();
                txtCMND.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDatCho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã khách hàng từ dòng được chọn
            var selectedRow = dgvDatCho.SelectedRows[0];
            var maKhachHang = (int)selectedRow.Cells[0].Value; // Giả sử cột 0 là MaKhachHang

            // Xác nhận xóa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Gọi phương thức xóa khách hàng từ dịch vụ
                    khachHangService.Delete(maKhachHang); // Đảm bảo rằng phương thức này đã được định nghĩa

                    // Cập nhật lại Grid
                    var listKhachHang = khachHangService.GetAll();
                    BindGrid(listKhachHang);

                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDatCho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các TextBox
            var maKhachHang = txtMaKH.Text.Trim();
            var hoTen = txtHoTen.Text.Trim();
            var soDienThoai = txtSDT.Text.Trim();
            var email = txtEmail.Text.Trim();
            var diaChi = txtDiaChi.Text.Trim();
            var cmnd = txtCMND.Text.Trim();

            // Kiểm tra ràng buộc
            if (string.IsNullOrWhiteSpace(maKhachHang) ||
                string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(soDienThoai) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(cmnd))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại
            if (soDienThoai.Length != 10 || !soDienThoai.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số và bắt đầu bằng số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã khách hàng từ dòng được chọn
            var selectedRow = dgvDatCho.SelectedRows[0];
            var id = (int)selectedRow.Cells[0].Value; // Giả sử cột 0 là MaKhachHang

            // Tạo đối tượng KhachHang để cập nhật
            var khachHang = new KhachHang
            {
                MaKhachHang = id,
                HoTen = hoTen,
                SoDienThoai = soDienThoai,
                Email = email,
                DiaChi = diaChi,
                CMND = cmnd
            };

            // Gọi phương thức sửa khách hàng từ dịch vụ
            try
            {
                khachHangService.Update(khachHang);
                MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại Grid
                var listKhachHang = khachHangService.GetAll();
                BindGrid(listKhachHang);

                // Xóa thông tin trong các TextBox
                txtMaKH.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();
                txtCMND.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
