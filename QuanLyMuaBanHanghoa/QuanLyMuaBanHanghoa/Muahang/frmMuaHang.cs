using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanHanghoa.Muahang
{
    public partial class frmMuaHang : Form
    {
        public frmMuaHang()
        {
            InitializeComponent();
        }

        private void dataGridView_MH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView_MH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {
            
        }
    }
}
