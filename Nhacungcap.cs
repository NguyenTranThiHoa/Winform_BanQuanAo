using SHOP_CDH.BLL;
using SHOP_CDH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOP_CDH
{
    public partial class Nhacungcap : Form
    {
        private NhaCungCapBLL nhacungcap = new NhaCungCapBLL();
        private bool is_insert = true;
        public Nhacungcap()
        {
            InitializeComponent();
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
            Doanhthu doanhthu   = new Doanhthu();
            doanhthu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang dssanpham = new NhapHang();
            dssanpham.ShowDialog();
            this.Close();
        }

        private void datasearchnc_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txt_manhacungcap.Text = datasearchnc_ncc.Rows[r].Cells[0].Value.ToString();
            txt_tenncc.Text = datasearchnc_ncc.Rows[r].Cells[1].Value.ToString();
            txt_sdtncc.Text = datasearchnc_ncc.Rows[r].Cells[2].Value.ToString();
            txt_diachincc.Text = datasearchnc_ncc.Rows[r].Cells[3].Value.ToString();
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            datasearchnc_ncc.DataSource = nhacungcap.LoadNCC();
        }

        private void txt_sdtncc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {
                MessageBox.Show("Vui lòng nhập số");
                e.Handled = true;


            }
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            txt_manhacungcap.Clear();
            txt_tenncc.Clear();
            txt_diachincc.Clear();
            txt_sdtncc.Clear();


            is_insert = true;
            panel3.Enabled = true;
            txt_manhacungcap.Enabled = true;
            txt_sdtncc.Enabled = true;
            txt_tenncc.Enabled = true ;
            txt_diachincc.Enabled = true;
        
        }

        private void txt_searchncc_TextChanged(object sender, EventArgs e)
        {
            datasearchnc_ncc.DataSource = nhacungcap.LoadDataSearch(txt_searchncc.Text);
        }

        private void btn_suancc_Click(object sender, EventArgs e)
        {
            txt_manhacungcap.Enabled = false;
            panel3.Enabled = true;
            is_insert = false;
        }

        private void btn_luuncc_Click(object sender, EventArgs e)
        {
            if (is_insert)
            {
                if (string.IsNullOrEmpty(txt_manhacungcap.Text) || string.IsNullOrEmpty(txt_tenncc.Text) || string.IsNullOrEmpty(txt_sdtncc.Text) || string.IsNullOrEmpty(txt_diachincc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    NhaCungCapModel formData = new NhaCungCapModel();
                    formData.maNCC = txt_manhacungcap.Text;
                    formData.tenNCC = txt_tenncc.Text;
                    formData.sdtNCC = txt_sdtncc.Text;
                    formData.diachiNCC = txt_diachincc.Text;

                    int res = nhacungcap.InsertNCC(formData);
                    if (res > 0)
                    {
                        datasearchnc_ncc.DataSource = nhacungcap.LoadNCC();
                        MessageBox.Show("Thêm nhà cung cấp thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp thất bại!");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt_manhacungcap.Text) || string.IsNullOrEmpty(txt_tenncc.Text) || string.IsNullOrEmpty(txt_sdtncc.Text) || string.IsNullOrEmpty(txt_diachincc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    NhaCungCapModel formData = new NhaCungCapModel();
                    formData.maNCC = txt_manhacungcap.Text;
                    formData.tenNCC = txt_tenncc.Text;
                    formData.sdtNCC = txt_sdtncc.Text;
                    formData.diachiNCC = txt_diachincc.Text;

                    int res = nhacungcap.UpdateNCC(formData);
                    if (res > 0)
                    {
                        datasearchnc_ncc.DataSource = nhacungcap.LoadNCC();
                        MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thất bại!");
                    }
                }
            }
        }

        private void btn_xoancc_Click(object sender, EventArgs e)
        {

            int res = 0;
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                res = nhacungcap.DeleteNCC(txt_manhacungcap.Text);
                if (res > 0)
                {
                    DataTable dt = nhacungcap.LoadNCC();
                    datasearchnc_ncc.DataSource = dt;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btn_huyncc_Click(object sender, EventArgs e)
        {
            txt_manhacungcap.Text = "";
            txt_tenncc.Text = "";
            txt_sdtncc.Text = "";
            txt_diachincc.Text = "";
        }

        private void btn_thoatncc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
