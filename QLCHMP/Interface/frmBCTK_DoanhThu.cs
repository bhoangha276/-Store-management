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
    public partial class frmBCTK_DoanhThu : Form
    {
        public frmBCTK_DoanhThu()
        {
            InitializeComponent();
        }

        Connect conn = new Connect();

        private void SumRevenue()
        {
            int sc = dgvHoaDon.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());

            labelDoanhThu.Text = string.Format("{0:#,##0}", thanhtien);
        }

        private void showData()
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";

            try
            {
                String sql = "select * from HoaDon order by MaHD";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "HoaDon");

                dgvHoaDon.DataSource = rs.Tables["HoaDon"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_showData : " + ex.Message);
            }
        }

        private void frmBCTK_DoanhThu_Load(object sender, EventArgs e)
        {
            showData();
            SumRevenue();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";
            String start = dateTimePickerStart.Text;
            String end = dateTimePickerEnd.Text;
            try
            {
                String sql = "SELECT * FROM HoaDon WHERE NgayBan BETWEEN @start AND @end";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@start", start));
                da.SelectCommand.Parameters.Add(new SqlParameter("@end", end));

                da.Fill(rs, "HoaDon");

                dgvHoaDon.DataSource = rs.Tables["HoaDon"];
                SumRevenue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_Search : " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
            SumRevenue();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            frmReportDoanhThu frm = new frmReportDoanhThu();
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            chartDoanhThu.Series["Tổng doanh thu"].Points.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-68U13L4\SQLEXPRESS; Initial Catalog = QL_CHMP; Integrated Security = True");
            try
            {
                string sql = "";
                if(radioButtonNam.Checked == true)
                {
                    // Tính tổng doanh thu theo năm
                    sql = "Select YEAR(NgayBan) as TG, SUM(TongTien) as DoanhThu from HoaDon group by YEAR(NgayBan)";
                }
                else
                {
                    sql = "Select MONTH(NgayBan) as TG, SUM(TongTien) as DoanhThu from HoaDon group by MONTH(NgayBan)";
                }

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                cn.Open();
                da.Fill(dt);
                cn.Close();

                String gt = radioButtonNam.Checked ? "Năm" : "Tháng";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = gt;
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                for (int i=0; i<dt.Rows.Count; i++)
                {
                    chartDoanhThu.Series["Tổng doanh thu"].Points.AddXY(dt.Rows[i]["TG"], dt.Rows[i]["DoanhThu"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("err_HienThi: " + ex.Message);
            }
        }
    }
}
