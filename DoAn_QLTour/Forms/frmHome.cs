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
        }

        private void hideForm()
        {
            panel1.Visible = false;
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }

        //form Tour show
        private void btnTour_Click(object sender, EventArgs e)
        {
            hideForm();

            frmTour frm = new frmTour();
            frm.MdiParent = this; // Giúp giao diện MDI chỉ nằm trong form cha (frmMain)
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideForm();
            panel1.Visible = true;
        }



    }
}
