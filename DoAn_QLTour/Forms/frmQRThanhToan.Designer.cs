namespace DoAn_QLTour.Forms
{
    partial class frmQRThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQRThanhToan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhanThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quý Khách Vui Lòng Thanh Toán";
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(280, 447);
            this.btnXacNhanThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(174, 37);
            this.btnXacNhanThanhToan.TabIndex = 2;
            this.btnXacNhanThanhToan.Text = "Xác Nhận Thanh Toán";
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = true;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnXacNhanThanhToan_Click_1);
            // 
            // frmQRThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 554);
            this.Controls.Add(this.btnXacNhanThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQRThanhToan";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "frmQRThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanThanhToan;
    }
}