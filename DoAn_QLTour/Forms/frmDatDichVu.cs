using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DuAnCuoiKy
{
    public partial class frmDatDichVu : Form
    {
        private string connectionString = "Data Source=_HEHENIKEN;Initial Catalog=QuanLyTour;Integrated Security=True";

        public frmDatDichVu()
        {
            InitializeComponent();
            LoadDatDichVu(); // Tải danh sách dịch vụ đã đặt ngay khi khởi động form
        }

        private void btnDatDV_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng nhập vào
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDichVu = txtMaDV.Text; // Nhập mã dịch vụ từ TextBox
            string maDatTour = txtDatTour.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO DatDichVu (MaDichVu, MaDatTour, SoLuong) VALUES (@MaDichVu, @MaDatTour, @SoLuong)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    cmd.Parameters.AddWithValue("@MaDatTour", maDatTour);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đặt dịch vụ thành công!");

                // Tải lại danh sách dịch vụ đã đặt
                LoadDatDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDatDichVu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaDatDichVu, MaDatTour, MaDichVu, SoLuong FROM DatDichVu"; // Thay đổi để lấy các trường cần thiết
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDatDV.DataSource = dt; // Đảm bảo dgvDatDV là tên đúng của DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách dịch vụ đã đặt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDatDV.SelectedRows.Count > 0)
            {
                int maDatDichVu = Convert.ToInt32(dgvDatDV.SelectedRows[0].Cells["MaDatDichVu"].Value);

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?",
                                     "Xóa Dịch Vụ",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM DatDichVu WHERE MaDatDichVu = @MaDatDichVu";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaDatDichVu", maDatDichVu);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Xóa dịch vụ thành công!");
                        LoadDatDichVu(); // Tải lại danh sách sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDatDV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDatDV.SelectedRows[0];

                // Đảm bảo các ô chứa giá trị trước khi truy cập
                if (selectedRow.Cells["MaDatDichVu"].Value != null &&
                    selectedRow.Cells["MaDichVu"].Value != null &&
                    selectedRow.Cells["SoLuong"].Value != null)
                {
                    int maDatDichVu = Convert.ToInt32(selectedRow.Cells["MaDatDichVu"].Value);
                    int maDichVu = Convert.ToInt32(selectedRow.Cells["MaDichVu"].Value);
                    int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);

                    // Thực hiện logic cập nhật tại đây
                }
                else
                {
                    MessageBox.Show("Một hoặc nhiều ô trong hàng đã chọn đang trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvDatDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo hàng được nhấn không phải là tiêu đề
            {
                DataGridViewRow selectedRow = dgvDatDV.Rows[e.RowIndex];

                // Kiểm tra các ô có giá trị trước khi truy cập
                if (selectedRow.Cells["MaDatTour"].Value != null &&
                    selectedRow.Cells["SoLuong"].Value != null)
                {
                    // Lấy các giá trị từ hàng được chọn (bỏ qua MaDatDichVu)
                    string maDatTour = selectedRow.Cells["MaDatTour"].Value.ToString();
                    int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);

                    // Gán giá trị vào các TextBox tương ứng (bỏ qua txtMaDV)
                    txtDatTour.Text = maDatTour;
                    txtSoLuong.Text = soLuong.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
