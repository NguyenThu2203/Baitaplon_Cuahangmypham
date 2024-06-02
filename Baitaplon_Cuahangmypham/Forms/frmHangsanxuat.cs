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
    public partial class frmHangsanxuat : Form
    {
        public frmHangsanxuat()
        {
            InitializeComponent();
        }

        private void frmHangsanxuat_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            //MessageBox.Show("Kết nối thành công");
            txtMahangsx.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            load_datagrid();
        }
        DataTable tblHSX;
        private void load_datagrid()
        {
            string sql;
            sql = "select Mahangsx, Tenhangsx from tblHangsanxuat";
            tblHSX = Class.Functions.GetDataToTable(sql);
            dgridHangsx.DataSource = tblHSX;
            dgridHangsx.Columns[0].HeaderText = "Mã hãng sản xuất";
            dgridHangsx.Columns[1].HeaderText = "Tên hãng sản xuất";
            dgridHangsx.AllowUserToAddRows = false;
            dgridHangsx.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridHangsx_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblHSX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMahangsx.Text = dgridHangsx.CurrentRow.Cells["Mahangsx"].Value.ToString();
            txtTenhangsx.Text = dgridHangsx.CurrentRow.Cells["Tenhangsx"].Value.ToString();
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
            txtMahangsx.Enabled = true;
            txtMahangsx.Focus();
            resetvalue();
        }
        private void resetvalue()
        {
            txtMahangsx.Text = "";
            txtTenhangsx.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMahangsx.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMahangsx.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahangsx.Focus();
                return;
            }
            if (txtTenhangsx.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenhangsx.Focus();
                return;
            }
            sql = "select Mahangsx from tblHangsanxuat where Mahangsx =N'" + txtMahangsx.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hãng sản xuất này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahangsx.Focus();
                txtMahangsx.Text = "";
                return;
            }
            sql = "insert into tblHangsanxuat(Mahangsx, Tenhangsx) values (N'" + txtMahangsx.Text.Trim() + "', N'" + txtTenhangsx.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMahangsx.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHSX.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMahangsx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenhangsx.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenhangsx.Focus();
                return;
            }
            sql = "update tblHangsanxuat set Tenhangsx=N'" + txtTenhangsx.Text.Trim() + "' where Mahangsx=N'" + txtMahangsx.Text + "'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHSX.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMahangsx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblHangsanxuat where Mahangsx=N'" + txtMahangsx.Text + "'";
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

        private void txtMahangsx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
