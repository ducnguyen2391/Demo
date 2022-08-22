using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanHanghoa.Banhang
{
    public partial class frmBanhang : Form
    {
        public frmBanhang()
        {
            InitializeComponent();
        }

        private void dataGridView_BH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_BH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmBanhang_Load(object sender, EventArgs e)
        {
            
        }
    }
}
