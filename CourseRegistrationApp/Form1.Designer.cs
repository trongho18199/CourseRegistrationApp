namespace CourseRegistrationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.labelSoThang = new System.Windows.Forms.Label();
            this.labelHinhThuc = new System.Windows.Forms.Label();
            this.labelKhoaHoc = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();

            // groupBox1
            this.groupBox1.Controls.Add(this.chkNhanEmail);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.labelNgaySinh);
            this.groupBox1.Controls.Add(this.labelSoDienThoai);
            this.groupBox1.Controls.Add(this.labelHoTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";

            // labelHoTen
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(20, 30);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(57, 16);
            this.labelHoTen.TabIndex = 0;
            this.labelHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(150, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(330, 22);
            this.txtHoTen.TabIndex = 1;

            // labelSoDienThoai
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Location = new System.Drawing.Point(20, 70);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(92, 16);
            this.labelSoDienThoai.TabIndex = 2;
            this.labelSoDienThoai.Text = "Số điện thoại:";

            // txtSoDienThoai
            this.txtSoDienThoai.Location = new System.Drawing.Point(150, 67);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(330, 22);
            this.txtSoDienThoai.TabIndex = 3;

            // labelNgaySinh
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(20, 110);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(69, 16);
            this.labelNgaySinh.TabIndex = 4;
            this.labelNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.Location = new System.Drawing.Point(150, 107);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(330, 22);
            this.dtpNgaySinh.TabIndex = 5;

            // chkNhanEmail
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(150, 145);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(165, 20);
            this.chkNhanEmail.TabIndex = 6;
            this.chkNhanEmail.Text = "Nhận Email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;

            // groupBox2
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.numSoThang);
            this.groupBox2.Controls.Add(this.radOffline);
            this.groupBox2.Controls.Add(this.radOnline);
            this.groupBox2.Controls.Add(this.cboKhoaHoc);
            this.groupBox2.Controls.Add(this.labelSoThang);
            this.groupBox2.Controls.Add(this.labelHinhThuc);
            this.groupBox2.Controls.Add(this.labelKhoaHoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khóa học";

            // labelKhoaHoc
            this.labelKhoaHoc.AutoSize = true;
            this.labelKhoaHoc.Location = new System.Drawing.Point(20, 30);
            this.labelKhoaHoc.Name = "labelKhoaHoc";
            this.labelKhoaHoc.Size = new System.Drawing.Size(91, 16);
            this.labelKhoaHoc.TabIndex = 0;
            this.labelKhoaHoc.Text = "Chọn khóa học:";

            // cboKhoaHoc
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(150, 27);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(330, 24);
            this.cboKhoaHoc.TabIndex = 1;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);

            // labelHinhThuc
            this.labelHinhThuc.AutoSize = true;
            this.labelHinhThuc.Location = new System.Drawing.Point(20, 75);
            this.labelHinhThuc.Name = "labelHinhThuc";
            this.labelHinhThuc.Size = new System.Drawing.Size(91, 16);
            this.labelHinhThuc.TabIndex = 2;
            this.labelHinhThuc.Text = "Hình thức học:";

            // radOnline
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(150, 73);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(66, 20);
            this.radOnline.TabIndex = 3;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;

            // radOffline
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(240, 73);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(65, 20);
            this.radOffline.TabIndex = 4;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Offline";
            this.radOffline.UseVisualStyleBackColor = true;

            // labelSoThang
            this.labelSoThang.AutoSize = true;
            this.labelSoThang.Location = new System.Drawing.Point(20, 115);
            this.labelSoThang.Name = "labelSoThang";
            this.labelSoThang.Size = new System.Drawing.Size(111, 16);
            this.labelSoThang.TabIndex = 5;
            this.labelSoThang.Text = "Số tháng đăng ký:";

            // numSoThang
            this.numSoThang.Location = new System.Drawing.Point(150, 112);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(120, 22);
            this.numSoThang.TabIndex = 6;
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);

            // lblTongTien
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(150, 150);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 16);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "0 VNĐ";

            // btnDangKy
            this.btnDangKy.Location = new System.Drawing.Point(100, 425);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 35);
            this.btnDangKy.TabIndex = 8;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(220, 425);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(340, 425);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label labelSoThang;
        private System.Windows.Forms.Label labelHinhThuc;
        private System.Windows.Forms.Label labelKhoaHoc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}
