namespace QuanLyMuaBanHanghoa.Kho
{
    partial class frmKhoAdd
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
            this.groupBox_Kho = new System.Windows.Forms.GroupBox();
            this.label_MaKho = new System.Windows.Forms.Label();
            this.label_TenKho = new System.Windows.Forms.Label();
            this.btnThoat_Kho = new System.Windows.Forms.Button();
            this.btnThem_Kho = new System.Windows.Forms.Button();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.cbox_Kho_Ngungtheodoi = new System.Windows.Forms.CheckBox();
            this.groupBox_Kho.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Kho
            // 
            this.groupBox_Kho.Controls.Add(this.cbox_Kho_Ngungtheodoi);
            this.groupBox_Kho.Controls.Add(this.txtMaKho);
            this.groupBox_Kho.Controls.Add(this.txtTenKho);
            this.groupBox_Kho.Controls.Add(this.btnThem_Kho);
            this.groupBox_Kho.Controls.Add(this.btnThoat_Kho);
            this.groupBox_Kho.Controls.Add(this.label_TenKho);
            this.groupBox_Kho.Controls.Add(this.label_MaKho);
            this.groupBox_Kho.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Kho.Name = "groupBox_Kho";
            this.groupBox_Kho.Size = new System.Drawing.Size(304, 166);
            this.groupBox_Kho.TabIndex = 0;
            this.groupBox_Kho.TabStop = false;
            this.groupBox_Kho.Text = "Thông tin chung";
            // 
            // label_MaKho
            // 
            this.label_MaKho.AutoSize = true;
            this.label_MaKho.Location = new System.Drawing.Point(6, 34);
            this.label_MaKho.Name = "label_MaKho";
            this.label_MaKho.Size = new System.Drawing.Size(47, 13);
            this.label_MaKho.TabIndex = 0;
            this.label_MaKho.Text = "Mã Kho:";
            // 
            // label_TenKho
            // 
            this.label_TenKho.AutoSize = true;
            this.label_TenKho.Location = new System.Drawing.Point(6, 71);
            this.label_TenKho.Name = "label_TenKho";
            this.label_TenKho.Size = new System.Drawing.Size(51, 13);
            this.label_TenKho.TabIndex = 0;
            this.label_TenKho.Text = "Tên Kho:";
            // 
            // btnThoat_Kho
            // 
            this.btnThoat_Kho.Location = new System.Drawing.Point(207, 128);
            this.btnThoat_Kho.Name = "btnThoat_Kho";
            this.btnThoat_Kho.Size = new System.Drawing.Size(75, 23);
            this.btnThoat_Kho.TabIndex = 1;
            this.btnThoat_Kho.Text = "Thoát";
            this.btnThoat_Kho.UseVisualStyleBackColor = true;
            // 
            // btnThem_Kho
            // 
            this.btnThem_Kho.Image = global::QuanLyMuaBanHanghoa.Properties.Resources._103;
            this.btnThem_Kho.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThem_Kho.Location = new System.Drawing.Point(126, 128);
            this.btnThem_Kho.Name = "btnThem_Kho";
            this.btnThem_Kho.Size = new System.Drawing.Size(75, 23);
            this.btnThem_Kho.TabIndex = 1;
            this.btnThem_Kho.Text = "Thêm";
            this.btnThem_Kho.UseVisualStyleBackColor = true;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(59, 64);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(223, 20);
            this.txtTenKho.TabIndex = 2;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(59, 31);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(223, 20);
            this.txtMaKho.TabIndex = 2;
            // 
            // cbox_Kho_Ngungtheodoi
            // 
            this.cbox_Kho_Ngungtheodoi.AutoSize = true;
            this.cbox_Kho_Ngungtheodoi.Location = new System.Drawing.Point(6, 134);
            this.cbox_Kho_Ngungtheodoi.Name = "cbox_Kho_Ngungtheodoi";
            this.cbox_Kho_Ngungtheodoi.Size = new System.Drawing.Size(99, 17);
            this.cbox_Kho_Ngungtheodoi.TabIndex = 3;
            this.cbox_Kho_Ngungtheodoi.Text = "Ngừng theo dõi";
            this.cbox_Kho_Ngungtheodoi.UseVisualStyleBackColor = true;
            // 
            // frmKhoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 193);
            this.Controls.Add(this.groupBox_Kho);
            this.Name = "frmKhoAdd";
            this.Text = "Thêm mới kho";
            this.groupBox_Kho.ResumeLayout(false);
            this.groupBox_Kho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Kho;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Button btnThem_Kho;
        private System.Windows.Forms.Button btnThoat_Kho;
        private System.Windows.Forms.Label label_TenKho;
        private System.Windows.Forms.Label label_MaKho;
        private System.Windows.Forms.CheckBox cbox_Kho_Ngungtheodoi;
    }
}