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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatDV
            // 
            this.dgvDatDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatDV.Location = new System.Drawing.Point(9, 2);
            this.dgvDatDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatDV.Name = "dgvDatDV";
            this.dgvDatDV.RowHeadersWidth = 51;
            this.dgvDatDV.RowTemplate.Height = 24;
            this.dgvDatDV.Size = new System.Drawing.Size(892, 280);
            this.dgvDatDV.TabIndex = 0;
            this.dgvDatDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatDV_CellClick);
            // 
            // btnDatDV
            // 
            this.btnDatDV.Location = new System.Drawing.Point(249, 98);
            this.btnDatDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatDV.Name = "btnDatDV";
            this.btnDatDV.Size = new System.Drawing.Size(63, 41);
            this.btnDatDV.TabIndex = 2;
            this.btnDatDV.Text = "Đặt";
            this.btnDatDV.UseVisualStyleBackColor = true;
            this.btnDatDV.Click += new System.EventHandler(this.btnDatDV_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(323, 31);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(92, 24);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Lượng";
            // 
            // txtDatTour
            // 
            this.txtDatTour.Location = new System.Drawing.Point(119, 29);
            this.txtDatTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatTour.Name = "txtDatTour";
            this.txtDatTour.Size = new System.Drawing.Size(92, 24);
            this.txtDatTour.TabIndex = 3;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(119, 68);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(92, 24);
            this.txtMaDV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Đặt Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Dịch Vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 97);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 39);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(466, 97);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 39);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnDatDV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDatTour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmDatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 675);
            this.Controls.Add(this.dgvDatDV);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Dịch Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}