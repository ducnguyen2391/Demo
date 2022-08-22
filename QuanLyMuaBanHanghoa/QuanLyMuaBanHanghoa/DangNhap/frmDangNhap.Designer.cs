namespace QuanLyMuaBanHanghoa.DangNhap
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
            this.groupBoxDangNhap = new System.Windows.Forms.GroupBox();
            this.cboxremember = new System.Windows.Forms.CheckBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_frmDN_Thoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDangNhap
            // 
            this.groupBoxDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDangNhap.Controls.Add(this.cboxremember);
            this.groupBoxDangNhap.Controls.Add(this.txtMatkhau);
            this.groupBoxDangNhap.Controls.Add(this.txtTaikhoan);
            this.groupBoxDangNhap.Controls.Add(this.label2);
            this.groupBoxDangNhap.Controls.Add(this.label1);
            this.groupBoxDangNhap.Controls.Add(this.btn_frmDN_Thoat);
            this.groupBoxDangNhap.Controls.Add(this.btnDangNhap);
            this.groupBoxDangNhap.Location = new System.Drawing.Point(48, 12);
            this.groupBoxDangNhap.Name = "groupBoxDangNhap";
            this.groupBoxDangNhap.Size = new System.Drawing.Size(398, 197);
            this.groupBoxDangNhap.TabIndex = 0;
            this.groupBoxDangNhap.TabStop = false;
            // 
            // cboxremember
            // 
            this.cboxremember.AutoSize = true;
            this.cboxremember.Location = new System.Drawing.Point(96, 110);
            this.cboxremember.Name = "cboxremember";
            this.cboxremember.Size = new System.Drawing.Size(93, 17);
            this.cboxremember.TabIndex = 3;
            this.cboxremember.Text = "Nhớ mật khẩu";
            this.cboxremember.UseVisualStyleBackColor = true;
            this.cboxremember.CheckedChanged += new System.EventHandler(this.cboxremember_CheckedChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(96, 65);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(208, 20);
            this.txtMatkhau.TabIndex = 2;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(96, 33);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(208, 20);
            this.txtTaikhoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btn_frmDN_Thoat
            // 
            this.btn_frmDN_Thoat.Location = new System.Drawing.Point(243, 151);
            this.btn_frmDN_Thoat.Name = "btn_frmDN_Thoat";
            this.btn_frmDN_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_frmDN_Thoat.TabIndex = 5;
            this.btn_frmDN_Thoat.Text = "Thoát";
            this.btn_frmDN_Thoat.UseVisualStyleBackColor = true;
            this.btn_frmDN_Thoat.Click += new System.EventHandler(this.btn_frmDN_Thoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(151, 151);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 271);
            this.Controls.Add(this.groupBoxDangNhap);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBoxDangNhap.ResumeLayout(false);
            this.groupBoxDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDangNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cboxremember;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_frmDN_Thoat;
        private System.Windows.Forms.Button btnDangNhap;
    }
}