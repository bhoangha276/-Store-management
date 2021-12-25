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
    public partial class frmCNHoaDon : Form
    {
        public frmCNHoaDon()
        {
            InitializeComponent();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.Show();
        }
    }
}
