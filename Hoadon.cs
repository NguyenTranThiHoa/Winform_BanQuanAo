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

using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Excel;
using SHOP_CDH.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOP_CDH
{
    public partial class Hoadon : Form
    {
        private NguoiDungBLL hoadon = new NguoiDungBLL();
        private bool is_insert = true;
        public Hoadon()
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

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoadon donhang = new Hoadon();
            donhang.ShowDialog();
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

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doanhthu doanhthu = new Doanhthu();
            doanhthu.ShowDialog();
            this.Close();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            this.Hide();
            CTHD donhang = new CTHD();
            donhang.ShowDialog();
            this.Close();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            dataGridView_tthd.DataSource = hoadon.LoadHD();
        }

        private void dataGridView_tthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_mahd.Text = dataGridView_tthd.Rows[index].Cells[0].Value.ToString();
                txt_makhhd.Text = dataGridView_tthd.Rows[index].Cells[1].Value.ToString();
                txt_manvhd.Text = dataGridView_tthd.Rows[index].Cells[2].Value.ToString();
                dateTimePicker2.Text = dataGridView_tthd.Rows[index].Cells[3].Value.ToString();
                txt_tongtien.Text = dataGridView_tthd.Rows[index].Cells[4].Value.ToString();
                txt_tongtien.Enabled = false;
            }
        }

        private void ClearText()
        {
            txt_mahd.Text = "";
            txt_makhhd.Text = "";
            txt_manvhd.Text = "";
            txt_tongtien.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btn_xuatExecl_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra DataGridView có dữ liệu hay không
                if (dataGridView_tthd.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Khởi tạo SaveFileDialog để chọn nơi lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
                saveFileDialog.Title = "Chọn nơi lưu file Excel";
                saveFileDialog.FileName = "DataExport.xlsx"; // Tên file mặc định
                saveFileDialog.ShowDialog();

                // Kiểm tra xem người dùng đã chọn đường dẫn lưu file chưa
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    // Gọi phương thức ExportToExcel để xuất dữ liệu từ DataGridView ra file Excel
                    ExportToExcel(dataGridView_tthd, saveFileDialog.FileName);
                    MessageBox.Show("Xuất Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xuất Excel thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất Excel thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                // Lấy dữ liệu từ DataGridView và ghi vào bảng Excel
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Lưu file Excel
                workbook.SaveAs(filePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                excelApp.Quit();
                workbook = null;
                excelApp = null;
                GC.Collect();
            }
        }

        private void btn_huysp_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            txt_makhhd.Text = "";
            txt_manvhd.Text = "";
            txt_tongtien.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            is_insert = true;
            txt_mahd.Enabled = false;
            txt_makhhd.Enabled = false;
            txt_manvhd.Enabled = false;
            btn_luuhd.Enabled = true;
        }

        private void btn_luuhd_Click(object sender, EventArgs e)
        {
            if (is_insert)
            {
                try
                {
                    HoaDon_DTO formData = new HoaDon_DTO();
                    formData.MaHD = txt_mahd.Text;
                    formData.MaKH = txt_makhhd.Text;
                    formData.MaNV = txt_manvhd.Text;
                    formData.NgayLapHD = dateTimePicker2.Value;

                    // Thực hiện cập nhật hóa đơn
                    int res = hoadon.UpdateDonHang(formData);
                    if (res > 0)
                    {
                        dataGridView_tthd.DataSource = hoadon.LoadHD();
                        MessageBox.Show("Sửa Hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa hóa đơn: " + ex.Message);
                }
            }
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string masp = txt_mahd.Text;
                int kq = hoadon.DeleteHoaDon(masp);
                if (kq > 0)
                {
                    dataGridView_tthd.DataSource = hoadon.LoadHD();
                    MessageBox.Show("Xóa hóa đơn thành công ");
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn Thất bại");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            dataGridView_tthd.DataSource = hoadon.Search3(s);
        }

        private void btn_thoatsp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }
    }
}
