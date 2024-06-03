namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmHoadonban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cboMahoadonban = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btnLuuhoadon = new System.Windows.Forms.Button();
            this.btnHuyhoadon = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThemhoadon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.lblKichdup = new System.Windows.Forms.Label();
            this.dgridChitiethoadonban = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cboMahang = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskNgayban = new System.Windows.Forms.MaskedTextBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.cboMakhachhang = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridChitiethoadonban)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(488, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(523, 1129);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(145, 38);
            this.btnTimkiem.TabIndex = 30;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cboMahoadonban
            // 
            this.cboMahoadonban.FormattingEnabled = true;
            this.cboMahoadonban.Location = new System.Drawing.Point(279, 1129);
            this.cboMahoadonban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMahoadonban.Name = "cboMahoadonban";
            this.cboMahoadonban.Size = new System.Drawing.Size(201, 33);
            this.cboMahoadonban.TabIndex = 29;
            this.cboMahoadonban.DropDown += new System.EventHandler(this.cboMahoadonban_DropDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 1132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "Mã hóa đơn bán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.btnLuuhoadon);
            this.groupBox2.Controls.Add(this.btnHuyhoadon);
            this.groupBox2.Controls.Add(this.btnInhoadon);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnThemhoadon);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblBangchu);
            this.groupBox2.Controls.Add(this.lblKichdup);
            this.groupBox2.Controls.Add(this.dgridChitiethoadonban);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(35, 384);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1252, 741);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(899, 556);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(181, 31);
            this.txtTongtien.TabIndex = 22;
            // 
            // btnLuuhoadon
            // 
            this.btnLuuhoadon.Location = new System.Drawing.Point(301, 664);
            this.btnLuuhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuhoadon.Name = "btnLuuhoadon";
            this.btnLuuhoadon.Size = new System.Drawing.Size(145, 49);
            this.btnLuuhoadon.TabIndex = 24;
            this.btnLuuhoadon.Text = "Lưu hóa đơn";
            this.btnLuuhoadon.UseVisualStyleBackColor = true;
            this.btnLuuhoadon.Click += new System.EventHandler(this.btnLuuhoadon_Click);
            // 
            // btnHuyhoadon
            // 
            this.btnHuyhoadon.Location = new System.Drawing.Point(485, 664);
            this.btnHuyhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyhoadon.Name = "btnHuyhoadon";
            this.btnHuyhoadon.Size = new System.Drawing.Size(195, 49);
            this.btnHuyhoadon.TabIndex = 23;
            this.btnHuyhoadon.Text = "Hủy hóa đơn";
            this.btnHuyhoadon.UseVisualStyleBackColor = true;
            this.btnHuyhoadon.Click += new System.EventHandler(this.btnHuyhoadon_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Location = new System.Drawing.Point(744, 664);
            this.btnInhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(195, 49);
            this.btnInhoadon.TabIndex = 22;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(992, 664);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(153, 49);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThemhoadon
            // 
            this.btnThemhoadon.Location = new System.Drawing.Point(59, 664);
            this.btnThemhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemhoadon.Name = "btnThemhoadon";
            this.btnThemhoadon.Size = new System.Drawing.Size(195, 49);
            this.btnThemhoadon.TabIndex = 20;
            this.btnThemhoadon.Text = "Thêm hóa đơn";
            this.btnThemhoadon.UseVisualStyleBackColor = true;
            this.btnThemhoadon.Click += new System.EventHandler(this.btnThemhoadon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tổng tiền";
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBangchu.Location = new System.Drawing.Point(69, 582);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(115, 25);
            this.lblBangchu.TabIndex = 17;
            this.lblBangchu.Text = "Bằng chữ: ";
            // 
            // lblKichdup
            // 
            this.lblKichdup.AutoSize = true;
            this.lblKichdup.ForeColor = System.Drawing.Color.Red;
            this.lblKichdup.Location = new System.Drawing.Point(69, 538);
            this.lblKichdup.Name = "lblKichdup";
            this.lblKichdup.Size = new System.Drawing.Size(316, 25);
            this.lblKichdup.TabIndex = 18;
            this.lblKichdup.Text = "Kích đúp một dòng hàng để xóa";
            // 
            // dgridChitiethoadonban
            // 
            this.dgridChitiethoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridChitiethoadonban.Location = new System.Drawing.Point(19, 262);
            this.dgridChitiethoadonban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgridChitiethoadonban.Name = "dgridChitiethoadonban";
            this.dgridChitiethoadonban.RowHeadersWidth = 82;
            this.dgridChitiethoadonban.RowTemplate.Height = 33;
            this.dgridChitiethoadonban.Size = new System.Drawing.Size(1208, 252);
            this.dgridChitiethoadonban.TabIndex = 3;
            this.dgridChitiethoadonban.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridChitiethoadonban_CellDoubleClick);
            this.dgridChitiethoadonban.Click += new System.EventHandler(this.dgridChitiethoadonban_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBoqua);
            this.panel3.Controls.Add(this.txtThanhtien);
            this.panel3.Controls.Add(this.txtDongiaban);
            this.panel3.Controls.Add(this.txtGiamgia);
            this.panel3.Controls.Add(this.txtTenhang);
            this.panel3.Controls.Add(this.txtSoluong);
            this.panel3.Controls.Add(this.cboMahang);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1246, 214);
            this.panel3.TabIndex = 1;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(1073, 145);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(149, 49);
            this.btnBoqua.TabIndex = 27;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(1020, 79);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(181, 31);
            this.txtThanhtien.TabIndex = 21;
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(1021, 25);
            this.txtDongiaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(181, 31);
            this.txtDongiaban.TabIndex = 20;
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Location = new System.Drawing.Point(605, 76);
            this.txtGiamgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(181, 31);
            this.txtGiamgia.TabIndex = 19;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(605, 19);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(181, 31);
            this.txtTenhang.TabIndex = 18;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(227, 72);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(181, 31);
            this.txtSoluong.TabIndex = 17;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            // 
            // cboMahang
            // 
            this.cboMahang.FormattingEnabled = true;
            this.cboMahang.Location = new System.Drawing.Point(227, 18);
            this.cboMahang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMahang.Name = "cboMahang";
            this.cboMahang.Size = new System.Drawing.Size(181, 33);
            this.cboMahang.TabIndex = 6;
            this.cboMahang.SelectedIndexChanged += new System.EventHandler(this.cboMahang_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(92, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 25);
            this.label16.TabIndex = 5;
            this.label16.Text = "Số lượng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tên hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Giảm giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(879, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Đơn giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(871, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskNgayban);
            this.groupBox1.Controls.Add(this.mskDienthoai);
            this.groupBox1.Controls.Add(this.cboMakhachhang);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.cboManhanvien);
            this.groupBox1.Controls.Add(this.txtMahoadon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(84, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1139, 271);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // mskNgayban
            // 
            this.mskNgayban.Location = new System.Drawing.Point(221, 92);
            this.mskNgayban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskNgayban.Mask = "00/00/0000";
            this.mskNgayban.Name = "mskNgayban";
            this.mskNgayban.Size = new System.Drawing.Size(231, 31);
            this.mskNgayban.TabIndex = 17;
            this.mskNgayban.ValidatingType = typeof(System.DateTime);
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(813, 202);
            this.mskDienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(231, 31);
            this.mskDienthoai.TabIndex = 16;
            // 
            // cboMakhachhang
            // 
            this.cboMakhachhang.FormattingEnabled = true;
            this.cboMakhachhang.Location = new System.Drawing.Point(813, 39);
            this.cboMakhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMakhachhang.Name = "cboMakhachhang";
            this.cboMakhachhang.Size = new System.Drawing.Size(231, 33);
            this.cboMakhachhang.TabIndex = 15;
            this.cboMakhachhang.SelectedIndexChanged += new System.EventHandler(this.cboMakhachhang_SelectedIndexChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(813, 148);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(231, 31);
            this.txtDiachi.TabIndex = 13;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(813, 92);
            this.txtTenkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(231, 31);
            this.txtTenkhachhang.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Số điện thoại";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(221, 196);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(231, 31);
            this.txtTennhanvien.TabIndex = 10;
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(221, 145);
            this.cboManhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(231, 33);
            this.cboManhanvien.TabIndex = 9;
            this.cboManhanvien.SelectedIndexChanged += new System.EventHandler(this.cboManhanvien_SelectedIndexChanged);
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(221, 41);
            this.txtMahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(231, 31);
            this.txtMahoadon.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn bán";
            // 
            // frmHoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1351, 1211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboMahoadonban);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoadonban";
            this.Text = "Hoadonban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoadonban_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridChitiethoadonban)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMahoadonban;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnLuuhoadon;
        private System.Windows.Forms.Button btnHuyhoadon;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThemhoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.Label lblKichdup;
        private System.Windows.Forms.DataGridView dgridChitiethoadonban;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cboMahang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskNgayban;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.ComboBox cboMakhachhang;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}