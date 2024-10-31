namespace DuAnCuoiKy
{
    partial class frmDatDichVu
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
            this.dgvDatDV = new System.Windows.Forms.DataGridView();
            this.btnDatDV = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatTour = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatDV
            // 
            this.dgvDatDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatDV.Location = new System.Drawing.Point(12, 2);
            this.dgvDatDV.Name = "dgvDatDV";
            this.dgvDatDV.RowHeadersWidth = 51;
            this.dgvDatDV.RowTemplate.Height = 24;
            this.dgvDatDV.Size = new System.Drawing.Size(776, 221);
            this.dgvDatDV.TabIndex = 0;
            this.dgvDatDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatDV_CellClick);
            // 
            // btnDatDV
            // 
            this.btnDatDV.Location = new System.Drawing.Point(327, 335);
            this.btnDatDV.Name = "btnDatDV";
            this.btnDatDV.Size = new System.Drawing.Size(84, 50);
            this.btnDatDV.TabIndex = 2;
            this.btnDatDV.Text = "Đặt";
            this.btnDatDV.UseVisualStyleBackColor = true;
            this.btnDatDV.Click += new System.EventHandler(this.btnDatDV_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(413, 250);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Lượng";
            // 
            // txtDatTour
            // 
            this.txtDatTour.Location = new System.Drawing.Point(153, 250);
            this.txtDatTour.Name = "txtDatTour";
            this.txtDatTour.Size = new System.Drawing.Size(121, 22);
            this.txtDatTour.TabIndex = 3;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(153, 298);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(121, 22);
            this.txtMaDV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Đặt Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Dịch Vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(467, 334);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 48);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(616, 334);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 48);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmDatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.txtDatTour);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnDatDV);
            this.Controls.Add(this.dgvDatDV);
            this.Name = "frmDatDichVu";
            this.Text = "Đặt Dịch Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatDV;
        private System.Windows.Forms.Button btnDatDV;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatTour;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}