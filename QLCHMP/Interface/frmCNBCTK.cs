using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMP.Interface
{
    public partial class frmCNBCTK : Form
    {
        public frmCNBCTK()
        {
            InitializeComponent();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmBCTK_DoanhThu frm = new frmBCTK_DoanhThu();
            frm.Show();
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            frmBCTK_TongChi frm = new frmBCTK_TongChi();
            frm.Show();
        }

        private void btnSPHot_Click(object sender, EventArgs e)
        {
            frmBCTK_SanPhamHot frm = new frmBCTK_SanPhamHot();
            frm.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmBCTK_NhanVien frm = new frmBCTK_NhanVien();
            frm.Show();
        }
    }
}
