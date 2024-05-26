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
    public partial class frmNuocsanxuat : Form
    {
        public frmNuocsanxuat()
        {
            InitializeComponent();
        }

        private void frmNuocsanxuat_Load(object sender, EventArgs e)
        {
            txtManuocsx.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblNuocsanxuat;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Manuocsx, tennuocsx from tblNuocsanxuat";
            tblNuocsanxuat = Class.Functions.GetDataToTable(sql);
            dgridNuocsanxuat.DataSource = tblNuocsanxuat;
            dgridNuocsanxuat.Columns[0].HeaderText = "Mã nước sản xuất";
            dgridNuocsanxuat.Columns[1].HeaderText = "Tên nước sản xuất";
            dgridNuocsanxuat.AllowUserToAddRows = false;
            dgridNuocsanxuat.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridNuocsanxuat_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblNuocsanxuat.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtManuocsx.Text = dgridNuocsanxuat.CurrentRow.Cells["Manuocsx"].Value.ToString();
            txtTennuocsx.Text = dgridNuocsanxuat.CurrentRow.Cells["Tennuocsx"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManuocsx.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtManuocsx.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManuocsx.Focus();
                return;
            }
            if (txtTennuocsx.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennuocsx.Focus();
                return;
            }
            string sql;
            //sql = "select machatlieu from tbtChatlieu where machatlieu = N'" + txtMachatlieu.Text.Trim().ToLower() + "'  ";
            sql = "select Manuocsx from tblNuocsanxuat where Manuocsx=N'" + txtManuocsx.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Trùng mã nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManuocsx.Focus();
                txtManuocsx.Text = "";
                return;
            }
            sql = "insert into tblNuocsanxuat(Manuocsx, Tennuocsx)values(N'" + txtManuocsx.Text.Trim() + "',N'" + txtTennuocsx.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtManuocsx.Enabled = false;
            ResetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblNuocsanxuat.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtManuocsx.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào để sửa");
                return;
            }
            if (txtTennuocsx.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nước sản xuất");
                txtTennuocsx.Focus();
                return;
            }
            string sql;
            sql = "update tblNuocsanxuat set Tennuocsx=N'" + txtTennuocsx.Text.Trim() + "'where Manuocsx=N'" + txtManuocsx.Text.Trim() + "' ";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblNuocsanxuat.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtManuocsx.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào để sửa");
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                string sql;
                sql = "delete tblNuocsanxuat where Manuocsx=N'" + txtManuocsx.Text.Trim() + "' ";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValue();
            }
        }
        private void ResetValue()
        {
            txtManuocsx.Text = "";
            txtTennuocsx.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtManuocsx.Enabled = true;
            ResetValue();
        }
    }
}
