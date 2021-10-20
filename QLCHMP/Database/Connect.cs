using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMP.Database
{
    class Connect
    {
        String conn_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMyPham;Integrated Security=True";
        SqlConnection conn = null;

        public Connect()
        {
            conn = new SqlConnection(conn_str);
        }

        //Kiểm tra đăng nhập - Đếm số dữ liệu trả về kết quả khi truy vấn
        public int CountData(String sql, List<SqlParameter> data)
        {
            int rs = 0;
            // mở kết nối
            conn.Open();
            try
            {
                // tạo command thực hiện truy vấn
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (data != null)
                {
                    // tạo các biến trong sql 
                    cmd.Parameters.AddRange(data.ToArray());
                }
                // chọn kiểu thực hiện truy vấn
                rs = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err count data :" + ex.Message);
            }
            // đóng kết nối
            conn.Close();
            return rs;
        }

        //Lấy dữ liệu trong database ra ngoài sử dụng
        public DataSet GetData(String sql, String table_name, List<SqlParameter> data)
        {
            DataSet ds = new DataSet();
            try
            {
                // Dung SqlDataAdapter để k cần quan tâm việc đóng mở kết nối và Fill dữ liệu vào Dataset với cái table name
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                if (data != null)
                {
                    da.SelectCommand.Parameters.AddRange(data.ToArray());
                }
                da.Fill(ds, table_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err get data :" + ex.Message);
            }

            return ds;
        }

        //Cập nhập những thay đổi dữ liệu trong database
        public void UpdateData(String sql, List<SqlParameter> data)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (data != null)
                {
                    cmd.Parameters.AddRange(data.ToArray());
                }
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("err update data:" + ex.Message);
            }
        }
    }
}
