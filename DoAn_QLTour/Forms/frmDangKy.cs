using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using QLTour.BUS.Properties;

namespace DoAn_QLTour.Forms
{
    public partial class frmDangKy : MaterialSkin.Controls.MaterialForm
    {
        // Biến connectionString được định nghĩa ở đầu lớp frmRegister, đảm bảo rằng nó có thể được sử dụng trong các phương thức khác trong cùng một lớp.
        private string connectionString = "Data Source=DESKTOP-LSF5N86\\NHAN;Initial Catalog=QuanLyTour;Integrated Security=True"; // Thay đổi thông tin kết nối
        public frmDangKy()
        {
            InitializeComponent();
        }
        
        private bool IsEmailTaken(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            string email = materialMaskedTextBoxEmail.Text.Trim();
            string password = materialMaskedTextBoxPassword.Text.Trim();

            User userBUS = new User();
            userBUS.RegisterUser(email, password);

            // Đóng form đăng ký sau khi đăng ký thành công
            this.Close();
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void materialButtonDangKy_Click(object sender, EventArgs e)
        {
            User userBUS = new User();
            string email = materialMaskedTextBoxEmail.Text.Trim();
            string password = materialMaskedTextBoxPassword.Text.Trim();
            string confirmPassword = materialMaskedTextBoxConfirmPassword.Text.Trim();

            // Ràng buộc đầu vào
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailTaken(email))
            {
                MessageBox.Show("Email này đã được đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đăng ký người dùng
            userBUS.RegisterUser(email, password);
        }
    }
}
