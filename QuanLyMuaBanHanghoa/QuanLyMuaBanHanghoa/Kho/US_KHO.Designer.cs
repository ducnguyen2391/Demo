namespace QuanLyMuaBanHanghoa.Kho
{
    partial class US_KHO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_KHO));
            this.panelctrkh = new System.Windows.Forms.Panel();
            this.USbtnXoa = new System.Windows.Forms.Button();
            this.USbtnSua = new System.Windows.Forms.Button();
            this.USbtnthem = new System.Windows.Forms.Button();
            this.gridviewListKHO = new System.Windows.Forms.DataGridView();
            this.ClmaKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CltenKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNgungtheodoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelctrkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListKHO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelctrkh
            // 
            this.panelctrkh.Controls.Add(this.USbtnXoa);
            this.panelctrkh.Controls.Add(this.USbtnSua);
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
            this.USbtnXoa.Location = new System.Drawing.Point(181, 14);
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
            this.USbtnSua.Location = new System.Drawing.Point(100, 14);
            this.USbtnSua.Name = "USbtnSua";
            this.USbtnSua.Size = new System.Drawing.Size(75, 23);
            this.USbtnSua.TabIndex = 0;
            this.USbtnSua.Text = "Sửa";
            this.USbtnSua.UseVisualStyleBackColor = true;
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
            // gridviewListKHO
            // 
            this.gridviewListKHO.ColumnHeadersHeight = 29;
            this.gridviewListKHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewListKHO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmaKHO,
            this.CltenKHO,
            this.ClNgungtheodoi});
            this.gridviewListKHO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewListKHO.Enabled = false;
            this.gridviewListKHO.Location = new System.Drawing.Point(0, 47);
            this.gridviewListKHO.Name = "gridviewListKHO";
            this.gridviewListKHO.RowHeadersWidth = 51;
            this.gridviewListKHO.Size = new System.Drawing.Size(905, 469);
            this.gridviewListKHO.TabIndex = 1;
            // 
            // ClmaKHO
            // 
            this.ClmaKHO.HeaderText = "Mã kho";
            this.ClmaKHO.MinimumWidth = 6;
            this.ClmaKHO.Name = "ClmaKHO";
            this.ClmaKHO.Width = 200;
            // 
            // CltenKHO
            // 
            this.CltenKHO.HeaderText = "Tên kho";
            this.CltenKHO.MinimumWidth = 6;
            this.CltenKHO.Name = "CltenKHO";
            this.CltenKHO.Width = 300;
            // 
            // ClNgungtheodoi
            // 
            this.ClNgungtheodoi.HeaderText = "Ngừng theo dõi";
            this.ClNgungtheodoi.MinimumWidth = 6;
            this.ClNgungtheodoi.Name = "ClNgungtheodoi";
            this.ClNgungtheodoi.Width = 360;
            // 
            // US_KHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridviewListKHO);
            this.Controls.Add(this.panelctrkh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "US_KHO";
            this.Size = new System.Drawing.Size(905, 516);
            this.panelctrkh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListKHO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelctrkh;
        private System.Windows.Forms.DataGridView gridviewListKHO;
        private System.Windows.Forms.Button USbtnXoa;
        private System.Windows.Forms.Button USbtnSua;
        private System.Windows.Forms.Button USbtnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmaKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CltenKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clngungtheodoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNgungtheodoi;
    }
}
