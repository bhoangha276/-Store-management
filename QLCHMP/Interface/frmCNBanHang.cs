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
    public partial class frmCNBanHang : Form
    {
        public frmCNBanHang()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.Show();
        }
    }
}
