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

        private void clearText()
        {
            txtdangnhap.Clear();
            txtmatkhau.Clear();
            txtnv.Clear();
            txtquanly.Clear();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-68U13L4\SQLEXPRESS; Initial Catalog = QL_CHMP; Integrated Security = True");
            try
            {
                cn.Open();
                string sql = "insert into DangNhap(TaiKhoan, MatKhau, QuyenQL, MaNV) values('" + txtdangnhap.Text + "', '" + txtmatkhau.Text + "', '" + txtquanly.Text + "', '" + txtnv.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đăng ký thành công !");
                    clearText();

                    frmDangKi frmDK = new frmDangKi();
                    frmDK.Dispose();
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
