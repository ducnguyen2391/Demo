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
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình không", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            Application.Exit();
            
        }

        private void frmACEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình không", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }

        private void heThongTSMI_Click(object sender, EventArgs e)
        {

        }

        private void khachHangTSMI_Click(object sender, EventArgs e)
        {
            Khachhang.US_KhachHangList uS_KhachHang = new Khachhang.US_KhachHangList();

            TabPage newtab = new TabPage() { Text = "Khách hàng" };

            newtab.Controls.Add(uS_KhachHang);

            tabBanLamViec.Controls.Add(newtab);

    

            



        }

        private void DanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khachhang.US_KhachHangList uS_KhachHangList = new Khachhang.US_KhachHangList();

            //uS_KhachHangList.Show();

        }

        private void InvoicemuaHangTSMI_Click(object sender, EventArgs e)
        {
            Muahang.US_MuahangList uS_MuahangList = new Muahang.US_MuahangList();

            TabPage newtabmuahang = new TabPage() { Text = "Mua hàng" };

            newtabmuahang.Controls.Add(uS_MuahangList);

            tabBanLamViec.Controls.Add(newtabmuahang);

           

        }

        private void nhaCungCapTSMI_Click(object sender, EventArgs e)
        {
            Nhacungcap.US_NCC uS_NCC = new Nhacungcap.US_NCC();

            TabPage Newtab = new TabPage() { Text = "Nhà cung cấp" };

            Newtab.Controls.Add(uS_NCC);

            tabBanLamViec.Controls.Add(Newtab);
        }

        private void nhanVienTSMI_Click(object sender, EventArgs e)
        {
            NhanVien.US_Nhanvien uS_Nhanvien = new NhanVien.US_Nhanvien();

            TabPage Newtab = new TabPage() { Text = "Nhân viên" };

            Newtab.Controls.Add(uS_Nhanvien);

            tabBanLamViec.Controls.Add(Newtab);
        }

        private void vatTuhangHoaTSMI_Click(object sender, EventArgs e)
        {
            VTHH.US_VTHH uS_VTHH = new VTHH.US_VTHH();

            TabPage newtabpage = new TabPage() { Text = "Danh sách vật tư hàng hoá" };

            newtabpage.Controls.Add(uS_VTHH);

            tabBanLamViec.Controls.Add(newtabpage);
            
            

        }

        private void KhoChonTSMI_Click(object sender, EventArgs e)
        {
            Kho.US_KHO uS_KHO = new Kho.US_KHO();

            TabPage newtabpage = new TabPage() { Text = "Danh sách kho" };

            newtabpage.Controls.Add(uS_KHO);

            tabBanLamViec.Controls.Add(newtabpage);
        }

        private void InvoicebanHangTSMI_Click(object sender, EventArgs e)
        {
            Banhang.US_BanhangList uS_BanhangList = new Banhang.US_BanhangList();

            TabPage newtabbanhang = new TabPage() { Text = "Bán hàng" };

            newtabbanhang.Controls.Add(uS_BanhangList);

            tabBanLamViec.Controls.Add(newtabbanhang);

        }
    }
}
