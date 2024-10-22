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
        }
        private void hideForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //form Tour show
        private void btnTour_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren) // Đối với mỗi form con trong giao diện..
            {
                if (f.Name == "frmTour")
                {
                    f.Activate(); // Mở giao diện
                    f.BringToFront(); // Đẩy lên phía trên
                    f.WindowState = FormWindowState.Maximized; // FullScreen
                    f.Show();
                    return;
                }
            }
            frmTour frm = new frmTour();
            frm.MdiParent = this; // Giúp giao diện MDI chỉ nằm trong form cha (frmMain)
       
            frm.Show();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
