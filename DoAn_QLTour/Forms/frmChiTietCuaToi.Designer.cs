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
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLichTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1673, 98);
            this.panel1.TabIndex = 50;
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
            this.colTrangThai});
            this.dgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTour.Location = new System.Drawing.Point(0, 98);
            this.dgvTour.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.Size = new System.Drawing.Size(1673, 804);
            this.dgvTour.TabIndex = 58;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // 
            // 
            this.colMaTour.HeaderText = "Tên Tour";
            this.colMaTour.MinimumWidth = 6;
            this.colMaTour.Name = "TenTour";
            this.colMaTour.Width = 80;
            // 
            // 
            // 
            this.colTen.HeaderText = "Lịch Trình";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "LichTrinh";
            this.colTen.Width = 200;
            // 
            // 
            // 
            this.colLichTrinh.HeaderText = "Giá Tiền";
            this.colLichTrinh.MinimumWidth = 6;
            this.colLichTrinh.Name = "GiaTien";
            this.colLichTrinh.Width = 250;
            // 
            // 
            // 
            this.colGia.HeaderText = "Mô Tả";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "MoTa";
            this.colGia.Width = 125;
            // 
            // 
            // 
            this.colMoTa.HeaderText = "Số Tiền Cọc";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "SoTienCoc";
            this.colMoTa.Width = 250;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Tình Trạng";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "TinhTrang";
            this.colTrangThai.Width = 125;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}