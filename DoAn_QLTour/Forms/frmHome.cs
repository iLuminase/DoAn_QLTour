using DoAn_QLTour.Forms;
using DuAnCuoiKy;
using MaterialSkin;
using PhanBaThanh_2280602959;
using QLTour.BUS.Services;
using QLTour.DAL.Entities;
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
        private readonly ThanhToanService thanhToanService;
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

            lblCountSuccessed.Font = new Font("Lucida Bright", 25, FontStyle.Bold);
            label5.Font = new Font("Microsoft Sans Serif", 15);

            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);

            lblCountSuccessed.ForeColor = Color.Black;
            label5.ForeColor = Color.Gray;
            // Khởi tạo repository và service
            ThanhToanRepository repository = new ThanhToanRepository();
            thanhToanService = new ThanhToanService(repository);

            // Cập nhật số lượng hóa đơn khi form được tải
            UpdateInvoiceCount();
        }

        private void UpdateInvoiceCount()
        {
            if (thanhToanService == null)
            {
                return;
            }
            lblCountSuccessed.Text = thanhToanService.GetThanhToanCount().ToString();
        }
        public frmHome(int roleID)
        {
            InitializeComponent();
            this.roleID = roleID;
            ApplyPermissions(); // Gọi hàm phân quyền dựa trên roleID

            this.FormClosed += FrmHome_FormClosed;
        }

        // xử lý sự kiện form đóng
        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gọi Application.Exit() khi form đóng
            Application.Exit();
        }

        private void ApplyPermissions()
        {
            if (roleID == 1) // Admin
            {
                //doanh thu
                //bao cao
                //thong ke 
                //
            }
            else if (roleID == 2) // Employee
            {
                //tat ca chuc nang tru chuc nang cua admin
            }
            else if (roleID == 3) // User
            {
                btnTour.Visible = false;
                btnDichVu.Visible = true;
                btnDatCho.Visible = true;
                btnThanhToan.Visible = true;
                btnTaiKhoan.Visible = true;
            }
        }

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

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu frm = new frmQuanLyDichVu();
            ShowFormAsMdiChild(frm);
        }

        private void btnDatTour_pn1_Click(object sender, EventArgs e)
        {
            // Logic for btnDatTour_pn1 click event
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // Cập nhật số lượng hóa đơn khi form được tải
            UpdateInvoiceCount();
        }

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            frmDatTour frm = new frmDatTour();
            ShowFormAsMdiChild(frm);
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            frmFeedback frm = new frmFeedback();
            ShowFormAsMdiChild(frm);
        }

        private void btnChiTietChuyenDiDaDat_Click(object sender, EventArgs e)
        {
            frmChiTietCuaToi frm = new frmChiTietCuaToi();
            ShowFormAsMdiChild(frm);
        }
    }
}
