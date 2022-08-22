namespace QuanLyMuaBanHanghoa.Banhang
{
    partial class US_BanhangList
    {

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_BanhangList));
            this.panelctrkh = new System.Windows.Forms.Panel();
            this.USbtnXoa = new System.Windows.Forms.Button();
            this.USbtnSua = new System.Windows.Forms.Button();
            this.USbtnxem = new System.Windows.Forms.Button();
            this.USbtnthem = new System.Windows.Forms.Button();
            this.gridviewListBanhang = new System.Windows.Forms.DataGridView();
            this.Clngaychungtu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clngayhachtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clsochungtu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelctrkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListBanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelctrkh
            // 
            this.panelctrkh.Controls.Add(this.USbtnXoa);
            this.panelctrkh.Controls.Add(this.USbtnSua);
            this.panelctrkh.Controls.Add(this.USbtnxem);
            this.panelctrkh.Controls.Add(this.USbtnthem);
            this.panelctrkh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelctrkh.Location = new System.Drawing.Point(0, 0);
            this.panelctrkh.Name = "panelctrkh";
            this.panelctrkh.Size = new System.Drawing.Size(905, 47);
            this.panelctrkh.TabIndex = 0;
            // 
            // USbtnXoa
            // 
            this.USbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("USbtnXoa.Image")));
            this.USbtnXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.USbtnXoa.Location = new System.Drawing.Point(262, 14);
            this.USbtnXoa.Name = "USbtnXoa";
            this.USbtnXoa.Size = new System.Drawing.Size(75, 23);
            this.USbtnXoa.TabIndex = 0;
            this.USbtnXoa.Text = "Xóa";
            this.USbtnXoa.UseVisualStyleBackColor = true;
            // 
            // USbtnSua
            // 
            this.USbtnSua.Image = ((System.Drawing.Image)(resources.GetObject("USbtnSua.Image")));
            this.USbtnSua.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.USbtnSua.Location = new System.Drawing.Point(181, 14);
            this.USbtnSua.Name = "USbtnSua";
            this.USbtnSua.Size = new System.Drawing.Size(75, 23);
            this.USbtnSua.TabIndex = 0;
            this.USbtnSua.Text = "Sửa";
            this.USbtnSua.UseVisualStyleBackColor = true;
            // 
            // USbtnxem
            // 
            this.USbtnxem.Image = ((System.Drawing.Image)(resources.GetObject("USbtnxem.Image")));
            this.USbtnxem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.USbtnxem.Location = new System.Drawing.Point(100, 14);
            this.USbtnxem.Name = "USbtnxem";
            this.USbtnxem.Size = new System.Drawing.Size(75, 23);
            this.USbtnxem.TabIndex = 0;
            this.USbtnxem.Text = "Xem";
            this.USbtnxem.UseVisualStyleBackColor = true;
            // 
            // USbtnthem
            // 
            this.USbtnthem.Image = ((System.Drawing.Image)(resources.GetObject("USbtnthem.Image")));
            this.USbtnthem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.USbtnthem.Location = new System.Drawing.Point(19, 14);
            this.USbtnthem.Name = "USbtnthem";
            this.USbtnthem.Size = new System.Drawing.Size(75, 23);
            this.USbtnthem.TabIndex = 0;
            this.USbtnthem.Text = "Thêm";
            this.USbtnthem.UseVisualStyleBackColor = true;
            this.USbtnthem.Click += new System.EventHandler(this.USbtnthem_Click);
            // 
            // gridviewListBanhang
            // 
            this.gridviewListBanhang.ColumnHeadersHeight = 29;
            this.gridviewListBanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewListBanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clngaychungtu,
            this.Clngayhachtoan,
            this.Clsochungtu,
            this.Clkh,
            this.ClSdt,
            this.Cltongtien});
            this.gridviewListBanhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewListBanhang.Enabled = false;
            this.gridviewListBanhang.Location = new System.Drawing.Point(0, 47);
            this.gridviewListBanhang.Name = "gridviewListBanhang";
            this.gridviewListBanhang.RowHeadersWidth = 51;
            this.gridviewListBanhang.Size = new System.Drawing.Size(905, 469);
            this.gridviewListBanhang.TabIndex = 1;
            // 
            // Clngaychungtu
            // 
            this.Clngaychungtu.HeaderText = "Ngày chứng từ ";
            this.Clngaychungtu.MinimumWidth = 6;
            this.Clngaychungtu.Name = "Clngaychungtu";
            this.Clngaychungtu.Width = 200;
            // 
            // Clngayhachtoan
            // 
            this.Clngayhachtoan.HeaderText = "Ngày hạch toán";
            this.Clngayhachtoan.MinimumWidth = 6;
            this.Clngayhachtoan.Name = "Clngayhachtoan";
            this.Clngayhachtoan.Width = 200;
            // 
            // Clsochungtu
            // 
            this.Clsochungtu.HeaderText = "Số chứng từ";
            this.Clsochungtu.MinimumWidth = 6;
            this.Clsochungtu.Name = "Clsochungtu";
            this.Clsochungtu.Width = 200;
            // 
            // Clkh
            // 
            this.Clkh.HeaderText = "Khách hàng";
            this.Clkh.MinimumWidth = 6;
            this.Clkh.Name = "Clkh";
            this.Clkh.Width = 360;
            // 
            // ClSdt
            // 
            this.ClSdt.HeaderText = "Số hoá đơn";
            this.ClSdt.MinimumWidth = 6;
            this.ClSdt.Name = "ClSdt";
            this.ClSdt.Width = 200;
            // 
            // Cltongtien
            // 
            this.Cltongtien.HeaderText = "Tổng tiền";
            this.Cltongtien.MinimumWidth = 6;
            this.Cltongtien.Name = "Cltongtien";
            this.Cltongtien.Width = 360;
            // 
            // US_BanhangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridviewListBanhang);
            this.Controls.Add(this.panelctrkh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "US_BanhangList";
            this.Size = new System.Drawing.Size(905, 516);
            this.panelctrkh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListBanhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelctrkh;
        private System.Windows.Forms.DataGridView gridviewListBanhang;
        private System.Windows.Forms.Button USbtnXoa;
        private System.Windows.Forms.Button USbtnSua;
        private System.Windows.Forms.Button USbtnxem;
        private System.Windows.Forms.Button USbtnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaychungtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayhachtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSOchungtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSohoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLtongtienhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clngaychungtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clngayhachtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clsochungtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cltongtien;
    }
}
