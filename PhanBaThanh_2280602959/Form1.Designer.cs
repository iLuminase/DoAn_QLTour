namespace PhanBaThanh_2280602959
{
    partial class Form1
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
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayPhanHoi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(433, 280);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(168, 22);
            this.txtMaTour.TabIndex = 15;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(166, 318);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(129, 22);
            this.txtNoiDung.TabIndex = 13;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(166, 283);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(129, 22);
            this.txtMaKH.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nội Dung Yêu Cầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cyan;
            this.btnSua.Location = new System.Drawing.Point(433, 384);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 45);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa Yêu Cầu";
            this.btnSua.UseVisualStyleBackColor = false;
          
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Cyan;
            this.btnXoa.Location = new System.Drawing.Point(244, 384);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 45);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa Yêu Cầu";
            this.btnXoa.UseVisualStyleBackColor = false;
            
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Cyan;
            this.btnThem.Location = new System.Drawing.Point(53, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 45);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Yêu Cầu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(12, 22);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(818, 228);
            this.dgvDV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày Phản Hồi";
            // 
            // dtpNgayPhanHoi
            // 
            this.dtpNgayPhanHoi.Location = new System.Drawing.Point(432, 319);
            this.dtpNgayPhanHoi.Name = "dtpNgayPhanHoi";
            this.dtpNgayPhanHoi.Size = new System.Drawing.Size(169, 22);
            this.dtpNgayPhanHoi.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.dtpNgayPhanHoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaTour);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayPhanHoi;
    }
}

