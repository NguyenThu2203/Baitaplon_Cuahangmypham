using Baitaplon_Cuahangmypham.Class;
using Baitaplon_Cuahangmypham.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon_Cuahangmypham
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            //MessageBox.Show("Kết nối thành công"); 
        }

        private void mnuCongdung_Click(object sender, EventArgs e)
        {
            Forms.frmCongdung a  = new Forms.frmCongdung();
            a.Show(); 
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            Forms.frmChatlieu a = new Forms.frmChatlieu();
            a.Show();
        }

        private void mnuLoai_Click(object sender, EventArgs e)
        {
            Forms.frmLoai a = new Forms.frmLoai();
            a.Show();
        }

        private void mnuHangsx_Click(object sender, EventArgs e)
        {
            Forms.frmHangsanxuat a = new Forms.frmHangsanxuat(); 
            a.Show();
        }

        private void mnuNuocsx_Click(object sender, EventArgs e)
        {
            Forms.frmNuocsanxuat a = new Forms.frmNuocsanxuat(); 
            a.Show();
        }

        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            frmHanghoa a = new frmHanghoa();
            a.Show(); 
        }

        private void mnuDanhmucHDB_Click(object sender, EventArgs e)
        {
            frmHoadonban a = new frmHoadonban();
            a.Show();
        }


        private void mnuTracuuhang_Click(object sender, EventArgs e)
        {
            frmTracuuHH a = new frmTracuuHH();
            a.Show(); 
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien a = new frmNhanvien();
            a.Show();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            //frmkhach a = new frmkhach();
            //a.Show();
        }

        private void mnuBaocaoDT_Click(object sender, EventArgs e)
        {
            frmBaocaodoanhthu a = new frmBaocaodoanhthu();
            a.Show();
        }
        private void mnuBaocaoBH_Click(object sender, EventArgs e)
        {
            frmBaocaobanhang a = new frmBaocaobanhang();
            a.Show();
        }

        private void mnuTracuuKH_Click(object sender, EventArgs e)
        {
            frmTracuuKH a = new frmTracuuKH();
        }
        private void mnuDanhmucHDN_Click(object sender, EventArgs e)
        {
            frmHoadonnhap a = new frmHoadonnhap();
            a.Show(); 
        }

    }
}
