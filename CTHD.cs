using iTextSharp.text;
using iTextSharp.text.pdf;
using SHOP_CDH.BLL;
using SHOP_CDH.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;


namespace SHOP_CDH
{
    public partial class CTHD : Form
    {
        private string document;

        private string imagePath;

        private NguoiDungBLL chitiet_hoadon = new NguoiDungBLL();

        private bool is_insert = true;

        public CTHD()
        {
            InitializeComponent();
        }

        public SqlConnection GetConnect()
        {
            string chuoiKN = @"Data Source=DESKTOP-57Q2OCR\SQLEXPRESS01;Initial Catalog=QLBH_QA;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(chuoiKN);
            return conn;
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang dssanpham = new NhapHang();
            dssanpham.ShowDialog();
            this.Close();
        }

        private void CTHD_Load(object sender, EventArgs e)
        {

            // Thêm các giá trị cho comboBox1 (Danh mục)
            comboBox1.Items.Add("Quần short");
            comboBox1.Items.Add("Áo crop top");
            comboBox1.Items.Add("Quần Ống Suông");
            comboBox1.Items.Add("Quần Jean");
            comboBox1.Items.Add("Áo len");
            comboBox1.Items.Add("Áo thun");
            comboBox1.Items.Add("Áo Hoodie");

            // Thêm các giá trị cho comboBox2 (Size)
            comboBox2.Items.Add("S");
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("L");
            comboBox2.Items.Add("XL");

            txt_mahd.Enabled = false;
            dataGridView_cthd.DataSource = chitiet_hoadon.LoadCombinedData();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doanhthu doanhthu = new Doanhthu();
            doanhthu.ShowDialog();
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
            Hoadon donhang1 = new Hoadon();
            donhang1.ShowDialog();
            this.Close();
        }

