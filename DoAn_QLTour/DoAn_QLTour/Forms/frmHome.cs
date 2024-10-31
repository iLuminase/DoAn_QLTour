using DoAn_QLTour.Forms;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTour
{
    public partial class frmHome : MaterialSkin.Controls.MaterialForm
    {
        private int roleID;
        public frmHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);  // Pass 'this' to manage the current form
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,   // Primary Color
                Primary.Blue700,   // Darker Primary
                Primary.Blue200,   // Lighter Primary
                Accent.Pink200,    // Accent Color
                TextShade.WHITE    // Text color (Black or White)
            );

            //thiet ket nut Dat tour
            btnDatTour_pn1.BackColor = Color.FromArgb(255, 128, 0);
            btnDatTour_pn2.BackColor = Color.FromArgb(255, 128, 0);
            btnDatTour_pn3.BackColor = Color.FromArgb(255, 128, 0);
            btnDatTour_pn4.BackColor = Color.FromArgb(255, 128, 0);

            btnDatTour_pn1.ForeColor = Color.White;
            btnDatTour_pn2.ForeColor = Color.White;
            btnDatTour_pn3.ForeColor = Color.White;
            btnDatTour_pn4.ForeColor = Color.White;

            //thiết kế label
            label1.Font = new Font("Lucida Bright", 15, FontStyle.Bold);
            label2.Font = new Font("Lucida Bright", 15, FontStyle.Bold);
            label3.Font = new Font("Lucida Bright", 15, FontStyle.Bold);
            label4.Font = new Font("Lucida Bright", 15, FontStyle.Bold);

            lblSoNguoiPhucVu.Font = new Font("Lucida Bright", 25, FontStyle.Bold);
            label5.Font = new Font("Microsoft Sans Serif", 15);

            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);

            lblSoNguoiPhucVu.ForeColor = Color.Black;
            label5.ForeColor = Color.Gray;
        }
        public frmHome(int roleID)
        {
            InitializeComponent();
            this.roleID = roleID;
            /*ApplyPermissions();*/ // Gọi hàm phân quyền dựa trên roleID
        }

        //private void ApplyPermissions()
        //{
        //    if (roleID == 1) // Admin
        //    {
        //        // Hiển thị tất cả các chức năng
        //        btnChiTietChuyenDiDaDat.Visible = false; // Trừ Chi Tiết Chuyến đi đã đặt của Người Dùng
        //    }
        //    else if (roleID == 2) // Employee
        //    {
        //        btnChiTietChuyenDiDaDat.Visible = false;
        //    }
        //    else if (roleID == 3) // User
        //    {

        //        btnTour.Visible = false;
        //        btnDichVu.Visible = false;
        //        btnDatCho.Visible = false;
        //        btnThanhToan.Visible = false;
        //        btnTaiKhoan.Visible = false;
                


        //    }
        //}

        private void hideForm(Form child)
        {
            panel1.Visible = false;

            // Hide all MDI child forms using LINQ
            foreach (var form in this.MdiChildren)
            {
                form.Hide();
            }

            // Set the size of the current form based on the child form
            this.Size = child != null ? new Size(child.Width, child.Height) : new Size(1552, 794);
        }

        // Helper method to show a form as an MDI child
        private void ShowFormAsMdiChild(Form child)
        {
            hideForm(child);
            child.MdiParent = this; // Ensure the form is a child of the current MDI parent
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        // form Tour show
        private void btnTour_Click(object sender, EventArgs e)
        {
            var frm = new frmQLTour();
            ShowFormAsMdiChild(frm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideForm(null);
            panel1.Visible = true;
        }

  

        private void btnChiTietChuyenDiDaDat_Click(object sender, EventArgs e)
        {
            // Mở Form Chi Tiết
            frmChiTietCuaToi ChiTietCuaToifrm = new frmChiTietCuaToi();
            ChiTietCuaToifrm.Show(); // Hiện Form Chi Tiết 
            this.Hide(); // Ẩn Form Home
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            
            frmDichVu frm = new frmDichVu();
            ShowFormAsMdiChild(frm);

        }
    }
}
