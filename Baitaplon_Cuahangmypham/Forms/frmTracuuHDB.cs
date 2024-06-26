﻿using Baitaplon_Cuahangmypham.Class;
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
    public partial class frmTracuuHDB : Form
    {
        public frmTracuuHDB()
        {
            InitializeComponent();
        }
        DataTable tblHDB;

        private void frmTracuuHDB_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgridTimhoadonban.DataSource = null;

        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMahoadonban.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahoadonban.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&(txtManhanvien.Text == "") && (txtMahoadonban.Text == "") &&(txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHoadonban WHERE 1=1";
            if (txtMahoadonban.Text != "")
                sql = sql + " AND SoHDB Like N'%" + txtMahoadonban.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(Ngayban) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(Ngayban) =" + txtNam.Text;
            if (txtManhanvien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtManhanvien.Text + "%'";
            if (txtMakhachhang.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtMakhachhang.Text + "%'";
            if (txtTongtien.Text != "")
                sql = sql + " AND Tongtien <=" + txtTongtien.Text;
            tblHDB = Functions.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridTimhoadonban.DataSource = tblHDB;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            dgridTimhoadonban.Columns[0].HeaderText = "Mã HĐB";
            dgridTimhoadonban.Columns[1].HeaderText = "Mã nhân viên";
            dgridTimhoadonban.Columns[2].HeaderText = "Ngày bán";
            dgridTimhoadonban.Columns[3].HeaderText = "Mã khách";
            dgridTimhoadonban.Columns[4].HeaderText = "Tổng tiền";
            dgridTimhoadonban.AllowUserToAddRows = false;
            dgridTimhoadonban.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridTimhoadonban.DataSource = null;

        }
        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgridTimhoadonban_DoubleClick(object sender, EventArgs e)
        {
            string mahdb = dgridTimhoadonban.CurrentRow.Cells["SoHDB"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahdb = dgridTimhoadonban.CurrentRow.Cells["SoHDB"].Value.ToString();
                frmHoadonban frm = new frmHoadonban();
                frm.getMahoadon(mahdb);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
