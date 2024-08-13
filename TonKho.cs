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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SHOP_CDH
{
    public partial class TonKho : Form
    {
        public TonKho()
        {
            InitializeComponent();
        }

        private string imagePath;
        private ConnectData data = new ConnectData();
        private TonKhoBLL tonkho = new TonKhoBLL();

        private bool is_insert2 = true;

        private int CountTonKho()
        {
            int soluong = 0;

            SqlConnection conn = data.GetConnect();
            string sql = "select count(MaSP) from TonKho";
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

        private void LoadTonKho()
        {

            SqlConnection conn = data.GetConnect();
            string sql = "select * from TonKho";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHang dssanpham = new NhapHang();
            dssanpham.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                txt_masp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_tensp.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txt_gianhap.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txt_giabansp.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txt_soluonghangton.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
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
                comboBox3.Text = dataGridView1.Rows[index].Cells[7].Value?.ToString();
                comboBox2.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void TonKho_Load(object sender, EventArgs e)
        {
            //panel1.Enabled = false;
            txt_masp.Enabled = false;
            //LoadTonKho();
            //dataGridView1.DataSource = tonkho.LoadTonKho();
            int soluong = CountTonKho();
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
    }
}
