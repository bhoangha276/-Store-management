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
    public partial class frmCNNhanVien : Form
    {
        public frmCNNhanVien()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frm = new frmChamCong();
            frm.Show();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            frmTinhLuong frm = new frmTinhLuong();
            frm.Show();
        }
    }
}
