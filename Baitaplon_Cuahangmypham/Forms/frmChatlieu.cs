using Baitaplon_Cuahangmypham.Class;
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
    public partial class frmChatlieu : Form
    {
        public frmChatlieu()
        {
            InitializeComponent();
        }

        private void frmChatlieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblChatlieu;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Machatlieu, Tenchatlieu from tblChatlieu";
            tblChatlieu = Class.Functions.GetDataToTable(sql);
            dgridChatlieu.DataSource = tblChatlieu;
            dgridChatlieu.Columns[0].HeaderText = "Mã chất liệu";
            dgridChatlieu.Columns[1].HeaderText = "Tên chất liệu";
            dgridChatlieu.AllowUserToAddRows = false;
            dgridChatlieu.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMachatlieu.Enabled = true;
            ResetValue();
        }
        private void ResetValue()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }

        private void dgridChatlieu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblChatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMachatlieu.Text = dgridChatlieu.CurrentRow.Cells["Machatlieu"].Value.ToString();
            txtTenchatlieu.Text = dgridChatlieu.CurrentRow.Cells["Tenchatlieu"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblChatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChatlieu WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
                Functions.RunSql(sql);
                Load_DataGridView();
                ResetValue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblChatlieu.Rows.Count == 0) //Kiểm tra có dữ liệu hay không
            {
                MessageBox.Show("không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //khi kích vào datagridview
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào để sửa");
                return;
            }
            if (txtTenchatlieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu");
                txtTenchatlieu.Focus();
                return;
            }
            string sql;
            sql = "update tblChatlieu set Tenchatlieu=N'" + txtTenchatlieu.Text.Trim() + "'where Machatlieu=N'" + txtMachatlieu.Text.Trim() + "' ";
            Class.Functions.RunSql(sql); //Thực thi
            Load_DataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchatlieu.Focus();
                return;
            }
            string sql;
            //sql = "select machatlieu from tbtChatlieu where machatlieu = N'" + txtMachatlieu.Text.Trim().ToLower() + "'  ";
            sql = "select Machatlieu from tblChatlieu where Machatlieu=N'" + txtMachatlieu.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Trùng mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachatlieu.Focus();
                txtMachatlieu.Text = "";
                return;
            }
            sql = "insert into tblChatlieu(Machatlieu, Tenchatlieu)values(N'" + txtMachatlieu.Text.Trim() + "',N'" + txtTenchatlieu.Text.Trim() + "')";
            // sql = "insert into tblChatlieu(machatlieu,tenchatlieu)";
            // Nếu là kiểu số: N"+ +"
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMachatlieu.Enabled = false;
            ResetValue();
            return;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
