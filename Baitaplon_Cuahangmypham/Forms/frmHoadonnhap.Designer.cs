namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmHoadonnhap
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cboMahoadonnhap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.cboMahang = new System.Windows.Forms.ComboBox();
            this.dgridChitietHDN = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMahoadonnhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgridHDN = new System.Windows.Forms.DataGridView();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.mskNgaynhap = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTennhacungcap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboManhacungcap = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridChitietHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(487, 904);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(93, 48);
            this.btnTimkiem.TabIndex = 42;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cboMahoadonnhap
            // 
            this.cboMahoadonnhap.FormattingEnabled = true;
            this.cboMahoadonnhap.Location = new System.Drawing.Point(207, 914);
            this.cboMahoadonnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMahoadonnhap.Name = "cboMahoadonnhap";
            this.cboMahoadonnhap.Size = new System.Drawing.Size(245, 28);
            this.cboMahoadonnhap.TabIndex = 41;
            this.cboMahoadonnhap.DropDown += new System.EventHandler(this.cboMahoadonnhap_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 918);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Mã hóa đơn nhập";
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(431, 354);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 52);
            this.btnBoqua.TabIndex = 60;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBoqua);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtDongianhap);
            this.groupBox2.Controls.Add(this.txtGiamgia);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.txtTenhang);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.lblBangchu);
            this.groupBox2.Controls.Add(this.cboMahang);
            this.groupBox2.Controls.Add(this.dgridChitietHDN);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(56, 465);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1149, 431);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(840, 82);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(175, 26);
            this.txtThanhtien.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(778, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 53;
            this.label19.Text = "Tổng tiền";
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(839, 36);
            this.txtDongianhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(175, 26);
            this.txtDongianhap.TabIndex = 50;
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Location = new System.Drawing.Point(507, 82);
            this.txtGiamgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(175, 26);
            this.txtGiamgia.TabIndex = 49;
            this.txtGiamgia.TextChanged += new System.EventHandler(this.txtGiamgia_TextChanged);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(856, 301);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(201, 26);
            this.txtTongtien.TabIndex = 54;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(506, 40);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(175, 26);
            this.txtTenhang.TabIndex = 48;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(189, 86);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(230, 26);
            this.txtSoluong.TabIndex = 47;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(104, 305);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(81, 20);
            this.lblBangchu.TabIndex = 55;
            this.lblBangchu.Text = "Bằng chữ:";
            // 
            // cboMahang
            // 
            this.cboMahang.FormattingEnabled = true;
            this.cboMahang.Location = new System.Drawing.Point(188, 40);
            this.cboMahang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMahang.Name = "cboMahang";
            this.cboMahang.Size = new System.Drawing.Size(230, 28);
            this.cboMahang.TabIndex = 46;
            this.cboMahang.TextChanged += new System.EventHandler(this.cboMahang_TextChanged);
            // 
            // dgridChitietHDN
            // 
            this.dgridChitietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridChitietHDN.Location = new System.Drawing.Point(105, 121);
            this.dgridChitietHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgridChitietHDN.Name = "dgridChitietHDN";
            this.dgridChitietHDN.RowHeadersWidth = 51;
            this.dgridChitietHDN.RowTemplate.Height = 24;
            this.dgridChitietHDN.Size = new System.Drawing.Size(963, 155);
            this.dgridChitietHDN.TabIndex = 45;
            this.dgridChitietHDN.Click += new System.EventHandler(this.dgridChitietHDN_Click);
            this.dgridChitietHDN.DoubleClick += new System.EventHandler(this.dgridChitietHDN_DoubleClick);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(867, 354);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(136, 52);
            this.btnDong.TabIndex = 59;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(144, 352);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 56);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(728, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Thành tiền";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(566, 355);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 52);
            this.btnIn.TabIndex = 58;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(727, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Đơn giá nhập";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(302, 352);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 56);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(426, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "Giảm giá";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(705, 355);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(134, 51);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã hàng";
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(249, 110);
            this.cboManhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(285, 28);
            this.cboManhanvien.TabIndex = 38;
            this.cboManhanvien.TextChanged += new System.EventHandler(this.cboManhanvien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tên nhà cung cấp";
            // 
            // txtMahoadonnhap
            // 
            this.txtMahoadonnhap.Location = new System.Drawing.Point(249, 39);
            this.txtMahoadonnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMahoadonnhap.Name = "txtMahoadonnhap";
            this.txtMahoadonnhap.Size = new System.Drawing.Size(285, 25);
            this.txtMahoadonnhap.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgridHDN);
            this.groupBox1.Controls.Add(this.txtDienthoai);
            this.groupBox1.Controls.Add(this.mskNgaynhap);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTennhacungcap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboManhacungcap);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboManhanvien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMahoadonnhap);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1149, 346);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dgridHDN
            // 
            this.dgridHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridHDN.Location = new System.Drawing.Point(123, 182);
            this.dgridHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgridHDN.Name = "dgridHDN";
            this.dgridHDN.RowHeadersWidth = 51;
            this.dgridHDN.RowTemplate.Height = 24;
            this.dgridHDN.Size = new System.Drawing.Size(962, 138);
            this.dgridHDN.TabIndex = 44;
            this.dgridHDN.Click += new System.EventHandler(this.dgridHDN_Click);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(780, 144);
            this.txtDienthoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(285, 25);
            this.txtDienthoai.TabIndex = 43;
            // 
            // mskNgaynhap
            // 
            this.mskNgaynhap.Location = new System.Drawing.Point(249, 74);
            this.mskNgaynhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgaynhap.Mask = "00/00/0000";
            this.mskNgaynhap.Name = "mskNgaynhap";
            this.mskNgaynhap.Size = new System.Drawing.Size(285, 25);
            this.mskNgaynhap.TabIndex = 37;
            this.mskNgaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(780, 109);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(285, 25);
            this.txtDiachi.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mã hóa đơn nhập";
            // 
            // txtTennhacungcap
            // 
            this.txtTennhacungcap.Location = new System.Drawing.Point(780, 74);
            this.txtTennhacungcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTennhacungcap.Name = "txtTennhacungcap";
            this.txtTennhacungcap.Size = new System.Drawing.Size(285, 25);
            this.txtTennhacungcap.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ngày nhập";
            // 
            // cboManhacungcap
            // 
            this.cboManhacungcap.FormattingEnabled = true;
            this.cboManhacungcap.Location = new System.Drawing.Point(780, 39);
            this.cboManhacungcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboManhacungcap.Name = "cboManhacungcap";
            this.cboManhacungcap.Size = new System.Drawing.Size(285, 28);
            this.cboManhacungcap.TabIndex = 40;
            this.cboManhacungcap.TextChanged += new System.EventHandler(this.cboManhacungcap_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mã nhân viên";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(249, 148);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(285, 25);
            this.txtTennhanvien.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(452, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "HÓA ĐƠN NHẬP";
            // 
            // frmHoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 844);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboMahoadonnhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHoadonnhap";
            this.Text = "frmHoadonnhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoadonnhap_FormClosing);
            this.Load += new System.EventHandler(this.frmHoadonnhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridChitietHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMahoadonnhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.ComboBox cboMahang;
        private System.Windows.Forms.DataGridView dgridChitietHDN;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMahoadonnhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgridHDN;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.MaskedTextBox mskNgaynhap;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTennhacungcap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboManhacungcap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}