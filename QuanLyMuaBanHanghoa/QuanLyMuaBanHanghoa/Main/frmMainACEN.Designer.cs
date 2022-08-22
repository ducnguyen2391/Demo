namespace QuanLyMuaBanHanghoa
{
    partial class frmACEN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmACEN));
            this.heThongTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tuyChonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCapTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.vatTuhangHoaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoChonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoicemuaHangTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoicebanHangTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TrangthaiStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabBanLamViec = new System.Windows.Forms.TabControl();
            this.tabpLamViec = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabBanLamViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // heThongTSMI
            // 
            this.heThongTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuyChonTSMI,
            this.ThoatTSMI});
            this.heThongTSMI.Image = ((System.Drawing.Image)(resources.GetObject("heThongTSMI.Image")));
            this.heThongTSMI.Name = "heThongTSMI";
            this.heThongTSMI.Size = new System.Drawing.Size(89, 24);
            this.heThongTSMI.Text = "&Hệ thống";
            this.heThongTSMI.Click += new System.EventHandler(this.heThongTSMI_Click);
            // 
            // tuyChonTSMI
            // 
            this.tuyChonTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem});
            this.tuyChonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("tuyChonTSMI.Image")));
            this.tuyChonTSMI.Name = "tuyChonTSMI";
            this.tuyChonTSMI.Size = new System.Drawing.Size(123, 22);
            this.tuyChonTSMI.Text = "Tùy chọn";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            // 
            // ThoatTSMI
            // 
            this.ThoatTSMI.Image = ((System.Drawing.Image)(resources.GetObject("ThoatTSMI.Image")));
            this.ThoatTSMI.Name = "ThoatTSMI";
            this.ThoatTSMI.Size = new System.Drawing.Size(123, 22);
            this.ThoatTSMI.Text = "Thoát";
            this.ThoatTSMI.Click += new System.EventHandler(this.ThoatTSMI_Click);
            // 
            // DanhMucToolStripMenuItem
            // 
            this.DanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachHangTSMI,
            this.nhaCungCapTSMI,
            this.nhanVienTSMI,
            this.vatTuhangHoaTSMI,
            this.KhoChonTSMI});
            this.DanhMucToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DanhMucToolStripMenuItem.Image")));
            this.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem";
            this.DanhMucToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.DanhMucToolStripMenuItem.Text = "&Danh mục";
            this.DanhMucToolStripMenuItem.Click += new System.EventHandler(this.DanhMucToolStripMenuItem_Click);
            // 
            // khachHangTSMI
            // 
            this.khachHangTSMI.Image = ((System.Drawing.Image)(resources.GetObject("khachHangTSMI.Image")));
            this.khachHangTSMI.Name = "khachHangTSMI";
            this.khachHangTSMI.Size = new System.Drawing.Size(184, 26);
            this.khachHangTSMI.Text = "Khách hàng";
            this.khachHangTSMI.Click += new System.EventHandler(this.khachHangTSMI_Click);
            // 
            // nhaCungCapTSMI
            // 
            this.nhaCungCapTSMI.Image = ((System.Drawing.Image)(resources.GetObject("nhaCungCapTSMI.Image")));
            this.nhaCungCapTSMI.Name = "nhaCungCapTSMI";
            this.nhaCungCapTSMI.Size = new System.Drawing.Size(184, 26);
            this.nhaCungCapTSMI.Text = "Nhà cung cấp";
            this.nhaCungCapTSMI.Click += new System.EventHandler(this.nhaCungCapTSMI_Click);
            // 
            // nhanVienTSMI
            // 
            this.nhanVienTSMI.Image = ((System.Drawing.Image)(resources.GetObject("nhanVienTSMI.Image")));
            this.nhanVienTSMI.Name = "nhanVienTSMI";
            this.nhanVienTSMI.Size = new System.Drawing.Size(184, 26);
            this.nhanVienTSMI.Text = "Nhân viên";
            this.nhanVienTSMI.Click += new System.EventHandler(this.nhanVienTSMI_Click);
            // 
            // vatTuhangHoaTSMI
            // 
            this.vatTuhangHoaTSMI.Image = ((System.Drawing.Image)(resources.GetObject("vatTuhangHoaTSMI.Image")));
            this.vatTuhangHoaTSMI.Name = "vatTuhangHoaTSMI";
            this.vatTuhangHoaTSMI.Size = new System.Drawing.Size(184, 26);
            this.vatTuhangHoaTSMI.Text = "Vật tư hàng hóa";
            this.vatTuhangHoaTSMI.Click += new System.EventHandler(this.vatTuhangHoaTSMI_Click);
            // 
            // KhoChonTSMI
            // 
            this.KhoChonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("KhoChonTSMI.Image")));
            this.KhoChonTSMI.Name = "KhoChonTSMI";
            this.KhoChonTSMI.Size = new System.Drawing.Size(184, 26);
            this.KhoChonTSMI.Text = "Kho";
            this.KhoChonTSMI.Click += new System.EventHandler(this.KhoChonTSMI_Click);
            // 
            // nghiepVuToolStripMenuItem
            // 
            this.nghiepVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InvoicemuaHangTSMI,
            this.InvoicebanHangTSMI});
            this.nghiepVuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nghiepVuToolStripMenuItem.Image")));
            this.nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            this.nghiepVuToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.nghiepVuToolStripMenuItem.Text = "&Nghiệp vụ";
            // 
            // InvoicemuaHangTSMI
            // 
            this.InvoicemuaHangTSMI.Image = ((System.Drawing.Image)(resources.GetObject("InvoicemuaHangTSMI.Image")));
            this.InvoicemuaHangTSMI.Name = "InvoicemuaHangTSMI";
            this.InvoicemuaHangTSMI.Size = new System.Drawing.Size(177, 22);
            this.InvoicemuaHangTSMI.Text = "Hóa đơn Mua hàng";
            this.InvoicemuaHangTSMI.Click += new System.EventHandler(this.InvoicemuaHangTSMI_Click);
            // 
            // InvoicebanHangTSMI
            // 
            this.InvoicebanHangTSMI.Image = ((System.Drawing.Image)(resources.GetObject("InvoicebanHangTSMI.Image")));
            this.InvoicebanHangTSMI.Name = "InvoicebanHangTSMI";
            this.InvoicebanHangTSMI.Size = new System.Drawing.Size(184, 26);
            this.InvoicebanHangTSMI.Text = "Hóa đơn Bán hàng";
            this.InvoicebanHangTSMI.Click += new System.EventHandler(this.InvoicebanHangTSMI_Click);
            // 
            // troGiupTSMI
            // 
            this.troGiupTSMI.BackColor = System.Drawing.SystemColors.Control;
            this.troGiupTSMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.troGiupTSMI.Image = ((System.Drawing.Image)(resources.GetObject("troGiupTSMI.Image")));
            this.troGiupTSMI.Name = "troGiupTSMI";
            this.troGiupTSMI.Size = new System.Drawing.Size(82, 24);
            this.troGiupTSMI.Text = "Trợ giúp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongTSMI,
            this.DanhMucToolStripMenuItem,
            this.nghiepVuToolStripMenuItem,
            this.troGiupTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrangthaiStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TrangthaiStatusLabel
            // 
            this.TrangthaiStatusLabel.ActiveLinkColor = System.Drawing.Color.Chartreuse;
            this.TrangthaiStatusLabel.Name = "TrangthaiStatusLabel";
            this.TrangthaiStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.TrangthaiStatusLabel.Text = "Trạng thái";
            this.TrangthaiStatusLabel.VisitedLinkColor = System.Drawing.Color.Lime;
            // 
            // tabBanLamViec
            // 
            this.tabBanLamViec.Controls.Add(this.tabpLamViec);
            this.tabBanLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBanLamViec.Location = new System.Drawing.Point(0, 28);
            this.tabBanLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.tabBanLamViec.Name = "tabBanLamViec";
            this.tabBanLamViec.SelectedIndex = 0;
            this.tabBanLamViec.Size = new System.Drawing.Size(800, 400);
            this.tabBanLamViec.TabIndex = 4;
            this.tabBanLamViec.Tag = "";
            // 
            // tabpLamViec
            // 
            this.tabpLamViec.AutoScroll = true;
            this.tabpLamViec.Location = new System.Drawing.Point(4, 22);
            this.tabpLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.tabpLamViec.Name = "tabpLamViec";
            this.tabpLamViec.Padding = new System.Windows.Forms.Padding(2);
            this.tabpLamViec.Size = new System.Drawing.Size(792, 374);
            this.tabpLamViec.TabIndex = 0;
            this.tabpLamViec.Text = "Bàn làm việc";
            this.tabpLamViec.UseVisualStyleBackColor = true;
            this.tabpLamViec.Click += new System.EventHandler(this.tabpLamViec_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmACEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabBanLamViec);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmACEN";
            this.Text = "ACEN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmACEN_FormClosing);
            this.Load += new System.EventHandler(this.frmACEN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabBanLamViec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem heThongTSMI;
        private System.Windows.Forms.ToolStripMenuItem tuyChonTSMI;
        private System.Windows.Forms.ToolStripMenuItem ThoatTSMI;
        private System.Windows.Forms.ToolStripMenuItem DanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangTSMI;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapTSMI;
        private System.Windows.Forms.ToolStripMenuItem nhanVienTSMI;
        private System.Windows.Forms.ToolStripMenuItem vatTuhangHoaTSMI;
        private System.Windows.Forms.ToolStripMenuItem KhoChonTSMI;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoicemuaHangTSMI;
        private System.Windows.Forms.ToolStripMenuItem InvoicebanHangTSMI;
        private System.Windows.Forms.ToolStripMenuItem troGiupTSMI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TrangthaiStatusLabel;
        private System.Windows.Forms.TabControl tabBanLamViec;
        private System.Windows.Forms.TabPage tabpLamViec;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

