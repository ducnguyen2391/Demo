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

namespace QuanLyMuaBanHanghoa
{
    public partial class frmACEN : Form
    {
        public frmACEN()
        {
            InitializeComponent();
        }

        private void khachHangTSMI_Click(object sender, EventArgs e)
        {

           Khachhang.US_KhachHangList uS_KhachHangList = new Khachhang.US_KhachHangList();

            uS_KhachHangList.Show();




        }

        private void tabpLamViec_Click(object sender, EventArgs e)
        {

        }

        private void frmACEN_Load(object sender, EventArgs e)
        {
            
            DangNhap.frmDangNhap login = new DangNhap.frmDangNhap();
            
            login.ShowDialog();

           

           
            
        }

        private void ThoatTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
