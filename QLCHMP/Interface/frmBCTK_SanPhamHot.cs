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
    public partial class frmBCTK_SanPhamHot : Form
    {
        public frmBCTK_SanPhamHot()
        {
            InitializeComponent();
        }

        private void frmBCTK_SanPhamHot_Load(object sender, EventArgs e)
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";
            try 
            { 
                String sql = "select MaSP, TenSP, SUM(SL) soluong from ChiTietHD, SanPham where SanPham.MaSP = ChiTietHD.MaSanPham group by SanPham.MaSP, SanPham.TenSP order by SUM(ChiTietHD.SL) DESC";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "HoaDon");

                dgvSanPham.DataSource = rs.Tables["HoaDon"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_showData : " + ex.Message);
            }
        }
    }
}
