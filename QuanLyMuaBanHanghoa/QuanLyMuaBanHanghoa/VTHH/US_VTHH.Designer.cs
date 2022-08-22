namespace QuanLyMuaBanHanghoa.VTHH
{
    partial class US_VTHH
    {
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
            this.panelctrkh = new System.Windows.Forms.Panel();
            this.USbtnXoa = new System.Windows.Forms.Button();
            this.USbtnSua = new System.Windows.Forms.Button();
            this.USbtnxem = new System.Windows.Forms.Button();
            this.USbtnthem = new System.Windows.Forms.Button();
            this.gridviewListVTHH = new System.Windows.Forms.DataGridView();
            this.ClmaVTHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CltenVTHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cldvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CltenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelctrkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListVTHH)).BeginInit();
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
            this.USbtnXoa.Location = new System.Drawing.Point(262, 14);
            this.USbtnXoa.Name = "USbtnXoa";
            this.USbtnXoa.Size = new System.Drawing.Size(75, 23);
            this.USbtnXoa.TabIndex = 0;
            this.USbtnXoa.Text = "Xóa";
            this.USbtnXoa.UseVisualStyleBackColor = true;
            // 
            // USbtnSua
            // 
            this.USbtnSua.Location = new System.Drawing.Point(181, 14);
            this.USbtnSua.Name = "USbtnSua";
            this.USbtnSua.Size = new System.Drawing.Size(75, 23);
            this.USbtnSua.TabIndex = 0;
            this.USbtnSua.Text = "Sửa";
            this.USbtnSua.UseVisualStyleBackColor = true;
            // 
            // USbtnxem
            // 
            this.USbtnxem.Location = new System.Drawing.Point(100, 14);
            this.USbtnxem.Name = "USbtnxem";
            this.USbtnxem.Size = new System.Drawing.Size(75, 23);
            this.USbtnxem.TabIndex = 0;
            this.USbtnxem.Text = "Xem";
            this.USbtnxem.UseVisualStyleBackColor = true;
            // 
            // USbtnthem
            // 
            this.USbtnthem.Location = new System.Drawing.Point(19, 14);
            this.USbtnthem.Name = "USbtnthem";
            this.USbtnthem.Size = new System.Drawing.Size(75, 23);
            this.USbtnthem.TabIndex = 0;
            this.USbtnthem.Text = "Thêm";
            this.USbtnthem.UseVisualStyleBackColor = true;
            this.USbtnthem.Click += new System.EventHandler(this.USbtnthem_Click);
            // 
            // gridviewListVTHH
            // 
            this.gridviewListVTHH.ColumnHeadersHeight = 29;
            this.gridviewListVTHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewListVTHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmaVTHH,
            this.CltenVTHH,
            this.Cldvt,
            this.ClSl,
            this.CltenNCC});
            this.gridviewListVTHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewListVTHH.Enabled = false;
            this.gridviewListVTHH.Location = new System.Drawing.Point(0, 47);
            this.gridviewListVTHH.Name = "gridviewListVTHH";
            this.gridviewListVTHH.RowHeadersWidth = 51;
            this.gridviewListVTHH.Size = new System.Drawing.Size(905, 469);
            this.gridviewListVTHH.TabIndex = 1;
            // 
            // ClmaVTHH
            // 
            this.ClmaVTHH.HeaderText = "Mã vật tư hàng hoá";
            this.ClmaVTHH.MinimumWidth = 6;
            this.ClmaVTHH.Name = "ClmaVTHH";
            this.ClmaVTHH.Width = 200;
            // 
            // CltenVTHH
            // 
            this.CltenVTHH.HeaderText = "Tên Vật tư hàng hoá";
            this.CltenVTHH.MinimumWidth = 6;
            this.CltenVTHH.Name = "CltenVTHH";
            this.CltenVTHH.Width = 300;
            // 
            // Cldvt
            // 
            this.Cldvt.HeaderText = "ĐVT";
            this.Cldvt.MinimumWidth = 6;
            this.Cldvt.Name = "Cldvt";
            // 
            // ClSl
            // 
            this.ClSl.HeaderText = "Số lượng";
            this.ClSl.MinimumWidth = 6;
            this.ClSl.Name = "ClSl";
            this.ClSl.Width = 300;
            // 
            // CltenNCC
            // 
            this.CltenNCC.HeaderText = "Tên nhà cung cấp";
            this.CltenNCC.MinimumWidth = 6;
            this.CltenNCC.Name = "CltenNCC";
            this.CltenNCC.Width = 360;
            // 
            // US_VTHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridviewListVTHH);
            this.Controls.Add(this.panelctrkh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "US_VTHH";
            this.Size = new System.Drawing.Size(905, 516);
            this.panelctrkh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListVTHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelctrkh;
        private System.Windows.Forms.DataGridView gridviewListVTHH;
        private System.Windows.Forms.Button USbtnXoa;
        private System.Windows.Forms.Button USbtnSua;
        private System.Windows.Forms.Button USbtnxem;
        private System.Windows.Forms.Button USbtnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmaVTHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CltenVTHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLtenNCC_VTHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cldvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CltenNCC;
    }
}

