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
    public partial class frmLoai : Form
    {
        public frmLoai()
        {
            InitializeComponent();
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            MessageBox.Show("Kết nối thành công");
            txtMaloai.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            load_datagrid();
        }
        DataTable tblL;
        private void load_datagrid()
        {
            string sql;
            sql = "select Maloai, Tenloai from tblLoai";
            tblL = Class.Functions.GetDataToTable(sql);
            dgridLoai.DataSource = tblL;
            dgridLoai.Columns[0].HeaderText = "Mã loại";
            dgridLoai.Columns[1].HeaderText = "Tên loại";
            dgridLoai.AllowUserToAddRows = false;
            dgridLoai.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridLoai_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMaloai.Text = dgridLoai.CurrentRow.Cells["Maloai"].Value.ToString();
            txtTenloai.Text = dgridLoai.CurrentRow.Cells["Tenloai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMaloai.Enabled = true;
            txtMaloai.Focus();
            resetvalue();
        }
        private void resetvalue()
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaloai.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaloai.Focus();
                return;
            }
            if (txtTenloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenloai.Focus();
                return;
            }
            sql = "select Maloai from tblLoai where Maloai = N'" + txtMaloai.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã loại này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaloai.Focus();
                txtMaloai.Text = "";
                return;
            }
            sql = "Insert into tblLoai(Maloai, Tenloai) values (N'" + txtMaloai.Text.Trim() + "', N'" + txtTenloai.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaloai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenloai.Focus();
                return;
            }
            sql = "update tblLoai set Tenloai=N'" + txtTenloai.Text.Trim() + "' where Maloai=N'" + txtMaloai.Text + "'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblLoai where Maloai=N'" + txtMaloai.Text + "'";
                Class.Functions.RunSqlDel(sql);
                load_datagrid();
                resetvalue();
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng cửa sổ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtMaloai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
