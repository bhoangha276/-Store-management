using QLCHMP.Database;
using QLCHMP.Interface;
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

namespace QLCHMP
{
    public partial class frmLogin : Form
    {
        Connect conn = new Connect();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += btnDangNhap_KeyUp;
        }

        private void btnDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tk = txtTK.Text;
            String mk = txtMK.Text;
            if (tk.Length == 0 || mk.Length == 0)
            {
                MessageBox.Show("Hãy nhập đủ tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "Select count(*) from DangNhap where TaiKhoan = @tk and MatKhau = @mk";
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@tk", tk));
                data.Add(new SqlParameter("@mk", mk));
                if (conn.CountData(sql, data) == 1)
                {
                    MessageBox.Show("Đăng Nhập thành công!");
                    DialogResult = DialogResult.OK;

                    this.Hide();
                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
                }

            }
    }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Show();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmDangKi dky = new frmDangKi();
            dky.Show();
        }
    }
}