        private void btn_luucthd_Click(object sender, EventArgs e)
        {

            if (is_insert)
            {
                if (string.IsNullOrEmpty(txt_mahd.Text) || string.IsNullOrEmpty(txt_masanpham.Text) || string.IsNullOrEmpty(txt_tensanpham.Text) ||
                    string.IsNullOrEmpty(txt_slsanpham.Text) || string.IsNullOrEmpty(txt_dongia.Text) || string.IsNullOrEmpty(txt_manv.Text) ||
                    string.IsNullOrEmpty(txt_makh.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    if (chitiet_hoadon.CheckExistMasp(txt_mahd.Text))
                    {
                        MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng chọn mã hóa đơn khác.");
                        return;
                    }

                    string maSP = txt_masanpham.Text;
                    int SoLuongBan = int.Parse(txt_slsanpham.Text);
                    int SoLuongXuatHienTai = chitiet_hoadon.LaySoLuongXuatHienTai(maSP);

                    // Kiểm tra SoLuongXuatHienTai có đủ lớn để trừ đi số lượng bán hay không
                    if (SoLuongXuatHienTai >= SoLuongBan)
                    {
                        int SoLuongXuatMoi = SoLuongXuatHienTai - SoLuongBan; // Tính toán số lượng xuất mới

                        int res = chitiet_hoadon.CapNhatSoLuongXuatHienTai_khiThem_CTHD(maSP, SoLuongBan);
                        if (res > 0)
                        {
                            ChiTietHD_DTO formData = new ChiTietHD_DTO();

                            formData.MaHD = txt_mahd.Text;
                            formData.MaSP = txt_masanpham.Text;
                            formData.TenSP = txt_tensanpham.Text;
                            formData.SoLuongBan = int.Parse(txt_slsanpham.Text);
                            formData.DonGiaBan = int.Parse(txt_dongia.Text);
                            formData.Size = comboBox2.Text;

                            formData.ThanhTien = formData.SoLuongBan * formData.DonGiaBan;

                            txt_thanhtien.Text = formData.ThanhTien.ToString();

                            HoaDon_DTO hdData = new HoaDon_DTO();
                            hdData.MaHD = txt_mahd.Text;
                            hdData.MaKH = txt_makh.Text;
                            hdData.MaNV = txt_manv.Text;
                            hdData.NgayLapHD = dateTimePicker1.Value;

                            // Thêm thành công chi tiết hóa đơn
                            int res2 = chitiet_hoadon.InsertChiTietHoaDon(formData, hdData);
                            if (res2 > 0)
                            {
                                dataGridView_cthd.DataSource = chitiet_hoadon.LoadCombinedData();
                                MessageBox.Show("Thêm hóa đơn và cập nhật số lượng xuất thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm hóa đơn thành công nhưng cập nhật số lượng xuất thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật số lượng xuất thất bại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng xuất không đủ!");
                    }
                }
            }
            else
            {
                /*************************************************************/

                try
                {
                    ChiTietHD_DTO formData = new ChiTietHD_DTO();
                    formData.MaSP = txt_masanpham.Text;
                    formData.TenSP = txt_tensanpham.Text;
                    formData.DonGiaBan = int.Parse(txt_dongia.Text);
                    formData.SoLuongBan = int.Parse(txt_slsanpham.Text);
                    formData.ThanhTien = formData.SoLuongBan * formData.DonGiaBan;

                    txt_thanhtien.Text = formData.ThanhTien.ToString();

                    HoaDon_DTO hdData = new HoaDon_DTO();
                    hdData.MaHD = txt_mahd.Text;
                    hdData.MaKH = txt_makh.Text;
                    hdData.MaNV = txt_manv.Text;
                    hdData.NgayLapHD = dateTimePicker1.Value;

                    string maSP = txt_masanpham.Text;
                    int soLuongBanMoi = int.Parse(txt_slsanpham.Text);

                    int soLuongBanCu = chitiet_hoadon.LaySoLuongBanCu(maSP);

                    // Kiểm tra xem sản phẩm đã tồn tại trong danh sách chi tiết hóa đơn chưa
                    if (chitiet_hoadon.CheckExistMasp1(txt_masanpham.Text))
                    {
                        // Nếu sản phẩm đã tồn tại, lấy giá trị số lượng bán cũ từ cơ sở dữ liệu
                        soLuongBanCu = chitiet_hoadon.LaySoLuongBanCu(txt_masanpham.Text);
                    }

                    // Cập nhật số lượng mới (SoLuongBanMoi)
                    int res1 = chitiet_hoadon.CapNhat1(maSP, soLuongBanMoi, soLuongBanCu);

                    // Cập nhật thông tin chi tiết hóa đơn
                    int res2 = chitiet_hoadon.CapNhatCTHD(formData);

                    // Cập nhật lại số lượng xuất mới trong bảng Chi Tiết Hóa đơn
                    int res3 = chitiet_hoadon.CapNhat2(maSP, soLuongBanMoi);
                    if (res1 > 0 && res2 > 0 && res3 > 0)
                    {
                        dataGridView_cthd.DataSource = chitiet_hoadon.LoadCombinedData();
                        MessageBox.Show("Cập nhật số lượng chi tiết hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật số lượng chi tiết hóa đơn thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm xuất hàng: " + ex.Message);
                }
            }
        }

        private void ClearText()
        {
            txt_mahd.Text = "";
            txt_masanpham.Text = "";
            txt_tensanpham.Text = "";
            txt_slsanpham.Text = "";
            txt_dongia.Text = "";
            txt_thanhtien.Text = "";
            txt_makh.Text = "";
            txt_manv.Text = "";
            dateTimePicker1.Text = "";
            pictureBox1.Image = null;
        }

        private void btn_themcthd_Click(object sender, EventArgs e)
        {
            ClearText();
            is_insert = true;
            txt_mahd.Enabled = true;
            txt_tensanpham.Enabled = false;
            comboBox1.Enabled = false;
            txt_dongia.Enabled = false;
            txt_thanhtien.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void btn_huycthd_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            txt_masanpham.Text = "";
            txt_tensanpham.Text = "";
            txt_slsanpham.Text = "";
            txt_dongia.Text = "";
            txt_thanhtien.Text = "";
            txt_makh.Text = "";
            txt_manv.Text = "";
            dateTimePicker1.Text = "";
        }

        private void txt_masanpham_TextChanged(object sender, EventArgs e)
        {
            string maSP = txt_masanpham.Text;

            if (!string.IsNullOrEmpty(maSP))
            {
                DataTable dt = chitiet_hoadon.HienThiThongTin(maSP);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txt_tensanpham.Text = row["TenSP"].ToString();
                    txt_dongia.Text = row["GiaBan"].ToString();
                    comboBox1.Text = row["DanhMuc"].ToString();
                    comboBox2.Text = row["Size"].ToString();
                    string imageName = row["HinhAnh"].ToString();
                    string imagePath = Path.Combine(Application.StartupPath, "/HÌNH ẢNH THỊ HÒA\\THỊ HÒA/", imageName);
                    try
                    {
                        //MessageBox.Show("Đường dẫn hình ảnh: " + imagePath); // Thêm MessageBox để kiểm tra đường dẫn
                        pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                    }
                }
                else
                {

                }
            }
        }

        private void btn_xoacthd_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa chi tiết đơn hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string mahd = txt_mahd.Text;

                string masp = txt_masanpham.Text;

                int soLuongBanDau = chitiet_hoadon.LaySoLuongBanDauCTHD(masp);

                int soLuongDaXuat = chitiet_hoadon.LaySoLuongXuatCu(mahd); // Sửa thành mã hóa đơn

                int soLuongSauXoa = soLuongBanDau + soLuongDaXuat;

                int kq = chitiet_hoadon.XoaCTHD(mahd); // Sửa thành mã hóa đơn

                if (kq > 0)
                {
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công ");

                    chitiet_hoadon.CapNhatXoaCTHD(masp, soLuongSauXoa);

                    // Load lại dữ liệu sau khi xóa
                    dataGridView_cthd.DataSource = chitiet_hoadon.LoadCombinedData();
                }
                else
                {
                    MessageBox.Show("Xóa Xuất hàng Thất bại");
                }
            }
        }

        private void dataGridView_cthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView_cthd.Rows.Count)
            {
                txt_mahd.Text = dataGridView_cthd.Rows[index].Cells[0].Value.ToString();
                txt_masanpham.Text = dataGridView_cthd.Rows[index].Cells[1].Value.ToString();
                txt_tensanpham.Text = dataGridView_cthd.Rows[index].Cells[2].Value.ToString();
                txt_dongia.Text = dataGridView_cthd.Rows[index].Cells[3].Value.ToString();
                txt_slsanpham.Text = dataGridView_cthd.Rows[index].Cells[4].Value.ToString();
                txt_thanhtien.Text = dataGridView_cthd.Rows[index].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView_cthd.Rows[index].Cells[6].Value.ToString();
                txt_manv.Text = dataGridView_cthd.Rows[index].Cells[7].Value.ToString();
                txt_makh.Text = dataGridView_cthd.Rows[index].Cells[8].Value.ToString();
                dateTimePicker1.Text = dataGridView_cthd.Rows[index].Cells[9].Value.ToString();
                comboBox1.Text = dataGridView_cthd.Rows[index].Cells[10].Value.ToString();

                string imageName = dataGridView_cthd.Rows[index].Cells[11].Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "/HÌNH ẢNH THỊ HÒA\\THỊ HÒA/" + imageName);
                try
                {
                    //MessageBox.Show("Đường dẫn hình ảnh: " + imagePath); // Thêm MessageBox để kiểm tra đường dẫn
                    pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                }
            }
        }

        private void btn_suacthd_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            is_insert = false;
            txt_mahd.Enabled = false;
            btn_luucthd.Enabled = true;

            txt_masanpham.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            txt_makh.Enabled = false;
            txt_manv.Enabled = false;
            txt_dongia.Enabled = false;
            txt_tensanpham.Enabled = false;
            txt_masanpham.Enabled = false;
        }

        private void btn_xuathd_Click(object sender, EventArgs e)
        {
            CTHD printer = new CTHD();
            printer.PrintInvoice(dataGridView_cthd);
        }

        public void PrintInvoice(DataGridView dataGridView)
        {
            // Tạo tệp PDF mới
            string outputPath = "invoice.pdf";
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
            document.Open();

            // Font cho tiêu đề và nội dung
            Font titleFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, 18);
            Font headerFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, 12);
            Font dataFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, 12);

            // Tiêu đề
            Paragraph title = new Paragraph("CỬA HÀNG BÁN QUẦN ÁO CHD", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);
            document.Add(Chunk.NEWLINE); // Khoảng trống

            // Hóa đơn bán hàng
            Paragraph subTitle = new Paragraph("HÓA ĐƠN BÁN HÀNG", titleFont);
            subTitle.Alignment = Element.ALIGN_CENTER;
            document.Add(subTitle);
            document.Add(Chunk.NEWLINE); // Khoảng trống

            // Ngày in hóa đơn
            Paragraph printDatePara = new Paragraph("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"), dataFont);
            printDatePara.Alignment = Element.ALIGN_RIGHT;
            document.Add(printDatePara);
            document.Add(Chunk.NEWLINE); // Khoảng trống

            // Tạo bảng dữ liệu từ ChiTietHD
            PdfPTable table = new PdfPTable(5); // 5 cột: Mã SP, Tên sản phẩm, Số lượng, Đơn giá, Thành tiền
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2f, 4f, 2f, 2f, 3f }); // Thiết lập tỷ lệ chiều rộng cho các cột

            // Thêm tiêu đề cột
            string[] headers = { "Mã Sản Phẩm", "Tên sản phẩm", "Số lượng", "Đơn giá", "Thành tiền" };
            foreach (string header in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            // Thêm dữ liệu từ ChiTietHD
            double tongTien = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                PdfPCell cell1 = new PdfPCell(new Phrase(row.Cells["MaSP"].Value.ToString(), dataFont));
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell1);

                PdfPCell cell2 = new PdfPCell(new Phrase(row.Cells["TenSP"].Value.ToString(), dataFont));
                cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell(new Phrase(row.Cells["SoLuongBan"].Value.ToString(), dataFont));
                cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell3);

                PdfPCell cell4 = new PdfPCell(new Phrase(row.Cells["DonGiaBan"].Value.ToString(), dataFont));
                cell4.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cell4);

                double thanhTien = Convert.ToDouble(row.Cells["SoLuongBan"].Value) * Convert.ToDouble(row.Cells["DonGiaBan"].Value);
                tongTien += thanhTien;
                PdfPCell cell5 = new PdfPCell(new Phrase(thanhTien.ToString(), dataFont));
                cell5.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cell5);
            }

            document.Add(table);
            document.Add(Chunk.NEWLINE); // Khoảng trống

            // Tổng tiền
            Paragraph totalPara = new Paragraph("Tổng tiền: " + tongTien.ToString(), dataFont);
            totalPara.Alignment = Element.ALIGN_RIGHT;
            document.Add(totalPara);
            document.Add(Chunk.NEWLINE); // Khoảng trống

            // Lời kết
            Paragraph thanksPara = new Paragraph("Cảm ơn quý khách đã mua hàng!", dataFont);
            thanksPara.Alignment = Element.ALIGN_CENTER;
            document.Add(thanksPara);

            // Đóng tài liệu
            document.Close();

            // Mở tệp PDF đã tạo
            System.Diagnostics.Process.Start(outputPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn chi tiết hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string masp = txt_masanpham.Text;

                int soLuongBanDau = chitiet_hoadon.LaySoLuongBanDauCTHD(masp);

                int soLuongDaXuat = chitiet_hoadon.LaySoLuongXuatCu(masp); // Sửa thành mã hóa đơn

                int soLuongSauXoa = soLuongBanDau - soLuongDaXuat;

                int kq = chitiet_hoadon.XoaCTHD(masp); // Sửa thành mã hóa đơn

                if (kq > 0)
                {
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công ");

                    chitiet_hoadon.CapNhatXoaCTHD(masp, soLuongSauXoa);

                    dataGridView_cthd.DataSource = chitiet_hoadon.LoadCombinedData();
                }
                else
                {
                    MessageBox.Show("Xóa chi tiết hóa đơn Thất bại");
                }
            }
        }

        private void txt_searcthd_TextChanged(object sender, EventArgs e)
        {
            string s = txt_searcthd.Text;
            dataGridView_cthd.DataSource = chitiet_hoadon.Search2(s);
        }

        private void txt_slsanpham_TextChanged(object sender, EventArgs e)
        {
            string input = txt_slsanpham.Text;
            bool isNumberic = true;
            if (txt_slsanpham.Text == "")
            {
                return;
            }
            // Kiểm tra từng ký tự trong chuỗi
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    isNumberic = false;
                    break; // Nếu tìm thấy ký tự số, thoát vòng lặp
                }
            }

            // Nếu chuỗi nhập vào chứa ký tự số, loại bỏ nó
            if (isNumberic)
            {
                txt_slsanpham.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
