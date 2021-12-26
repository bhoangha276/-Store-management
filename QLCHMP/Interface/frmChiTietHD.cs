using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMP.Interface
{
    public partial class frmChiTietHD : Form
    {
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        private void showData()
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";

            try
            {
                String sql = "select * from ChiTietHD order by MaHD";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "ChiTietHD");

                dgvChiTietHD.DataSource = rs.Tables["ChiTietHD"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_showData : " + ex.Message);
            }
        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
