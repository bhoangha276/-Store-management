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
    public partial class frmCNKhoHang : Form
    {
        public frmCNKhoHang()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            frm.Show();
        }
    }
}
