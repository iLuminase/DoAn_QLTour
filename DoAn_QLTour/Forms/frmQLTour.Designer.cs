namespace DoAn_QLTour.Forms
{
    partial class frmQLTour
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
            this.btnThemHoacSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.dtpNgayKT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpNgayBD);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTenTour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1605, 146);
            this.panel1.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThemHoacSua);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(329, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 63);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(114, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 35);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.TabStop = false;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThemHoacSua
            // 
            this.btnThemHoacSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHoacSua.Location = new System.Drawing.Point(22, 18);
            this.btnThemHoacSua.Name = "btnThemHoacSua";
            this.btnThemHoacSua.Size = new System.Drawing.Size(86, 35);
            this.btnThemHoacSua.TabIndex = 7;
            this.btnThemHoacSua.TabStop = false;
            this.btnThemHoacSua.Text = "Thêm/Sửa";
            this.btnThemHoacSua.UseVisualStyleBackColor = true;
            this.btnThemHoacSua.Click += new System.EventHandler(this.btnThemHoacSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(206, 18);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 35);
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
            this.label3.Location = new System.Drawing.Point(133, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên Tour";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTour.Location = new System.Drawing.Point(37, 41);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.ReadOnly = true;
            this.txtMaTour.Size = new System.Drawing.Size(76, 24);
            this.txtMaTour.TabIndex = 57;
            this.txtMaTour.TabStop = false;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(170, 106);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(110, 24);
            this.dtpNgayKT.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(36, 105);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(110, 24);
            this.dtpNgayBD.TabIndex = 56;
            this.dtpNgayBD.Value = new System.DateTime(2023, 2, 22, 0, 0, 0, 0);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(329, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 35);
            this.btnTimKiem.TabIndex = 59;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Text = "Lọc tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTour.Location = new System.Drawing.Point(136, 41);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(168, 24);
            this.txtTenTour.TabIndex = 52;
            // 
            // dgvTour
            // 
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTour,
            this.colTen,
            this.colLichTrinh,
            this.colGia,
            this.colMoTa,
            this.colNgayBD,
            this.colNgayKT,
            this.colTrangThai});
            this.dgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTour.Location = new System.Drawing.Point(0, 146);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.Size = new System.Drawing.Size(1605, 587);
            this.dgvTour.TabIndex = 58;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // colMaTour
            // 
            this.colMaTour.HeaderText = "Mã Tour";
            this.colMaTour.Name = "colMaTour";
            this.colMaTour.Width = 80;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên Tour";
            this.colTen.Name = "colTen";
            this.colTen.Width = 200;
            // 
            // colLichTrinh
            // 
            this.colLichTrinh.HeaderText = "Lịch Trình";
            this.colLichTrinh.Name = "colLichTrinh";
            this.colLichTrinh.Width = 250;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá Tiền";
            this.colGia.Name = "colGia";
            // 
            // colMoTa
            // 
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Width = 250;
            // 
            // colNgayBD
            // 
            this.colNgayBD.HeaderText = "Ngày Bắt Đầu";
            this.colNgayBD.Name = "colNgayBD";
            this.colNgayBD.Width = 110;
            // 
            // colNgayKT
            // 
            this.colNgayKT.HeaderText = "Ngày Kết Thúc";
            this.colNgayKT.Name = "colNgayKT";
            this.colNgayKT.Width = 110;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // frmQLTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 733);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.panel1);
            this.Name = "frmQLTour";
            this.Text = "Quản Lý Tour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemHoacSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLichTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}