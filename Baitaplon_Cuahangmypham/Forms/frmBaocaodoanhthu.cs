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
    public partial class frmBaocaodoanhthu : Form
    {
        public frmBaocaodoanhthu()
        {
            InitializeComponent();
        }
        DataTable tbldoanhthu;
        private void frmBaocaodoanhthu_Load(object sender, EventArgs e)
        {
            Dgriddoanhthu.DataSource = null;
            rdbxngay.Checked = false;
            rdbxkhoang.Checked = false;
            mskngayban.Visible = false;
            msktungay.Visible = false;
            mskdenngay.Visible = false;
            gbokhoang.Visible = false;
            txttongtien.ReadOnly = true;
            //txttongtien.Text = "0";
            Functions.FillCombo("SELECT Tenhang FROM tblHanghoa", cbotensp, "Tenhang", "Mahang");
            cbotensp.SelectedIndex = -1;

        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";

        }
        private void load_datagridview(string sql)
        {
            tbldoanhthu = Class.Functions.GetDataToTable(sql);
            Dgriddoanhthu.DataSource = tbldoanhthu;
            Dgriddoanhthu.Columns[0].HeaderText = "Tên hàng";
            Dgriddoanhthu.Columns[1].HeaderText = "Số lượng bán";
            Dgriddoanhthu.Columns[2].HeaderText = "Đơn giá";
            Dgriddoanhthu.Columns[3].HeaderText = "Giảm giá";
            Dgriddoanhthu.Columns[4].HeaderText = "Ngày bán";
            Dgriddoanhthu.Columns[5].HeaderText = "Doanh thu";
            Dgriddoanhthu.AllowUserToAddRows = false;
            Dgriddoanhthu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void rdbxngay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbxngay.Checked)
            {
                mskngayban.Visible = true;
                gbokhoang.Visible = false;
            }
            else
            {
                mskngayban.Visible = false;
            }
        }

        private void rdbxkhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbxkhoang.Checked)
            {
                mskngayban.Visible = false;
                gbokhoang.Visible = true;
                msktungay.Visible = true;
                mskdenngay.Visible = true;
            }
            else
            {
                gbokhoang.Visible = false;
            }
        }

        private void frmBaocaodoanhthu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql, sql1;
            if (cbotensp.SelectedValue == null &&
                 mskngayban.Text == "  /  /" &&
                 msktungay.Text == "  /  /" &&
                 mskdenngay.Text == "  /  /" &&
                txtsoluong.Text == "" &&
                txtgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = @"select hh.tenhang, 
                      cthdb.soluong, 
                      hh.dongiaban, 
                      cthdb.giamgia, 
                      hdb.ngayban,
                      case when cthdb.giamgia is null then cthdb.soluong * hh.dongiaban
                           else cthdb.soluong * hh.dongiaban * (1 - cthdb.giamgia)
                      end as doanhthu
               from tblhoadonban hdb 
               JOIN tblChitiethoadonban cthdb ON hdb.SoHDB = cthdb.SoHDB
               JOIN tblHanghoa hh ON cthdb.Mahang = hh.Mahang 
               WHERE 1=1";
            if (cbotensp.SelectedValue != null)
            {
                sql = sql + " and hh.Tenhang = N'" + cbotensp.Text + "'";
            }
            if (txtgia.Text != "")
                sql = sql + " and hh.Dongiaban=" + txtgia.Text + "'";
            if (mskngayban.Text != "  /  /")
            {
                if (!Functions.IsDate(mskngayban.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskngayban.Focus();
                    mskngayban.Text = "";
                    return;
                }
                sql = sql + "and hdb.Ngayban='" + Functions.ConvertDatetime(mskngayban.Text) + "'";
            }
            if (msktungay.Text != "  /  /")
            {
                if (mskdenngay.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập đến ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    return;
                }
            }
            if (mskdenngay.Text != "  /  /")
            {
                if (msktungay.Text == "  /  /")
                {

                    MessageBox.Show("Hãy nhập ngày bắt đầu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    return;
                }
            }
            if (msktungay.Text != "  /  /" && mskdenngay.Text != "  /  /")
            {
                if (!Functions.IsDate(mskdenngay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày cuối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    mskdenngay.Text = "";
                    return;
                }
                if (!Functions.IsDate(msktungay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bắt đầu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    msktungay.Text = "";
                    return;
                }
                if (DateTime.ParseExact(msktungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskdenngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Text = "";
                    msktungay.Text = "";
                    return;
                }
                sql = sql + "and (ngayban between'" + Functions.ConvertDatetime(msktungay.Text) + "' and '" + Functions.ConvertDatetime(mskdenngay.Text) + "')";
            }
            if (txtsoluong.Text != "")
            {
                sql = sql + "and cthdb.Soluong =" + txtsoluong.Text + "";
            }

            sql1 = " where 1=1";
            if (cbotensp.SelectedValue != null)
            {
                sql1 = sql1 + " and hh.Tenhang =N'" + cbotensp.Text + "'";
            }

            if (txtgia.Text != "")
            {
                sql1 = sql1 + " and hh.Dongiaban =" + txtgia.Text + "";
            }
            if (mskngayban.Text != "  /  /")
            {
                if (!Functions.IsDate(mskngayban.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskngayban.Focus();
                    mskngayban.Text = "";
                    return;
                }
                sql1 = sql1 + "and hdb.Ngayban='" + Functions.ConvertDatetime(mskngayban.Text) + "'";
            }
            if (msktungay.Text != "  /  /" && mskdenngay.Text != "  /  /")
            {
                if (!Functions.IsDate(mskdenngay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    mskdenngay.Text = "";
                    return;
                }
                if (!Functions.IsDate(msktungay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bắt đầu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    msktungay.Text = "";
                    return;
                }
                if (DateTime.ParseExact(msktungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskdenngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Text = "";
                    msktungay.Text = "";
                    return;
                }
                sql1 = sql1 + "and (hdb.Ngayban between'" + Functions.ConvertDatetime(msktungay.Text) + "' and '" + Functions.ConvertDatetime(mskdenngay.Text) + "')";
            }

            tbldoanhthu = Class.Functions.GetDataToTable(sql);
            if (tbldoanhthu.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
            {

                MessageBox.Show("Có " + tbldoanhthu.Rows.Count + " bản ghi thỏa mãn điều kiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_datagridview(sql);
                double dt = tbldoanhthu.AsEnumerable().Sum(row => row.Field<double>("doanhthu"));
                txttongtien.Text = dt.ToString("N2");
                lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(dt.ToString());
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            cbotensp.Text = "";
            txtsoluong.Text = "";
            mskdenngay.Text = "  /  /";
            mskngayban.Text = "  /  /";
            msktungay.Text = "  /  /";
            lblbangchu.Text = "";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng cửa sổ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblDoanhThu;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];

            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BÁO CÁO DOANH THU";

            // Lấy thông tin của báo cáo doanh thu
            sql = @"SELECT hh.tenhang, cthdb.soluong, hh.dongiaban, cthdb.giamgia, hdb.ngayban,
            CASE 
                WHEN cthdb.giamgia IS NULL THEN cthdb.soluong * hh.dongiaban
                ELSE cthdb.soluong * hh.dongiaban * (1 - cthdb.giamgia)
            END AS doanhthu
            FROM tblhoadonban hdb 
             JOIN tblChitiethoadonban cthdb ON hdb.SoHDB = cthdb.SoHDB
            JOIN tblHanghoa hh ON cthdb.Mahang = hh.Mahang 
            WHERE 1=1";

            tblDoanhThu = Functions.GetDataToTable(sql);

            // Tạo dòng tiêu đề bảng
            exRange.Range["A5:G5"].Font.Bold = true;
            exRange.Range["A5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:F5"].ColumnWidth = 12;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Tên hàng";
            exRange.Range["C5:C5"].Value = "Số lượng";
            exRange.Range["D5:D5"].Value = "Đơn giá bán";
            exRange.Range["E5:E5"].Value = "Giảm giá";
            exRange.Range["F5:F5"].Value = "Thời gian";
            exRange.Range["G5:G5"].Value = "Doanh Thu";

            // Điền dữ liệu vào bảng
            for (hang = 0; hang < tblDoanhThu.Rows.Count; hang++)
            {
                // Điền số thứ tự vào cột 1 từ dòng 6
                exSheet.Cells[1][hang + 6] = hang + 1;
                for (cot = 0; cot < tblDoanhThu.Columns.Count; cot++)
                {
                    // Điền thông tin hàng từ cột thứ 2, dòng 6
                    exSheet.Cells[cot + 2][hang + 6] = tblDoanhThu.Rows[hang][cot].ToString();
                }
            }

            // Tính tổng doanh thu
            double dt = tbldoanhthu.AsEnumerable().Sum(row => row.Field<double>("doanhthu"));
            exRange = exSheet.Cells[6][tblDoanhThu.Rows.Count + 6];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[7][tblDoanhThu.Rows.Count + 6];
            exRange.Font.Bold = true;
            exRange.Value2 = dt.ToString("C2");

            // Chuyển đổi số thành chữ (giả sử bạn có hàm `ChuyenSoSangChu`)
            exRange = exSheet.Cells[1][tblDoanhThu.Rows.Count + 7];
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(dt.ToString());

            // Ngày tháng
            DateTime currentTime = DateTime.Now;

            DateTime ngayBan = Convert.ToDateTime(tblDoanhThu.Rows[0]["ngayban"]);
            exRange = exSheet.Cells[4][tblDoanhThu.Rows.Count + 9];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + currentTime.Day + " tháng " + currentTime.Month + " năm " + currentTime.Year;

            exRange = exSheet.Cells[4][tblDoanhThu.Rows.Count + 10];
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Quản lý Cửa Hàng";
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }
    }
}
