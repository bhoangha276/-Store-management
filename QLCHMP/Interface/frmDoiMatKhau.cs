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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source =DESKTOP-LTAOR50; Initial Catalog = QLCHMP; Integrated Security = True");
        private void butdoimatkhau_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) from DangNhap where TaiKhoan = N'" + textBox1.Text + "' and MatKhau = N'" + txtmatkhaucu.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtmatkhaumoi.Text == txtnhaplaimatkhau.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update DangNhap set MatKhau = N'" + txtmatkhaumoi.Text + "' where TaiKhoan = N'" + textBox1.Text + "'and MatKhau = N'" + txtmatkhaucu.Text + "'", cn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(txtmatkhaumoi, "Bạn chưa điền mật khẩu!");
                    errorProvider1.SetError(txtnhaplaimatkhau, "Mật khẩu nhập lại chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Tên người dùng không đúng !");
                errorProvider1.SetError(txtmatkhaucu, "Mật khẩu cũ không đúng");
            }
        }

        private void butthoatdmk_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
