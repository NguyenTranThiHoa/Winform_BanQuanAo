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
using System.Data.SqlClient;
using System.IO;
using SHOP_CDH.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOP_CDH
{
    public partial class XuatHang : Form
    {
        private int Soluong { get; set; }

        public XuatHang()
        {
            InitializeComponent();
        }

        public XuatHang(int value)
        {
            InitializeComponent();
            Soluong = value;
        }

        private string imagePath;
        private HangHoaBLL hanghoa = new HangHoaBLL();
        private ConnectData data = new ConnectData();
        private bool is_insert2 = true;
        private HangHoaBLL tonkho = new HangHoaBLL();

        private int CountXuatHang()
        {
            int soluong = 0;

            SqlConnection conn = data.GetConnect();
            string sql = "select count(MaSP) from XuatHang";
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
        private void LoadNhaCungCap()
        {
            SqlConnection conn = data.GetConnect();
            string sql = "SELECT TenNhaCC FROM NhaCungCap";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                // Tạo một danh sách chứa các tên nhà cung cấp
                List<string> nhaCungCapList = new List<string>();

                // Duyệt qua các bản ghi và thêm tên nhà cung cấp vào danh sách
                while (reader.Read())
                {
                    string tenNCC = reader["TenNhaCC"].ToString();
                    nhaCungCapList.Add(tenNCC);
                }
                reader.Close();

                // Gán danh sách các tên nhà cung cấp vào combobox
                comboBox3.DataSource = nhaCungCapList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhà cung cấp: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadXuatHang()
        {

            SqlConnection conn = data.GetConnect();
            string sql = "select * from XuatHang";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra DataGridView có dữ liệu hay không
                if (dataGridView1.Rows.Count == 0)
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
                    ExportToExcel(dataGridView1, saveFileDialog.FileName);
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

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoadon hoadon = new Hoadon();
            hoadon.ShowDialog();
            this.Close();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khachhang khachhang1 = new Khachhang();
            khachhang1.ShowDialog();
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

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang dssanpham = new NhapHang();
            dssanpham.ShowDialog();
            this.Close();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            is_insert2 = true;
            panel1.Enabled = true;
            txt_masp.Enabled = true;
            txt_tensp.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            btn_luusp.Enabled = true;

            txt_masp.Clear();
            txt_tensp.Clear();
            txt_giaxuatsp.Clear();
            txt_soluonhxuat.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void btn_luusp_Click(object sender, EventArgs e)
        {
            if (is_insert2)
            {
                if (string.IsNullOrEmpty(txt_masp.Text) || string.IsNullOrEmpty(txt_tensp.Text) || string.IsNullOrEmpty(txt_giaxuatsp.Text) || string.IsNullOrEmpty(txt_soluonhxuat.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        string maSP = txt_masp.Text;
                        int soLuongXuat = int.Parse(txt_soluonhxuat.Text);

                        // Kiểm tra xem sản phẩm đã tồn tại trong danh sách xuất hàng chưa
                        if (hanghoa.CheckExistMasp1(txt_masp.Text))
                        {
                            // Nếu sản phẩm đã tồn tại, cập nhật số lượng xuất cho sản phẩm đó
                            int res1 = hanghoa.CapNhatSoLuongXuatHang(txt_masp.Text, int.Parse(txt_soluonhxuat.Text));
                            int res2 = hanghoa.CapNhatSoLuongSanPham(txt_masp.Text, int.Parse(txt_soluonhxuat.Text));
                            if (res1 > 0 && res2 > 0)
                            {
                                dataGridView1.DataSource = hanghoa.LoadXuatHang();
                                MessageBox.Show("Cập nhật số lượng xuất thành công");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật số lượng xuất thất bại!");
                            }
                        }
                        else
                        {
                            // Nếu sản phẩm chưa tồn tại, thêm mới xuất hàng
                            XuatHang_DTO formData = new XuatHang_DTO();
                            formData.MaSP = txt_masp.Text;
                            formData.TenSP = txt_tensp.Text;
                            formData.GiaBan = int.Parse(txt_giaxuatsp.Text);
                            formData.SoLuongXuat = int.Parse(txt_soluonhxuat.Text);
                            formData.DanhMuc = comboBox1.Text;
                            formData.Size = comboBox2.Text;
                            formData.NhaCungCap = comboBox3.Text;
                            formData.HinhAnh = imagePath;

                            int res = hanghoa.ThemXuatHang(formData);
                            if (res > 0)
                            {
                                dataGridView1.DataSource = hanghoa.LoadXuatHang();
                                MessageBox.Show("Thêm xuất hàng thành công");
                                hanghoa.CapNhatSoLuongSanPham(maSP, soLuongXuat);
                            }
                            else
                            {
                                MessageBox.Show("Thêm xuất hàng thất bại!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm xuất hàng: " + ex.Message);
                    }
                }
            }
            /**************************************Cập nhật Xuất hàng******************************************/
            else
            {
                try
                {
                    XuatHang_DTO formData = new XuatHang_DTO();
                    formData.MaSP = txt_masp.Text;
                    formData.TenSP = txt_tensp.Text;
                    formData.GiaBan = int.Parse(txt_giaxuatsp.Text);
                    formData.SoLuongXuat = int.Parse(txt_soluonhxuat.Text);
                    formData.DanhMuc = comboBox1.Text;
                    formData.Size = comboBox2.Text;
                    formData.NhaCungCap = comboBox3.Text;

                    string maSP = txt_masp.Text;
                    int soLuongXuatMoi = int.Parse(txt_soluonhxuat.Text);

                    int soLuongXuatCu = hanghoa.LaySoLuongXuatCu(formData.MaSP);

                    // Kiểm tra xem sản phẩm đã tồn tại trong danh sách xuất hàng chưa
                    if (hanghoa.CheckExistMasp1(txt_masp.Text))
                    {
                        // Nếu sản phẩm đã tồn tại, lấy giá trị số lượng xuất cũ từ cơ sở dữ liệu
                        soLuongXuatCu = hanghoa.LaySoLuongXuatCu(txt_masp.Text);
                    }

                    // Cập nhật số lượng mới (SoLuongXuatMoi)
                    int res1 = hanghoa.CapNhat1(maSP, soLuongXuatMoi, soLuongXuatCu);

                    // Cập nhật thông tin xuất hàng
                    int res2 = hanghoa.CapNhatXuatHang(formData);

                    // Cập nhật lại số lượng xuất mới trong bảng xuất hàng
                    int res3 = hanghoa.CapNhat2(maSP, soLuongXuatMoi);

                    if (res1 > 0 && res2 > 0 && res3 > 0)
                    {
                        dataGridView1.DataSource = hanghoa.LoadXuatHang();
                        MessageBox.Show("Cập nhật số lượng xuất thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật số lượng xuất thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm xuất hàng: " + ex.Message);
                }
            }
        }

        private void txt_masp_TextChanged(object sender, EventArgs e)
        {
            string maSP = txt_masp.Text;

            if (!string.IsNullOrEmpty(maSP))
            {
                DataTable dt = hanghoa.HienThiThongTin(maSP);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txt_tensp.Text = row["TenSP"].ToString();
                    txt_giaxuatsp.Text = row["GiaBan"].ToString();
                    comboBox1.Text = row["DanhMuc"].ToString();
                    comboBox2.Text = row["Size"].ToString();
                    string imageName = row["HinhAnh"].ToString();
                    string imagePath = Path.Combine(Application.StartupPath, "/HÌNH ẢNH THỊ HÒA\\THỊ HÒA/", imageName);
                    try
                    {
                        //MessageBox.Show("Đường dẫn hình ảnh: " + imagePath); // Thêm MessageBox để kiểm tra đường dẫn
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                    }
                    comboBox3.Text = row["NhaCungCap"].ToString();
                }
                else
                {

                }
            }
        }

        private void XuatHang_Load_1(object sender, EventArgs e)
        {
            //panel1.Enabled = false;
            txt_masp.Enabled = false;
            LoadXuatHang();
            dataGridView1.DataSource = hanghoa.LoadXuatHang();
            int soluong = CountXuatHang();
            LoadNhaCungCap();

            btn_luusp.Enabled = false;

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
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            is_insert2 = false;
            txt_masp.Enabled = true;
            btn_luusp.Enabled = true;

            txt_tensp.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
        }

        private void btn_huysp_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu đã nhập trên form
            txt_masp.Clear();
            txt_tensp.Clear();
            txt_giaxuatsp.Clear();
            txt_soluonhxuat.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox1.Image = null;
            comboBox3.SelectedIndex = -1;

            // Vô hiệu hóa panel
            panel1.Enabled = false;
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa Xuất hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string masp = txt_masp.Text;

                int soLuongBanDau = hanghoa.LaySoLuongBanDau(masp);

                int soLuongDaXuat = hanghoa.LaySoLuongXuatCu(masp);

                int soLuongSauXoa = soLuongBanDau + soLuongDaXuat;

                int kq = hanghoa.XoaXuatHang(masp);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa Xuất hàng thành công ");

                    hanghoa.CapNhatXoa(masp, soLuongSauXoa);

                    LoadXuatHang(); 
                }
                else
                {
                    MessageBox.Show("Xóa Xuất hàng Thất bại");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                txt_masp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_tensp.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txt_giaxuatsp.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txt_soluonhxuat.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                //string imageName = dataGridView1.Rows[index].Cells[6].Value.ToString();
                //string imagePath = Path.Combine(Application.StartupPath, "/HÌNH ẢNH THỊ HÒA\\THỊ HÒA/" + imageName);
                //try
                //{
                //    MessageBox.Show("Đường dẫn hình ảnh: " + imagePath); // Thêm MessageBox để kiểm tra đường dẫn
                //    pictureBox1.Image = Image.FromFile(imagePath);
                //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                //}
                comboBox3.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            }
        }

        private void txt_giaxuatsp_TextChanged(object sender, EventArgs e)
        {
            string input = txt_giaxuatsp.Text;
            bool isNumberic = true;
            if (txt_giaxuatsp.Text == "")
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
                txt_giaxuatsp.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_soluonhxuat_TextChanged(object sender, EventArgs e)
        {
            string input = txt_soluonhxuat.Text;
            bool isNumberic = true;
            if (txt_soluonhxuat.Text == "")
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
                txt_soluonhxuat.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_searchma_TextChanged(object sender, EventArgs e)
        {
            string s = txt_searchma.Text;
            dataGridView1.DataSource = hanghoa.Search1(s);
        }

        private void btn_thoatsp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }   
}
