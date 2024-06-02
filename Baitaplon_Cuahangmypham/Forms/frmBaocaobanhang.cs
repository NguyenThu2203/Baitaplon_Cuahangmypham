using Baitaplon_Cuahangmypham.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel; 

namespace Baitaplon_Cuahangmypham.Forms
{
    public partial class frmBaocaobanhang : Form
    {
        public frmBaocaobanhang()
        {
            InitializeComponent();
        }
        DataTable tblHDB, tblSP;
        private void frmBaocaobanhang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            MessageBox.Show("Ket noi thanh cong:");
            load_datagrid();
            load_datagridsp();
            Functions.FillCombo("select SoHDB from tblHoadonban", cboSoHDB, "SoHDB", "SoHDB");
            Functions.FillCombo("select Tenhang from tblHanghoa", cbotensp, "Tenhang", "Tenhang");
            Functions.FillCombo("select MaKH from tblKhachhang", cbokhachhang, "MaKH", "MaKH");
            Functions.FillCombo("select MaNV from tblNhanvien", cbonhanvien, "MaNV", "MaNV");
            cboSoHDB.SelectedIndex = -1;
            cbokhachhang.SelectedIndex = -1;
            cbonhanvien.SelectedIndex = -1;
            cbotensp.SelectedIndex = -1;
            grbkhoang.Enabled = false;
            msktheongay.Enabled = false;
        }
        private void load_datagrid()
        {
            string sql;
            sql = "select hdb.SoHDB, Tenhang, hh.Mahang, cthdb.Soluong, Dongiaban, Giamgia, Thanhtien,Ngayban,MaKH, MaNV from tblHoadonban hdb join tblChitiethoadonban cthdb on hdb.SoHDB=cthdb.SoHDB join tblHanghoa hh on cthdb.Mahang=hh.Mahang   ";
            tblHDB = Class.Functions.GetDataToTable(sql);
            dgridCTHDB.DataSource = tblHDB;
            dgridCTHDB.Columns[0].HeaderText = "Số HĐB ";
            dgridCTHDB.Columns[1].HeaderText = "Tên hàng ";
            dgridCTHDB.Columns[2].HeaderText = "Mã hàng ";
            dgridCTHDB.Columns[3].HeaderText = "Số lượng bán ";
            dgridCTHDB.Columns[4].HeaderText = "Đơn giá bán ";
            dgridCTHDB.Columns[5].HeaderText = "Giảm giá ";
            dgridCTHDB.Columns[6].HeaderText = "Thành tiền ";
            dgridCTHDB.Columns[7].HeaderText = "Ngày bán ";
            dgridCTHDB.Columns[8].HeaderText = " Mã khách hàng";
            dgridCTHDB.Columns[9].HeaderText = "Mã nhân viên ";

            dgridCTHDB.AllowUserToAddRows = false;
            dgridCTHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void load_datagridsp()
        {
            string sql;
            sql = "select Tenhang, sum(cthdb.Soluong) from tblHanghoa hh join tblChitiethoadonban cthdb on hh.Mahang=cthdb.Mahang group by Tenhang order by sum(cthdb.Soluong) DESC";
            tblSP = Class.Functions.GetDataToTable(sql);
            dgridSP.DataSource = tblSP;
            dgridSP.Columns[0].HeaderText = "Tên hàng ";
            dgridSP.Columns[1].HeaderText = "Số lượng bán";

            dgridSP.AllowUserToAddRows = false;
            dgridSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboSoHDB.SelectedValue == null) && (cbotensp.SelectedValue == null) && (cbokhachhang.SelectedValue == null) && (cbonhanvien.SelectedValue == null) && (txtdongiaban.Text == "") && (msktungay.Text == "  /  /") && (mskdenngay.Text == "  /  /") && (msktheongay.Text == "  /  /"))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "select hdb.SoHDB,Ngayban,MaKH, MaNV, Tenhang, hh.Mahang, cthdb.Soluong, Dongiaban, Giamgia, Thanhtien from tblHoadonban hdb join tblChitiethoadonban cthdb on hdb.SoHDB=cthdb.SoHDB join tblHanghoa hh on cthdb.Mahang=hh.Mahang where 1=1 ";

