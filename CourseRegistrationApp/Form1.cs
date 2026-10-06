using System;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Clear();
            cboKhoaHoc.Items.Add("C# WinForms cơ bản");
            cboKhoaHoc.Items.Add("SQL Server cơ bản");
            cboKhoaHoc.Items.Add("Web Frontend cơ bản");
            cboKhoaHoc.Items.Add("Lập trình Python cơ bản");

            cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;
            radOffline.Checked = false;

            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;

            TinhTongTien();
            txtHoTen.Focus();
        }

        private long LayHocPhiMotThang()
        {
            switch (cboKhoaHoc.SelectedIndex)
            {
                case 0: return 800000;
                case 1: return 700000;
                case 2: return 750000;
                case 3: return 650000;
                default: return 0;
            }
        }

        private void TinhTongTien()
        {
            long hocPhiThang = LayHocPhiMotThang();
            long tongTien = hocPhiThang * (long)numSoThang.Value;
            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            if (cboKhoaHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            string hinhThucHoc = radOnline.Checked ? "Online" : "Offline";
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";
            long tongTien = LayHocPhiMotThang() * (long)numSoThang.Value;

            string phieuDangKy =
                "PHIẾU ĐĂNG KÝ KHÓA HỌC\n\n" +
                "Họ tên: " + txtHoTen.Text.Trim() + "\n" +
                "Số điện thoại: " + txtSoDienThoai.Text.Trim() + "\n" +
                "Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\n" +
                "Khóa học: " + cboKhoaHoc.Text + "\n" +
                "Hình thức học: " + hinhThucHoc + "\n" +
                "Số tháng: " + numSoThang.Value + "\n" +
                "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n" +
                "Nhận email thông báo: " + nhanEmail;

            MessageBox.Show(phieuDangKy, "Đăng ký thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();

            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;

            cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;
            radOffline.Checked = false;

            numSoThang.Value = 1;

            TinhTongTien();
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
