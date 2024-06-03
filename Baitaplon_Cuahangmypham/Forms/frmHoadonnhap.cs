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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Baitaplon_Cuahangmypham.Forms
{
    public partial class frmHoadonnhap : Form
    {
        public void getMahoadonnhap(string Mahoadonnhap)
        {
            txtMahoadonnhap.Text = Mahoadonnhap;
        }

        public frmHoadonnhap()
        {
            InitializeComponent();
        }
        DataTable tblHDN, tblCTHDN;
        private void frmHoadonnhap_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            txtMahoadonnhap.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTennhacungcap.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDienthoai.ReadOnly = true;
            txtTenhang.ReadOnly = true;
            txtDongianhap.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "0";
            txtTongtien.Text = "0";
            Functions.FillCombo("SELECT MaNCC, TenNCC FROM tblNhacungcap", cboManhacungcap, "MaNCC", "MaNCC");
            cboManhacungcap.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNV, TenNV FROM tblNhanVien", cboManhanvien, "MaNV", "MaNV");
            cboManhanvien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHang, TenHang FROM tblHanghoa", cboMahang, "Mahang", "Mahang");
            cboMahang.SelectedIndex = -1;
            Functions.FillCombo("SELECT SoHDN FROM tblChitiethoadonnhap", cboMahoadonnhap, "SoHDN", "SoHDN");
            cboMahoadonnhap.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMahoadonnhap.Text != "")
            {
                LoadInfoHoaDon();
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }
            Load_DataGridViewHoadonnhap();
            LoadDataGridViewChitietHDN();
            UpdateGiaBan();
        }
        private void UpdateGiaBan()
        {
            // Lệnh SQL để cập nhật giá bán
            string sqlUpdateGiaBan = "UPDATE tblHanghoa SET Dongiaban = 1.1 * Dongianhap";

            // Thực hiện lệnh cập nhật giá bán
            Functions.RunSql(sqlUpdateGiaBan);
        }
        private void Load_DataGridViewHoadonnhap()
        {
            string sql = "SELECT H.SoHDN, H.Ngaynhap, H.MaNV, NV.TenNV, H.MaNCC, N.TenNCC, N.DiaChi, N.DienThoai,  H.Tongtien FROM ((tblHoadonnhap H INNER JOIN tblNhacungcap N ON H.MaNCC = N.MaNCC) INNER JOIN tblNhanvien NV ON H.MaNV = NV.MaNV)";
            tblHDN = Functions.GetDataToTable(sql);
            dgridHDN.DataSource = tblHDN;
            dgridHDN.Columns[0].HeaderText = "Số HĐN";
            dgridHDN.Columns[1].HeaderText = "Ngày nhập";
            dgridHDN.Columns[2].HeaderText = "Mã nhân viên";
            dgridHDN.Columns[3].HeaderText = "Tên Nhân viên";
            dgridHDN.Columns[4].HeaderText = "Mã NCC";
            dgridHDN.Columns[5].HeaderText = "Tên NCC";
            dgridHDN.Columns[6].HeaderText = "Địa chỉ";
            dgridHDN.Columns[7].HeaderText = "Điện thoại";
            dgridHDN.Columns[8].HeaderText = "Tổng tiền";
            dgridHDN.Columns[0].Width = 100;
            dgridHDN.Columns[1].Width = 150;
            dgridHDN.Columns[2].Width = 100;
            dgridHDN.Columns[3].Width = 150;
            dgridHDN.Columns[4].Width = 200;
            dgridHDN.Columns[5].Width = 120;
            dgridHDN.Columns[6].Width = 100;
            dgridHDN.Columns[7].Width = 150;
            dgridHDN.Columns[8].Width = 100;
            dgridHDN.AllowUserToAddRows = false;
            dgridHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDataGridViewChitietHDN()
        {
            string sql;
            sql = "SELECT a.Mahang, b.Tenhang, a.Soluong, b.Dongianhap, a.Giamgia,a.Thanhtien FROM tblChitiethoadonnhap AS a, tblHanghoa AS b WHERE a.SoHDN = N'" + txtMahoadonnhap.Text + "' AND a.Mahang=b.Mahang";
            tblCTHDN = Functions.GetDataToTable(sql);
            dgridChitietHDN.DataSource = tblCTHDN;
            dgridChitietHDN.Columns[0].HeaderText = "Mã hàng";
            dgridChitietHDN.Columns[1].HeaderText = "Tên hàng";
            dgridChitietHDN.Columns[2].HeaderText = "Số lượng";
            dgridChitietHDN.Columns[3].HeaderText = "Đơn giá nhập";
            dgridChitietHDN.Columns[4].HeaderText = "Giảm giá %";
            dgridChitietHDN.Columns[5].HeaderText = "Thành tiền";
            dgridChitietHDN.Columns[0].Width = 80;
            dgridChitietHDN.Columns[1].Width = 130;
            dgridChitietHDN.Columns[2].Width = 80;
            dgridChitietHDN.Columns[3].Width = 90;
            dgridChitietHDN.Columns[4].Width = 90;
            dgridChitietHDN.Columns[5].Width = 90;
            dgridChitietHDN.AllowUserToAddRows = false;
            dgridChitietHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMahoadonnhap.Text = Functions.CreateKey("I");
            LoadDataGridViewChitietHDN();
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT Ngaynhap FROM tblHoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'";
            mskNgaynhap.Text = Functions.ConvertDatetime(Functions.getfieldvalues(str));
            str = "SELECT MaNV FROM tblHoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'";
            cboManhanvien.Text = Functions.getfieldvalues(str);
            str = "SELECT MaNCC FROM tblHoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'";
            cboManhacungcap.Text = Functions.getfieldvalues(str);
            str = "SELECT Tongtien FROM tblHoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'";
            txtTongtien.Text = Functions.getfieldvalues(str);
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = Functions.ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLmoi, tong, Tongmoi;
            sql = "SELECT SoHDN FROM tblHoadonnhap WHERE SoHDN=N'" + txtMahoadonnhap.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDNhap được sinh tự động do đó không có trường hợp trùng khóa
                if (mskNgaynhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskNgaynhap.Focus();
                    return;
                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboManhacungcap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboManhacungcap.Focus();
                    return;
                }
                sql = "INSERT INTO tblHoadonnhap(SoHDN, Ngaynhap, MaNV, MaNCC, Tongtien) VALUES (N'" + txtMahoadonnhap.Text.Trim() + "','" +
                        Functions.ConvertDatetime(mskNgaynhap.Text.Trim()) + "',N'" + cboManhanvien.SelectedValue + "',N'" +
                        cboManhacungcap.SelectedValue + "'," + txtTongtien.Text + ")";
                Functions.RunSql(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cboMahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMahang.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return;
            }
            sql = "SELECT Mahang FROM tblChitiethoadonnhap WHERE Mahang=N'" + cboMahang.SelectedValue + "' AND SoHDN = N'" + txtMahoadonnhap.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMahang.Focus();
                return;
            }
            
            sl = Convert.ToDouble(Functions.getfieldvalues("SELECT Soluong FROM tblHanghoa WHERE Mahang = N'" + cboMahang.SelectedValue + "'"));
            sql = "INSERT INTO tblChitiethoadonnhap(SoHDN,Mahang,Soluong,Dongianhap, Giamgia,Thanhtien) VALUES(N'" + txtMahoadonnhap.Text.Trim() + "',N'" + cboMahang.SelectedValue + "'," + txtSoluong.Text + "," + txtDongianhap.Text + "," + txtGiamgia.Text + "," + txtThanhtien.Text + ")";
            Functions.RunSql(sql);
            LoadDataGridViewChitietHDN();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLmoi = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblHanghoa SET Soluong =" + SLmoi + " WHERE Mahang= N'" + cboMahang.SelectedValue + "'";
            Functions.RunSql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.getfieldvalues("SELECT Tongtien FROM tblHoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblHoadonnhap SET Tongtien =" + Tongmoi + " WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'";
            Functions.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
        }

        private void ResetValues()
        {
            txtMahoadonnhap.Text = "";
            mskNgaynhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboManhanvien.Text = "";
            cboManhacungcap.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            txtTennhanvien.Text = "";
            txtTennhacungcap.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Mahang,Soluong FROM tblChitiethoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'";
                DataTable tblHang = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.getfieldvalues("SELECT Soluong FROM tblHanghoa WHERE Mahang = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblHanghoa SET Soluong =" + slcon + " WHERE Mahang= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Functions.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChitiethoadonnhap WHERE SoHDN=N'" + txtMahoadonnhap.Text + "'";
                Functions.RunSql(sql);

                //Xóa hóa đơn
                sql = "DELETE tblHoadonnhap WHERE SoHDN=N'" + txtMahoadonnhap.Text + "'";
                Functions.RunSql(sql);
                ResetValues();
                LoadDataGridViewChitietHDN();
                btnHuy.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNV from tblNhanvien where MaNV =N'" + cboManhanvien.SelectedValue + "'";
            txtTennhanvien.Text = Functions.getfieldvalues(str);
        }

        private void cboManhacungcap_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhacungcap.Text == "")
            {
                txtTennhacungcap.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenNCC from tblNhacungcap where MaNCC = N'" + cboManhacungcap.SelectedValue + "'";
            txtTennhacungcap.Text = Functions.getfieldvalues(str);
            str = "Select Diachi from tblNhacungcap where MaNCC = N'" + cboManhacungcap.SelectedValue + "'";
            txtDiachi.Text = Functions.getfieldvalues(str);
            str = "Select Dienthoai from tblNhacungcap where MaNCC= N'" + cboManhacungcap.SelectedValue + "'";
            txtDienthoai.Text = Functions.getfieldvalues(str);
        }

        private void cboMahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMahang.Text == "")
            {
                txtTenhang.Text = "";
                txtDongianhap.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT Tenhang FROM tblHanghoa WHERE Mahang =N'" + cboMahang.SelectedValue + "'";
            txtTenhang.Text = Functions.getfieldvalues(str);
            str = "SELECT Dongianhap FROM tblHanghoa WHERE Mahang =N'" + cboMahang.SelectedValue + "'";
            txtDongianhap.Text = Functions.getfieldvalues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMahoadonnhap.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn nhập để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMahoadonnhap.Focus();
                return;
            }
            txtMahoadonnhap.Text = cboMahoadonnhap.Text;
            LoadInfoHoaDon();
            LoadDataGridViewChitietHDN();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cboMahoadonnhap.SelectedIndex = -1;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cboMahoadonnhap_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT SoHDN FROM tblHoadonnhap", cboMahoadonnhap, "SoHDN", "SoHDN");
            cboMahoadonnhap.SelectedIndex = -1;
        }

        private void frmHoadonnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
        }

        private void dgridHDN_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMahoadonnhap.Text = dgridHDN.CurrentRow.Cells["SoHDN"].Value.ToString();
            mskNgaynhap.Text = dgridHDN.CurrentRow.Cells["Ngaynhap"].Value.ToString();
            cboManhanvien.Text = dgridHDN.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTennhanvien.Text = dgridHDN.CurrentRow.Cells["TenNV"].Value.ToString();
            cboManhacungcap.Text = dgridHDN.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTennhacungcap.Text = dgridHDN.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiachi.Text = dgridHDN.CurrentRow.Cells["Diachi"].Value.ToString();
            txtDienthoai.Text = dgridHDN.CurrentRow.Cells["Dienthoai"].Value.ToString();
            txtTongtien.Text = dgridHDN.CurrentRow.Cells["Tongtien"].Value.ToString();
            btnHuy.Enabled = true;
            btnBoqua.Enabled = true;
            btnIn.Enabled = true;
            LoadDataGridViewChitietHDN();
        }

        private void dgridChitietHDN_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slmoi, tong, tongmoi;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgridChitietHDN.CurrentRow.Cells["Mahang"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgridChitietHDN.CurrentRow.Cells["Soluong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgridChitietHDN.CurrentRow.Cells["Thanhtien"].Value.ToString());
                sql = "DELETE tblChitiethoadonnhap WHERE SoHDN=N'" + txtMahoadonnhap.Text + "' AND Mahang = N'" + MaHangxoa + "'";
                Functions.RunSql(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.getfieldvalues("SELECT Soluong FROM tblHanghoa WHERE Mahang = N'" + MaHangxoa + "'"));
                slmoi = sl - SoLuongxoa;
                sql = "UPDATE tblHanghoa SET SoLuong =" + slmoi + " WHERE MaHang= N'" + MaHangxoa + "'";
                Functions.RunSql(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.getfieldvalues("SELECT Tongtien FROM tblHoadonnhap WHERE SoHDN = N'" + txtMahoadonnhap.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblHoadonnhap SET Tongtien =" + tongmoi + " WHERE SOHDN = N'" + txtMahoadonnhap.Text + "'";
                Functions.RunSql(sql);
                txtTongtien.Text = tongmoi.ToString();
                lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                LoadDataGridViewChitietHDN();
            }
        }

        private void dgridChitietHDN_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgridChitietHDN.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgridChitietHDN.CurrentRow;

                // Gán dữ liệu từ các cột của dòng được chọn vào các điều khiển tương ứng
                cboMahang.Text = selectedRow.Cells["Mahang"].Value.ToString();
                txtTenhang.Text = selectedRow.Cells["Tenhang"].Value.ToString();
                txtSoluong.Text = selectedRow.Cells["Soluong"].Value.ToString();
                txtDongianhap.Text = selectedRow.Cells["Dongianhap"].Value.ToString();
                txtGiamgia.Text = selectedRow.Cells["Giamgia"].Value.ToString();
                txtThanhtien.Text = selectedRow.Cells["Thanhtien"].Value.ToString();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = true;
            cboMahoadonnhap.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Lâm Anh";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Cầu Giấy - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";
            // Biểu diễn thông tin chung của hóa đơn nhập
            sql = "SELECT a.SoHDN, a.Ngaynhap, a.Tongtien, b.TenNCC, b.Diachi, b.Dienthoai, c.TenNV FROM tblHoadonnhap AS a, tblNhacungcap AS b, tblNhanvien AS c WHERE a.SoHDN = N'" + txtMahoadonnhap.Text + "' AND a.MaNCC = b.MaNCC AND a.MaNV =c.MaNV";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn nhập:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tenhang, a.Soluong, b.Dongianhap, a.Giamgia, a.Thanhtien " +
                  "FROM tblChitiethoadonnhap AS a , tblHanghoa AS b WHERE a.SoHDN = N'" + txtMahoadonnhap.Text + "' AND a.Mahang = b.Mahang";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá nhập";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu
 (tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close(); 
            }
        }


        private void ResetValuesHang()
        {
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }
    }
}
