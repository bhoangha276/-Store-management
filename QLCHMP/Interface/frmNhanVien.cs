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
    public partial class frmNhanVien : Form
    {
        Connect conn = new Connect();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            //txtMaNV.Clear();
            txtTenNV.Clear();
            cbbChucVu.Refresh();
            txtCMND.Clear();
            radioButtonNam.Checked = true;
            dtNgaySinh.Refresh();
            txtDiaChi.Clear();
            txtSDT.Clear();

        }

        private void setLock(bool e)
        {
            txtMaNV.Enabled = !e;
            txtTenNV.Enabled = !e;
            cbbChucVu.Enabled = !e;
            txtCMND.Enabled = !e;
            panelGioiTinh.Enabled = !e;
            dtNgaySinh.Enabled = !e;
            txtDiaChi.Enabled = !e;
            txtSDT.Enabled = !e;

        }

        private void showData()
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMyPham;Integrated Security=True";

            try
            {
                String sql = "select * from NhanVien order by MaNV";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "NhanVien");

                dgvNhanVien.DataSource = rs.Tables["NhanVien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmNV : " + ex.Message);
            }
        }

        private int checkData()
        {
            String manv = txtMaNV.Text;
            String tennv = txtTenNV.Text;
            String cv = cbbChucVu.Text;
            String cmnd = txtCMND.Text;
            String gt = radioButtonNam.Checked ? "Nam" : "Nữ";
            DateTime ns = dtNgaySinh.Value;
            String dc = txtDiaChi.Text;
            String sdt = txtSDT.Text;

            String sql = "Select count(*) from NhanVien where MaNV = @manv and TenNV = @tennv and ChucVu = @cv and CMND = @cmnd and GioiTinh = @gt and NgaySinh = @ns and DiaChi = @dc and SDT = @sdt";
            List<SqlParameter> data = new List<SqlParameter>();
            data.Add(new SqlParameter("@manv", manv));
            data.Add(new SqlParameter("@tennv", tennv));
            data.Add(new SqlParameter("@cv", cv));
            data.Add(new SqlParameter("@cmnd", cmnd));
            data.Add(new SqlParameter("@gt", gt));
            data.Add(new SqlParameter("@ns", ns));
            data.Add(new SqlParameter("@dc", dc));
            data.Add(new SqlParameter("@sdt", sdt));

            int rs = conn.CountData(sql, data);
            return rs;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            showData();
            clearText();
            setLock(true);
            //setButton(true);
            dgvNhanVien.Columns[5].DefaultCellStyle.Format = "Custom";
            dgvNhanVien.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String con_str = "Data Source = DESKTOP-68U13L4\\SQLEXPRESS;Initial Catalog=QL_CHMyPham;Integrated Security=True";
            String tennv = txtSearch.Text;
            try
            {
                String sql = "select * from NhanVien where TenNV like '%'+ @tennv +'%' order by MaNV";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@tennv", tennv));
                da.Fill(rs, "NhanVien");

                dgvNhanVien.DataSource = rs.Tables["NhanVien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmNV : " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Enabled == false)
            {
                setLock(false);
                clearText();
            }
            else
            {
                try
                {
                    String manv = txtMaNV.Text;
                    String tennv = txtTenNV.Text;
                    String cv = cbbChucVu.Text;
                    String cmnd = txtCMND.Text;
                    String gt = radioButtonNam.Checked ? "Nam" : "Nữ";
                    DateTime ns = dtNgaySinh.Value;
                    String dc = txtDiaChi.Text;
                    String sdt = txtSDT.Text;

                    if (manv == "" || tennv == "" || cv == "" || cmnd == "" || dc == "" || sdt == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    }
                    else if (txtMaNV.Text.Length > 10)
                    {
                        MessageBox.Show("Mã nhân viên không quá 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (checkData() == 1)
                    {
                        MessageBox.Show("Thông tin nhân viên bị trùng lặp!");
                    }
                    else
                    {

                        String sql = "insert into NhanVien values (@manv, @tennv, @cv, @cmnd, @gt, @ns, @dc, @sdt)";

                        List<SqlParameter> data = new List<SqlParameter>();
                        data.Add(new SqlParameter("@manv", manv));
                        data.Add(new SqlParameter("@tennv", tennv));
                        data.Add(new SqlParameter("@cv", cv));
                        data.Add(new SqlParameter("@cmnd", cmnd));
                        data.Add(new SqlParameter("@gt", gt));
                        data.Add(new SqlParameter("@ns", ns));
                        data.Add(new SqlParameter("@dc", dc));
                        data.Add(new SqlParameter("@sdt", sdt));

                        conn.UpdateData(sql, data);

                        MessageBox.Show("Thêm nhân viên thành công!");
                        showData();
                        clearText();
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
            if (txtMaNV.Enabled == true)
            {
                txtMaNV.Enabled = false;
                clearText();
            }
            else if (txtMaNV.Enabled == false && txtTenNV.Enabled == false)
            {
                setLock(false);
                clearText();
                txtMaNV.Enabled = false;
            }
            else
            {
                if (txtMaNV.Text.Length == 0 || txtTenNV.Text.Length == 0 || cbbChucVu.Text.Length == 0 || txtCMND.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa và nhập đầy đủ!");
                }
                else if (checkData() == 1)
                {
                    MessageBox.Show("Thông tin nhân viên bị trùng lặp!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            String sql = "Update NhanVien set TenNV = @TenNV, ChucVu = @ChucVu, CMND = @CMND, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT where MaNV = @MaNV";
                            String MaNV = txtMaNV.Text;
                            String TenNV = txtTenNV.Text;
                            String ChucVu = cbbChucVu.Text;
                            String CMND = txtCMND.Text;
                            String GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                            DateTime NgaySinh = dtNgaySinh.Value;
                            String DiaChi = txtDiaChi.Text;
                            String SDT = txtSDT.Text;



                            List<SqlParameter> data = new List<SqlParameter>();
                            data.Add(new SqlParameter("@MaNV", MaNV));
                            data.Add(new SqlParameter("@TenNV", TenNV));
                            data.Add(new SqlParameter("@ChucVu", ChucVu));
                            data.Add(new SqlParameter("@CMND", CMND));
                            data.Add(new SqlParameter("@GioiTinh", GioiTinh));
                            data.Add(new SqlParameter("@NgaySinh", NgaySinh));
                            data.Add(new SqlParameter("@DiaChi", DiaChi));
                            data.Add(new SqlParameter("@SDT", SDT));

                            conn.UpdateData(sql, data);

                            MessageBox.Show("Sửa thông tin thành công!");
                            showData();
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
            if (txtTenNV.Enabled == true)
            {
                setLock(true);
                clearText();
            }
            else
            {
                if (txtMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên hoặc nhập mã nhân viên cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {

                            String MaNV = txtMaNV.Text;
                            String sql = "delete NhanVien where MaNV = @MaNV ";

                            List<SqlParameter> data = new List<SqlParameter>();
                            data.Add(new SqlParameter("@MaNV", MaNV));
                            conn.UpdateData(sql, data);

                            MessageBox.Show("Xóa nhân viên thành công!");
                            showData();
                            clearText();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("errXoa : " + ex.Message);
                        }
                    }

                    else
                        return;
                }
            }
        }

        private void btnKLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0 || txtTenNV.Text.Length == 0 || cbbChucVu.Text.Length == 0 || txtCMND.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Chưa có gì thể làm mới!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn muốn hủy làm mới thao tác?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clearText();
                    setLock(false);
                    //setButton(true);
                }

                else
                    return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                cbbChucVu.Text = row.Cells[2].Value.ToString();
                txtCMND.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Nam")
                {
                    radioButtonNam.Checked = true;
                }
                else
                {
                    radioButtonNu.Checked = true;
                }
                dtNgaySinh.Text = DateTime.Now.ToShortDateString();
                dtNgaySinh.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();



                //Không cho phép sửa trường STT
                txtMaNV.Enabled = false;
            }
        }
    }
}
