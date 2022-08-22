using QuanLyMuaBanHanghoa.frmKhachhang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanHanghoa.Khachhang
{
    public partial class US_KhachHangList : UserControl
    {
        

        public US_KhachHangList()
        {
            InitializeComponent();
        }

        private void USbtnthem_Click(object sender, EventArgs e)
        {
            frmKhachHangAdd frmKhachang = new frmKhachhang.frmKhachHangAdd();

            frmKhachang.ShowDialog();

        }

        private void gridviewListKh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
