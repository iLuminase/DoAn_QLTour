using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using DuAnCuoiKy;

namespace DuAnCuoiKy
{
    public partial class frmQuanLyDichVu : Form
    {
        Function fn = new Function();
        String query;

        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            query = "select * from DichVu";
            DataSet ds = fn.GetData(query);
            dgvDichVu.DataSource = ds.Tables[0];

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text != "" && txtMoTa.Text != "" && txtGia.Text != "")
            {
                String TenDichVu = txtTenDV.Text;
                String MoTa = txtMoTa.Text;

                // Sử dụng decimal thay cho Int64
                if (decimal.TryParse(txtGia.Text, out decimal GiaTien))
                {
                    query = $"insert into DichVu (TenDichVu, MoTa, GiaTien) values ('{TenDichVu}', '{MoTa}', {GiaTien})";
                    fn.ExecuteQuery(query, "Đã thêm Dịch Vụ");
                    frmQuanLyDichVu_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Giá tiền phải là một số hợp lệ với tối đa 2 chữ số thập phân", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearAll()
        {
            txtTenDV.Clear();
            txtMoTa.Clear();
            txtGia.Clear();
        }
        private void frmQuanLyDichVu_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void frmQuanLyDichVu_Enter(object sender, EventArgs e)
        {
            frmQuanLyDichVu_Load (this, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Giả sử bạn có một DataGridView có tên là dgvDichVu và nó có một cột cho ID
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDichVu.SelectedCells[0].RowIndex; // Lấy chỉ mục của hàng đã chọn
                DataGridViewRow selectedRow = dgvDichVu.Rows[selectedIndex];

               
                int serviceId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Tạo truy vấn xóa
                query = $"DELETE FROM DichVu WHERE DichVuID = {serviceId}";

                // Thực hiện lệnh xóa
                fn.ExecuteQuery(query, "Đã xóa Dịch Vụ");

                // Làm mới DataGridView
                frmQuanLyDichVu_Load(this, null);
            }
            else
            {
                MessageBox.Show("Xin vui lòng chọn một dịch vụ để xóa", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDichVu.SelectedCells[0].RowIndex; // Lấy chỉ mục của hàng đã chọn
                DataGridViewRow selectedRow = dgvDichVu.Rows[selectedIndex];

                // Lấy ID dịch vụ từ hàng đã chọn
                int serviceId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Lấy dữ liệu từ textbox
                String TenDichVu = txtTenDV.Text;
                String MoTa = txtMoTa.Text;

                // Sử dụng decimal thay cho Int64
                if (decimal.TryParse(txtGia.Text, out decimal GiaTien))
                {
                    // Tạo truy vấn cập nhật
                    query = $"UPDATE DichVu SET TenDichVu = '{TenDichVu}', MoTa = '{MoTa}', GiaTien = {GiaTien} WHERE DichVuID = {serviceId}";

                    // Thực hiện lệnh cập nhật
                    fn.ExecuteQuery(query, "Đã sửa Dịch Vụ");

                    // Làm mới DataGridView
                    frmQuanLyDichVu_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Giá tiền phải là một số hợp lệ với tối đa 2 chữ số thập phân", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xin vui lòng chọn một dịch vụ để sửa", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo hàng đã chọn không phải là tiêu đề
            {
                DataGridViewRow selectedRow = dgvDichVu.Rows[e.RowIndex];

                // Lấy thông tin từ các ô trong hàng đã chọn và điền vào textbox
                txtTenDV.Text = selectedRow.Cells["TenDichVu"].Value.ToString();
                txtMoTa.Text = selectedRow.Cells["MoTa"].Value.ToString();
                txtGia.Text = selectedRow.Cells["GiaTien"].Value.ToString();
            }
        }
    }
}
