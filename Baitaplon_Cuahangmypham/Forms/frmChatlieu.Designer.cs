namespace Baitaplon_Cuahangmypham.Forms
{
    partial class frmChatlieu
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
            this.dgridChatlieu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblMachatlieu = new System.Windows.Forms.Label();
            this.txtTenchatlieu = new System.Windows.Forms.TextBox();
            this.lblTenchatlieu = new System.Windows.Forms.Label();
            this.txtMachatlieu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDanhmucchatlieu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridChatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.dgridChatlieu);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.lblMachatlieu);
            this.panel1.Controls.Add(this.txtTenchatlieu);
            this.panel1.Controls.Add(this.lblTenchatlieu);
            this.panel1.Controls.Add(this.txtMachatlieu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(37, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 615);
            this.panel1.TabIndex = 29;
            // 
            // dgridChatlieu
            // 
            this.dgridChatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridChatlieu.Location = new System.Drawing.Point(69, 182);
            this.dgridChatlieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgridChatlieu.Name = "dgridChatlieu";
            this.dgridChatlieu.RowHeadersWidth = 82;
            this.dgridChatlieu.RowTemplate.Height = 33;
            this.dgridChatlieu.Size = new System.Drawing.Size(853, 268);
            this.dgridChatlieu.TabIndex = 15;
            this.dgridChatlieu.Click += new System.EventHandler(this.dgridChatlieu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(781, 502);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 51);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblMachatlieu
            // 
            this.lblMachatlieu.AutoSize = true;
            this.lblMachatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachatlieu.Location = new System.Drawing.Point(64, 34);
            this.lblMachatlieu.Name = "lblMachatlieu";
            this.lblMachatlieu.Size = new System.Drawing.Size(141, 29);
            this.lblMachatlieu.TabIndex = 13;
            this.lblMachatlieu.Text = "Mã chất liệu";
            // 
            // txtTenchatlieu
            // 
            this.txtTenchatlieu.Location = new System.Drawing.Point(284, 105);
            this.txtTenchatlieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenchatlieu.Multiline = true;
            this.txtTenchatlieu.Name = "txtTenchatlieu";
            this.txtTenchatlieu.Size = new System.Drawing.Size(229, 42);
            this.txtTenchatlieu.TabIndex = 22;
            // 
            // lblTenchatlieu
            // 
            this.lblTenchatlieu.AutoSize = true;
            this.lblTenchatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenchatlieu.Location = new System.Drawing.Point(64, 105);
            this.lblTenchatlieu.Name = "lblTenchatlieu";
            this.lblTenchatlieu.Size = new System.Drawing.Size(151, 29);
            this.lblTenchatlieu.TabIndex = 14;
            this.lblTenchatlieu.Text = "Tên chất liệu";
            // 
            // txtMachatlieu
            // 
            this.txtMachatlieu.Location = new System.Drawing.Point(284, 34);
            this.txtMachatlieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMachatlieu.Multiline = true;
            this.txtMachatlieu.Name = "txtMachatlieu";
            this.txtMachatlieu.Size = new System.Drawing.Size(229, 42);
            this.txtMachatlieu.TabIndex = 21;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(101, 502);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 51);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(648, 502);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(115, 51);
            this.btnBoqua.TabIndex = 20;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 502);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 51);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(515, 502);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 51);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(379, 502);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 51);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // lblDanhmucchatlieu
            // 
            this.lblDanhmucchatlieu.AutoSize = true;
            this.lblDanhmucchatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmucchatlieu.Location = new System.Drawing.Point(336, -98);
            this.lblDanhmucchatlieu.Name = "lblDanhmucchatlieu";
            this.lblDanhmucchatlieu.Size = new System.Drawing.Size(348, 33);
            this.lblDanhmucchatlieu.TabIndex = 28;
            this.lblDanhmucchatlieu.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // frmChatlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDanhmucchatlieu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChatlieu";
            this.Text = "frmChatlieu";
            this.Load += new System.EventHandler(this.frmChatlieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridChatlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgridChatlieu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblMachatlieu;
        private System.Windows.Forms.TextBox txtTenchatlieu;
        private System.Windows.Forms.Label lblTenchatlieu;
        private System.Windows.Forms.TextBox txtMachatlieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDanhmucchatlieu;
    }
}