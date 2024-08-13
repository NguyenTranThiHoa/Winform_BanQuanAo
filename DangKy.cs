using SHOP_CDH.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            // Kiểm tra xem đã nhập đầy đủ thông tin tài khoản và mật khẩu chưa
            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //
            }

            NguoiDungBLL dangKyBLL = new NguoiDungBLL();
            // Gọi phương thức DangKy từ BLL để thực hiện đăng ký
            dangKyBLL.DangKy(taiKhoan, matKhau);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
