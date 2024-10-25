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
    public partial class frmDangNhap : MaterialSkin.Controls.MaterialForm
    {
        private string connectionString = "Data Source=DESKTOP-LSF5N86\\NHAN;Initial Catalog=QuanLyTour;Integrated Security=True";

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
                string query = "SELECT Password FROM Account WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader["Password"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                            {
                                // Đăng nhập thành công
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Tạo instance của frmHome và hiển thị
                                frmHome homeForm = new frmHome();
                                homeForm.Show(); // Hiển thị Form Chính

                                this.Hide(); // Ẩn Form Đăng Nhập
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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void materialButtonDangNhap_Click(object sender, EventArgs e)
        {
            string email = materialMaskedTextBoxEmail.Text.Trim();
            string password = materialMaskedTextBoxPassword.Text.Trim();

            // Gọi hàm xác thực người dùng
            AuthenticateUser(email, password);
        }
    }
}