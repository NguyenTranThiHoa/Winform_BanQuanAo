using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH
{
    public partial class Khachhang : Form
    {
        private KhachHangBLL khachhang1 = new KhachHangBLL();
        private bool is_insert = true;
        private ConnectData connectData = new ConnectData();
        public Khachhang()
        {
            InitializeComponent();
        }

        private int CountKH()
        {
            int soluong = 0;

            SqlConnection conn = connectData.GetConnect();
            string sql = "select count(MaKH) from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                soluong = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối lỗi: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return soluong;
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang dssanpham = new NhapHang();
            dssanpham.ShowDialog();
            this.Close();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhanvien nhanvien = new Nhanvien();
            nhanvien.ShowDialog();
            this.Close();
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoadon hoadon = new Hoadon();
            hoadon.ShowDialog();
            this.Close();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doanhthu doanhthu = new Doanhthu();
            doanhthu.ShowDialog();
            this.Close();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            dataGridView_khachhang.DataSource = khachhang1.LoadKH();
            int soluong = CountKH();

            // Thêm các giá trị cho comboBox1 (Giới tính)
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");
        }

        private void dataGridView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txt_makh.Text = dataGridView_khachhang.Rows[r].Cells[0].Value.ToString();
            txt_tenkh.Text = dataGridView_khachhang.Rows[r].Cells[1].Value.ToString();
            txt_sdtkh.Text = dataGridView_khachhang.Rows[r].Cells[2].Value.ToString();
            txt_diachikh.Text = dataGridView_khachhang.Rows[r].Cells[3].Value.ToString();
            cmb_gioitinh.Text = dataGridView_khachhang.Rows[r].Cells[4].Value.ToString();
        }

        private void LoadKH()
        {
            SqlConnection conn = connectData.GetConnect();
            string sql = "select * from KhachHang";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView_khachhang.DataSource = dt;
        }

        private void txt_sdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                MessageBox.Show("Vui lòng nhập số");
                e.Handled = true;
            }
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            txt_makh.Enabled = true;
            txt_makh.Enabled = true;
            txt_tenkh.Enabled = true;
            txt_sdtkh.Enabled = true;
            txt_diachikh.Enabled = true;
            btn_luukh.Enabled = true;
            is_insert = true;
        }

        private void btn_luukh_Click(object sender, EventArgs e)
        {
            if (is_insert)
            {
                if (string.IsNullOrEmpty(txt_makh.Text) || string.IsNullOrEmpty(txt_tenkh.Text) || string.IsNullOrEmpty(txt_sdtkh.Text) || string.IsNullOrEmpty(txt_diachikh.Text) || string.IsNullOrEmpty(cmb_gioitinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    KhachHangModel formData1 = new KhachHangModel();
                    formData1.makhachhang = txt_makh.Text;
                    formData1.tenkhachhang = txt_tenkh.Text;
                    formData1.sdtkhachhang = txt_sdtkh.Text;
                    formData1.diachikhachhang = txt_diachikh.Text;
                    formData1.gioitinh = cmb_gioitinh.Text;

                    int res = khachhang1.ThemKH(formData1);
                    if (res > 0)
                    {
                        dataGridView_khachhang.DataSource = khachhang1.LoadKH();
                        MessageBox.Show("Thêm khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt_makh.Text) || string.IsNullOrEmpty(txt_tenkh.Text) || string.IsNullOrEmpty(txt_sdtkh.Text) || string.IsNullOrEmpty(txt_diachikh.Text) || string.IsNullOrEmpty(cmb_gioitinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    KhachHangModel formData1 = new KhachHangModel();
                    formData1.makhachhang = txt_makh.Text;
                    formData1.tenkhachhang = txt_tenkh.Text;
                    formData1.sdtkhachhang = txt_sdtkh.Text;
                    formData1.diachikhachhang = txt_diachikh.Text;
                    formData1.gioitinh = cmb_gioitinh.Text;

                    int res = khachhang1.UpdateKH(formData1);
                    if (res > 0)
                    {
                        dataGridView_khachhang.DataSource = khachhang1.LoadKH();
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại!");
                    }
                }
            }
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = false;
            panel3.Enabled = true;
            is_insert = false;
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            int res = 0;
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                res = khachhang1.DeleteKH(txt_makh.Text);
                if (res > 0)
                {
                    DataTable dt = khachhang1.LoadKH();
                    dataGridView_khachhang.DataSource = dt;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btn_huykh_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu đã nhập trên form
            txt_makh.Clear();
            txt_sdtkh.Clear();
            txt_tenkh.Clear();
            txt_diachikh.Clear();
            cmb_gioitinh.SelectedIndex = -1;
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();

        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {
            string input = txt_tenkh.Text;
            bool containsDigit = false;

            // Kiểm tra từng ký tự trong chuỗi
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    containsDigit = true;
                    break; // Nếu tìm thấy ký tự số, thoát vòng lặp
                }
            }

            // Nếu chuỗi nhập vào chứa ký tự số, loại bỏ nó
            if (containsDigit)
            {
                txt_tenkh.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_sdtkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoatkh_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_searchkh_TextChanged(object sender, EventArgs e)
        {
            dataGridView_khachhang.DataSource = khachhang1.LoadDataSearch(txt_searchkh.Text);
        }

        private void dataGridView_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
