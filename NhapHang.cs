using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

using ClosedXML.Excel;
using System.ComponentModel.Composition.Primitives;

namespace SHOP_CDH
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }

        private string imagePath;
        private HangHoaBLL hanghoa = new HangHoaBLL();
        private ConnectData data = new ConnectData();
        private bool is_insert1 = true;
        private HangHoaBLL tonkho = new HangHoaBLL();

        private int CountSP()
        {
            int soluong = 0;
             
            SqlConnection conn = data.GetConnect();
            string sql = "select count(MaSP) from SanPham";
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

        private void LoadSP()
        {

            SqlConnection conn = data.GetConnect();
            string sql = "select * from SanPham";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhacungcap nhacungcap = new Nhacungcap();
            nhacungcap.ShowDialog();
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
            Doanhthu doanhthu = new Doanhthu();
            doanhthu.ShowDialog();
            this.Close();
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {

        }

        private void dssanpham_Load(object sender, EventArgs e)
        {
            //panel1.Enabled = false;
            txt_masp.Enabled = false;
            LoadSP();
            dataGridView1.DataSource = hanghoa.LoadHanghoa();
            int soluong = CountSP();
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

        private void btn_thoatsp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }


        private void txt_searchma_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hanghoa.Search(txt_searchma.Text);

        }

        private void txt_giabansp_TextChanged(object sender, EventArgs e)
        {
            string input = txt_giabansp.Text;
            bool isNumberic = true;
            if (txt_giabansp.Text == "")
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
                txt_giabansp.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_soluongsp_TextChanged(object sender, EventArgs e)
        {
            string input = txt_soluongsp.Text;
            bool isNumberic = true;
            if (txt_soluongsp.Text == "")
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
                txt_soluongsp.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                txt_masp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_tensp.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txt_giabansp.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txt_soluongsp.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                string imageName = dataGridView1.Rows[index].Cells[6].Value?.ToString() ?? "";
                string imagePath = Path.Combine(Application.StartupPath, "/HÌNH ẢNH THỊ HÒA\\THỊ HÒA/" + imageName);
                try
                {
                   /* MessageBox.Show("Đường dẫn hình ảnh: " + imagePath);*/ // Thêm MessageBox để kiểm tra đường dẫn
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                }
                comboBox3.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Chọn ảnh sản phẩm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Lấy tên của tệp ảnh (không bao gồm đường dẫn)
                imagePath = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void btn_themsp_Click_1(object sender, EventArgs e)
        {
            is_insert1 = true;
            panel1.Enabled = true;
            txt_masp.Enabled = true;
            btn_luusp.Enabled = true;

            txt_masp.Clear();
            txt_tensp.Clear();
            txt_giabansp.Clear();
            txt_soluongsp.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void btn_suasp_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            is_insert1 = false;
            txt_masp.Enabled = false;
            btn_luusp.Enabled = true;
        }

        private void btn_xoasp_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa nhập hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string masp = txt_masp.Text;

                int kq = hanghoa.DeleteSP(masp);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa nhập hàng thành công ");

                    hanghoa.XoaXuatHang(masp);
                    LoadSP();
                }
                else
                {
                    MessageBox.Show("Xóa nhập hàng Thất bại");
                }
            }
        }

        private void btn_luusp_Click_1(object sender, EventArgs e)
        { 
            if (is_insert1)
            {
                if (string.IsNullOrEmpty(txt_tensp.Text) || string.IsNullOrEmpty(txt_giabansp.Text) || string.IsNullOrEmpty(txt_soluongsp.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(imagePath) || string.IsNullOrEmpty(comboBox3.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        if (hanghoa.CheckExistMasp(txt_masp.Text))
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng chọn mã sản phẩm khác.");
                            return;
                        }

                        //insert 
                        HangHoaModel formData = new HangHoaModel();
                        formData.Masp = txt_masp.Text;
                        formData.Tensp = txt_tensp.Text;
                        formData.Giaban = int.Parse(txt_giabansp.Text);
                        formData.Soluong = int.Parse(txt_soluongsp.Text);
                        formData.Danhmuc = comboBox1.Text;
                        formData.Size = comboBox2.Text;
                        formData.Hinhanh = imagePath; // Sử dụng biến imagePath
                        formData.Nhacungcap = comboBox3.Text;

                        int res = hanghoa.InsertSP(formData);
                        if (res > 0)
                        {


                            dataGridView1.DataSource = hanghoa.LoadHanghoa();
                            MessageBox.Show("Thêm Sản phẩm  thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    HangHoaModel formData = new HangHoaModel();
                    formData.Masp = txt_masp.Text;
                    formData.Tensp = txt_tensp.Text;
                    formData.Giaban = int.Parse(txt_giabansp.Text);
                    formData.Soluong = int.Parse(txt_soluongsp.Text);
                    formData.Danhmuc = comboBox1.Text;
                    formData.Size = comboBox2.Text;
                    formData.Hinhanh = imagePath; // Sử dụng biến imagePath
                    formData.Nhacungcap = comboBox3.Text;

                    int res = hanghoa.UpdateSP(formData);
                    if (res > 0)
                    {
                        dataGridView1.DataSource = hanghoa.LoadHanghoa();
                        MessageBox.Show("Sửa Sản phẩm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
                }
            }
        }

        private void btn_huysp_Click_1(object sender, EventArgs e)
        {
            // Xóa dữ liệu đã nhập trên form
            txt_masp.Clear();
            txt_tensp.Clear();
            txt_giabansp.Clear();
            txt_soluongsp.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox1.Image = null;
            comboBox3.SelectedIndex = -1;

            // Vô hiệu hóa panel
            panel1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            XuatHang xuathang = new XuatHang();
            xuathang.ShowDialog();
            this.Close();

            int valueFromTextBox = int.Parse(txt_soluongsp.Text); // Lấy giá trị từ textBox trên Form A
            XuatHang formB = new XuatHang(valueFromTextBox);
            formB.Show(); // Hiển thị Form B
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void txt_giabansp_TextChanged_1(object sender, EventArgs e)
        {
            string input = txt_giabansp.Text;
            bool isNumberic = true;
            if (txt_giabansp.Text == "")
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
                txt_giabansp.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_soluongsp_TextChanged_1(object sender, EventArgs e)
        {
            string input = txt_soluongsp.Text;
            bool isNumberic = true;
            if (txt_soluongsp.Text == "")
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
                txt_soluongsp.Text = string.Empty; // Xóa nội dung không hợp lệ
                MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_searchma_TextChanged_1(object sender, EventArgs e)
        {
            string s = txt_searchma.Text;
            dataGridView1.DataSource = hanghoa.Search(s);
        }
    }
}
