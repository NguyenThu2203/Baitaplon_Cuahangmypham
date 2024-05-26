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
    public partial class frmCongdung : Form
    {
        public frmCongdung()
        {
            InitializeComponent();
        }

        private void frmCongdung_Load(object sender, EventArgs e)
        {
            txtMacongdung.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblCD; 
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Macongdung, Tencongdung FROM tblCongdung";
            tblCD = Class.Functions.GetDataToTable(sql);
            dgridCongdung.DataSource = tblCD;
            dgridCongdung.Columns[0].HeaderText = "Mã công dụng";
            dgridCongdung.Columns[1].HeaderText = "Tên công dụng";
            dgridCongdung.Columns[0].Width = 100;
            dgridCongdung.Columns[1].Width = 300;
            dgridCongdung.AllowUserToAddRows = false;
            dgridCongdung.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridCongdung_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMacongdung.Focus();
                return;
            }
            if (tblCD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMacongdung.Text = dgridCongdung.CurrentRow.Cells["Macongdung"].Value.ToString();
            txtTencongdung.Text = dgridCongdung.CurrentRow.Cells["Tencongdung"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMacongdung.Enabled = true;
            txtMacongdung.Focus();
        }
        private void ResetValues()
        {
            txtMacongdung.Text = "";
            txtTencongdung.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMacongdung.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacongdung.Focus();
                return;
            }
            if (txtTencongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTencongdung.Focus();
                return;
            }
            sql = "SELECT Macongdung FROM tblCongdung WHERE Macongdung=N'" + txtMacongdung.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã công dụng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacongdung.Focus();
                txtTencongdung.Text = "";
                return;
            }
            sql = "INSERT INTO tblCongdung(Macongdung,Tencongdung) VALUES(N'" + txtMacongdung.Text + "',N'" + txtTencongdung.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMacongdung.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblCD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTencongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTencongdung.Focus();
                return;
            }
            string sql;
            sql = "UPDATE tblCongdung SET Tencongdung=N'" + txtTencongdung.Text.ToString() + "' WHERE Macongdung = N'" + txtMacongdung.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblCongdung WHERE Macongdung=N'" + txtMacongdung.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMacongdung.Enabled = false;
        }

        private void txtMacongdung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
