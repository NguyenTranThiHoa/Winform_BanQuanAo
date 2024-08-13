using SHOP_CDH.BLL;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOP_CDH
{
    public partial class Nhanvien : Form
    {
        private NhanVienBLL nhanvien = new NhanVienBLL();
        private bool is_insert = true;

        public ErrorProvider errorProvider { get; private set; }

        public Nhanvien()
        {
            InitializeComponent();
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

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang dssanpham = new NhapHang();
            dssanpham.ShowDialog();
                this.Close();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khachhang khachhang = new Khachhang();
            khachhang.ShowDialog();
            this.Close();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            dataGridView_nhanvien.DataSource = nhanvien.LoadNV();

            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            txt_manv.Clear();
            txt_tennv.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker_ngaysinhnv.Text ="";
            txt_sdt.Clear();
            is_insert = true;
        }

        private void dataGridView_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_manv.Text = dataGridView_nhanvien.Rows[index].Cells[0].Value.ToString();
                txt_tennv.Text = dataGridView_nhanvien.Rows[index].Cells[1].Value.ToString();
                dateTimePicker_ngaysinhnv.Text = dataGridView_nhanvien.Rows[index].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView_nhanvien.Rows[index].Cells[3].Value.ToString();
                txt_diachinv.Text = dataGridView_nhanvien.Rows[index].Cells[4].Value.ToString();
                txt_sdt.Text = dataGridView_nhanvien.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void btn_luunv_Click(object sender, EventArgs e)
        {
            if (is_insert)
            {
                if (string.IsNullOrEmpty(txt_manv.Text) || string.IsNullOrEmpty(txt_tennv.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(txt_diachinv.Text) || string.IsNullOrEmpty(txt_sdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    NhanVienModel formData = new NhanVienModel();
                    formData.maNV = txt_manv.Text;
                    formData.tenNV = txt_tennv.Text;
                    formData.ngaysinh = dateTimePicker_ngaysinhnv.Value;
                    formData.gioitinh = comboBox1.Text;
                    formData.diachi = txt_diachinv.Text;
                    formData.sodt = txt_sdt.Text;

                    int res = nhanvien.InsertNV(formData);
                    if (res > 0)
                    {
                        dataGridView_nhanvien.DataSource = nhanvien.LoadNV();
                        MessageBox.Show("Thêm nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt_manv.Text) || string.IsNullOrEmpty(txt_tennv.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(txt_diachinv.Text) || string.IsNullOrEmpty(txt_sdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    NhanVienModel formData = new NhanVienModel();
                    formData.maNV = txt_manv.Text;
                    formData.tenNV = txt_tennv.Text;
                    formData.ngaysinh = dateTimePicker_ngaysinhnv.Value;
                    formData.gioitinh = comboBox1.Text;
                    formData.diachi = txt_diachinv.Text;
                    formData.sodt = txt_sdt.Text;

                    int res = nhanvien.UpdateNV(formData);
                    if (res > 0)
                    {
                        dataGridView_nhanvien.DataSource = nhanvien.LoadNV();
                        MessageBox.Show("Cập nhật nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại!");
                    }
                }
            }
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {
                MessageBox.Show("Vui lòng nhập số");
                e.Handled = true;


            }
        }

        private void txt_tennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider = new ErrorProvider();
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Nếu có, hiển thị thông báo lỗi và hủy sự kiện KeyPress
                errorProvider.SetError(txt_tennv, "Vui lòng nhập thông tin!");
                e.Handled = true; // Hủy sự kiện KeyPress
            }
            else
            {
                // Nếu không, xóa thông báo lỗi (nếu có)
                errorProvider.SetError(txt_tennv, "");
            }
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            int res = 0;
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                res = nhanvien.DeleteNV(txt_manv.Text);
                if (res > 0)
                {
                    DataTable dt = nhanvien.LoadNV();
                    dataGridView_nhanvien.DataSource = dt;
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
                }
            }
        }

        private void btn_huynv_Click(object sender, EventArgs e)
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            comboBox1.Text = "";
            txt_diachinv.Text = "";
            txt_sdt.Text = "";
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = false;
        }

        private void btn_thoatnv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_searchnv_TextChanged(object sender, EventArgs e)
        {
            dataGridView_nhanvien.DataSource = nhanvien.LoadDataSearch(txt_searchnv.Text);
        }
    }
}
