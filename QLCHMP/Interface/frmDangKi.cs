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
using QLCHMP.Database;

namespace QLCHMP.Interface
{
    public partial class frmDangKi : Form
    {
        Connect conn = new Connect();

        public frmDangKi()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            txtdangnhap.Clear();
            txtmatkhau.Clear();
            txtnv.Clear();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            String taikhoan = txtdangnhap.Text;
            String matkhau = txtmatkhau.Text;
            String quyen = "Nhanvien";
            String manv = txtnv.Text;
            try
            {
                String sql = "insert into DangNhap values (@taikhoan, @matkhau, @quyen, @manv)";

                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@taikhoan", taikhoan));
                data.Add(new SqlParameter("@matkhau", matkhau));
                data.Add(new SqlParameter("@quyen", quyen));
                data.Add(new SqlParameter("@manv", manv));

                conn.UpdateData(sql, data);

                MessageBox.Show("Thêm thành công!");
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng kí thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("errThem: " + ex.Message);
            }
        }
    }
}
