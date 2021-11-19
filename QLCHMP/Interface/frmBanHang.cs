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
    public partial class frmBanHang : Form
    {
        Connect conn = new Connect();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            txtMaSP.Clear();
            txtMaLSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtNhaCC.Clear();

            txtMaHD.Clear();
            dtNgayBan.Refresh();
            txtTenKH.Clear();
            //labelTongTien.Text = "0 VNĐ";

        }

        private void setLock1(bool e)
        {
            txtMaSP.Enabled = !e;
            txtMaLSP.Enabled = !e;
            txtTenSP.Enabled = !e;
            txtSoLuong.Enabled = !e;
            txtGiaBan.Enabled = !e;
            txtNhaCC.Enabled = !e;

        }

        private void setLock2(bool e)
        {
            txtMaHD.Enabled = !e;
            cbbMaNV.Enabled = !e;
            dtNgayBan.Enabled = !e;
            txtTenKH.Enabled = !e;
        }

        private void setButton(bool e)
        {
            btnThemSP.Enabled = !e;
            btnXoaSP.Enabled = !e;
        }

        private void showDataSanPham()
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";

            try
            {
                String sql = "select * from SanPham order by MaSP";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "SanPham");

                dgvSanPham.DataSource = rs.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmSP : " + ex.Message);
            }
        }

        private DataTable dataTable = new DataTable();



        public void showcbb()
        {
            string sql = "select * from NhanVien";
            DataSet rs = conn.GetData(sql, "NhanVien", null);
            cbbMaNV.DataSource = rs.Tables["NhanVien"];
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
        }

        private void TongTien()
        {
            //DecimalFormat x = new DecimalFormat("###,###,###,###");
            //int Tong = 0;
            //for (int i = 0; i < tblDoanhThu.getRowCount(); i++)
            //{
            //    Tong += Integer.parseInt(tableModel.getValueAt(i, 2).toString());
            //}
            //lbDoanhThu.setText("TỔNG DOANH THU: " + x.format(Tong) + " " + "VND");

            int sc = dgvChiTietHD.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvChiTietHD.Rows[i].Cells[3].Value.ToString());

            lbTongTien.Text = thanhtien.ToString();
            labelTongTien.Text = string.Format("{0:#,##0}", thanhtien);


        }

        private void ThemSP()
        {

            try
            {
                String sql = "Update SanPham set SoLuong = SoLuong - @slban where MaSP = @masp";
                String masp = txtMaSP.Text;
                String slban = numericUpDownSLBan.Text;



                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@masp", masp));
                data.Add(new SqlParameter("@slban", slban));
                conn.UpdateData(sql, data);

                showDataSanPham();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật số lượng lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("errSuaSL :" + ex.Message);
            }
        }

        private void GiamSP()
        {

            try
            {
                int rowSelected = Convert.ToInt32(dgvChiTietHD.CurrentRow.Index);

                int slban = int.Parse(dgvChiTietHD.Rows[rowSelected].Cells[2].Value.ToString());
                string masp = dgvChiTietHD.Rows[rowSelected].Cells[0].Value.ToString();


                String sql = "Update SanPham set SoLuong = SoLuong + @slban where MaSP = @masp";

                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@masp", masp));
                data.Add(new SqlParameter("@slban", slban));

                conn.UpdateData(sql, data);

                showDataSanPham();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật số lượng lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("errSuaSL :" + ex.Message);
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            showDataSanPham();
            showcbb();
            setLock1(true);
            setLock2(true);
            setButton(true);


            //String mahd = "HD01";
            //String sql = "select count(*) from ChiTietHD where MaHD = @mahd";
            //List<SqlParameter> data = new List<SqlParameter>();
            //data.Add(new SqlParameter("@mahd", mahd));

            //int rs = conn.CountData(sql, data);
            //labelTongTien.Text = rs.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";
            String tensp = txtSearch.Text;
            try
            {
                String sql = "select * from SanPham where TenSP like '%'+ @tensp +'%' order by MaSP";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@tensp", tensp));
                da.Fill(rs, "SanPham");

                dgvSanPham.DataSource = rs.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmSP : " + ex.Message);
            }
        }

        private void BtnThemHD_Click(object sender, EventArgs e)
        {
            setLock2(false);
            setButton(false);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập thông tin hóa đơn trước!");
            }
            else
            {
                int DonGia = 0;
                int soluong = Convert.ToInt32(numericUpDownSLBan.Text);
                int giaban = Convert.ToInt32(txtGiaBan.Text);
                DonGia = soluong * giaban;

                dgvChiTietHD.Rows.Add(txtMaSP.Text, txtTenSP.Text, numericUpDownSLBan.Text, DonGia);


                TongTien();

                ThemSP();

                try
                {
                    String mahd = txtMaHD.Text;
                    String masp = txtMaSP.Text;

                    String sql = "insert into ChiTietHD values (@mahd, @masp,  @soluong, @DonGia)";

                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@mahd", mahd));
                    data.Add(new SqlParameter("@masp", masp));
                    data.Add(new SqlParameter("@soluong", soluong));
                    data.Add(new SqlParameter("@DonGia", DonGia));

                    conn.UpdateData(sql, data);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("errThem: " + ex.Message);
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            GiamSP();
            foreach (DataGridViewRow item in this.dgvChiTietHD.SelectedRows)
            {
                dgvChiTietHD.Rows.RemoveAt(item.Index);
            }
            TongTien();
            try
            {
                String mahd = txtMaHD.Text;
                String masp = txtMaSP.Text;
                int soluong = Convert.ToInt32(numericUpDownSLBan.Text);
                int giaban = Convert.ToInt32(txtGiaBan.Text);
                int DonGia = soluong * giaban;

                String sql = "delete ChiTietHD where MaHD = @mahd and MaSanPham = @MaSP and SL= @soluong and DonGia = @DonGia";

                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@mahd", mahd));
                data.Add(new SqlParameter("@masp", masp));
                data.Add(new SqlParameter("@soluong", soluong));
                data.Add(new SqlParameter("@DonGia", DonGia));

                conn.UpdateData(sql, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("errThem: " + ex.Message);
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frmReportHoaDon frm = new frmReportHoaDon();
            frm.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Enabled == false)
            {
                setLock2(false);
                //clearText();
            }
            else if (txtMaHD.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hóa đơn!");
            }
            else if (lbTongTien.Text == "0 VNĐ")
            {
                MessageBox.Show("Chưa chọn sản phẩm!");
            }
            else
            {
                try
                {
                    String mahd = txtMaHD.Text;
                    String manv = cbbMaNV.Text;
                    DateTime ngayban = dtNgayBan.Value;
                    String tenkh = txtTenKH.Text;
                    String tongtien = lbTongTien.Text;

                    if (mahd == "" || tenkh == "" || tongtien == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    }
                    else
                    {

                        String sql = "insert into HoaDon values (@mahd, @manv, @ngayban, @tenkh, @tongtien)";
                        try
                        {
                            List<SqlParameter> data = new List<SqlParameter>();
                            data.Add(new SqlParameter("@mahd", mahd));
                            data.Add(new SqlParameter("@manv", manv));
                            data.Add(new SqlParameter("@ngayban", ngayban));
                            data.Add(new SqlParameter("@tenkh", tenkh));
                            data.Add(new SqlParameter("@tongtien", tongtien));

                            conn.UpdateData(sql, data);

                            MessageBox.Show("Thanh toán thành công!");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Err aaa:" + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thanh toán không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("errThem: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvSanPham.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtMaLSP.Text = row.Cells[1].Value.ToString();
                txtTenSP.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGiaBan.Text = row.Cells[4].Value.ToString();
                txtNhaCC.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
