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
    public partial class frmHanghoa : Form
    {
        public frmHanghoa()
        {
            InitializeComponent();
        }

        private void frmHanghoa_Load(object sender, EventArgs e)
        {
            txtMahang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMahang.Enabled = true;
            txtDongiaban.Enabled = false;
            txtDongianhap.Enabled = false;
            Load_DataGridView();
            Class.Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMachatlieu.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Maloai, Tenloai FROM tblLoai", cboMaloai, "Maloai", "TenLoai");
            cboMaloai.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Makhoiluong, Tenkhoiluong FROM tblKhoiluong", cboMakhoiluong, "Makhoiluong", "Tenkhoiluong");
            cboMakhoiluong.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Mahangsx, Tenhangsx FROM tblHangsanxuat", cboMahangsx, "Mahangsx", "Tenhangsx");
            cboMahangsx.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Macongdung, Tencongdung FROM tblCongdung", cboMacongdung, "Macongdung", "Tencongdung");
            cboMacongdung.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Mamua, Tenmua FROM tblMua", cboMamua, "Mamua", "Tenmua");
            cboMamua.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Mamau, Tenmau FROM tblMausac", cboMamau, "Mamau", "Tenmau");
            cboMamau.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Manuocsx, Tennuocsx FROM tblNuocsanxuat", cboManuocSX, "Manuocsx", "Tennuocsx");
            cboManuocSX.SelectedIndex = -1;
        }
        DataTable tblHH; 
        private void Load_DataGridView()
        {
            string sql;
            sql = "Select Mahang, TenHang, Maloai, Makhoiluong, Mahangsx, Machatlieu, Macongdung, Mamua, Mamau, ManuocSX, Soluong, Thoigianbaohanh,Dongianhap,Dongiaban from tblHanghoa";
            tblHH = Class.Functions.GetDataToTable(sql);
            dgridHanghoa.DataSource = tblHH;
            dgridHanghoa.Columns[0].HeaderText = "Mã hàng";
            dgridHanghoa.Columns[1].HeaderText = "Tên hàng";
            dgridHanghoa.Columns[2].HeaderText = "Mã loại";
            dgridHanghoa.Columns[3].HeaderText = "Mã khối lượng";
            dgridHanghoa.Columns[4].HeaderText = "Hãng sản xuất";
            dgridHanghoa.Columns[5].HeaderText = "Chất liệu";
            dgridHanghoa.Columns[6].HeaderText = "Công dụng";
            dgridHanghoa.Columns[7].HeaderText = "Mùa";
            dgridHanghoa.Columns[8].HeaderText = "Màu";
            dgridHanghoa.Columns[9].HeaderText = "Nước SX";
            dgridHanghoa.Columns[10].HeaderText = "Số lượng";
            dgridHanghoa.Columns[11].HeaderText = "Thời gian bảo hành";
            dgridHanghoa.Columns[12].HeaderText = "Đơn giá nhập";
            dgridHanghoa.Columns[13].HeaderText = "Đơn giá bán";
            dgridHanghoa.AllowUserToAddRows = false;
            dgridHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridHanghoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMahang.Text = dgridHanghoa.CurrentRow.Cells["Mahang"].Value.ToString();
            txtTenhang.Text = dgridHanghoa.CurrentRow.Cells["Tenhang"].Value.ToString();

            string maloai; 
            maloai = dgridHanghoa.CurrentRow.Cells["Maloai"].Value.ToString();
            cboMaloai.Text = Functions.getfieldvalues("select Tenloai from tblLoai where Maloai = N'" + maloai + "'");
            string makl; 
            makl =  dgridHanghoa.CurrentRow.Cells["Makhoiluong"].Value.ToString();
            cboMakhoiluong.Text = Functions.getfieldvalues("select Tenkhoiluong from tblKhoiluong where Makhoiluong = N'" + makl + "'");
            string mahsx; 
            mahsx = dgridHanghoa.CurrentRow.Cells["Mahangsx"].Value.ToString();
            cboMahangsx.Text = Functions.getfieldvalues("select Tenhangsx from tblHangsanxuat where Mahangsx = N'" + mahsx + "'");
            string macl; 
            macl = dgridHanghoa.CurrentRow.Cells["Machatlieu"].Value.ToString();
            cboMachatlieu.Text = Functions.getfieldvalues("select Tenchatlieu from tblChatlieu where Machatlieu = N'" + macl + "'");
            string macd;
            macd = dgridHanghoa.CurrentRow.Cells["Macongdung"].Value.ToString();
            cboMacongdung.Text = Functions.getfieldvalues("select Tencongdung from tblCongdung where Macongdung = N'" + macd + "'");
            string manua;
            manua = dgridHanghoa.CurrentRow.Cells["Mamua"].Value.ToString();
            cboMamua.Text = Functions.getfieldvalues("select Tenmua from tblMua where Mamua = N'" + manua + "'");
            string mamau;
            mamau = dgridHanghoa.CurrentRow.Cells["Mamau"].Value.ToString();
            cboMamau.Text = Functions.getfieldvalues("select Tenmau from tblMausac where Mamau = N'" + mamau + "'");
            string manuoc;
            manuoc = dgridHanghoa.CurrentRow.Cells["ManuocSX"].Value.ToString();
            cboManuocSX.Text = Functions.getfieldvalues("select Tennuocsx from tblNuocsanxuat where ManuocSX = N'" + manuoc + "'");

            txtSoluong.Text = dgridHanghoa.CurrentRow.Cells["Soluong"].Value.ToString();
            txtThoigianbaohanh.Text = dgridHanghoa.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            txtDongiaban.Text = dgridHanghoa.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtDongianhap.Text = dgridHanghoa.CurrentRow.Cells["Dongianhap"].Value.ToString();
            string ma;
            ma = dgridHanghoa.CurrentRow.Cells["Mahang"].Value.ToString();
            txtAnh.Text = Class.Functions.getfieldvalues("Select Anh from tblHanghoa where Mahang = N'" + ma + "'");
            txtGhichu.Text = Class.Functions.getfieldvalues("Select Ghichu from tblHanghoa where Mahang = N'" + ma + "'");
            if (txtAnh.Text != "")
            {
                picAnh.Image = Image.FromFile(txtAnh.Text);
                return;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlopen = new OpenFileDialog();
            dlopen.Filter = "JPG|*.jpg|GIF|*.gif|ALlfile|*.*";
            dlopen.InitialDirectory = "D:\\";
            dlopen.FilterIndex = 3;
            dlopen.Title = "Hãy chọn hình ảnh để hiển thị";
            if (dlopen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlopen.FileName);
            }
            txtAnh.Text = dlopen.FileName;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMahang.Enabled = true;
            resetvalue();
        }
        private void resetvalue()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            cboMaloai.Text = "";
            cboMakhoiluong.Text = "";
            cboMahangsx.Text = "";
            cboMachatlieu.Text = "";
            cboMacongdung.Text = "";
            cboMamua.Text = "";
            cboMamau.Text = "";
            cboManuocSX.Text = "";
            txtSoluong.Text = "0";
            txtThoigianbaohanh.Text = "0";
            txtDongiaban.Text = "0";
            txtDongianhap.Text = "0";
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhichu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMahang.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("bạn phải chọn mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenhang.Focus();
                return;
            }
            if (cboMaloai.Text == "")
            {
                MessageBox.Show("bạn phải chọn mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaloai.Focus();
                return;
            }
            if (cboMakhoiluong.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã khối lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMakhoiluong.Focus();
                return;
            }
            if (cboMahangsx.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMahangsx.Focus();
                return;
            }
            if (cboMachatlieu.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMachatlieu.Focus();
                return;
            }
            if (cboMacongdung.Text == "")
            {
                MessageBox.Show("bạn phải chọn mã công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMacongdung.Focus();
                return;
            }
            if (cboMamua.Text == "")
            {
                MessageBox.Show("bạn phải chọn mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMamua.Focus();
                return;
            }
            if (cboMamau.Text == "")
            {
                MessageBox.Show("bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMamau.Focus();
                return;
            }
            if (cboManuocSX.Text == "")
            {
                MessageBox.Show("bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMamau.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return;
            }
            if (txtThoigianbaohanh.Text == "")
            {
                MessageBox.Show("bạn phải nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThoigianbaohanh.Focus();
                return;
            }
            txtDongiaban.Text = (Convert.ToInt32(txtDongiaban.Text) * 0.11).ToString();
            //nhập hàng hóa xong sẽ nhập hóa đơn nhập, sau đó sẽ điền các thông tin hàng hóa
            sql = "Select Mahang from tblHanghoa where Mahang = N'" + txtMahang.Text + "'";
            if (Class.Functions.Checkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahang.Text = "";
                txtMahang.Focus();
                return;
            }
            sql = "INSERT INTO tblHanghoa(Mahang,Tenhang,Maloai, Makhoiluong, Mahangsx, Machatlieu, Macongdung, Mamua, Anh, Ghichu, Mamau, ManuocSX, Soluong, Thoigianbaohanh, Dongiaban, Dongianhap) VALUES(N'" + txtMahang.Text.Trim() + "',N'" + txtTenhang.Text.Trim() + "',N'" + cboMaloai.SelectedValue.ToString() + "',N'" + cboMakhoiluong.SelectedValue.ToString() + "',N'" + cboMahangsx.SelectedValue.ToString() + "',N'" + cboMachatlieu.SelectedValue.ToString() + "',N'" + cboMacongdung.SelectedValue.ToString() + "',N'" + cboMamua.SelectedValue.ToString() + "',N'" + txtAnh.Text + "', N'" + txtGhichu.Text + "',N'" + cboMamau.SelectedValue.ToString() + "', N'" + cboManuocSX.SelectedValue.ToString() + "', '" + txtSoluong.Text + "', '" + txtThoigianbaohanh.Text + "','" + txtDongiaban.Text + "', '" + txtDongianhap.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            resetvalue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = false;
            txtMahang.Enabled = false; 
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dòng dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            if (MessageBox.Show("Bạn muốn xóa dòng dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "delete tblHanghoa where Mahang = N'" + txtMahang.Text.Trim() + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                resetvalue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = false;
            txtMahang.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenhang.Focus();
                return;
            }
            if (cboMaloai.Text == "")
            {
                MessageBox.Show("bạn phải chọn mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaloai.Focus();
                return;
            }
            if (cboMakhoiluong.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã khối lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMakhoiluong.Focus();
                return;
            }
            if (cboMahangsx.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMahangsx.Focus();
                return;
            }
            if (cboMachatlieu.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMachatlieu.Focus();
                return;
            }
            if (cboMacongdung.Text == "")
            {
                MessageBox.Show("bạn phải chọn mã công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMacongdung.Focus();
                return;
            }
            if (cboMamua.Text == "")
            {
                MessageBox.Show("bạn phải chọn mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMamua.Focus();
                return;
            }
            if (cboMamau.Text == "")
            {
                MessageBox.Show("bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMamau.Focus();
                return;
            }
            if (cboManuocSX.Text == "")
            {
                MessageBox.Show("bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMamau.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return;
            }
            if (txtThoigianbaohanh.Text == "")
            {
                MessageBox.Show("bạn phải nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThoigianbaohanh.Focus();
                return;
            }
            if (txtDongiaban.Text == "")
            {
                MessageBox.Show("bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThoigianbaohanh.Focus();
                return;
            }
            string sql;
            //Lỗi: Nếu không sửa hết các combobox khác thì sẽ có lỗi 

            sql = "update tblHanghoa set Tenhang = N'" + txtTenhang.Text + "', Maloai = N'" + cboMaloai.SelectedValue.ToString() + "', Makhoiluong = N'" + cboMakhoiluong.SelectedValue.ToString() + "', Mahangsx = N'" + cboMahangsx.SelectedValue.ToString() + "', Machatlieu = N'" + cboMachatlieu.SelectedValue.ToString() + "', Macongdung = N'" + cboMacongdung.SelectedValue.ToString() + "', Mamua = N'" + cboMamua.SelectedValue.ToString() + "', Anh = N'" + txtAnh.Text + "', Ghichu = N'" + txtGhichu.Text + "', Mamau = N'" + cboMamau.SelectedValue.ToString() + "', ManuocSX = N'" + cboManuocSX.SelectedValue.ToString() + "', Dongiaban = " + txtDongiaban.Text + " where Mahang = N'" + txtMahang.Text.Trim() + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            resetvalue();
            btnBoqua.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahang.Text == "") && (txtTenhang.Text == "") && (cboMachatlieu.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu nhập điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHanghoa WHERE 1=1";
            if (txtMahang.Text != "")
                sql = sql + " AND Mahang Like N'%" + txtMahang.Text + "%'";
            if (txtTenhang.Text != "")
                sql = sql + " AND Tenhang Like N'%" + txtTenhang.Text + "%'";
            if (cboMachatlieu.Text != "")
                sql = sql + " AND Machatlieu Like N'%" + cboMachatlieu.SelectedValue + "%'";
            tblHH = Functions.GetDataToTable(sql);
            if (tblHH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblHH.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dgridHanghoa.DataSource = tblHH;
            resetvalue();
        }

        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "Select Mahang, TenHang, Maloai, Makhoiluong, Mahangsx, Machatlieu, Macongdung, Mamua, Mamau, ManuocSX, Soluong, Thoigianbaohanh,Dongianhap,Dongiaban from tblHanghoa";
            tblHH = Functions.GetDataToTable(sql);
            dgridHanghoa.DataSource = tblHH;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtThoigianbaohanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
