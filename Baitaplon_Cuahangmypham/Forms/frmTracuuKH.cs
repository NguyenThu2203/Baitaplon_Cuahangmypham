﻿using System;
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
    public partial class frmTracuuKH : Form
    {
        public frmTracuuKH()
        {
            InitializeComponent();
        }
        DataTable tblTKKH;

        private void frmTracuuKH_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            //MessageBox.Show("Kết nối thành công");
            resetvalue();
            load_datagrid();
        }
        private void resetvalue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            mskdienthoai.Text = "";
            txtMaKH.Focus();
        }
        private void load_datagrid()
        {
            string sql;
            sql = "Select * from tblKhachhang";
            tblTKKH = Class.Functions.GetDataToTable(sql);
            dgridTimkiemkH.DataSource = tblTKKH;

            dgridTimkiemkH.Columns[0].HeaderText = "Mã khách hàng";
            dgridTimkiemkH.Columns[1].HeaderText = "Tên khách hàng";
            dgridTimkiemkH.Columns[2].HeaderText = "Số điện thoại";
            dgridTimkiemkH.Columns[3].HeaderText = "Địa chỉ";
            dgridTimkiemkH.AllowUserToAddRows = false;
            dgridTimkiemkH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaKH.Text == "") && (txtTenKH.Text == "") && (txtDiachi.Text == "") && (mskdienthoai.Text == "(   )    -"))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "SELECT * FROM tblKhachhang WHERE 1=1";
            if (txtMaKH.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtMaKH.Text.Trim().ToString() + "%'";
            if (txtTenKH.Text != "")
                sql = sql + " AND Tenkhach Like N'%" + txtTenKH.Text.Trim().ToString() + "%'";
            if (txtDiachi.Text != "")
                sql = sql + " AND Diachi Like N'%" + txtDiachi.Text.Trim().ToString() + "%'";
            if (mskdienthoai.Text != "(   )    -")
                sql = sql + " AND Dienthoai Like N'%" + mskdienthoai.Text.ToString() + "%'";

            tblTKKH = Class.Functions.GetDataToTable(sql);
            dgridTimkiemkH.DataSource = tblTKKH;

            if (tblTKKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalue();
            }
            else
                MessageBox.Show("Có " + tblTKKH.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiachi.Enabled = false;
            mskdienthoai.Enabled = false;
            resetvalue();
        }

        private void btnTimkiemlai_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiachi.Enabled = true;
            mskdienthoai.Enabled = true;
            resetvalue();
            load_datagrid();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
