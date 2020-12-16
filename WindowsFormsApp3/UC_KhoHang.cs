using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UC_KhoHang : UserControl
    {
        public UC_KhoHang()
        {
            InitializeComponent();
        }

 

        private void btnThemMatHangMoi_Click(object sender, EventArgs e)
        {
            Form_ThemMoiSanPham tmsp = new Form_ThemMoiSanPham();
            tmsp.ShowDialog();
        }

        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            Form_DVT tdvt = new Form_DVT();
            tdvt.ShowDialog();
        }
    }
}
