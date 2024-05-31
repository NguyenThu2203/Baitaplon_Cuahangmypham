using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Banmypham.Forms
{
    public partial class frmNhacungcap : Form
    {
        public frmNhacungcap()
        {
            InitializeComponent();
        }

        private void frmNhacungcap_Load(object sender, EventArgs e)
        {
            txtManhacungcap.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            load_datagrid();
            
        }
        DataTable tblncc;
        private void load_datagrid()
        {
            string sql;
            sql = "select MaNCC, TenNCC, Diachi, Dienthoai from tblNhacungcap";
            tblncc = Class.Function.Getdatatotable(sql);
            
            dgridNhacungcap.DataSource = tblncc;
            dgridNhacungcap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgridNhacungcap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgridNhacungcap.Columns[2].HeaderText = "Địa chỉ";
            dgridNhacungcap.Columns[3].HeaderText = "Điện thoại";
            dgridNhacungcap.Columns[0].Width = 120;
            dgridNhacungcap.Columns[1].Width = 140;
            dgridNhacungcap.Columns[2].Width = 150;
            dgridNhacungcap.Columns[3].Width = 150;
            dgridNhacungcap.AllowUserToAddRows = false;
            dgridNhacungcap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridNhacungcap_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtManhacungcap.Text = dgridNhacungcap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTennhacungcap.Text = dgridNhacungcap.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiachi.Text = dgridNhacungcap.CurrentRow.Cells["Diachi"].Value.ToString();
            txtDienthoai.Text = dgridNhacungcap.CurrentRow.Cells["Dienthoai"].Value.ToString();
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
            txtManhacungcap.Enabled = true;
            txtManhacungcap.Focus();
            resetvalue();
        }
        private void resetvalue()
        {
            txtManhacungcap.Text = "";
            txtTennhacungcap.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtManhacungcap.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManhacungcap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManhacungcap.Focus();
                return;
            }
            if (txtTennhacungcap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennhacungcap.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiachi.Focus();
                return;
            }
            if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienthoai.Focus();
                return;
            }
            //ktr trung ma
            sql = "select MaNCC from tblNhacungcap where MaNCC=N'" + txtManhacungcap.Text.Trim() + "'";
            if (Class.Function.checkkey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManhacungcap.Focus();
                txtManhacungcap.Text = "";
                return;
            }
            sql = "insert into tblNhacungcap(MaNCC,TenNCC, Diachi, Dienthoai)values(N'" + txtManhacungcap.Text.Trim() + "',N'" + txtTennhacungcap.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "',N'" + txtDienthoai.Text.Trim() + "')";
            Class.Function.runsql(sql);
            load_datagrid();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhacungcap.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtManhacungcap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTennhacungcap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennhacungcap.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiachi.Focus();
                return;
            }
            if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienthoai.Focus();
                return;
            }
            sql = "update tblNhacungcap set TenNCC=N'" + txtTennhacungcap.Text.Trim() + "', DiaChi = N'" + txtDiachi.Text.Trim() + "', DienThoai = N'" + txtDienthoai.Text.Trim() + "' WHERE MaNCC = N'" + txtManhacungcap.Text + "'";
            Class.Function.runsql(sql);
            load_datagrid();
            resetvalue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtManhacungcap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thong báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblNhacungcap where MaNCC=N'" + txtManhacungcap.Text + "'";
                Class.Function.runsql(sql);
                load_datagrid();
                resetvalue();

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Ban có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }    
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
