using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHOP_CDH.DTO;
using SHOP_CDH.DAL;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOP_CDH.BLL
{
    public class NguoiDungBLL
    {
        private ConnectData connectData = new ConnectData(); // Tạo một instance của lớp ConnectData
        public SqlConnection GetConnect()
        {
            string chuoiKN = @"Data Source=DESKTOP-57Q2OCR\SQLEXPRESS01;Initial Catalog=QLBH_QA;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(chuoiKN);
            return conn;
        }

        public void KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sql = "SELECT * FROM DangNhap WHERE TaiKhoan = @taiKhoan AND MatKhau = @matKhau";
            using (SqlConnection conn = GetConnect())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@matKhau", matKhau);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Hiển thị thông báo khi đăng nhập thành công
                                MessageBox.Show("Bạn đã đăng nhập thành công!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                NhapHang mainForm = new NhapHang();
                                mainForm.Show();
                            }
                            else
                            {
                                // Hiển thị thông báo khi đăng nhập thất bại
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo khi xảy ra lỗi
                        MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void DangKy(string taiKhoan, string matKhau)
        {
            // Kiểm tra xem tài khoản và mật khẩu không rỗng trước khi đăng ký
            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không tiếp tục nếu thông tin chưa đầy đủ
            }

            // Kiểm tra xem tài khoản đã tồn tại trong cơ sở dữ liệu chưa
            KiemTraTonTaiTaiKhoan(taiKhoan, matKhau);
        }

        private void KiemTraTonTaiTaiKhoan(string taiKhoan, string matKhau)
        {
            string sql = "SELECT COUNT(*) FROM DangNhap WHERE TaiKhoan = @taiKhoan";
            using (SqlConnection conn = connectData.GetConnect())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Thêm thông tin tài khoản mới vào cơ sở dữ liệu
                        string insertSql = "INSERT INTO DangNhap (TaiKhoan, MatKhau) VALUES (@taiKhoan, @matKhau)";
                        SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                        insertCmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                        insertCmd.Parameters.AddWithValue("@matKhau", matKhau);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DangNhap formDanghNhap = new DangNhap();
                        // Hiển thị form đăng ký
                        formDanghNhap.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi kiểm tra tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**********************************************Load hóa đơn**********************************************/

        public DataTable LoadHD()
        {
            string sql = "SELECT HoaDon1.MaHD, HoaDon1.MaKH, HoaDon1.MaNV, HoaDon1.NgayLapHD, ChiTietHD.ThanhTien " +
                         "FROM HoaDon1 " +
                         "INNER JOIN ChiTietHD ON HoaDon1.MaHD = ChiTietHD.MaHD";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        /*******************************************Load chi tiết hóa đơn************************************************/
        public DataTable LoadCombinedData()
        {
            string sql = "SELECT ChiTietHD.MaHD, " +
                 "SanPham.MaSP, " +
                 "ChiTietHD.TenSP, " +
                 "ChiTietHD.DonGiaBan, " +
                 "ChiTietHD.SoLuongBan, " +
                 "ChiTietHD.ThanhTien, " +
                 "ChiTietHD.Size, " +
                 "HoaDon1.MaNV, " +
                 "HoaDon1.MaKH, " +
                 "HoaDon1.NgayLapHD, " +
                 "SanPham.DanhMuc, " +
                 "SanPham.HinhAnh "+
                 "FROM ChiTietHD " +
                 "INNER JOIN SanPham ON ChiTietHD.MaSP = SanPham.MaSP " +
                 "INNER JOIN HoaDon1 ON ChiTietHD.MaHD = HoaDon1.MaHD";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        /*******************************************Hóa đơn************************************************/
        public int UpdateDonHang(HoaDon_DTO hd)
        {
            string sql = "UPDATE HoaDon1 SET NgayLapHD = '" + hd.NgayLapHD + "' WHERE MaHD = '" + hd.MaHD + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int DeleteHoaDon(string MaHD)
        {
            string sql = "DELETE HoaDon1 WHERE MaHD ='" + MaHD + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        /*****************************************Thêm Chi tiết hóa đơn**************************************************/
        public int InsertChiTietHoaDon(ChiTietHD_DTO cthd, HoaDon_DTO hd)
        {
            string sqlHD = "INSERT INTO HoaDon1 (MaHD, MaKH, MaNV, NgayLapHD) " +
                                        "VALUES ('" + hd.MaHD + "', '" + hd.MaKH + "', '" + hd.MaNV + "', '" + hd.NgayLapHD + "')";

            string sqlCTHD = "INSERT INTO ChiTietHD (MaHD, MaSP, TenSP, SoLuongBan, DonGiaBan, ThanhTien, Size) " +
                                            "VALUES ('" + cthd.MaHD + "', '" + cthd.MaSP + "', N'" + cthd.TenSP + "', " + cthd.SoLuongBan + ", " + cthd.DonGiaBan + ", " + cthd.ThanhTien + ", N'" + cthd.Size + "')";

            int rowsAffectedChiTietHD = connectData.ChangeData(sqlCTHD);

            int rowsAffectedHoaDon = connectData.ChangeData(sqlHD);

            if (rowsAffectedChiTietHD > 0 && rowsAffectedHoaDon > 0)
            {
                return 1; // Thành công
            }
            else
            {
                return 0; // Thất bại
            }
        }

        /********************************Kiểm tra trùng mã hóa đơn***********************************************/
        public bool CheckExistMasp(string MaHD)
        {
            SqlConnection conn = connectData.GetConnect();
            string sql = "SELECT COUNT(*) FROM ChiTietHD WHERE MaHD = @mahd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahd", MaHD);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra mã hóa đơn: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /***************************************Text_changed hiển thị sản phẩm theo MaSP***************************************************/
        public DataTable HienThiThongTin(string MaSP)
        {
            string sql = "SELECT TenSP, GiaBan, DanhMuc, Size, HinhAnh FROM XuatHang WHERE MaSP = '" + MaSP + "'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }
        /**************************************THÔNG TIN VỀ THÊM CHI TIẾT ĐƠN HÀNG******************************************/
        public int LaySoLuongXuatHienTai(string maSP)
        {
            int soLuongXuatHienTai = 0;

            string query = "SELECT SoLuongXuat FROM XuatHang WHERE MaSP = @MaSP";

            using (SqlConnection connection = connectData.GetConnect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", maSP);

                try
                {
                    connection.Open();
                    soLuongXuatHienTai = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn số lượng xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; 
                }
            }
            return soLuongXuatHienTai;
        }

        public int CapNhatSoLuongXuatHienTai_khiThem_CTHD(string maSP, int SoLuongBan)
        {
            int SoLuongXuatHienTai = LaySoLuongXuatHienTai(maSP);
            int SoLuongXuatMoi = SoLuongXuatHienTai - SoLuongBan; // Tính toán số lượng xuất mới

            string sql = "UPDATE XuatHang SET SoLuongXuat = " + SoLuongXuatMoi + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        /***************************************THÔNG TIN VỀ CẬP NHẬT CHI TIẾT ĐƠN HÀNG *************************************************/
        public int CapNhat1(string maSP, int soLuongBanMoi, int soLuongBanCu)
        {
            string sql = "UPDATE XuatHang SET SoLuongXuat = SoLuongXuat + " + soLuongBanCu + " - " + soLuongBanMoi + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhat2(string maSP, int soLuongBanMoi)
        {
            // Cập nhật số lượng xuất hàng trong bảng XuatHang
            string sql = "UPDATE ChiTietHD SET SoLuongBan = " + soLuongBanMoi + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhatCTHD(ChiTietHD_DTO xh)
        {
            string sql = "UPDATE ChiTietHD SET DonGiaBan = '" + xh.DonGiaBan + "', SoLuongBan = '" + xh.SoLuongBan + "' WHERE MaSP = '" + xh.MaSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int LaySoLuongBanCu(string maSP)
        {
            int soLuongXuatCu = 0;
            string sql = "SELECT SoLuongBan FROM ChiTietHD WHERE MaSP = @MaSP";

            using (SqlConnection connection = connectData.GetConnect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        soLuongXuatCu = Convert.ToInt32(reader["SoLuongBan"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn số lượng chi tiết hóa đơn cũ: " + ex.Message);
                }
            }
            return soLuongXuatCu;
        }

        public bool CheckExistMasp1(string MaSP)
        {
            SqlConnection conn = connectData.GetConnect();
            string sql = "SELECT COUNT(*) FROM ChiTietHD WHERE MaSP = @masp";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masp", MaSP);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra mã sản phẩm trong hóa đơn: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /************************************THÔNG TIN VỀ XÓA XUẤT HẢNG SẢN PHẨM******************************************/
        public DataTable Search2(string s)
        {
            string sql = "SELECT * FROM ChiTietHD WHERE TenSP LIKE N'%" + s + "%' OR MaSP LIKE'%" + s + "%'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        public int XoaCTHD(string MaSP)
        {
            string sql = "DELETE ChiTietHD WHERE MaSP ='" + MaSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhatXoaCTHD(string maSP, int soLuongSauXoa)
        {
            string sql = "UPDATE XuatHang SET SoLuongXuat = " + soLuongSauXoa + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int LaySoLuongBanDauCTHD(string maSP)
        {
            int soLuongBanDau = 0;

            string sql = "SELECT SoLuongXuat FROM XuatHang WHERE MaSP = @MaSP";

            using (SqlConnection connection = connectData.GetConnect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        soLuongBanDau = Convert.ToInt32(reader["SoLuongXuat"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn số lượng xuất hàng cũ: " + ex.Message);
                }
            }
            return soLuongBanDau;
        }

        public int LaySoLuongXuatCu(string maSP)
        {
            int soLuongXuatCu = 0;
            string sql = "SELECT SoLuongBan FROM ChiTietHD WHERE MaSP = @MaSP";

            using (SqlConnection connection = connectData.GetConnect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        soLuongXuatCu = Convert.ToInt32(reader["SoLuongBan"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn số lượng xuất cũ: " + ex.Message);
                }
            }
            return soLuongXuatCu;
        }

        //public int XoaCTHD(string MaHD)
        //{
        //    string sql = "DELETE ChiTietHD WHERE MaHD ='" + MaHD + "'";
        //    int res = connectData.ChangeData(sql);
        //    return res;
        //}

        //public int CapNhatXoaCTHD(string maSP, int soLuongSauXoa)
        //{
        //    string sql = "UPDATE XuatHang SET SoLuongXuat = " + soLuongSauXoa + " WHERE MaSP = '" + maSP + "'";
        //    int res = connectData.ChangeData(sql);
        //    return res;
        //}

        //public int LaySoLuongBanDauCTHD(string maSP)
        //{
        //    int soLuongBanDau = 0;

        //    string sql = "SELECT SoLuongXuat FROM XuatHang WHERE MaSP = @MaSP";

        //    using (SqlConnection connection = connectData.GetConnect())
        //    {
        //        try
        //        {
        //            connection.Open();
        //            SqlCommand command = new SqlCommand(sql, connection);
        //            command.Parameters.AddWithValue("@MaSP", maSP);
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                soLuongBanDau = Convert.ToInt32(reader["SoLuongXuat"]);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi khi truy vấn số lượng xuất hàng cũ: " + ex.Message);
        //        }
        //    }
        //    return soLuongBanDau;
        //}

        //public int LaySoLuongXuatCu(string maHD)
        //{
        //    int soLuongXuatCu = 0;
        //    string sql = "SELECT SoLuongBan FROM ChiTietHD WHERE MaHD = @MaHD";

        //    using (SqlConnection connection = connectData.GetConnect())
        //    {
        //        try
        //        {
        //            connection.Open();
        //            SqlCommand command = new SqlCommand(sql, connection);
        //            command.Parameters.AddWithValue("@MaHD", maHD);
        //            SqlDataReader reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                soLuongXuatCu += Convert.ToInt32(reader["SoLuongBan"]);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi khi truy vấn số lượng xuất cũ: " + ex.Message);
        //        }
        //    }
        //    return soLuongXuatCu;
        //}
        /********************************************************/

        public DataTable Search3(string s)
        {
            string sql = "SELECT * FROM HoaDon1 WHERE TenSP LIKE N'%" + s + "%' OR MaSP LIKE'%" + s + "%'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }


    }
}
