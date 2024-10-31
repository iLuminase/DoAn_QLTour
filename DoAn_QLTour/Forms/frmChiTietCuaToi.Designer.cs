namespace DoAn_QLTour.Forms
{
    partial class frmChiTietCuaToi : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LichTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1667, 98);
            this.panel1.TabIndex = 50;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(449, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Chi Tiết Tour Của Tôi";
            // 
            // dgvTour
            // 
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTour,
            this.LichTrinh,
            this.GiaTien,
            this.NgayDat,
            this.SoTienCoc,
            this.TinhTrang,
            this.SoNguoi});
            this.dgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTour.Location = new System.Drawing.Point(3, 162);
            this.dgvTour.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.Size = new System.Drawing.Size(1667, 737);
            this.dgvTour.TabIndex = 58;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // TenTour
            // 
            this.TenTour.HeaderText = "Tên Tour";
            this.TenTour.MinimumWidth = 6;
            this.TenTour.Name = "TenTour";
            this.TenTour.Width = 80;
            // 
            // LichTrinh
            // 
            this.LichTrinh.HeaderText = "Lịch Trình";
            this.LichTrinh.MinimumWidth = 6;
            this.LichTrinh.Name = "LichTrinh";
            this.LichTrinh.Width = 200;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 250;
            // 
            // NgayDat
            // 
            this.NgayDat.HeaderText = "Ngày Đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Width = 125;
            // 
            // SoTienCoc
            // 
            this.SoTienCoc.HeaderText = "Số Tiền Cọc";
            this.SoTienCoc.MinimumWidth = 6;
            this.SoTienCoc.Name = "SoTienCoc";
            this.SoTienCoc.Width = 250;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // SoNguoi
            // 
            this.SoNguoi.HeaderText = "Số Người";
            this.SoNguoi.MinimumWidth = 6;
            this.SoNguoi.Name = "SoNguoi";
            this.SoNguoi.Width = 125;
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(4, 9);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 43);
            this.btnDong.TabIndex = 8;
            this.btnDong.TabStop = false;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmChiTietCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 902);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietCuaToi";
            this.Text = "Chi Tiết Tour Của Tôi";
            this.Load += new System.EventHandler(this.frmQLTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
        private System.Windows.Forms.Button btnDong;
    }
}