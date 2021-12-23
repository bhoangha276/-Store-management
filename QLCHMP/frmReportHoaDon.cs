using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMP
{
    public partial class frmReportHoaDon : Form
    {
        public frmReportHoaDon()
        {
            InitializeComponent();
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_CHMPDataSet.ChiTietHD' table. You can move, or remove it, as needed.
            this.ChiTietHDTableAdapter.Fill(this.QL_CHMPDataSet.ChiTietHD);

            this.reportViewer1.RefreshReport();
        }
    }
}
