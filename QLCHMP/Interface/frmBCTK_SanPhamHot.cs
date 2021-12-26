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
                String sql = "select MaSP, TenSP, SUM(SL) soluong, GiaBan, NhaCungCap from ChiTietHD, SanPham where SanPham.MaSP = ChiTietHD.MaSanPham group by SanPham.MaSP, SanPham.TenSP, GiaBan, NhaCungCap order by SUM(ChiTietHD.SL) DESC";

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

        private void btnInBC_Click(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            chartSanPham.Series["Sản phẩm"].Points.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-68U13L4\SQLEXPRESS; Initial Catalog = QL_CHMP; Integrated Security = True");

            try
            {
                string sql = "select MaSP, TenSP, SUM(SL) soluong from ChiTietHD, SanPham where SanPham.MaSP = ChiTietHD.MaSanPham group by SanPham.MaSP, SanPham.TenSP";
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                cn.Open();
                da.Fill(dt);
                cn.Close();

                chartSanPham.ChartAreas["ChartArea1"].AxisX.Title = "Tên sản phẩm";
                chartSanPham.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                chartSanPham.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartSanPham.Series["Sản phẩm"].Points.AddXY(dt.Rows[i]["TenSP"], dt.Rows[i]["soluong"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_HienThi: " + ex.Message);
            }
        }
    }
}
