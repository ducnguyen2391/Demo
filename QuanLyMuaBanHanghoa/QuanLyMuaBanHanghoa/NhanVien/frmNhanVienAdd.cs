using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanHanghoa.NhanVien
{
    public partial class frmNhanVienAdd : Form
    {

        List<string> listgioitinh = new List<string>() { "Nam", "Nữ", "Không xác định" };

        public frmNhanVienAdd()
        {
            InitializeComponent();
        }

        private void frmNhanVienAdd_Load(object sender, EventArgs e)
        {
            cbogioitinh.DataSource = listgioitinh;
        }
    }
}
