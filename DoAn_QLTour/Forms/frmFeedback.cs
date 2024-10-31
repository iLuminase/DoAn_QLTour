using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAn_QLTour;
using DuAnCuoiKy;
namespace PhanBaThanh_2280602959
{
    public partial class frmFeedback : Form
    {
        private readonly Function fn = new Function();
        private string query;

        public frmFeedback()
        {
            InitializeComponent();
            LoadData(); // Gọi phương thức LoadData khi khởi tạo Form
        }
        private void LoadData()
        {
            try
            {
                query = "SELECT * FROM Feedback";
                DataSet ds = fn.GetData(query);
                dgvDV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKH.Text;
            string maTour = txtMaTour.Text;
            string noiDung = txtNoiDung.Text;
            string ngayPhanHoi = dtpNgayPhanHoi.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(maKhachHang) ||
                string.IsNullOrWhiteSpace(maTour) ||
                string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Feedback (MaKhachHang, MaTour, NoiDung, NgayPhanHoi) " +
                           "VALUES (@MaKhachHang, @MaTour, @NoiDung, @NgayPhanHoi)";

            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=ADMIN-PC\\SQL; Database=QuanLyTour; Integrated Security=True"))
                {
  
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@MaTour", maTour);
                        cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                        cmd.Parameters.AddWithValue("@NgayPhanHoi", ngayPhanHoi);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm phản hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
        private void ClearAll()
        {
            txtMaKH.Clear();        
            txtMaTour.Clear();       
            txtNoiDung.Clear();      
            dtpNgayPhanHoi.Value = DateTime.Now; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một phản hồi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phản hồi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return; 
            }

            string maKhachHang = txtMaKH.Text.Trim();

            string query = "DELETE FROM Feedback WHERE MaKhachHang = @MaKhachHang";

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ADMIN-PC\\SQL; Database=QuanLyTour; Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xóa phản hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll(); 
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một phản hồi để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string maKhachHang = txtMaKH.Text.Trim();
            string maTour = txtMaTour.Text.Trim();
            string noiDung = txtNoiDung.Text.Trim();
            string ngayPhanHoi = dtpNgayPhanHoi.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(maTour) || string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa phản hồi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return; 
            }

            string query = "UPDATE Feedback SET MaTour = @MaTour, NoiDung = @NoiDung, NgayPhanHoi = @NgayPhanHoi WHERE MaKhachHang = @MaKhachHang";

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ADMIN-PC\\SQL; Database=QuanLyTour; Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@MaTour", maTour);
                        cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                        cmd.Parameters.AddWithValue("@NgayPhanHoi", ngayPhanHoi);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Số hàng bị ảnh hưởng

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa phản hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phản hồi để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                ClearAll(); 
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvDV.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDV.Rows[e.RowIndex];

                txtMaKH.Text = selectedRow.Cells["MaKhachHang"]?.Value?.ToString() ?? string.Empty;
                txtMaTour.Text = selectedRow.Cells["MaTour"]?.Value?.ToString() ?? string.Empty;
                txtNoiDung.Text = selectedRow.Cells["NoiDung"]?.Value?.ToString() ?? string.Empty;

                if (DateTime.TryParse(selectedRow.Cells["NgayPhanHoi"]?.Value?.ToString(), out DateTime ngayPhanHoi))
                {
                    dtpNgayPhanHoi.Value = ngayPhanHoi;
                }
                else
                {
                    dtpNgayPhanHoi.Value = DateTime.Now;
                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một phản hồi hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}