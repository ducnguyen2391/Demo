using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanHanghoa.Nhacungcap
{
    public partial class US_NCC : UserControl
    {
        public US_NCC()
        {
            InitializeComponent();
        }

        private void gridviewListNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridviewListNCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
