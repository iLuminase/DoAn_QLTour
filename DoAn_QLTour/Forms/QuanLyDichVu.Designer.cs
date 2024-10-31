namespace DuAnCuoiKy
{
    partial class frmQuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDichVu));
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(384, 11);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(726, 285);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(10, 292);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(122, 36);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Dịch Vụ";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(140, 292);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(111, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá Dịch Vụ";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = null;
            this.btnSua.Location = new System.Drawing.Point(262, 292);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(110, 36);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa Dịch Vụ";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mô Tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tình Trạng";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(108, 27);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(157, 27);
            this.txtTenDV.TabIndex = 12;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(108, 72);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(157, 27);
            this.txtGia.TabIndex = 12;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(108, 127);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(157, 27);
            this.txtMoTa.TabIndex = 12;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(108, 172);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(157, 27);
            this.txtTinhTrang.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 273);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnDatDV
            // 
            this.btnDatDV.BackColor = System.Drawing.Color.IndianRed;
            this.btnDatDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatDV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatDV.ForeColor = System.Drawing.Color.White;
            this.btnDatDV.Location = new System.Drawing.Point(12, 347);
            this.btnDatDV.Name = "btnDatDV";
            this.btnDatDV.Size = new System.Drawing.Size(120, 48);
            this.btnDatDV.TabIndex = 14;
            this.btnDatDV.Text = "Đặt dịch vụ";
            this.btnDatDV.UseVisualStyleBackColor = false;
            this.btnDatDV.Click += new System.EventHandler(this.btnDatDV_Click);
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 696);
            this.Controls.Add(this.btnDatDV);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyDichVu";
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.frmQuanLyDichVu_Load);
            this.Enter += new System.EventHandler(this.frmQuanLyDichVu_Enter);
            this.Leave += new System.EventHandler(this.frmQuanLyDichVu_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatDV;
    }
}

