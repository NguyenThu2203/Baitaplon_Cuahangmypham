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
    public partial class frmTracuuHH : Form
    {
        public frmTracuuHH()
        {
            InitializeComponent();
        }

        private void frmTracuuHH_Load(object sender, EventArgs e)
        {
            cboMahang.Enabled = true;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Class.Functions.FillCombo("SELECT Mahang, Tenhang FROM tblHanghoa", cboMahang, "Mahang", "Tenhang");
            cboMahang.SelectedIndex = -1;
            cboMaloai.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Maloai, Tenloai FROM tblLoai", cboMaloai, "Maloai", "TenLoai");
            cboMaloai.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Mahangsx, Tenhangsx FROM tblHangsanxuat", cboMahangsx, "Mahangsx", "Tenhangsx");
            cboMahangsx.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Macongdung, Tencongdung FROM tblCongdung", cboMacongdung, "Macongdung", "Tencongdung");
            cboMacongdung.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Mamua, Tenmua FROM tblMua", cboMamua, "Mamua", "Tenmua");
            cboMamua.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT Manuocsx, Tennuocsx FROM tblNuocsanxuat", cboManuocSX, "Manuocsx", "Tennuocsx");
            cboManuocSX.SelectedIndex = -1;
            btnBoqua.Enabled = false;
            cboMahang.Focus(); 
        }
        DataTable tblHH;
        private void Load_DataGridView()
        {
            string sql;
            sql = "Select Mahang, TenHang, Maloai, Makhoiluong, Mahangsx, Machatlieu, Macongdung, Mamua, Mamau, ManuocSX, Soluong, Thoigianbaohanh,Dongianhap,Dongiaban from tblHanghoa";
            tblHH = Class.Functions.GetDataToTable(sql);
            dgridTracuuHH.DataSource = tblHH;
            dgridTracuuHH.Columns[0].HeaderText = "Mã hàng";
            dgridTracuuHH.Columns[1].HeaderText = "Tên hàng";
            dgridTracuuHH.Columns[2].HeaderText = "Mã loại";
            dgridTracuuHH.Columns[3].HeaderText = "Mã khối lượng";
            dgridTracuuHH.Columns[4].HeaderText = "Hãng sản xuất";
            dgridTracuuHH.Columns[5].HeaderText = "Chất liệu";
            dgridTracuuHH.Columns[6].HeaderText = "Công dụng";
            dgridTracuuHH.Columns[7].HeaderText = "Mùa";
            dgridTracuuHH.Columns[8].HeaderText = "Màu";
            dgridTracuuHH.Columns[9].HeaderText = "Nước SX";
            dgridTracuuHH.Columns[10].HeaderText = "Số lượng";
            dgridTracuuHH.Columns[11].HeaderText = "Thời gian bảo hành";
            dgridTracuuHH.Columns[12].HeaderText = "Đơn giá nhập";
            dgridTracuuHH.Columns[13].HeaderText = "Đơn giá bán";
            dgridTracuuHH.AllowUserToAddRows = false;
            dgridTracuuHH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMahang.Text == "") && (cboMaloai.Text == "") && (cboMacongdung.Text == "") && (cboMahangsx.Text == "")&&(cboManuocSX.Text == "") && (cboMamua.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu nhập điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHanghoa WHERE 1=1";
            if (cboMahang.Text != "")
                sql = sql + " AND Mahang Like N'%" + cboMahang.SelectedValue.ToString() + "%'";
            if (cboMaloai.Text != "")
                sql = sql + " AND Maloai Like N'%" + cboMaloai.SelectedValue.ToString() + "%'";
            if (cboMacongdung.Text != "")
                sql = sql + " AND Macongdung Like N'%" + cboMacongdung.SelectedValue.ToString() + "%'";
            if (cboMahangsx.Text != "")
                sql = sql + " AND Mahangsx Like N'%" + cboMahangsx.SelectedValue.ToString() + "%'";
            if (cboManuocSX.Text != "")
                sql = sql + " AND ManuocSX Like N'%" + cboManuocSX.SelectedValue.ToString() + "%'";
            if (cboMamua.Text != "")
                sql = sql + " AND Mamua Like N'%" + cboMamua.SelectedValue.ToString() + "%'";
            tblHH = Functions.GetDataToTable(sql);
            if (tblHH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblHH.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridTracuuHH.DataSource = tblHH;
            btnTimkiem.Enabled = false;
            btnBoqua.Enabled = true;
            cboManuocSX.Enabled = false;
            cboMamua.Enabled = false;
            cboMahang.Enabled = false;
            cboMahangsx.Enabled = false;
            cboMaloai.Enabled = false;
            cboMacongdung.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetValues();
            btnBoqua.Enabled = false;
            btnTimkiem.Enabled = true;
            cboManuocSX.Enabled = true;
            cboMamua.Enabled = true;
            cboMahang.Enabled = true;
            cboMahangsx.Enabled = true;
            cboMaloai.Enabled = true;
            cboMacongdung.Enabled = true; 
        }
        private void resetValues()
        {
            cboMahang.Text = "";
            cboMahangsx.Text = "";
            cboMacongdung.Text = "";
            cboMaloai.Text = "";
            cboMamua.Text = "";
            cboManuocSX.Text = ""; 
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
