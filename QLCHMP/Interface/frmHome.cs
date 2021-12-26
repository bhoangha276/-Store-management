using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMP.Interface
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNNhanVien(), sender);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNKhoHang(), sender);
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNBCTK(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNHoaDon(), sender);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNBanHang(), sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNDoiMatKhau(), sender);
        }

        private void BtnHoTro_Click(object sender, EventArgs e)
        {
            frmHoTro frm = new frmHoTro();
            frm.Show();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Restart();
        }

    }
}
