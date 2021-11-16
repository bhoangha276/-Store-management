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

        private void ThongTinNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void ChamCongNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChamCong frm = new frmChamCong();
            frm.Show();
        }

        private void TinhLuongNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinhLuong frm = new frmTinhLuong();
            frm.Show();
        }

        private void LoaiSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            frm.Show();
        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
        }

        private void bctkSanPhamHotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCTK_SanPhamHot frm = new frmBCTK_SanPhamHot();
            frm.Show();
        }

        private void bctkdoanhthuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCTK_DoanhThu frm = new frmBCTK_DoanhThu();
            frm.Show();
        }

        private void bctkTongChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCTK_TongChi frm = new frmBCTK_TongChi();
            frm.Show();
        }

        private void bctkNhanVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBCTK_NhanVien frm = new frmBCTK_NhanVien();
            frm.Show();
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.Show();
        }

        private void BanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Restart();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void HoTroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoTro frm = new frmHoTro();
            frm.Show();
        }
    }
}
