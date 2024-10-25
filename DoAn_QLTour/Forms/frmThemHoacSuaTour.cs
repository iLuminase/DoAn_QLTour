﻿using QLTour.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTour.Forms
{
    public partial class frmThemHoacSuaTour : Form
    {
        public frmThemHoacSuaTour()
        {
            InitializeComponent();
        }
        ModelTourDB db = new ModelTourDB();
        private void btnThemHoacSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtTenTour.Text) || string.IsNullOrWhiteSpace(txtLichTrinh.Text) ||
                string.IsNullOrEmpty(txtGiaTien.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Tour.");
                return;
            }

            DateTime ngayBatDau = DateTime.Parse(dtpNgayBD.Text);
            DateTime ngayKetThuc = DateTime.Parse(dtpNgayKT.Text);

            // Kiểm tra ngày kết thúc phải lớn hơn ngày bắt đầu
            if (ngayKetThuc <= ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKT.Focus();
                return;
            }
            // kiem tra neu TenTour da ton tai thi cap nhat lai thong tin
            Tour t = db.Tours.FirstOrDefault(tr => tr.TenTour.ToString().CompareTo(txtTenTour.Text.Trim()) == 0);
            if (t != null)
            {
                t.TenTour = txtTenTour.Text;
                t.LichTrinh = txtLichTrinh.Text;
                t.MoTa = txtMoTa.Text;
                t.GiaTien = decimal.Parse(txtGiaTien.Text);
                t.NgayBatDau = DateTime.Parse(dtpNgayBD.Text);
                t.NgayKetThuc = DateTime.Parse(dtpNgayKT.Text);

                db.Tours.AddOrUpdate(t);
                db.SaveChanges();
                MessageBox.Show($"Cập nhật tour {txtTenTour.Text} thành công!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             // Nguoc lai thi tao moi tour
                Tour tour = new Tour()
                {
                    TenTour = txtTenTour.Text,
                    LichTrinh = txtLichTrinh.Text,
                    MoTa = txtMoTa.Text,
                    GiaTien = int.Parse(txtGiaTien.Text),
                    NgayBatDau = DateTime.Parse(dtpNgayBD.Text),
                    NgayKetThuc = DateTime.Parse(dtpNgayKT.Text)
                };
                db.Tours.Add(tour);
                db.SaveChanges();
                MessageBox.Show($"Thêm thông tin cho tour {txtTenTour.Text} thành công!", "Thông báo");
            }

        }
    }
}