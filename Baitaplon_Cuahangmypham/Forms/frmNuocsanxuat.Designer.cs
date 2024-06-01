namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmNuocsanxuat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgridNuocsanxuat = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblManuoc = new System.Windows.Forms.Label();
            this.txtTennuocsx = new System.Windows.Forms.TextBox();
            this.lblTennuoc = new System.Windows.Forms.Label();
            this.txtManuocsx = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDanhmucnuocsanxuat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNuocsanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dgridNuocsanxuat);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.lblManuoc);
            this.panel1.Controls.Add(this.txtTennuocsx);
            this.panel1.Controls.Add(this.lblTennuoc);
            this.panel1.Controls.Add(this.txtManuocsx);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(35, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 440);
            this.panel1.TabIndex = 17;
            // 
            // dgridNuocsanxuat
            // 
            this.dgridNuocsanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridNuocsanxuat.Location = new System.Drawing.Point(66, 149);
            this.dgridNuocsanxuat.Margin = new System.Windows.Forms.Padding(2);
            this.dgridNuocsanxuat.Name = "dgridNuocsanxuat";
            this.dgridNuocsanxuat.RowHeadersWidth = 82;
            this.dgridNuocsanxuat.RowTemplate.Height = 33;
            this.dgridNuocsanxuat.Size = new System.Drawing.Size(561, 182);
            this.dgridNuocsanxuat.TabIndex = 3;
            this.dgridNuocsanxuat.Click += new System.EventHandler(this.dgridNuocsanxuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(578, 378);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 41);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblManuoc
            // 
            this.lblManuoc.AutoSize = true;
            this.lblManuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManuoc.Location = new System.Drawing.Point(62, 32);
            this.lblManuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManuoc.Name = "lblManuoc";
            this.lblManuoc.Size = new System.Drawing.Size(78, 22);
            this.lblManuoc.TabIndex = 1;
            this.lblManuoc.Text = "Mã nước";
            // 
            // txtTennuocsx
            // 
            this.txtTennuocsx.Location = new System.Drawing.Point(181, 89);
            this.txtTennuocsx.Margin = new System.Windows.Forms.Padding(2);
            this.txtTennuocsx.Multiline = true;
            this.txtTennuocsx.Name = "txtTennuocsx";
            this.txtTennuocsx.Size = new System.Drawing.Size(206, 34);
            this.txtTennuocsx.TabIndex = 10;
            // 
            // lblTennuoc
            // 
            this.lblTennuoc.AutoSize = true;
            this.lblTennuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennuoc.Location = new System.Drawing.Point(62, 89);
            this.lblTennuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTennuoc.Name = "lblTennuoc";
            this.lblTennuoc.Size = new System.Drawing.Size(86, 22);
            this.lblTennuoc.TabIndex = 2;
            this.lblTennuoc.Text = "Tên nước";
            // 
            // txtManuocsx
            // 
            this.txtManuocsx.Location = new System.Drawing.Point(181, 32);
            this.txtManuocsx.Margin = new System.Windows.Forms.Padding(2);
            this.txtManuocsx.Multiline = true;
            this.txtManuocsx.Name = "txtManuocsx";
            this.txtManuocsx.Size = new System.Drawing.Size(206, 34);
            this.txtManuocsx.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 378);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 41);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(477, 378);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(86, 41);
            this.btnBoqua.TabIndex = 8;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(171, 378);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 41);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(377, 378);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 41);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(274, 378);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 41);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANH MỤC NƯỚC SẢN XUẤT";
            // 
            // lblDanhmucnuocsanxuat
            // 
            this.lblDanhmucnuocsanxuat.AutoSize = true;
            this.lblDanhmucnuocsanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmucnuocsanxuat.Location = new System.Drawing.Point(175, -66);
            this.lblDanhmucnuocsanxuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhmucnuocsanxuat.Name = "lblDanhmucnuocsanxuat";
            this.lblDanhmucnuocsanxuat.Size = new System.Drawing.Size(340, 26);
            this.lblDanhmucnuocsanxuat.TabIndex = 16;
            this.lblDanhmucnuocsanxuat.Text = "DANH MỤC NƯỚC SẢN XUẤT";
            // 
            // frmNuocsanxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDanhmucnuocsanxuat);
            this.Name = "frmNuocsanxuat";
            this.Text = "frmNuocsanxuat";
            this.Load += new System.EventHandler(this.frmNuocsanxuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNuocsanxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgridNuocsanxuat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblManuoc;
        private System.Windows.Forms.TextBox txtTennuocsx;
        private System.Windows.Forms.Label lblTennuoc;
        private System.Windows.Forms.TextBox txtManuocsx;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDanhmucnuocsanxuat;
    }
}