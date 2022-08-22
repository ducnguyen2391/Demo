namespace QuanLyMuaBanHanghoa.Khachhang
{
    partial class US_KhachHangList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_KhachHangList));
            this.panelctrkh = new System.Windows.Forms.Panel();
            this.USbtnXoa = new System.Windows.Forms.Button();
            this.USbtnSua = new System.Windows.Forms.Button();
            this.USbtnxem = new System.Windows.Forms.Button();
            this.USbtnthem = new System.Windows.Forms.Button();
            this.gridviewListKh = new System.Windows.Forms.DataGridView();
            this.ClmaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CltenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelctrkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListKh)).BeginInit();
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
            // gridviewListKh
            // 
            this.gridviewListKh.ColumnHeadersHeight = 29;
            this.gridviewListKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewListKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmaKH,
            this.CltenKh,
            this.Cldiachi,
            this.ClSdt});
            this.gridviewListKh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewListKh.Enabled = false;
            this.gridviewListKh.Location = new System.Drawing.Point(0, 47);
            this.gridviewListKh.Name = "gridviewListKh";
            this.gridviewListKh.RowHeadersWidth = 51;
            this.gridviewListKh.Size = new System.Drawing.Size(905, 469);
            this.gridviewListKh.TabIndex = 1;
            this.gridviewListKh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewListKh_CellContentClick);
            // 
            // ClmaKH
            // 
            this.ClmaKH.HeaderText = "Mã Khách hàng";
            this.ClmaKH.MinimumWidth = 6;
            this.ClmaKH.Name = "ClmaKH";
            this.ClmaKH.Width = 200;
            // 
            // CltenKh
            // 
            this.CltenKh.HeaderText = "Tên khách hàng";
            this.CltenKh.MinimumWidth = 6;
            this.CltenKh.Name = "CltenKh";
            this.CltenKh.Width = 300;
            // 
            // Cldiachi
            // 
            this.Cldiachi.HeaderText = "Địa chỉ";
            this.Cldiachi.MinimumWidth = 6;
            this.Cldiachi.Name = "Cldiachi";
            this.Cldiachi.Width = 360;
            // 
            // ClSdt
            // 
            this.ClSdt.HeaderText = "Số điện thoại";
            this.ClSdt.MinimumWidth = 6;
            this.ClSdt.Name = "ClSdt";
            this.ClSdt.Width = 300;
            // 
            // US_KhachHangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridviewListKh);
            this.Controls.Add(this.panelctrkh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "US_KhachHangList";
            this.Size = new System.Drawing.Size(905, 516);
            this.panelctrkh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListKh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelctrkh;
        private System.Windows.Forms.DataGridView gridviewListKh;
        private System.Windows.Forms.Button USbtnXoa;
        private System.Windows.Forms.Button USbtnSua;
        private System.Windows.Forms.Button USbtnxem;
        private System.Windows.Forms.Button USbtnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CltenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSdt;
    }
}
