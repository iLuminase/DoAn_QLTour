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

namespace DoAn_QLTour.Forms
{
    public partial class frmDangNhap : Form
    {
        private string connectionString = "Data Source=_HEHENIKEN;Initial Catalog=QuanLyTour;Integrated Security=True";

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void materialButtonDangKy_Click(object sender, EventArgs e)
        {
            // Mở Form Đăng Ký
            frmDangKy registerForm = new frmDangKy();
            registerForm.Show(); // Hiện Form Đăng Ký
            this.Hide(); // Ẩn Form Đăng Nhập
        }

        private void AuthenticateUser(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Password, RoleID FROM Account WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader["Password"].ToString();
                            int roleID = (int)reader["RoleID"];  // Lấy RoleID từ database

                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                            {
                              

                                // Lưu email vào CurrentSession
                                CurrentSession.LoggedInUserEmail = email;

                                // Khởi tạo form chính với role của người dùng
                                frmHome homeForm = new frmHome(roleID);
                                homeForm.Show();

                                this.Hide(); // Ẩn form đăng nhập
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void materialButtonDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Gọi hàm xác thực người dùng
            AuthenticateUser(email, password);
        }



        // xử lý sự kiện Enter
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                materialButtonDangNhap_Click(sender, e);
            }
        }

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

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbxShowPass.Checked ? '\0' : '*';
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           
        }
        //Tao session luu phien dang nhap nguoi dung voi mail
        public static class CurrentSession
        {
            public static string LoggedInUserEmail { get; set; }
        }
    }

}