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
    public partial class frmTimkiemHDN : Form
    {
        public frmTimkiemHDN()
        {
            InitializeComponent();
        }
        DataTable tblHDN;
        private void frmTimkiemHDN_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgridTimhoadonnhap.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMahoadonnhap.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahoadonnhap.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtManhanvien.Text == "") && (txtManhacungcap.Text == "") &&
               (txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHoadonnhap WHERE 1=1";
            if (txtMahoadonnhap.Text != "")
                sql = sql + " AND SoHDN Like N'%" + txtMahoadonnhap.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(Ngaynhap) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(Ngaynhap) =" + txtNam.Text;
            if (txtManhanvien.Text != "")
                sql = sql + " AND Manhanvien Like N'%" + txtManhanvien.Text + "%'";
            if (txtManhacungcap.Text != "")
                sql = sql + " AND MaNCC Like N'%" + txtManhacungcap.Text + "%'";
            if (txtTongtien.Text != "")
                sql = sql + " AND Tongtien <=" + txtTongtien.Text;
            tblHDN = Functions.GetDataToTable(sql);
            if (tblHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridTimhoadonnhap.DataSource = tblHDN;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            dgridTimhoadonnhap.Columns[0].HeaderText = "Số hóa đơn nhập";
            dgridTimhoadonnhap.Columns[1].HeaderText = "Mã nhân viên";
            dgridTimhoadonnhap.Columns[2].HeaderText = "Ngày nhập";
            dgridTimhoadonnhap.Columns[3].HeaderText = "Mã nhà cung cấp";
            dgridTimhoadonnhap.Columns[4].HeaderText = "Tổng tiền";
            dgridTimhoadonnhap.AllowUserToAddRows = false;
            dgridTimhoadonnhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridTimhoadonnhap.DataSource = null;
        }

        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgridTimhoadonnhap_DoubleClick(object sender, EventArgs e)
        {
            string mahd = dgridTimhoadonnhap.CurrentRow.Cells["SoHDN"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgridTimhoadonnhap.CurrentRow.Cells["SoHDN"].Value.ToString();
                frmHoadonnhap frm = new frmHoadonnhap();
                txtMahoadonnhap.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
