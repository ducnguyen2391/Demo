using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanHanghoa
{
    public class taikhoan

    {
        private string tentaikhoan;

        public string Tentaikhoan
        {
            get => tentaikhoan;

            set => tentaikhoan = value;
        }

        private string matkhau;

        public string Matkhau
        {
            get => matkhau;

            set => matkhau = value;
        }


        public taikhoan(string tentaikhoan, string matkhau)

        {
           this.Tentaikhoan = tentaikhoan;
            
           this.Matkhau = matkhau;

        }
    }
}
