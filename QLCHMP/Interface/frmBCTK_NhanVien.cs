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
    public partial class frmBCTK_NhanVien : Form
    {
        public frmBCTK_NhanVien()
        {
            InitializeComponent();
        }

        private void frmBCTK_NhanVien_Load(object sender, EventArgs e)
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";
            try
            {
                String sql = "select HoaDon.MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, SUM(TongTien) DoanhThu from NhanVien, HoaDon where NhanVien.MaNV = HoaDon.MaNV group by HoaDon.MaNV, TenNV, GioiTinh, NgaySinh, DiaChi";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "NhanVien");

                dgvNhanVien.DataSource = rs.Tables["NhanVien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_showData : " + ex.Message);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            chartNhanVien.Series["Doanh thu"].Points.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-68U13L4\SQLEXPRESS; Initial Catalog = QL_CHMP; Integrated Security = True");

            try
            {
                string sql = "select HoaDon.MaNV, NhanVien.TenNV, SUM(TongTien) DoanhThu from NhanVien, HoaDon where NhanVien.MaNV = HoaDon.MaNV group by HoaDon.MaNV, NhanVien.TenNV ";
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                cn.Open();
                da.Fill(dt);
                cn.Close();

                chartNhanVien.ChartAreas["ChartArea1"].AxisX.Title = "Tên nhân viên";
                chartNhanVien.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartNhanVien.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartNhanVien.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["TenNV"], dt.Rows[i]["DoanhThu"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_HienThi: " + ex.Message);
            }
        }
    }
}
