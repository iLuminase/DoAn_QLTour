using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhanBaThanh_2280602959
{
    public partial class Form1 : Form
    {
        private readonly function fn = new function();
        private string query;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            try
            {
                query = "SELECT MaFeedback, MaKhachHang, MaTour, NoiDung, NgayPhanHoi FROM Feedback";
                DataSet ds = fn.getData(query);

                if (ds?.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvDV.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            txtMaKH.Clear();
            txtNoiDung.Clear();
            dtpNgayPhanHoi.Value = DateTime.Now;
            txtMaTour.Clear();
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDV.Rows[e.RowIndex];
                txtMaKH.Text = selectedRow.Cells["MaKhachHang"]?.Value.ToString();
                txtNoiDung.Text = selectedRow.Cells["NoiDung"]?.Value.ToString();
                txtMaTour.Text = selectedRow.Cells["MaTour"]?.Value.ToString();
                if (DateTime.TryParse(selectedRow.Cells["NgayPhanHoi"]?.Value.ToString(), out DateTime ngayPhanHoi))
                {
                    dtpNgayPhanHoi.Value = ngayPhanHoi;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e) => AddFeedback();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteFeedback();
        private void btnSua_Click(object sender, EventArgs e) => UpdateFeedback();

        private void AddFeedback()
        {
            if (ValidateInputs(out string MaKhachHang, out string NoiDung, out string MaTour))
            {
                string NgayPhanHoi = dtpNgayPhanHoi.Value.ToString("yyyy-MM-dd");
                query = "INSERT INTO Feedback (MaKhachHang, MaTour, NoiDung, NgayPhanHoi) VALUES (@MaKhachHang, @MaTour, @NoiDung, @NgayPhanHoi)";
                ExecuteNonQuery(query, new SqlParameter[]
                {
                    new SqlParameter("@MaKhachHang", MaKhachHang),
                    new SqlParameter("@MaTour", MaTour),
                    new SqlParameter("@NoiDung", NoiDung),
                    new SqlParameter("@NgayPhanHoi", NgayPhanHoi)
                });

                LoadData();
                ClearAll();
                MessageBox.Show("Đã thêm yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteFeedback()
        {
            string MaKhachHang = txtMaKH.Text.Trim();
            if (string.IsNullOrEmpty(MaKhachHang) || !CheckMaKhachHangExists(MaKhachHang))
            {
                MessageBox.Show("Mã Khách Hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            query = "DELETE FROM Feedback WHERE MaKhachHang = @MaKhachHang";
            ExecuteNonQuery(query, new SqlParameter[] { new SqlParameter("@MaKhachHang", MaKhachHang) });

            LoadData();
            ClearAll();
            MessageBox.Show("Đã xóa yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateFeedback()
        {
            if (ValidateInputs(out string MaKhachHang, out string NoiDung, out string MaTour))
            {
                string MaFeedback = dgvDV.CurrentRow.Cells["MaFeedback"].Value.ToString();
                if (!CheckMaFeedbackExists(MaFeedback))
                {
                    MessageBox.Show("Mã Feedback không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                query = "UPDATE Feedback SET NoiDung = @NoiDung, NgayPhanHoi = @NgayPhanHoi, MaTour = @MaTour WHERE MaFeedback = @MaFeedback";
                ExecuteNonQuery(query, new SqlParameter[]
                {
                    new SqlParameter("@NoiDung", NoiDung),
                    new SqlParameter("@NgayPhanHoi", dtpNgayPhanHoi.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@MaTour", MaTour),
                    new SqlParameter("@MaFeedback", MaFeedback)
                });

                LoadData();
                ClearAll();
                MessageBox.Show("Đã sửa yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = fn.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddRange(parameters);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private bool CheckMaFeedbackExists(string MaFeedback)
        {
            query = "SELECT COUNT(*) FROM Feedback WHERE MaFeedback = @MaFeedback";
            using (SqlConnection con = fn.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@MaFeedback", MaFeedback);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool CheckMaKhachHangExists(string MaKhachHang) => CheckExists("KhachHang", "@MaKhachHang", MaKhachHang);
        private bool CheckMaTourExists(string MaTour) => CheckExists("Tour", "@MaTour", MaTour);

        private bool CheckExists(string table, string param, string value)
        {
            query = $"SELECT COUNT(*) FROM {table} WHERE {param.TrimStart('@')} = {param}";
            using (SqlConnection con = fn.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue(param, value);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool ValidateInputs(out string MaKhachHang, out string NoiDung, out string MaTour)
        {
            MaKhachHang = txtMaKH.Text.Trim();
            NoiDung = txtNoiDung.Text.Trim();
            MaTour = txtMaTour.Text.Trim();

            if (string.IsNullOrEmpty(MaKhachHang) || string.IsNullOrEmpty(NoiDung) || string.IsNullOrEmpty(MaTour))
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
