using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCHMP.Interface
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
    
        private void butdoimatkhau_Click(object sender, EventArgs e)
        {
           
        }

        private void butthoatdmk_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-LTAOR50; Initial Catalog = QLCHMP; Integrated Security = True");
            try
            {
                cn.Open();
                string sql = "insert into DangNhap(TaiKhoan, MatKhau, QuyenQL, MaNV) values('" + txtdangnhap.Text + "', '" + txtmatkhau.Text + "', '" + txtquanly.Text + "', '" + txtNv.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đăng ký thành công !");
                }
                else
                    MessageBox.Show("Đăng ký thất bại !");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }
    }
}
