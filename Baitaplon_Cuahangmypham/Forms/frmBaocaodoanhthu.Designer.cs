namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmBaocaodoanhthu
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
            this.btndong = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.lblbangchu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dgriddoanhthu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.mskngayban = new System.Windows.Forms.MaskedTextBox();
            this.gbokhoang = new System.Windows.Forms.GroupBox();
            this.mskdenngay = new System.Windows.Forms.MaskedTextBox();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.cbotensp = new System.Windows.Forms.ComboBox();
            this.rdbxkhoang = new System.Windows.Forms.RadioButton();
            this.rdbxngay = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgriddoanhthu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbokhoang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(1386, 794);
            this.btndong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(129, 49);
            this.btndong.TabIndex = 28;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(1091, 794);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(129, 49);
            this.btnlammoi.TabIndex = 27;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Location = new System.Drawing.Point(1246, 794);
            this.btnexport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(123, 49);
            this.btnexport.TabIndex = 26;
            this.btnexport.Text = "In báo cáo";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.ForeColor = System.Drawing.Color.Black;
            this.txttongtien.Location = new System.Drawing.Point(299, 785);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(188, 30);
            this.txttongtien.TabIndex = 25;
            // 
            // lblbangchu
            // 
            this.lblbangchu.AutoSize = true;
            this.lblbangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbangchu.Location = new System.Drawing.Point(124, 859);
            this.lblbangchu.Name = "lblbangchu";
            this.lblbangchu.Size = new System.Drawing.Size(0, 25);
            this.lblbangchu.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 788);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // Dgriddoanhthu
            // 
            this.Dgriddoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgriddoanhthu.Location = new System.Drawing.Point(335, 422);
            this.Dgriddoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgriddoanhthu.Name = "Dgriddoanhthu";
            this.Dgriddoanhthu.RowHeadersWidth = 51;
            this.Dgriddoanhthu.RowTemplate.Height = 24;
            this.Dgriddoanhthu.Size = new System.Drawing.Size(946, 331);
            this.Dgriddoanhthu.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.mskngayban);
            this.groupBox1.Controls.Add(this.gbokhoang);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.cbotensp);
            this.groupBox1.Controls.Add(this.rdbxkhoang);
            this.groupBox1.Controls.Add(this.rdbxngay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(110, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1405, 288);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(1163, 205);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(132, 61);
            this.btntimkiem.TabIndex = 20;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(225, 124);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(259, 26);
            this.txtsoluong.TabIndex = 19;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // mskngayban
            // 
            this.mskngayban.Location = new System.Drawing.Point(846, 34);
            this.mskngayban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskngayban.Mask = "00/00/0000";
            this.mskngayban.Name = "mskngayban";
            this.mskngayban.Size = new System.Drawing.Size(216, 26);
            this.mskngayban.TabIndex = 18;
            this.mskngayban.ValidatingType = typeof(System.DateTime);
            // 
            // gbokhoang
            // 
            this.gbokhoang.Controls.Add(this.mskdenngay);
            this.gbokhoang.Controls.Add(this.msktungay);
            this.gbokhoang.Controls.Add(this.label8);
            this.gbokhoang.Controls.Add(this.label9);
            this.gbokhoang.Location = new System.Drawing.Point(793, 105);
            this.gbokhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbokhoang.Name = "gbokhoang";
            this.gbokhoang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbokhoang.Size = new System.Drawing.Size(573, 62);
            this.gbokhoang.TabIndex = 17;
            this.gbokhoang.TabStop = false;
            // 
            // mskdenngay
            // 
            this.mskdenngay.Location = new System.Drawing.Point(348, 19);
            this.mskdenngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskdenngay.Mask = "00/00/0000";
            this.mskdenngay.Name = "mskdenngay";
            this.mskdenngay.Size = new System.Drawing.Size(216, 26);
            this.mskdenngay.TabIndex = 20;
            this.mskdenngay.ValidatingType = typeof(System.DateTime);
            // 
            // msktungay
            // 
            this.msktungay.Location = new System.Drawing.Point(53, 19);
            this.msktungay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msktungay.Mask = "00/00/0000";
            this.msktungay.Name = "msktungay";
            this.msktungay.Size = new System.Drawing.Size(216, 26);
            this.msktungay.TabIndex = 19;
            this.msktungay.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Từ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Đến:";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(225, 205);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(259, 26);
            this.txtgia.TabIndex = 9;
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // cbotensp
            // 
            this.cbotensp.FormattingEnabled = true;
            this.cbotensp.Location = new System.Drawing.Point(225, 34);
            this.cbotensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotensp.Name = "cbotensp";
            this.cbotensp.Size = new System.Drawing.Size(259, 28);
            this.cbotensp.TabIndex = 7;
            // 
            // rdbxkhoang
            // 
            this.rdbxkhoang.AutoSize = true;
            this.rdbxkhoang.Location = new System.Drawing.Point(602, 122);
            this.rdbxkhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbxkhoang.Name = "rdbxkhoang";
            this.rdbxkhoang.Size = new System.Drawing.Size(131, 24);
            this.rdbxkhoang.TabIndex = 4;
            this.rdbxkhoang.TabStop = true;
            this.rdbxkhoang.Text = "Theo khoảng:";
            this.rdbxkhoang.UseVisualStyleBackColor = true;
            this.rdbxkhoang.CheckedChanged += new System.EventHandler(this.rdbxkhoang_CheckedChanged);
            // 
            // rdbxngay
            // 
            this.rdbxngay.AutoSize = true;
            this.rdbxngay.Location = new System.Drawing.Point(602, 46);
            this.rdbxngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbxngay.Name = "rdbxngay";
            this.rdbxngay.Size = new System.Drawing.Size(112, 24);
            this.rdbxngay.TabIndex = 3;
            this.rdbxngay.TabStop = true;
            this.rdbxngay.Text = "Theo ngày:";
            this.rdbxngay.UseVisualStyleBackColor = true;
            this.rdbxngay.CheckedChanged += new System.EventHandler(this.rdbxngay_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(563, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // frmBaocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1581, 870);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.lblbangchu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgriddoanhthu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBaocaodoanhthu";
            this.Text = "frmBaocaodoanhthu";
            this.Load += new System.EventHandler(this.frmBaocaodoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgriddoanhthu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbokhoang.ResumeLayout(false);
            this.gbokhoang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label lblbangchu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dgriddoanhthu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.MaskedTextBox mskngayban;
        private System.Windows.Forms.GroupBox gbokhoang;
        private System.Windows.Forms.MaskedTextBox mskdenngay;
        private System.Windows.Forms.MaskedTextBox msktungay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.ComboBox cbotensp;
        private System.Windows.Forms.RadioButton rdbxkhoang;
        private System.Windows.Forms.RadioButton rdbxngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}