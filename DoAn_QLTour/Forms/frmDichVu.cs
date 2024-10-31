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

    public partial class frmDichVu : Form
    {
        private readonly dichVuService dichVu = new dichVuService();
        ModelTourDB db = new ModelTourDB();
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            var listDichVu = dichVu.GetALl();
            dgvDichVu.Rows.Clear();
            foreach (var item in listDichVu)
            {


                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = item.DichVuID;
                dgvDichVu.Rows[index].Cells[1].Value = item.TenDichVu;
                dgvDichVu.Rows[index].Cells[2].Value = item.MoTa;
                dgvDichVu.Rows[index].Cells[3].Value = item.GiaTien;

                dgvDichVu.Rows[index].Cells[4].Value = item.TinhTrang == 1 ? "Còn Hoạt Động" : "Ngưng Hoạt Động";
            }
        }
    }
}
