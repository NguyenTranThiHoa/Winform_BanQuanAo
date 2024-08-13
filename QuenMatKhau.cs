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
using SHOP_CDH.BLL;
using System.Data.SqlClient;

namespace SHOP_CDH
{
    public partial class QuenMatKhau : Form
    {
        private ConnectData connectData = new ConnectData();
        DangNhap modify = new DangNhap();
        public SqlConnection GetConnect()
        {
            string chuoiKN = @"Data Source=DESKTOP-57Q2OCR\SQLEXPRESS01;Initial Catalog=QLBH_QA;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(chuoiKN);
            return conn;
        }
        public QuenMatKhau()
        {
            InitializeComponent();
            lbl_quenmatkhau.Text = "";
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nguoidung = txtTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(nguoidung))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản đã đăng ký!");
            }
            else
            {
                string sql = "SELECT MatKhau FROM DangNhap WHERE TaiKhoan = @taiKhoan";
                using (SqlConnection conn = GetConnect())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taiKhoan", nguoidung);
                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                lbl_quenmatkhau.ForeColor = Color.Blue;
                                lbl_quenmatkhau.Text = "Mật khẩu: " + result.ToString();
                            }
                            else
                            {
                                lbl_quenmatkhau.ForeColor = Color.Red;
                                lbl_quenmatkhau.Text = "Tài khoản này chưa được đăng ký";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap formDangNhap = new DangNhap();
            // Hiển thị form đăng ký
            formDangNhap.Show();
            this.Hide();
        }
    }
}
