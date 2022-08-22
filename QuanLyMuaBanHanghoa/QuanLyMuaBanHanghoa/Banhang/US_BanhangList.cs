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
    public partial class US_BanhangList : UserControl
    {
        public US_BanhangList()
        {
            InitializeComponent();
        }

        private void USbtnthem_Click(object sender, EventArgs e)
        {
            Banhang.frmBanhang frmBanhang = new Banhang.frmBanhang();

            frmBanhang.ShowDialog();
        }
    }
}
