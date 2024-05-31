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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            MessageBox.Show("Kết nối thành công");
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            load_datagrid();
        }
        DataTable tblNV;
        private void load_datagrid()
        {
            string sql;
            sql = "select MaNV, TenNV, Gioitinh, Ngaysinh, Dienthoai, Diachi, MaCV from tblNhanvien";
            tblNV = Class.Functions.GetDataToTable(sql);
            dgridNhanvien.DataSource = tblNV;
            dgridNhanvien.Columns[0].HeaderText = "Mã nhân viên ";
            dgridNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgridNhanvien.Columns[2].HeaderText = "Giới tính";
            dgridNhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgridNhanvien.Columns[4].HeaderText = "Điện thoại";
            dgridNhanvien.Columns[5].HeaderText = "Địa chỉ";
            dgridNhanvien.Columns[6].HeaderText = "Mã công việc";
            dgridNhanvien.AllowUserToAddRows = false;
            dgridNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridNhanvien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtManhanvien.Text = dgridNhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTennhanvien.Text = dgridNhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtMaCV.Text = dgridNhanvien.CurrentRow.Cells["MaCV"].Value.ToString();
            txtDiachi.Text = dgridNhanvien.CurrentRow.Cells["Diachi"].Value.ToString();
            mskdienthoai.Text = dgridNhanvien.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskngaysinh.Text = dgridNhanvien.CurrentRow.Cells["Ngaysinh"].Value.ToString();

            // Xử lý giới tính
            string gioiTinh = dgridNhanvien.CurrentRow.Cells["Gioitinh"].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else if (gioiTinh == "Nữ")
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = false;
            }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetvalue();
        }
        private void resetvalue()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtDiachi.Text = "";
            txtMaCV.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            mskdienthoai.Text = "";
            mskngaysinh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennhanvien.Focus();
                return;
            }
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennhanvien.Focus();
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
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Functions.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }

            string gt;
            if (rdNam.Checked == true)
                gt = "Nam";
            else if (rdNu.Checked == true)
                gt = "Nữ";
            else
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql;
            sql = "select MaNV from tblNhanvien where MaNV=N'" + txtManhanvien.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }

            sql = "insert into tblNhanvien(MaNV, TenNV, Gioitinh, Ngaysinh, Dienthoai, Diachi, MaCV) values(N'" + txtManhanvien.Text + "', N'" + txtTennhanvien.Text + "', N'" + gt + "', '" + Class.Functions.ConvertDatetime(mskngaysinh.Text) + "', '" + mskdienthoai.Text + "', N'" + txtDiachi.Text + "', N'" + txtMaCV.Text + "' )";
            Class.Functions.RunSql(sql);
            load_datagrid();
            resetvalue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblNhanvien where MaNV=N'" + txtManhanvien.Text + "'";
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
            txtManhanvien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTennhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennhanvien.Focus();
                return;
            }
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTennhanvien.Focus();
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
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Functions.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            string gt;
            if (rdNam.Checked == true)
                gt = "Nam";
            else if (rdNu.Checked == true)
                gt = "Nữ";
            else
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = "update tblNhanvien set TenNV=N'" + txtTennhanvien.Text.Trim().ToString() + "', MaCV=N'" + txtMaCV.Text.Trim().ToString() + "', Diachi=N'" + txtDiachi.Text.Trim().ToString() + "', Gioitinh =N'" + gt + "', Dienthoai='" + mskdienthoai.Text.ToString() + "',  Ngaysinh='" + Class.Functions.ConvertDatetime(mskngaysinh.Text) + "' where MaNV=N'" + txtManhanvien.Text + "'";
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
