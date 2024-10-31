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

namespace DoAn_QLTour.Forms
{
    public partial class frmDangKy : Form
    {
        // Biến connectionString được định nghĩa ở đầu lớp frmRegister, đảm bảo rằng nó có thể được sử dụng trong các phương thức khác trong cùng một lớp.
        private string connectionString = "Data Source=_HEHENIKEN;Initial Catalog=QuanLyTour;Integrated Security=True"; // Thay đổi thông tin kết nối
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

        private void RegisterUser(string email, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Account (Email, Password, RoleID) VALUES (@Email, @Password, @RoleID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@RoleID", 3); // 3 là User
                    cmd.ExecuteNonQuery();

                }
            }

            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form đăng ký
        }
        

        private void materialButtonDangKy_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtPassword2.Text.Trim();

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
            RegisterUser(email, password);
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
        
        // xử lý nút X

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = default;
        }
        // xử lý sự kiện Enter
        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                materialButtonDangKy_Click(sender, e);
            }
        }
        // xử lý nút sign in
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show(); 
            this.Hide(); 
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbxShowPass.Checked ? '\0' : '*';
            txtPassword2.PasswordChar = cbxShowPass.Checked ? '\0' : '*';

        }
    }
}
