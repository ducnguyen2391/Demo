using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanHanghoa.DangNhap
{
    public partial class frmDangNhap : Form
    {


        List<taikhoan> listtaikhoan = Nguoi_dung.DanhSachTaiKhoan.Loadtaikhoan.lsttaikhoan;
        

        bool kiemtradangnhap(string tentaikhoan, string matkhau)
        {
           for(int i =  0; i < listtaikhoan.Count; i++)
            {
                if(tentaikhoan == listtaikhoan[i].Tentaikhoan && matkhau == listtaikhoan[i].Matkhau)
                {
                    return true;
                }    
            }    
            return false;
        }  

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_frmDN_Thoat_Click(object sender, EventArgs e)
        {
            
            
                Application.Exit();
            
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (kiemtradangnhap(txtTaikhoan.Text, txtMatkhau.Text))
            {

                frmACEN login = new frmACEN();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ. Bạn vui lòng kiểm tra lại");

                txtTaikhoan.Focus();

                txtTaikhoan.Clear();

                txtMatkhau.Clear();
                return;
            }
            
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

          

        }

        


        private void cboxremember_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxremember.Checked == true)
            {
               
              
            }
            
        }
    }
}
