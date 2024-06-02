namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmBaocaobanhang
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbkhoang = new System.Windows.Forms.GroupBox();
            this.mskdenngay = new System.Windows.Forms.MaskedTextBox();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdtheokhoang = new System.Windows.Forms.RadioButton();
            this.rdtheongay = new System.Windows.Forms.RadioButton();
            this.cbokhachhang = new System.Windows.Forms.ComboBox();
            this.cbonhanvien = new System.Windows.Forms.ComboBox();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cbotensp = new System.Windows.Forms.ComboBox();
            this.cboSoHDB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msktheongay = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridCTHDB = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbkhoang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 38);
            this.label3.TabIndex = 79;
            this.label3.Text = "BÁO CÁO BÁN HÀNG ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbkhoang);
            this.groupBox1.Controls.Add(this.rdtheokhoang);
            this.groupBox1.Controls.Add(this.rdtheongay);
            this.groupBox1.Controls.Add(this.cbokhachhang);
            this.groupBox1.Controls.Add(this.cbonhanvien);
            this.groupBox1.Controls.Add(this.txtdongiaban);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.cbotensp);
            this.groupBox1.Controls.Add(this.cboSoHDB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msktheongay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 226);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // grbkhoang
            // 
            this.grbkhoang.Controls.Add(this.mskdenngay);
            this.grbkhoang.Controls.Add(this.msktungay);
            this.grbkhoang.Controls.Add(this.label2);
            this.grbkhoang.Controls.Add(this.label9);
            this.grbkhoang.Location = new System.Drawing.Point(801, 27);
            this.grbkhoang.Name = "grbkhoang";
            this.grbkhoang.Size = new System.Drawing.Size(420, 38);
            this.grbkhoang.TabIndex = 29;
            this.grbkhoang.TabStop = false;
            // 
            // mskdenngay
            // 
            this.mskdenngay.Location = new System.Drawing.Point(251, 10);
            this.mskdenngay.Mask = "00/00/0000";
            this.mskdenngay.Name = "mskdenngay";
            this.mskdenngay.Size = new System.Drawing.Size(152, 22);
            this.mskdenngay.TabIndex = 24;
            this.mskdenngay.ValidatingType = typeof(System.DateTime);
            // 
            // msktungay
            // 
            this.msktungay.Location = new System.Drawing.Point(56, 11);
            this.msktungay.Mask = "00/00/0000";
            this.msktungay.Name = "msktungay";
            this.msktungay.Size = new System.Drawing.Size(152, 22);
            this.msktungay.TabIndex = 21;
            this.msktungay.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Từ";
            // 
            // rdtheokhoang
            // 
            this.rdtheokhoang.AutoSize = true;
            this.rdtheokhoang.Location = new System.Drawing.Point(679, 36);
            this.rdtheokhoang.Name = "rdtheokhoang";
            this.rdtheokhoang.Size = new System.Drawing.Size(108, 20);
            this.rdtheokhoang.TabIndex = 28;
            this.rdtheokhoang.TabStop = true;
            this.rdtheokhoang.Text = "Theo khoảng";
            this.rdtheokhoang.UseVisualStyleBackColor = true;
            this.rdtheokhoang.CheckedChanged += new System.EventHandler(this.rdtheokhoang_CheckedChanged);
            // 
            // rdtheongay
            // 
            this.rdtheongay.AutoSize = true;
            this.rdtheongay.Location = new System.Drawing.Point(679, 81);
            this.rdtheongay.Name = "rdtheongay";
            this.rdtheongay.Size = new System.Drawing.Size(96, 20);
            this.rdtheongay.TabIndex = 27;
            this.rdtheongay.TabStop = true;
            this.rdtheongay.Text = "Theo ngày ";
            this.rdtheongay.UseVisualStyleBackColor = true;
            this.rdtheongay.CheckedChanged += new System.EventHandler(this.rdtheongay_CheckedChanged);
            // 
            // cbokhachhang
            // 
            this.cbokhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbokhachhang.FormattingEnabled = true;
            this.cbokhachhang.Location = new System.Drawing.Point(450, 34);
            this.cbokhachhang.Name = "cbokhachhang";
            this.cbokhachhang.Size = new System.Drawing.Size(152, 24);
            this.cbokhachhang.TabIndex = 18;
            // 
            // cbonhanvien
            // 
            this.cbonhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonhanvien.FormattingEnabled = true;
            this.cbonhanvien.Location = new System.Drawing.Point(450, 73);
            this.cbonhanvien.Name = "cbonhanvien";
            this.cbonhanvien.Size = new System.Drawing.Size(152, 24);
            this.cbonhanvien.TabIndex = 17;
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.Location = new System.Drawing.Point(450, 119);
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.Size = new System.Drawing.Size(152, 22);
            this.txtdongiaban.TabIndex = 16;
            this.txtdongiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongiaban_KeyPress);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(1123, 185);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(123, 41);
            this.btnTimkiem.TabIndex = 7;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cbotensp
            // 
            this.cbotensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotensp.FormattingEnabled = true;
            this.cbotensp.Location = new System.Drawing.Point(133, 70);
            this.cbotensp.Name = "cbotensp";
            this.cbotensp.Size = new System.Drawing.Size(152, 24);
            this.cbotensp.TabIndex = 15;
            // 
            // cboSoHDB
            // 
            this.cboSoHDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoHDB.FormattingEnabled = true;
            this.cboSoHDB.Location = new System.Drawing.Point(133, 41);
            this.cboSoHDB.Name = "cboSoHDB";
            this.cboSoHDB.Size = new System.Drawing.Size(152, 24);
            this.cboSoHDB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sản phẩm";
            // 
            // msktheongay
            // 
            this.msktheongay.Location = new System.Drawing.Point(857, 81);
            this.msktheongay.Mask = "00/00/0000";
            this.msktheongay.Name = "msktheongay";
            this.msktheongay.Size = new System.Drawing.Size(152, 22);
            this.msktheongay.TabIndex = 8;
            this.msktheongay.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số HĐB";
            // 
            // dgridCTHDB
            // 
            this.dgridCTHDB.AllowUserToAddRows = false;
            this.dgridCTHDB.AllowUserToDeleteRows = false;
            this.dgridCTHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCTHDB.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgridCTHDB.Location = new System.Drawing.Point(125, 328);
            this.dgridCTHDB.Name = "dgridCTHDB";
            this.dgridCTHDB.RowHeadersWidth = 51;
            this.dgridCTHDB.RowTemplate.Height = 24;
            this.dgridCTHDB.Size = new System.Drawing.Size(1087, 225);
            this.dgridCTHDB.TabIndex = 81;
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(1137, 621);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(115, 40);
            this.btndong.TabIndex = 87;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(980, 621);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(132, 41);
            this.btnIn.TabIndex = 86;
            this.btnIn.Text = "In báo cáo ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(829, 621);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(123, 41);
            this.btnHienthi.TabIndex = 85;
            this.btnHienthi.Text = "Hiển Thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // frmBaocaobanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 674);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.dgridCTHDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaocaobanhang";
            this.Text = "frmBaocaobanhang";
            this.Load += new System.EventHandler(this.frmBaocaobanhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbkhoang.ResumeLayout(false);
            this.grbkhoang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCTHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbkhoang;
        private System.Windows.Forms.MaskedTextBox mskdenngay;
        private System.Windows.Forms.MaskedTextBox msktungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdtheokhoang;
        private System.Windows.Forms.RadioButton rdtheongay;
        private System.Windows.Forms.ComboBox cbokhachhang;
        private System.Windows.Forms.ComboBox cbonhanvien;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cbotensp;
        private System.Windows.Forms.ComboBox cboSoHDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktheongay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgridCTHDB;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienthi;
    }
}