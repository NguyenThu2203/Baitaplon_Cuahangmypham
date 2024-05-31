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
    public partial class frmkhach : Form
    {
        public frmkhach()
        {
            InitializeComponent();
        }
        DataTable tblkhachhang;
        private void frmkhach_Load(object sender, EventArgs e)
        {
            txtmakh.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            load_datagridview();
            ResetValues();
        }
        private void ResetValues()
        {
            txtmakh.Text = "";
            txtdiachi.Text = "";
            txttenkhach.Text = "";
            mskdienthoai.Text = "";
        }
        private void load_datagridview()
        {
            string sql;
            sql = "select * from tblKhachhang ";
            tblkhachhang = Functions.GetDataToTable(sql);
            Dgrikhachhang.DataSource = tblkhachhang;
            Dgrikhachhang.Columns[0].HeaderText = "Mã khách hàng";
            Dgrikhachhang.Columns[1].HeaderText = "Tên khách hàng";
            Dgrikhachhang.Columns[2].HeaderText = "Địa chỉ";
            Dgrikhachhang.Columns[3].HeaderText = "Số điện thoại";
            Dgrikhachhang.AllowUserToAddRows = false;
            Dgrikhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmakh.Enabled = true;
            txtmakh.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "UPDATE tblKhachhang SET Tenkhach = N'" + txttenkhach.Text.Trim() + "', Diachi = N'" + txtdiachi.Text.Trim() + "', Dienthoai = '" + mskdienthoai.Text.Trim() + "' WHERE MaKH = N'" + txtmakh.Text.Trim() + "'";
            Class.Functions.RunSql(sql);
            load_datagridview();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhachhang WHERE MaKH=N'" + txtmakh.Text + "'";
                Class.Functions.RunSql(sql);
                load_datagridview();
                ResetValues();
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            // kiểm tra nhập đủ
            string sql;
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Focus();
                return;
            }
            if (txttenkhach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }

            // ktra ma bi trùng
            sql = "select MaKH from tblKhachhang where MaKH=N'" + txtmakh.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Đã có mã khách hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Text = "";
                txtmakh.Focus();
                return;
            }
            sql = "INSERT INTO tblKhachhang(MaKH, Tenkhach, Diachi, Dienthoai ) values(N'" + txtmakh.Text.Trim() + "',N'" + txttenkhach.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "', '" + mskdienthoai.Text + "')";
            Class.Functions.RunSql(sql);
            load_datagridview();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmakh.Enabled = false;
        
    }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmakh.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng cửa sổ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Dgrikhachhang_Click_1(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtmakh.Text = Dgrikhachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            txttenkhach.Text = Dgrikhachhang.CurrentRow.Cells["Tenkhach"].Value.ToString();
            txtdiachi.Text = Dgrikhachhang.CurrentRow.Cells["Diachi"].Value.ToString();
            mskdienthoai.Text = Dgrikhachhang.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }
    }
}
