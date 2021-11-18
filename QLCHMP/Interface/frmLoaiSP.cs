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
    public partial class frmLoaiSP : Form
    {
        Connect conn = new Connect();

        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void setLock(bool e)
        {
            txtMaLoaiSP.Enabled = !e;
            txtTenLoaiSP.Enabled = !e;
        }

        private void clearText()
        {
            txtMaLoaiSP.Clear();
            txtTenLoaiSP.Clear();
        }

        private void showDataLoaiSP()
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";

            try
            {
                String sql = "select * from LoaiSP order by MaLoaiSP";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "LoaiSP");

                dgvLoaiSP.DataSource = rs.Tables["LoaiSP"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_dgvLoaiSP : " + ex.Message);
            }
        }

        private int checkDataLoaiSP()
        {
            String maloaisp = txtMaLoaiSP.Text;
            //String tenloaisp = txtTenLoaiSP.Text;


            String sql = "Select count(*) from LoaiSP where MaLoaiSP = @maloaisp";
            List<SqlParameter> data = new List<SqlParameter>();
            data.Add(new SqlParameter("@maloaisp", maloaisp));
            //data.Add(new SqlParameter("@tenloaisp", tenloaisp));

            int rs = conn.CountData(sql, data);
            return rs;
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            showDataLoaiSP();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMP;Integrated Security=True";
            String tenlsp = txtSearch.Text;
            try
            {
                String sql = "select * from LoaiSP where TenLoaiSP like '%'+ @tenlsp +'%' order by MaLoaiSP";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@tenlsp", tenlsp));
                da.Fill(rs, "Sanpham");

                dgvLoaiSP.DataSource = rs.Tables["Sanpham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmSP : " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String maloaisp = txtMaLoaiSP.Text;
                String tenloaisp = txtTenLoaiSP.Text;

                if (maloaisp == "" || tenloaisp == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else if (txtMaLoaiSP.Text.Length > 10)
                {
                    MessageBox.Show("Mã loại sản phẩm không quá 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (checkDataLoaiSP() == 1)
                {
                    MessageBox.Show("Mã loại sản phẩm đã tồn tại!");
                }
                else
                {

                    String sql = "insert into LoaiSP values (@maloaisp, @tenloaisp)";

                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@maloaisp", maloaisp));
                    data.Add(new SqlParameter("@tenloaisp", tenloaisp));

                    conn.UpdateData(sql, data);

                    MessageBox.Show("Thêm thành công!");
                    showDataLoaiSP();
                    clearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("errThem: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maloaisp = txtMaLoaiSP.Text;
            String tenloaisp = txtTenLoaiSP.Text;

            if (maloaisp == "" || tenloaisp == "")
            {
                MessageBox.Show("Vui lòng loại sản phẩm cần sửa và nhập đầy đủ!");
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
                        String sql = "Update LoaiSP set TenLoaiSP = @tenloaisp where MaLoaiSP = @maloaisp";

                        List<SqlParameter> data = new List<SqlParameter>();
                        data.Add(new SqlParameter("@tenloaisp", tenloaisp));
                        data.Add(new SqlParameter("@maloaisp", maloaisp));

                        conn.UpdateData(sql, data);

                        MessageBox.Show("Sửa thông tin thành công!");
                        showDataLoaiSP();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            setLock(true);
            //clearText();

            if (txtMaLoaiSP.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        String maloaisp = txtMaLoaiSP.Text;
                        String sql = "delete LoaiSP where MaLoaiSP = @maloaisp ";

                        List<SqlParameter> data = new List<SqlParameter>();
                        data.Add(new SqlParameter("@maloaisp", maloaisp));
                        conn.UpdateData(sql, data);

                        MessageBox.Show("Xóa loại sản phẩm thành công!");
                        showDataLoaiSP();
                        clearText();
                        setLock(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("errXoa : " + ex.Message);
                    }
                }

                else
                {
                    setLock(true);
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

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvLoaiSP.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaLoaiSP.Text = row.Cells[0].Value.ToString();
                txtTenLoaiSP.Text = row.Cells[1].Value.ToString();

                //Không cho phép sửa trường STT
                //txtMaLoaiSP.Enabled = false;
            }
        }
    }
}
