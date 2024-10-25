namespace DoAn_QLTour.Forms
{
    partial class frmDangNhap
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
            this.materialButtonDangKy = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMaskedTextBoxEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBoxPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButtonDangNhap = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButtonDangKy
            // 
            this.materialButtonDangKy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDangKy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDangKy.Depth = 0;
            this.materialButtonDangKy.HighEmphasis = true;
            this.materialButtonDangKy.Icon = null;
            this.materialButtonDangKy.Location = new System.Drawing.Point(245, 361);
            this.materialButtonDangKy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDangKy.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDangKy.Name = "materialButtonDangKy";
            this.materialButtonDangKy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDangKy.Size = new System.Drawing.Size(83, 36);
            this.materialButtonDangKy.TabIndex = 2;
            this.materialButtonDangKy.Text = "Đăng Ký";
            this.materialButtonDangKy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDangKy.UseAccentColor = false;
            this.materialButtonDangKy.UseVisualStyleBackColor = true;
            this.materialButtonDangKy.Click += new System.EventHandler(this.materialButtonDangKy_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(159, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Đăng Nhập";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 140);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Email: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 250);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Password: ";
            // 
            // materialMaskedTextBoxEmail
            // 
            this.materialMaskedTextBoxEmail.AllowPromptAsInput = true;
            this.materialMaskedTextBoxEmail.AnimateReadOnly = false;
            this.materialMaskedTextBoxEmail.AsciiOnly = false;
            this.materialMaskedTextBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxEmail.BeepOnError = false;
            this.materialMaskedTextBoxEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxEmail.Depth = 0;
            this.materialMaskedTextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxEmail.HidePromptOnLeave = false;
            this.materialMaskedTextBoxEmail.HideSelection = true;
            this.materialMaskedTextBoxEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxEmail.LeadingIcon = null;
            this.materialMaskedTextBoxEmail.Location = new System.Drawing.Point(110, 140);
            this.materialMaskedTextBoxEmail.Mask = "";
            this.materialMaskedTextBoxEmail.MaxLength = 32767;
            this.materialMaskedTextBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxEmail.Name = "materialMaskedTextBoxEmail";
            this.materialMaskedTextBoxEmail.PasswordChar = '\0';
            this.materialMaskedTextBoxEmail.PrefixSuffixText = null;
            this.materialMaskedTextBoxEmail.PromptChar = '_';
            this.materialMaskedTextBoxEmail.ReadOnly = false;
            this.materialMaskedTextBoxEmail.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxEmail.ResetOnPrompt = true;
            this.materialMaskedTextBoxEmail.ResetOnSpace = true;
            this.materialMaskedTextBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxEmail.SelectedText = "";
            this.materialMaskedTextBoxEmail.SelectionLength = 0;
            this.materialMaskedTextBoxEmail.SelectionStart = 0;
            this.materialMaskedTextBoxEmail.ShortcutsEnabled = true;
            this.materialMaskedTextBoxEmail.Size = new System.Drawing.Size(218, 48);
            this.materialMaskedTextBoxEmail.SkipLiterals = true;
            this.materialMaskedTextBoxEmail.TabIndex = 6;
            this.materialMaskedTextBoxEmail.TabStop = false;
            this.materialMaskedTextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxEmail.TrailingIcon = null;
            this.materialMaskedTextBoxEmail.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxEmail.ValidatingType = null;
            // 
            // materialMaskedTextBoxPassword
            // 
            this.materialMaskedTextBoxPassword.AllowPromptAsInput = true;
            this.materialMaskedTextBoxPassword.AnimateReadOnly = false;
            this.materialMaskedTextBoxPassword.AsciiOnly = false;
            this.materialMaskedTextBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxPassword.BeepOnError = false;
            this.materialMaskedTextBoxPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxPassword.Depth = 0;
            this.materialMaskedTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxPassword.HidePromptOnLeave = false;
            this.materialMaskedTextBoxPassword.HideSelection = true;
            this.materialMaskedTextBoxPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxPassword.LeadingIcon = null;
            this.materialMaskedTextBoxPassword.Location = new System.Drawing.Point(110, 250);
            this.materialMaskedTextBoxPassword.Mask = "";
            this.materialMaskedTextBoxPassword.MaxLength = 32767;
            this.materialMaskedTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxPassword.Name = "materialMaskedTextBoxPassword";
            this.materialMaskedTextBoxPassword.PasswordChar = '\0';
            this.materialMaskedTextBoxPassword.PrefixSuffixText = null;
            this.materialMaskedTextBoxPassword.PromptChar = '_';
            this.materialMaskedTextBoxPassword.ReadOnly = false;
            this.materialMaskedTextBoxPassword.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxPassword.ResetOnPrompt = true;
            this.materialMaskedTextBoxPassword.ResetOnSpace = true;
            this.materialMaskedTextBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxPassword.SelectedText = "";
            this.materialMaskedTextBoxPassword.SelectionLength = 0;
            this.materialMaskedTextBoxPassword.SelectionStart = 0;
            this.materialMaskedTextBoxPassword.ShortcutsEnabled = true;
            this.materialMaskedTextBoxPassword.Size = new System.Drawing.Size(218, 48);
            this.materialMaskedTextBoxPassword.SkipLiterals = true;
            this.materialMaskedTextBoxPassword.TabIndex = 7;
            this.materialMaskedTextBoxPassword.TabStop = false;
            this.materialMaskedTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxPassword.TrailingIcon = null;
            this.materialMaskedTextBoxPassword.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxPassword.ValidatingType = null;
            // 
            // materialButtonDangNhap
            // 
            this.materialButtonDangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDangNhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDangNhap.Depth = 0;
            this.materialButtonDangNhap.HighEmphasis = true;
            this.materialButtonDangNhap.Icon = null;
            this.materialButtonDangNhap.Location = new System.Drawing.Point(110, 361);
            this.materialButtonDangNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDangNhap.Name = "materialButtonDangNhap";
            this.materialButtonDangNhap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDangNhap.Size = new System.Drawing.Size(105, 36);
            this.materialButtonDangNhap.TabIndex = 8;
            this.materialButtonDangNhap.Text = "Đăng Nhập";
            this.materialButtonDangNhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDangNhap.UseAccentColor = false;
            this.materialButtonDangNhap.UseVisualStyleBackColor = true;
            this.materialButtonDangNhap.Click += new System.EventHandler(this.materialButtonDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 435);
            this.Controls.Add(this.materialButtonDangNhap);
            this.Controls.Add(this.materialMaskedTextBoxPassword);
            this.Controls.Add(this.materialMaskedTextBoxEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButtonDangKy);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonDangKy;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxPassword;
        private MaterialSkin.Controls.MaterialButton materialButtonDangNhap;
    }
}