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
    public partial class frmDoiMatKhau : Form
    {
        Connect conn = new Connect();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            txtTK.Clear();
            txtMKCu.Clear();
            txtMKMoi1.Clear();
            txtMKMoi2.Clear();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                String tk = txtTK.Text;
                String mkcu = txtMKCu.Text;
                String mkmoi1 = txtMKMoi1.Text;
                String mkmoi2 = txtMKMoi2.Text;


                if (tk == "" || mkcu == "" || mkmoi1 == "" || mkmoi2 == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else if (mkmoi1.Length < 3)
                {
                    MessageBox.Show("Mật khẩu ko ngắn quá 3 kí tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (mkmoi1 != mkmoi2)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp!");
                }
                else
                {

                    String sql = "Update DangNhap set MatKhau = @mkmoi1 where TaiKhoan = @tk and MatKhau = @mkcu";

                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@tk", tk));
                    data.Add(new SqlParameter("@mkcu", mkcu));
                    data.Add(new SqlParameter("@mkmoi1", mkmoi1));

                    conn.UpdateData(sql, data);

                    MessageBox.Show("Đổi mật khẩu thành công!");
                    clearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
