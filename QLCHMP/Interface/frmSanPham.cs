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
    public partial class frmSanPham : Form
    {
        Connect conn = new Connect();

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void setLock(bool e)
        {
            txtMaSP.Enabled = !e;
            cbbMaLSP.Enabled = !e;
            txtTenSP.Enabled = !e;
            txtSoLuong.Enabled = !e;
            txtGiaBan.Enabled = !e;
            txtGiaNhap.Enabled = !e;
            txtNhaCC.Enabled = !e;
        }

        private void clearText()
        {
            txtMaSP.Clear();
            cbbMaLSP.Refresh();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtGiaNhap.Clear();
            txtNhaCC.Clear();

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

                dgvSP.DataSource = rs.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_dgvSanPham : " + ex.Message);
            }
        }

        public void showcbb()
        {
            string sql = "select * from LoaiSP";
            DataSet rs = conn.GetData(sql, "LoaiSP", null);
            cbbMaLSP.DataSource = rs.Tables["LoaiSP"];
            cbbMaLSP.DisplayMember = "MaLoaiSP";
            cbbMaLSP.ValueMember = "MaLoaiSP";
        }

        private int checkDataSanPham()
        {
            String masp = txtMaSP.Text;
            //String tenloaisp = txtTenLoaiSP.Text;


            String sql = "Select count(*) from SanPham where MaSP = @masp";
            List<SqlParameter> data = new List<SqlParameter>();
            data.Add(new SqlParameter("@masp", masp));
            //data.Add(new SqlParameter("@tenloaisp", tenloaisp));

            int rs = conn.CountData(sql, data);
            return rs;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            showDataSanPham();
            showcbb();
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
                da.Fill(rs, "Sanpham");

                dgvSP.DataSource = rs.Tables["Sanpham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmSP : " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Enabled == false)
            {
                setLock(false);
                clearText();
            }
            else
            {
                try
                {
                    String masp = txtMaSP.Text;
                    String malsp = cbbMaLSP.Text;
                    String tensp = txtTenSP.Text;
                    String soluong = txtSoLuong.Text;
                    String giaban = txtGiaBan.Text;
                    String gianhap = txtGiaNhap.Text;
                    String nhacc = txtNhaCC.Text;

                    if (masp == "" || malsp == "" || tensp == "" || soluong == "" || giaban == "" || gianhap == "" || nhacc == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    }
                    else if (txtMaSP.Text.Length > 10)
                    {
                        MessageBox.Show("Mã sản phẩm không quá 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (checkDataSanPham() == 1)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại!");
                    }
                    else
                    {

                        String sql = "insert into SanPham values (@masp, @malsp, @tensp, @soluong, @giaban, @gianhap ,@nhacc)";

                        List<SqlParameter> data = new List<SqlParameter>();
                        data.Add(new SqlParameter("@masp", masp));
                        data.Add(new SqlParameter("@malsp", malsp));
                        data.Add(new SqlParameter("@tensp", tensp));
                        data.Add(new SqlParameter("@soluong", soluong));
                        data.Add(new SqlParameter("@giaban", giaban));
                        data.Add(new SqlParameter("@gianhap", gianhap));
                        data.Add(new SqlParameter("@nhacc", nhacc));


                        conn.UpdateData(sql, data);

                        MessageBox.Show("Thêm thành công!");
                        showDataSanPham();
                        clearText();
                        showcbb();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("errThem: " + ex.Message);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Enabled == false)
            {
                setLock(false);
                clearText();
            }
            else
            {
                String masp = txtMaSP.Text;
                String malsp = cbbMaLSP.Text;
                String tensp = txtTenSP.Text;
                String soluong = txtSoLuong.Text;
                String giaban = txtGiaBan.Text;
                String gianhap = txtGiaNhap.Text;
                String nhacc = txtNhaCC.Text;

                if (masp == "" || malsp == "" || tensp == "" || soluong == "" || giaban == "" || gianhap == "" || nhacc == "")
                {
                    MessageBox.Show("Vui lòng sản phẩm cần sửa và nhập đầy đủ!");
                }
                //else if (checkDataLoaiSP() == 1)
                //{
                //    MessageBox.Show("Thông tin loại sản phẩm bị trùng lặp!");
                //}
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            String sql = "Update SanPham set MaLoaiSP = @malsp, TenSP = @tensp, SoLuong = @soluong, GiaBan = @giaban, GiaNhap = @gianhap, NhaCungCap = @nhacc where MaSP= @masp";

                            List<SqlParameter> data = new List<SqlParameter>();
                            data.Add(new SqlParameter("@masp", masp));
                            data.Add(new SqlParameter("@malsp", malsp));
                            data.Add(new SqlParameter("@tensp", tensp));
                            data.Add(new SqlParameter("@soluong", soluong));
                            data.Add(new SqlParameter("@giaban", giaban));
                            data.Add(new SqlParameter("@gianhap", gianhap));
                            data.Add(new SqlParameter("@nhacc", nhacc));

                            conn.UpdateData(sql, data);

                            MessageBox.Show("Sửa thông tin thành công!");
                            showDataSanPham();
                            clearText();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("errSua :" + ex.Message);
                        }
                    }

                    else
                        return;

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //setLockSwitch(false);
            setLock(true);

            //clearText();

            if (txtMaSP.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        String masp = txtMaSP.Text;
                        String sql = "delete SanPham where MaSP = @masp ";

                        List<SqlParameter> data = new List<SqlParameter>();
                        data.Add(new SqlParameter("@masp", masp));
                        conn.UpdateData(sql, data);

                        MessageBox.Show("Xóa sản phẩm thành công!");
                        showDataSanPham();
                        clearText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("errXoa : " + ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn hủy làm mới thao tác?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clearText();
                //setButton(true);
            }

            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSP.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells[0].Value.ToString();
                cbbMaLSP.Text = row.Cells[1].Value.ToString();
                txtTenSP.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGiaBan.Text = row.Cells[4].Value.ToString();
                txtGiaNhap.Text = row.Cells[5].Value.ToString();
                txtNhaCC.Text = row.Cells[6].Value.ToString();

                //txtMaSP.Enabled = false;
            }
        }
    }
}
