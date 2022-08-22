using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanHanghoa.Nguoi_dung
{
    public class DanhSachTaiKhoan

    {
        private static DanhSachTaiKhoan loadtaikhoan;

        public static DanhSachTaiKhoan Loadtaikhoan

        {
            get
            {
                if(loadtaikhoan == null)
                {
                    loadtaikhoan = new DanhSachTaiKhoan();
                } 
                return loadtaikhoan;
            }
            set => loadtaikhoan = value;
        }


         List<taikhoan> Lsttaikhoan;

        public List<taikhoan> lsttaikhoan
        {
            get => Lsttaikhoan;

            set => Lsttaikhoan = value;
        }
        DanhSachTaiKhoan()

        {
            Lsttaikhoan = new List<taikhoan>();

            Lsttaikhoan.Add(new taikhoan("Ducnguyen", "123456"));
        }

       
         



    }
}
