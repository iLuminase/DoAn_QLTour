namespace DoAn_QLTour.Forms
{
    partial class QLDatCho
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
            this.dgvDatCho = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatCho
            // 
            this.dgvDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.SDT,
            this.Email,
            this.DiaChi,
            this.CMND});
            this.dgvDatCho.Location = new System.Drawing.Point(448, 22);
            this.dgvDatCho.Name = "dgvDatCho";
            this.dgvDatCho.RowHeadersWidth = 51;
            this.dgvDatCho.RowTemplate.Height = 24;
            this.dgvDatCho.Size = new System.Drawing.Size(806, 476);
            this.dgvDatCho.TabIndex = 0;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 557);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = null;
            this.btnSua.Location = new System.Drawing.Point(289, 491);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(64, 36);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(188, 491);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(64, 36);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(91, 491);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(64, 36);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(149, 422);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(204, 22);
            this.txtCMND.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(149, 339);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(215, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(149, 198);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(163, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(149, 131);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(215, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "DiaChi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "HoTen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(149, 67);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(163, 22);
            this.txtMaKH.TabIndex = 0;
            // 
            // QLDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatCho);
            this.Name = "QLDatCho";
            this.Text = "QLDatCho";
            this.Load += new System.EventHandler(this.QLDatCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}