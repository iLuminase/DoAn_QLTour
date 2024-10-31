using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTour.Forms
{
    public partial class frmQRThanhToan : MaterialSkin.Controls.MaterialForm
    {
        public frmQRThanhToan()
        {
            InitializeComponent();
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {

            // Hiển thị lại Form đăng nhập
            frmDatTour frmDatTour = new frmDatTour();
            frmDatTour.Show();

            // Đóng Form Home hiện tại
            this.Hide();
        }
    }
}
