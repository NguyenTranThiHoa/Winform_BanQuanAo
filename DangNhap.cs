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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            NguoiDungBLL dangNhapBLL = new NguoiDungBLL();
            // Gọi phương thức KiemTraDangNhap từ BLL để kiểm tra đăng nhập
            dangNhapBLL.KiemTraDangNhap(taiKhoan, matKhau);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKy formDangKy = new DangKy();
            // Hiển thị form đăng ký
            formDangKy.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            // Hiển thị form đăng ký
            quenMatKhau.Show();
            this.Hide();
        }
    }
}
