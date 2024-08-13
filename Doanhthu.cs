using iTextSharp.text.pdf;
using iTextSharp.text;
using SHOP_CDH.BLL;
using SHOP_CDH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP_CDH
{
    public partial class Doanhthu : Form
    {
        private DoanhthuBLL doanhthuBLL;
        public Doanhthu()
        {
            InitializeComponent();
            doanhthuBLL = new DoanhthuBLL(); // Tạo đối tượng DoanhthuBLL
        }

        private void LoadData_DThu()
        {
            // Lấy dữ liệu từ BLL
            List<DoanhthuDTO> doanhthuData = doanhthuBLL.GetDoanhthuData();

            // Tạo danh sách để lưu trữ dữ liệu cho tất cả các tháng
            List<DoanhthuDTO> doanhthuList = new List<DoanhthuDTO>();

            // Cập nhật giá trị cho các tháng có dữ liệu thực tế
            foreach (var item in doanhthuData)
            {
                // Kiểm tra và thay thế giá trị null bằng 0
                if (item.SoLuongDaBan == null)
                    item.SoLuongDaBan = "0";
                if (item.DoanhThu == null)
                    item.DoanhThu = "0";
                if (item.LoiNhuan == null)
                    item.LoiNhuan = "0";

                doanhthuList.Add(item);
            }

            // Gán danh sách này vào DataGridView để hiển thị
            dataGridView_doanhthu.DataSource = doanhthuList;
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
            Hoadon hoadon = new Hoadon();
            hoadon.ShowDialog();
            this.Close(); ;
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

        private void Doanhthu_Load(object sender, EventArgs e)
        {
            LoadData_DThu();
        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng Document
            Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            try
            {
                // Thực hiện tạo file PDF và mở luồng ghi
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Doanh thu.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        PdfWriter.GetInstance(doc, fs);

                        // Mở Document để bắt đầu viết
                        doc.Open();

                        Paragraph title = new Paragraph("DOANH THU BÁN HÀNG", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24f, iTextSharp.text.Font.BOLD));
                        title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        doc.Add(title);

                        // Thêm dòng trống sau tiêu đề
                        doc.Add(new Paragraph("\n"));

                        // Tạo một bảng PDF với số cột bằng số cột trong DataGridView
                        PdfPTable table = new PdfPTable(dataGridView_doanhthu.Columns.Count);

                        // Thêm tiêu đề từ DataGridView vào bảng PDF
                        for (int i = 0; i < dataGridView_doanhthu.Columns.Count; i++)
                        {
                            table.AddCell(new Phrase(dataGridView_doanhthu.Columns[i].HeaderText));
                        }

                        // Thêm dữ liệu từ DataGridView vào bảng PDF
                        for (int i = 0; i < dataGridView_doanhthu.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView_doanhthu.Columns.Count; j++)
                            {
                                if (dataGridView_doanhthu.Rows[i].Cells[j].Value != null)
                                {
                                    table.AddCell(new Phrase(dataGridView_doanhthu.Rows[i].Cells[j].Value.ToString()));
                                }
                            }
                        }

                        // Thêm bảng vào Document
                        doc.Add(table);

                        // Đóng Document để kết thúc việc viết
                        doc.Close();
                    }

                    MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_doanhthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_thang.Text = dataGridView_doanhthu.Rows[index].Cells[0].Value.ToString();
                txt_soluongban.Text = dataGridView_doanhthu.Rows[index].Cells[1].Value.ToString();
                txt_doanhthu.Text = dataGridView_doanhthu.Rows[index].Cells[2].Value.ToString();
                txt_loinhuan.Text = dataGridView_doanhthu.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btn_thoatnv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
