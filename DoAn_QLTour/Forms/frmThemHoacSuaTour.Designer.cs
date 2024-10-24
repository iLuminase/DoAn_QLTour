namespace DoAn_QLTour.Forms
{
    partial class frmThemHoacSuaTour
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLichTrinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnThemHoacSua = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTinhTrangTour = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnThemHoacSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 83);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbTinhTrangTour);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpNgayKT);
            this.panel2.Controls.Add(this.dtpNgayBD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGiaTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtLichTrinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTenTour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 501);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(158, 46);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(200, 27);
            this.txtTenTour.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lịch Trình";
            // 
            // txtLichTrinh
            // 
            this.txtLichTrinh.Location = new System.Drawing.Point(158, 88);
            this.txtLichTrinh.Multiline = true;
            this.txtLichTrinh.Name = "txtLichTrinh";
            this.txtLichTrinh.Size = new System.Drawing.Size(285, 94);
            this.txtLichTrinh.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(79, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(158, 197);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(100, 27);
            this.txtGiaTien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(91, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô Tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(158, 242);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(285, 154);
            this.txtMoTa.TabIndex = 1;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(158, 411);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayBD.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(41, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Bắt Đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(37, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Kết Thúc";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(158, 452);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayKT.TabIndex = 2;
            // 
            // btnThemHoacSua
            // 
            this.btnThemHoacSua.AutoSize = false;
            this.btnThemHoacSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemHoacSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemHoacSua.Depth = 0;
            this.btnThemHoacSua.HighEmphasis = true;
            this.btnThemHoacSua.Icon = null;
            this.btnThemHoacSua.Location = new System.Drawing.Point(169, 21);
            this.btnThemHoacSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemHoacSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemHoacSua.Name = "btnThemHoacSua";
            this.btnThemHoacSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemHoacSua.Size = new System.Drawing.Size(108, 36);
            this.btnThemHoacSua.TabIndex = 0;
            this.btnThemHoacSua.Text = "Thêm/Sửa";
            this.btnThemHoacSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemHoacSua.UseAccentColor = false;
            this.btnThemHoacSua.UseVisualStyleBackColor = true;
            this.btnThemHoacSua.Click += new System.EventHandler(this.btnThemHoacSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(375, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tình Trạng";
            // 
            // cbbTinhTrangTour
            // 
            this.cbbTinhTrangTour.FormattingEnabled = true;
            this.cbbTinhTrangTour.Location = new System.Drawing.Point(460, 450);
            this.cbbTinhTrangTour.Name = "cbbTinhTrangTour";
            this.cbbTinhTrangTour.Size = new System.Drawing.Size(121, 28);
            this.cbbTinhTrangTour.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 482);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(335, 21);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(108, 36);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmThemHoacSuaTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemHoacSuaTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemHoacSuaTour";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLichTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnThemHoacSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTinhTrangTour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
    }
}