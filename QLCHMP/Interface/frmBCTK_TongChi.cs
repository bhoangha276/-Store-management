using QLCHMP.Database;
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
    public partial class frmBCTK_TongChi : Form
    {
        public frmBCTK_TongChi()
        {
            InitializeComponent();
        }

        Connect conn = new Connect();

        private void SumRevenue()
        {
            int sc = dgvSanPham.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvSanPham.Rows[i].Cells[5].Value.ToString());

            labelDoanhThu.Text = string.Format("{0:#,##0}", thanhtien);
        }

        private void showData()
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";

            try
            {
                String sql = "select MaSP, MaLoaiSP, TenSP, SoLuong, NhaCungCap, TongChiTieu= SoLuong*(GiaBan-GiaNhap) from SanPham";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "SanPham");

                dgvSanPham.DataSource = rs.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_showData : " + ex.Message);
            }
        }

        private void frmBCTK_TongChi_Load(object sender, EventArgs e)
        {
            showData();
            SumRevenue();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
            SumRevenue();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            chartChiTieu.Series["Tổng chi tiêu"].Points.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-68U13L4\SQLEXPRESS; Initial Catalog = QL_CHMP; Integrated Security = True");
            try
            {
                string sql = "select TenSP, ChiTieu= SoLuong*(GiaBan-GiaNhap) from SanPham";

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                cn.Open();
                da.Fill(dt);
                cn.Close();

                chartChiTieu.ChartAreas["ChartArea1"].AxisX.Title = "Sản phẩm";
                chartChiTieu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartChiTieu.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartChiTieu.Series["Tổng chi tiêu"].Points.AddXY(dt.Rows[i]["TenSP"], dt.Rows[i]["ChiTieu"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_HienThi: " + ex.Message);
            }
        }

    }
}
