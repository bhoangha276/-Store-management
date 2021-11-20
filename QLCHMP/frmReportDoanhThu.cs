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
    public partial class frmReportDoanhThu : Form
    {
        public frmReportDoanhThu()
        {
            InitializeComponent();
        }

        private void frmReportDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_CHMPDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.QL_CHMPDataSet.HoaDon);

            this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //this.HoaDonTableAdapter.Fill(this.QL_CHMPDataSet.HoaDon, txtSearch);
            //this.reportViewer1.RefreshReport();
        }
    }
}
