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

            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
        }
        public frmHome(int roleID)
        {
            InitializeComponent();
            this.roleID = roleID;
            ApplyPermissions(); // Gọi hàm phân quyền dựa trên roleID
        }

        private void ApplyPermissions()
        {
            if (roleID == 1) // Admin
            {
                // Hiển thị tất cả các chức năng
                btnChiTietChuyenDiDaDat.Visible = false; // Trừ Chi Tiết Chuyến đi đã đặt của Người Dùng
            }
            else if (roleID == 2) // Employee
            {
                btnChiTietChuyenDiDaDat.Visible = false;
            }
            else if (roleID == 3) // User
            {

                btnTour.Visible = false;
                btnDichVu.Visible = false;
                btnDatCho.Visible = false;
                btnThanhToan.Visible = false;
                btnTaiKhoan.Visible = false;
                //btnChiTietChuyenDiDaDat.Visible = false;


            }
        }

        private void hideForm(Form child)
        {

            panel1.Visible = false;
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
            if (child != null)
            { this.Size = new Size(child.Width, child.Height); }
            else
            {
                this.Size = new Size(1552, 794);
            } 
                
            
        }

        //form Tour show
        private void btnTour_Click(object sender, EventArgs e)
        {
            
            
            frmQLTour frm = new frmQLTour();
            hideForm(frm);
            frm.MdiParent = this; // Giúp giao diện MDI chỉ nằm trong form cha (frmMain)
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideForm(null);
            panel1.Visible = true;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnDatTour_pn1_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTietChuyenDiDaDat_Click(object sender, EventArgs e)
        {

        }
    }
}
