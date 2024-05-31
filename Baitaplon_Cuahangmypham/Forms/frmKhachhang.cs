using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon_Cuahangmypham.Forms
{
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            //MessageBox.Show("Kết nối thành công");
            txtMaKH.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            load_datagrid();
        }
        DataTable tblKH;
        private void load_datagrid()
        {
            string sql;
            sql = "select * from tblKhachhang";
            tblKH = Class.Functions.GetDataToTable(sql);
            dgridKhachhang.DataSource = tblKH;
            dgridKhachhang.Columns[0].HeaderText = "Mã khách hàng ";
            dgridKhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgridKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgridKhachhang.Columns[3].HeaderText = "Điện thoại";
            dgridKhachhang.AllowUserToAddRows = false;
            dgridKhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridKhachhang_Click(object sender, EventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaKH.Text = dgridKhachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgridKhachhang.CurrentRow.Cells["Tenkhach"].Value.ToString();
            txtDiachi.Text = dgridKhachhang.CurrentRow.Cells["Diachi"].Value.ToString();
            mskdienthoai.Text = dgridKhachhang.CurrentRow.Cells["Dienthoai"].Value.ToString();
           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetvalue();
        }
        private void resetvalue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            mskdienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }

            sql = "select MaKH from tblKhachhang where MaKH = N'" + txtMaKH.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                txtMaKH.Text = "";
                return;
            }
            sql = "Insert into tblKhachhang(MaKH, Tenkhach, Diachi, Dienthoai) values (N'" + txtMaKH.Text.Trim() + "', N'" + txtTenKH.Text.Trim() + "', N'" +txtDiachi.Text.Trim()+ "', '" + mskdienthoai.Text + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblKhachhang where MaKH=N'" + txtMaKH.Text + "'";
                Class.Functions.RunSqlDel(sql);
                load_datagrid();
                resetvalue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }

            sql = "update tblKhachhang set Tenkhach=N'" + txtTenKH.Text.Trim() + "', Diachi=N'" + txtDiachi.Text.Trim().ToString() + "', Dienthoai='" + mskdienthoai.Text.ToString() + "' where MaKH=N'" + txtMaKH.Text + "'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnBoqua.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
