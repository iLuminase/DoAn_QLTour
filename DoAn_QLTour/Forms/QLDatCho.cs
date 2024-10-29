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
        private readonly KhachHangService khachHangService = new KhachHangService();
        ModelTourDB db = new ModelTourDB();
        public QLDatCho()
        {
          
            InitializeComponent();
            var listKhachHang = khachHangService.GetAll();
            BindGrid(listKhachHang);


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
                //dgvTour.Rows[index].Cells[5].Value = item.NgayBatDau != null
                //     ? item.NgayBatDau.Value.ToString("dd/MM/yyyy")
                //     : string.Empty;

                //dgvTour.Rows[index].Cells[6].Value = item.NgayKetThuc != null
                //    ? item.NgayKetThuc.Value.ToString("dd/MM/yyyy")
                //    : string.Empty;
              
            }
        }

        private void QLDatCho_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            string maKhachHang = txtMaKH.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();

           
            bool isValid = true;
            string errorMessage = "";

           
            if (string.IsNullOrEmpty(maKhachHang))
            {
                errorMessage += "Mã khách hàng không được để trống!\n";
                isValid = false;
            }
            else if (khachHangService.IsMaKhachHangExists(maKhachHang))
            {
                errorMessage += "Mã khách hàng đã tồn tại. Vui lòng nhập mã khác!\n";
                isValid = false;
            }

         
            if (string.IsNullOrEmpty(soDienThoai))
            {
                errorMessage += "Số điện thoại không được để trống!\n";
                isValid = false;
            }
            else if (!soDienThoai.StartsWith("0") || soDienThoai.Length != 10)
            {
                errorMessage += "Số điện thoại phải bắt đầu bằng 0 và đủ 10 số!\n";
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(email))
            {
                errorMessage += "Email không được để trống!\n";
                isValid = false;
            }
            else if (!email.EndsWith("@gmail.com"))
            {
                errorMessage += "Email phải có định dạng @gmail.com!\n";
                isValid = false;
            }

            
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            KhachHang khachHang = new KhachHang
            {
                MaKhachHang = maKhachHang,
                HoTen = hoTen,
                SoDienThoai = soDienThoai,
                Email = email,
                DiaChi = diaChi,
                CMND = cmnd
            };

           
            khachHangService.Add(khachHang);

            
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";

            
            BindGrid(khachHangService.GetAll());

           
            MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDatCho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã khách hàng của dòng được chọn
            string maKhachHang = dgvDatCho.SelectedRows[0].Cells[0].Value.ToString();

            // Xác nhận việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if
         (result == DialogResult.No)
            {
                return;
            }

            // Gọi hàm xóa khách hàng trong service
            if (khachHangService.Delete(maKhachHang))
            {
                // Cập nhật lại DataGridView
                BindGrid(khachHangService.GetAll());
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại!",
         "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        
        }
    }
}
