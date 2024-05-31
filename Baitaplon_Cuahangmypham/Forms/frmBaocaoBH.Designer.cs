namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmBaocaoBH
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.dgridSP = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgridbaocaoBH = new System.Windows.Forms.DataGridView();
            this.mskdenngay = new System.Windows.Forms.MaskedTextBox();
            this.msktheongay = new System.Windows.Forms.MaskedTextBox();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.cboNVban = new System.Windows.Forms.ComboBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridbaocaoBH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(760, 517);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(89, 44);
            this.btnIn.TabIndex = 97;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(631, 517);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(89, 44);
            this.btnHienthi.TabIndex = 96;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            // 
            // dgridSP
            // 
            this.dgridSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSP.Location = new System.Drawing.Point(696, 309);
            this.dgridSP.Name = "dgridSP";
            this.dgridSP.ReadOnly = true;
            this.dgridSP.RowHeadersWidth = 51;
            this.dgridSP.RowTemplate.Height = 24;
            this.dgridSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridSP.Size = new System.Drawing.Size(294, 182);
            this.dgridSP.TabIndex = 95;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(779, 228);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(89, 44);
            this.btnTimkiem.TabIndex = 94;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // dgridbaocaoBH
            // 
            this.dgridbaocaoBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridbaocaoBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridbaocaoBH.Location = new System.Drawing.Point(3, 309);
            this.dgridbaocaoBH.Name = "dgridbaocaoBH";
            this.dgridbaocaoBH.ReadOnly = true;
            this.dgridbaocaoBH.RowHeadersWidth = 51;
            this.dgridbaocaoBH.RowTemplate.Height = 24;
            this.dgridbaocaoBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridbaocaoBH.Size = new System.Drawing.Size(661, 182);
            this.dgridbaocaoBH.TabIndex = 93;
            // 
            // mskdenngay
            // 
            this.mskdenngay.Location = new System.Drawing.Point(918, 90);
            this.mskdenngay.Mask = "00/00/0000";
            this.mskdenngay.Name = "mskdenngay";
            this.mskdenngay.Size = new System.Drawing.Size(100, 22);
            this.mskdenngay.TabIndex = 92;
            this.mskdenngay.ValidatingType = typeof(System.DateTime);
            // 
            // msktheongay
            // 
            this.msktheongay.Location = new System.Drawing.Point(749, 138);
            this.msktheongay.Mask = "00/00/0000";
            this.msktheongay.Name = "msktheongay";
            this.msktheongay.Size = new System.Drawing.Size(100, 22);
            this.msktheongay.TabIndex = 91;
            this.msktheongay.ValidatingType = typeof(System.DateTime);
            // 
            // msktungay
            // 
            this.msktungay.Location = new System.Drawing.Point(775, 88);
            this.msktungay.Mask = "00/00/0000";
            this.msktungay.Name = "msktungay";
            this.msktungay.Size = new System.Drawing.Size(100, 22);
            this.msktungay.TabIndex = 90;
            this.msktungay.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(881, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 88;
            this.label9.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(626, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Theo ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(626, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Theo khoảng: ";
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(461, 182);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(121, 22);
            this.txtDongiaban.TabIndex = 85;
            // 
            // cboNVban
            // 
            this.cboNVban.FormattingEnabled = true;
            this.cboNVban.Location = new System.Drawing.Point(461, 133);
            this.cboNVban.Name = "cboNVban";
            this.cboNVban.Size = new System.Drawing.Size(121, 24);
            this.cboNVban.TabIndex = 84;
            // 
            // cboTenKH
            // 
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(461, 86);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(121, 24);
            this.cboTenKH.TabIndex = 83;
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(159, 133);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(121, 24);
            this.cboTenSP.TabIndex = 82;
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(159, 85);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(121, 24);
            this.cboMaHD.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(311, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Đơn giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(311, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nhân viên bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(311, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 75;
            this.label1.Text = "BÁO CÁO BÁN HÀNG";
            // 
            // frmBaocaoBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 568);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.dgridSP);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dgridbaocaoBH);
            this.Controls.Add(this.mskdenngay);
            this.Controls.Add(this.msktheongay);
            this.Controls.Add(this.msktungay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDongiaban);
            this.Controls.Add(this.cboNVban);
            this.Controls.Add(this.cboTenKH);
            this.Controls.Add(this.cboTenSP);
            this.Controls.Add(this.cboMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaocaoBH";
            this.Text = "frmBaocaoBH";
            ((System.ComponentModel.ISupportInitialize)(this.dgridSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridbaocaoBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.DataGridView dgridSP;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgridbaocaoBH;
        private System.Windows.Forms.MaskedTextBox mskdenngay;
        private System.Windows.Forms.MaskedTextBox msktheongay;
        private System.Windows.Forms.MaskedTextBox msktungay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.ComboBox cboNVban;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}