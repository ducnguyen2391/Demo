namespace QuanLyMuaBanHanghoa.Nhacungcap
{
    partial class US_NCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_NCC));
            this.panelctrkh = new System.Windows.Forms.Panel();
            this.USbtnXoa = new System.Windows.Forms.Button();
            this.USbtnSua = new System.Windows.Forms.Button();
            this.USbtnxem = new System.Windows.Forms.Button();
            this.USbtnthem = new System.Windows.Forms.Button();
            this.gridviewListNCC = new System.Windows.Forms.DataGridView();
            this.ClmaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CltenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelctrkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListNCC)).BeginInit();
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
            // 
            // gridviewListNCC
            // 
            this.gridviewListNCC.ColumnHeadersHeight = 29;
            this.gridviewListNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewListNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmaNCC,
            this.CltenNCC,
            this.Cldiachi,
            this.ClSdt});
            this.gridviewListNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewListNCC.Enabled = false;
            this.gridviewListNCC.Location = new System.Drawing.Point(0, 47);
            this.gridviewListNCC.Name = "gridviewListNCC";
            this.gridviewListNCC.RowHeadersWidth = 51;
            this.gridviewListNCC.Size = new System.Drawing.Size(905, 469);
            this.gridviewListNCC.TabIndex = 1;
            this.gridviewListNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewListNCC_CellContentClick);
            // 
            // ClmaKH
            // 
            this.ClmaNCC.HeaderText = "Mã Nhà cung cấp";
            this.ClmaNCC.MinimumWidth = 6;
            this.ClmaNCC.Name = "ClmaKH";
            this.ClmaNCC.Width = 200;
            // 
            // CltenNCC
            // 
            this.CltenNCC.HeaderText = "Tên nhà cung cấp";
            this.CltenNCC.MinimumWidth = 6;
            this.CltenNCC.Name = "CltenNCC";
            this.CltenNCC.Width = 300;
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
            // US_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridviewListNCC);
            this.Controls.Add(this.panelctrkh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "US_NCC";
            this.Size = new System.Drawing.Size(905, 516);
            this.panelctrkh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelctrkh;
        private System.Windows.Forms.DataGridView gridviewListNCC;
        private System.Windows.Forms.Button USbtnXoa;
        private System.Windows.Forms.Button USbtnSua;
        private System.Windows.Forms.Button USbtnxem;
        private System.Windows.Forms.Button USbtnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CltenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSdt;
    }
}