            if (cboSoHDB.SelectedValue != null)
            {
                sql = sql + " AND hdb.SoHDB= N'" + cboSoHDB.Text + "'";
            }
            if (cbotensp.SelectedValue != null)
            {
                sql = sql + " AND Tenhang= N'" + cbotensp.Text + "'";
            }
            if (cbokhachhang.SelectedValue != null)
            {
                sql = sql + " AND MaKH= N'" + cbokhachhang.Text + "'";
            }
            if (cbonhanvien.SelectedValue != null)
            {
                sql = sql + " AND MaNV = N'" + cbonhanvien.Text + "'";
            }
            if (txtdongiaban.Text != "")
            {
                sql = sql + " AND Dongiaban = '" + txtdongiaban.Text + "'";
            }
            if (msktungay.Text != "  /  /")
            {
                if (mskdenngay.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    return;
                }
            }
            if (mskdenngay.Text != "  /  /")
            {
                if (msktungay.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập từ ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    grbkhoang.Focus();
                    return;
                }
            }
            if (msktungay.Text != "  /  /" && mskdenngay.Text != "  /  /")
            {
                if (!Functions.IsDate(msktungay.Text))
                {
                    MessageBox.Show("Hãy nhập từ ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    return;
                }
                if (!Functions.IsDate(mskdenngay.Text))
                {
                    MessageBox.Show("Hãy nhập đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    return;
                }
                if (DateTime.ParseExact(msktungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskdenngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Text = "";
                    msktungay.Text = "";
                    return;
                }
                sql = sql + " AND (Ngayban between'" + Functions.ConvertDatetime(msktungay.Text) + "' AND '" + Functions.ConvertDatetime(mskdenngay.Text) + "')";
            }
            if (msktheongay.Text != "  /  /")
            {
                if (!Functions.IsDate(msktheongay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktheongay.Focus();
                    msktheongay.Text = "";
                    return;
                }
                sql = sql + " AND Ngayban='" + Functions.ConvertDatetime(msktheongay.Text) + "'";
            }

            tblHDB = Class.Functions.GetDataToTable(sql);
            dgridCTHDB.DataSource = tblHDB;
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalue();
                return;
            }
            else
            {
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalue();
                return;
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng cửa sổ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            load_datagrid();
            resetvalue();
        }

        private void txtdongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rdtheokhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtheokhoang.Checked == true)
                grbkhoang.Enabled = true;
            else
            {
                grbkhoang.Enabled = false;
                msktungay.Text = "";
                mskdenngay.Text = "";
            }
        }

        private void rdtheongay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtheongay.Checked == true)
                msktheongay.Enabled = true;
            else
            {
                msktheongay.Enabled = false;
                msktheongay.Text = "";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;//Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet;//Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            string sql;
            int hang = 0, cot = 0;
            DataTable tblbaocao;
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
            exRange.Range["C2:E2"].Value = "BÁO CÁO BÁN HÀNG";

            // Biểu diễn thông tin chung của chi tiết hóa đơn bán 
            sql = "select hdb.SoHDB, Tenhang, hh.Mahang, cthdb.Soluong, Dongiaban, Giamgia, Thanhtien,Ngayban,MaKH, MaNV from tblHoadonban hdb join tblChitiethoadonban cthdb on hdb.SoHDB=cthdb.SoHDB join tblHanghoa hh on cthdb.Mahang=hh.Mahang   ";
            tblbaocao = Class.Functions.GetDataToTable(sql);

            // Tạo dòng tiêu đề bảng
            exRange.Range["A7:K7"].Font.Bold = true;
            exRange.Range["A7:K7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A8:K8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A9:K9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A10:K10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A10:K10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C7:K7"].ColumnWidth = 25;
            exRange.Range["A7:A7"].Value = "STT";
            exRange.Range["A7:A7"].ColumnWidth = 10;
            exRange.Range["B7:B7"].Value = "Số HĐB";
            exRange.Range["B7:B7"].ColumnWidth = 10;
            exRange.Range["C7:C7"].Value = "Ngày bán ";
            exRange.Range["C7:C7"].ColumnWidth = 15;
            exRange.Range["D7:D7"].Value = "Mã khách hàng ";
            exRange.Range["D7:D7"].ColumnWidth = 15;
            exRange.Range["E7:E7"].Value = "Mã nhân viên ";
            exRange.Range["E7:E7"].ColumnWidth = 15;
            exRange.Range["F7:F7"].Value = "Tên hàng ";
            exRange.Range["F7:F7"].ColumnWidth = 25;
            exRange.Range["G7:G7"].Value = "Mã hàng ";
            exRange.Range["G7:G7"].ColumnWidth = 10;
            exRange.Range["H7:H7"].Value = "Số lượng bán ";
            exRange.Range["H7:H7"].ColumnWidth = 15;
            exRange.Range["I7:I7"].Value = "Đơn giá bán";
            exRange.Range["I7:I7"].ColumnWidth = 10;
            exRange.Range["J7:J7"].Value = "Giảm giá";
            exRange.Range["J7:J7"].ColumnWidth = 10;
            exRange.Range["K7:K7"].Value = "Thành tiền";
            exRange.Range["K7:K7"].ColumnWidth = 10;

            //Điền thông tin của cột Ngày bán 
            for (int row = 0; row < tblHDB.Rows.Count; row++)
            {
                exSheet.Cells[1][row + 8] = row + 1;
                for (int col = 0; col < tblHDB.Columns.Count; col++)
                {
                    if (tblHDB.Columns[col].ColumnName == "Ngayban")
                    {

                        DateTime ngayNhap = Convert.ToDateTime(tblHDB.Rows[row]["Ngayban"]);
                        exSheet.Cells[col + 2][row + 8] = ngayNhap.ToShortDateString();
                    }
                    else
                    {

                        exSheet.Cells[col + 2][row + 8] = tblHDB.Rows[row][col].ToString();
                    }
                }
            }

            // Điền dữ liệu vào bảng
            for (hang = 0; hang < tblHDB.Rows.Count; hang++)
            {
                // Điền số thứ tự vào cột 1 từ dòng 8
                exSheet.Cells[1][hang + 8] = hang + 1;
                for (cot = 0; cot < tblHDB.Columns.Count; cot++)
                {
                    // Điền thông tin hàng từ cột thứ 2, dòng 8
                    exSheet.Cells[cot + 2][hang + 8] = tblHDB.Rows[hang][cot].ToString();
                }
            }
            // Ngày tháng
            DateTime currentTime = DateTime.Now;

            DateTime ngayBan = Convert.ToDateTime(tblHDB.Rows[0]["Ngayban"]);
            exRange = exSheet.Cells[4][tblHDB.Rows.Count + 14];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + currentTime.Day + " tháng " + currentTime.Month + " năm " + currentTime.Year;

            exRange = exSheet.Cells[4][tblHDB.Rows.Count + 15];
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Quản lý Cửa Hàng";
            exSheet.Name = "Báo cáo bán hàng";
            exApp.Visible = true;
        }

        private void resetvalue()
        {
            cboSoHDB.SelectedIndex = -1;
            cbotensp.SelectedIndex = -1;
            cbokhachhang.SelectedIndex = -1;
            cbonhanvien.SelectedIndex = -1;
            txtdongiaban.Text = "";
            msktheongay.Text = "";
            rdtheokhoang.Checked = false;
            rdtheongay.Checked = false;
            grbkhoang.Enabled = false;
            msktheongay.Enabled = false;
            msktungay.Text = "";
            mskdenngay.Text = "";
        }
    }
}
