namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmkhach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgrikhachhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrikhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(212, 534);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 47);
            this.btnthem.TabIndex = 58;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(322, 534);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(87, 47);
            this.btnsua.TabIndex = 59;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(427, 534);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 47);
            this.btnxoa.TabIndex = 60;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(749, 534);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 47);
            this.btndong.TabIndex = 63;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(639, 534);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(93, 47);
            this.btnboqua.TabIndex = 61;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(529, 534);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(90, 47);
            this.btnluu.TabIndex = 62;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(815, 138);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(205, 22);
            this.txtdiachi.TabIndex = 57;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(815, 187);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(205, 22);
            this.mskdienthoai.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã khách hàng :";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(247, 135);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(256, 22);
            this.txtmakh.TabIndex = 53;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(247, 189);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(256, 22);
            this.txttenkhach.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên khách hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Địa chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Số điện thoại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // Dgrikhachhang
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgrikhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgrikhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgrikhachhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgrikhachhang.Location = new System.Drawing.Point(311, 246);
            this.Dgrikhachhang.Name = "Dgrikhachhang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgrikhachhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgrikhachhang.RowHeadersWidth = 51;
            this.Dgrikhachhang.RowTemplate.Height = 24;
            this.Dgrikhachhang.Size = new System.Drawing.Size(543, 252);
            this.Dgrikhachhang.TabIndex = 64;
            this.Dgrikhachhang.Click += new System.EventHandler(this.Dgrikhachhang_Click_1);
            // 
            // frmkhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 596);
            this.Controls.Add(this.Dgrikhachhang);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmkhach";
            this.Text = "frmkhach";
            this.Load += new System.EventHandler(this.frmkhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrikhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgrikhachhang;
    }
}