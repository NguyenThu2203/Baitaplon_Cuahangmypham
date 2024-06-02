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
    public partial class frmHoadonban : Form
    {
        public frmHoadonban()
        {
            InitializeComponent();
        }
        DataTable tblCTHDB;

        private void frmHoadonban_Load(object sender, EventArgs e)
        {
            btnThemhoadon.Enabled = true;
            btnLuuhoadon.Enabled = false;
            btnHuyhoadon.Enabled = false;
            btnInhoadon.Enabled = false;
            txtMahoadon.Enabled = true;
            txtTennhanvien.ReadOnly = true;
            txtTenkhachhang.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            mskNgayban.Enabled = true;
            txtTenhang.ReadOnly = true;
            txtDongiaban.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "";
            btnBoqua.Enabled = false;
            txtTongtien.Text = "0";
            Functions.FillCombo("SELECT MaKH, Tenkhach FROM tblKhachhang", cboMakhachhang, "MaKH", "MaKH");
            cboMakhachhang.SelectedIndex = -1;

            Functions.FillCombo("SELECT MaNV, TenNV FROM tblNhanvien", cboManhanvien, "MaNV", "MaNV");
            cboManhanvien.SelectedIndex = -1;
            Functions.FillCombo("SELECT Mahang, Tenhang FROM tblHanghoa", cboMahang, "Mahang", "Mahang");
            cboMahang.SelectedIndex = -1;
            Functions.FillCombo("SELECT SoHDB FROM tblChitiethoadonban", cboMahoadonban, "SoHDB", "SoHDB");
            cboMahoadonban.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMahoadon.Text != "")
            {
                Load_ThongtinHD();
                btnHuyhoadon.Enabled = true;
                btnInhoadon.Enabled = true;
            }
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT a.Mahang, b.Tenhang, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien FROM tblChitiethoadonban AS a, tblHanghoa AS b WHERE a.SoHDB = N'" + txtMahoadon.Text + "' AND a.Mahang=b.Mahang";
            tblCTHDB = Functions.GetDataToTable(sql);
            dgridChitiethoadonban.DataSource = tblCTHDB;

            dgridChitiethoadonban.Columns[0].HeaderText = "Mã hàng";
            dgridChitiethoadonban.Columns[1].HeaderText = "Tên hàng";
            dgridChitiethoadonban.Columns[2].HeaderText = "Số lượng";
            dgridChitiethoadonban.Columns[3].HeaderText = "Đơn giá";
            dgridChitiethoadonban.Columns[4].HeaderText = "Giảm giá %";
            dgridChitiethoadonban.Columns[5].HeaderText = "Thành tiền";
            dgridChitiethoadonban.AllowUserToAddRows = false;
            dgridChitiethoadonban.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // nạp chi tiết hóa đơn khi chọn cboMahoadonban
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT Ngayban FROM tblHoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "'";
            mskNgayban.Text = Functions.ConvertDatetime(Functions.getfieldvalues(str));
            str = "SELECT MaNV FROM tblHoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "'";
            cboManhanvien.Text = Functions.getfieldvalues(str);

            str = "SELECT MaKH FROM tblHoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "'";
            cboMakhachhang.Text = Functions.getfieldvalues(str);

            str = "SELECT Tongtien FROM tblHoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "'";
            txtTongtien.Text = Functions.getfieldvalues(str);

            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongtien.Text);
        }

        private void ResetValues()
        {
            txtMahoadon.Text = "";
            mskNgayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //mskNgayban.Text = DateTime.Now.ToShortDateString();
            txtTennhanvien.Text = "";
            txtTenkhachhang.Text = "";
            mskDienthoai.Text = "";
            txtDiachi.Text = "";
            cboManhanvien.Text = "";
            cboMakhachhang.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMahang.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "";
            txtThanhtien.Text = "0";
        }

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboManhanvien.SelectedItem != null)
            {
                txtTennhanvien.Text = Class.Functions.getfieldvalues("select TenNV from tblNhanvien WHERE MaNV= N'" + cboManhanvien.SelectedValue + "'");
            }
        }

        private void cboMakhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMakhachhang.SelectedItem != null)
            {
                txtTenkhachhang.Text = Class.Functions.getfieldvalues("select Tenkhach from tblKhachhang WHERE MaKH= N'" + cboMakhachhang.SelectedValue + "'");
                txtDiachi.Text = Class.Functions.getfieldvalues("select Diachi from tblKhachhang WHERE MaKH= N'" + cboMakhachhang.SelectedValue + "'");
                mskDienthoai.Text = Class.Functions.getfieldvalues("select Dienthoai from tblKhachhang WHERE MaKH= N'" + cboMakhachhang.SelectedValue + "'");
            }
        }

        private void cboMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBoqua.Enabled = true;
            btnDong.Enabled = true;
            txtGiamgia.Enabled = false;
            txtThanhtien.Enabled = false;
            if (cboMahang.SelectedItem != null)
            {
                txtDongiaban.Text = Class.Functions.getfieldvalues("select Dongiaban from tblHanghoa WHERE Mahang= N'" + cboMahang.SelectedValue + "'");
                txtTenhang.Text = Class.Functions.getfieldvalues("select Tenhang from tblHanghoa WHERE Mahang= N'" + cboMahang.SelectedValue + "'");
                txtGiamgia.Text = Class.Functions.getfieldvalues("select Giamgia from tblChitiethoadonban WHERE Mahang= N'" + cboMahang.SelectedValue + "'");
                if (txtGiamgia.Text == "")
                {
                    txtGiamgia.Text = "0";
                    txtGiamgia.Focus();
                    return;
                }
            }
        }
        //thêm hàng vào datagridview
        private void ResetValuesHang()
        {
            cboMahang.Text = "";
            txtTenhang.Text = "";
            txtDongiaban.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "";
            txtThanhtien.Text = "0";

        }

        private void dgridChitiethoadonban_Click(object sender, EventArgs e)
        {
            cboMahang.Text = dgridChitiethoadonban.CurrentRow.Cells["Mahang"].Value.ToString();
            txtTenhang.Text = dgridChitiethoadonban.CurrentRow.Cells["Tenhang"].Value.ToString();
            txtDongiaban.Text = dgridChitiethoadonban.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtSoluong.Text = dgridChitiethoadonban.CurrentRow.Cells["Soluong"].Value.ToString();
            txtGiamgia.Text = dgridChitiethoadonban.CurrentRow.Cells["Giamgia"].Value.ToString();
            txtThanhtien.Text = dgridChitiethoadonban.CurrentRow.Cells["Thanhtien"].Value.ToString();
            btnBoqua.Enabled = true;
        }

        private void btnThemhoadon_Click(object sender, EventArgs e)
        {
            btnHuyhoadon.Enabled = true;
            btnLuuhoadon.Enabled = true;
            btnInhoadon.Enabled = true;
            btnThemhoadon.Enabled = false;
            ResetValues();
            ResetValuesHang();
            txtMahoadon.Text = Functions.CreateKey("ORD");
        }

        private void btnLuuhoadon_Click(object sender, EventArgs e)
        {

            {
                string sql;
                int sl, slcon, tong, tongmoi;
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboMakhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMakhachhang.Focus();
                    return;
                }

                sql = "INSERT INTO tblHoadonban(SoHDB, Ngayban, MaNV, MaKH, Tongtien) VALUES (N'" + txtMahoadon.Text.Trim() + "','" + Functions.ConvertDatetime(mskNgayban.Text.Trim()) + "',N'" + cboManhanvien.SelectedValue + "',N'" + cboMakhachhang.SelectedValue + "'," + txtTongtien.Text + ")";
                Functions.RunSql(sql);

                if (cboMahang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMahang.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoluong.Focus();
                    return;

                }
                sql = "SELECT Mahang FROM tblChitiethoadonban WHERE Mahang=N'" + cboMahang.SelectedValue + "' AND SoHDB = N'" + txtMahoadon.Text.Trim() + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValuesHang();
                    cboMahang.Focus();
                    return;
                }

                sl = Convert.ToInt32(Functions.getfieldvalues("SELECT Soluong FROM tblHanghoa WHERE Mahang = N'" + cboMahang.SelectedValue + "'"));
                if (Convert.ToInt32(txtSoluong.Text) > sl)
                {
                    MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoluong.Text = "";
                    txtSoluong.Focus();
                    return;
                }
                sql = "INSERT INTO tblChitiethoadonban(SoHDB,Mahang,Soluong, Giamgia,Thanhtien) VALUES(N'" + txtMahoadon.Text.Trim() + "',N'" + cboMahang.SelectedValue + "'," + txtSoluong.Text + "," + txtGiamgia.Text + "," + txtThanhtien.Text + ")";
                Functions.RunSql(sql);
                Load_DataGridView();

                // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
                slcon = sl - Convert.ToInt32(txtSoluong.Text);
                sql = "UPDATE tblHanghoa SET Soluong =" + slcon + " WHERE Mahang= N'" + cboMahang.SelectedValue + "'";
                Functions.RunSql(sql);

                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToInt32(Functions.getfieldvalues("SELECT Tongtien FROM tblHoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "'"));
                tongmoi = tong + Convert.ToInt32(txtThanhtien.Text);

                sql = "UPDATE tblHoadonban SET Tongtien =" + tongmoi + " WHERE SoHDB = N'" + txtMahoadon.Text + "'";
                Functions.RunSql(sql);
                txtTongtien.Text = tongmoi.ToString();


                lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                ResetValuesHang();
                btnInhoadon.Enabled = true;

            }
        }

        private void btnHuyhoadon_Click(object sender, EventArgs e)
        {
            ResetValues();
            ResetValuesHang();
            Load_DataGridView();
            btnThemhoadon.Enabled = true;
            mskNgayban.Text = "";
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            //sql = "SELECT a.SoHDB, a.Ngayban, a.Tongtien, b.Tenkhach, b.Diachi, b.Dienthoai, c.TenNV FROM tblHoadonban AS a, tblKhachhang AS b. tblNhanvien AS c WHERE a.SoHDB = N'" + txtMahoadon.Text + "' AND a.MaKH = b.MaKH AND a.MaNV = c.MaNV";
            sql = "SELECT a.SoHDB, a.Ngayban, a.Tongtien, b.Tenkhach, b.Diachi, b.Dienthoai, c.TenNV FROM tblHoadonban AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.SoHDB = N'" + txtMahoadon.Text + "' AND a.MaKH = b.MaKH AND a.MaNV =c.MaNV";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tenhang, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien " + "FROM tblChitiethoadonban AS a , tblHanghoa AS b WHERE a.SoHDB = N'" + txtMahoadon.Text + "' AND a.Mahang = b.Mahang";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
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
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMahoadonban_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT SoHDB FROM tblHoadonban", cboMahoadonban, "SoHDB", "SoHDB");
            cboMahoadonban.SelectedIndex = -1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMahoadonban.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMahoadonban.Focus();
                return;
            }
            txtMahoadon.Text = cboMahoadonban.Text;
            Load_ThongtinHD();
            Load_DataGridView();
            btnHuyhoadon.Enabled = true;
            btnLuuhoadon.Enabled = true;
            btnInhoadon.Enabled = true;
            cboMahoadonban.SelectedIndex = -1;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValuesHang();
            btnBoqua.Enabled = false;
            cboMahang.Enabled = true;
        }

        private void dgridChitiethoadonban_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahang;
            double thanhtien;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahang = dgridChitiethoadonban.CurrentRow.Cells["Mahang"].Value.ToString();
                DelHang(txtMahoadon.Text, mahang);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                thanhtien = Convert.ToDouble(dgridChitiethoadonban.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtMahoadon.Text, thanhtien);
                Load_DataGridView();
            }
        }
        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT Soluong FROM tblChitiethoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "' AND Mahang = N'" + cboMahang.SelectedValue + "'";
            s = Convert.ToDouble(Functions.getfieldvalues(sql));
            sql = "DELETE tblChitiethoadonban WHERE SoHDB=N'" + txtMahoadon.Text + "' AND Mahang = N'" + cboMahang.SelectedValue + "'";
            Functions.RunSql(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT Soluong FROM tblHanghoa WHERE Mahang = N'" + cboMahang.SelectedValue + "'";
            sl = Convert.ToDouble(Functions.getfieldvalues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblHanghoa SET Soluong =" + SLcon + " WHERE Mahang= N'" + cboMahang.SelectedValue + "'";
            Functions.RunSql(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHoadonban WHERE SoHDB = N'" + txtMahoadon.Text + "'";
            Tong = Convert.ToDouble(Functions.getfieldvalues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHoadonban SET Tongtien =" + Tongmoi + " WHERE SoHDB = N'" + txtMahoadon.Text + "'";
            Functions.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt = 0;
            double sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongiaban.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongiaban.Text);
            tt = sl * dg * (1 - gg);
            txtThanhtien.Text = tt.ToString();
        }
    }
}
