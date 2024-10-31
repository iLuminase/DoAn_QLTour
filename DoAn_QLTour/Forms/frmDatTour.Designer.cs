namespace DoAn_QLTour.Forms
{
    partial class frmDatTour
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDatTour = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.dgvDatTour = new System.Windows.Forms.DataGridView();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNhapSoNguoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNhapSoNguoi);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTenTour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 98);
            this.panel1.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnDatTour);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(736, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(418, 78);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(152, 22);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 43);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.TabStop = false;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnDatTour
            // 
            this.btnDatTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTour.Location = new System.Drawing.Point(29, 22);
            this.btnDatTour.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Size = new System.Drawing.Size(115, 43);
            this.btnDatTour.TabIndex = 7;
            this.btnDatTour.TabStop = false;
            this.btnDatTour.Text = "Đặt Tour";
            this.btnDatTour.UseVisualStyleBackColor = true;
            this.btnDatTour.Click += new System.EventHandler(this.btnDatTour_Click);
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(275, 22);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 43);
            this.btnDong.TabIndex = 7;
            this.btnDong.TabStop = false;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên Tour";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTour.Location = new System.Drawing.Point(49, 50);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.ReadOnly = true;
            this.txtMaTour.Size = new System.Drawing.Size(100, 28);
            this.txtMaTour.TabIndex = 57;
            this.txtMaTour.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Tour";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(573, 38);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(155, 43);
            this.btnTimKiem.TabIndex = 59;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Text = "Lọc tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenTour
            // 
            this.txtTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTour.Location = new System.Drawing.Point(181, 50);
            this.txtTenTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(223, 28);
            this.txtTenTour.TabIndex = 52;
            // 
            // dgvDatTour
            // 
            this.dgvDatTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTour,
            this.colTen,
            this.colLichTrinh,
            this.colGia,
            this.colMoTa,
            this.colTrangThai});
            this.dgvDatTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatTour.Location = new System.Drawing.Point(0, 98);
            this.dgvDatTour.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatTour.Name = "dgvDatTour";
            this.dgvDatTour.RowHeadersWidth = 51;
            this.dgvDatTour.Size = new System.Drawing.Size(1673, 804);
            this.dgvDatTour.TabIndex = 58;
            this.dgvDatTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatTour_CellClick);
            this.dgvDatTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatTour_CellContentClick);
            // 
            // colMaTour
            // 
            this.colMaTour.HeaderText = "Mã Tour";
            this.colMaTour.MinimumWidth = 6;
            this.colMaTour.Name = "colMaTour";
            this.colMaTour.Width = 80;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên Tour";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.Width = 200;
            // 
            // colLichTrinh
            // 
            this.colLichTrinh.HeaderText = "Lịch Trình";
            this.colLichTrinh.MinimumWidth = 6;
            this.colLichTrinh.Name = "colLichTrinh";
            this.colLichTrinh.Width = 250;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá Tiền";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.Width = 125;
            // 
            // colMoTa
            // 
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Width = 250;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 125;
            // 
            // txtNhapSoNguoi
            // 
            this.txtNhapSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSoNguoi.Location = new System.Drawing.Point(412, 50);
            this.txtNhapSoNguoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapSoNguoi.Name = "txtNhapSoNguoi";
            this.txtNhapSoNguoi.Size = new System.Drawing.Size(153, 28);
            this.txtNhapSoNguoi.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nhập Số Người";
            // 
            // frmDatTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 902);
            this.Controls.Add(this.dgvDatTour);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatTour";
            this.Text = "Đặt Tour";
            this.Load += new System.EventHandler(this.frmQLTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDatTour;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.DataGridView dgvDatTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapSoNguoi;
    }
}