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
    public partial class US_MuahangList : UserControl
    {
        public US_MuahangList()
        {
            InitializeComponent();
        }

        private void USbtnthem_Click(object sender, EventArgs e)
        {
            Muahang.frmMuaHang frmMuaHang = new Muahang.frmMuaHang();

            frmMuaHang.ShowDialog();    
        }
    }
}
