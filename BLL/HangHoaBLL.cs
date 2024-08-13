using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH.BLL
{
    public class HangHoaBLL
    {
        private ConnectData connectData = new ConnectData();

        public DataTable LoadHanghoa()
        {
            string sql = "SELECT * FROM SanPham";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        public DataTable Search(string s)
        {
            string sql = "SELECT * FROM SanPham WHERE TenSP LIKE N'%" + s + "%' OR MaSP LIKE'%" + s + "%'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        public int DeleteSP(string MaSP)
        {
            string sql = "DELETE SanPham WHERE MaSP ='" + MaSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int InsertSP(HangHoaModel sp)
        {
            string sql = "INSERT INTO SanPham(MaSP, TenSP, GiaBan, SoLuong, DanhMuc, Size, HinhAnh, NhaCungCap) VALUES ('" + sp.Masp + "', N'" + sp.Tensp + "', '" + sp.Giaban + "', '" + sp.Soluong + "', N'" + sp.Danhmuc + "', '" + sp.Size + "', '" + sp.Hinhanh + "', N'" + sp.Nhacungcap + "')";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int UpdateSP(HangHoaModel sp)
        {
            string sql = "UPDATE SanPham SET TenSP = N'" + sp.Tensp + "', GiaBan = '" + sp.Giaban + "', SoLuong = '" + sp.Soluong + "', DanhMuc = N'" + sp.Danhmuc + "', Size = '" + sp.Size + "', HinhAnh = '" + sp.Hinhanh + "', NhaCungCap = N'" + sp.Nhacungcap + "' WHERE MaSP = '" + sp.Masp + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }
        public bool CheckExistMasp(string masp)
        {
            SqlConnection conn = connectData.GetConnect();
            string sql = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @masp";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masp", masp);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra mã sản phẩm: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /********************************Hàm kiểm tra mã đơn hàng của xuất hàng************************************/
        public bool CheckExistMasp1(string maSP)
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn kiểm tra sự tồn tại của Mã sản phẩm
            SqlConnection connection = connectData.GetConnect();
            string query = "SELECT COUNT(*) FROM XuatHang WHERE MaSP = @MaSP";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", maSP);
                int count = (int)command.ExecuteScalar();

                // Nếu số lượng bản ghi có Mã sản phẩm tương ứng lớn hơn 0, tức là sản phẩm tồn tại
                return count > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Lỗi khi kiểm tra sự tồn tại của sản phẩm: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        /***************************************Text_changed hiển thị sản phẩm theo MaSP***************************************************/
        public DataTable HienThiThongTin(string MaSP)
        {
            string sql = "SELECT TenSP, GiaBan, DanhMuc, Size, HinhAnh, NhaCungCap FROM SanPham WHERE MaSP = '" + MaSP + "'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        /*************************************THÔNG TIN VỀ THÊM XUẤT HÀNG SẢN PHẨM****************************************/
        public DataTable LoadXuatHang()
        {
            string sql = "SELECT * FROM XuatHang";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        public int ThemXuatHang(XuatHang_DTO xh)
        {
            string sql = "INSERT INTO XuatHang(MaSP, TenSP, GiaBan, SoLuongXuat, DanhMuc, Size, HinhAnh, NhaCungCap) VALUES ('" + xh.MaSP + "', N'" + xh.TenSP + "', '" + xh.GiaBan + "', '" + xh.SoLuongXuat + "', N'" + xh.DanhMuc + "', '" + xh.Size + "', '" + xh.HinhAnh + "', N'" + xh.NhaCungCap + "')";
            int res1 = connectData.ChangeData(sql);
            return res1;
        }

        public int CapNhatSoLuongSanPham(string maSP, int soLuongXuat)
        {
            // Cập nhật số lượng sản phẩm trong bảng SanPham
            string sql = "UPDATE SanPham SET SoLuong = SoLuong - " + soLuongXuat + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhatSoLuongXuatHang(string maSP, int soLuongXuat)
        {
            // Tạo câu truy vấn SQL để cập nhật số lượng xuất của sản phẩm
            string sql = "UPDATE XuatHang SET SoLuongXuat = SoLuongXuat + " + soLuongXuat +" WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhatXuatHang(XuatHang_DTO xh)
        {
            string sql = "UPDATE XuatHang SET GiaBan = '" + xh.GiaBan + "', SoLuongXuat = '" + xh.SoLuongXuat + "', Size = '" + xh.Size + "' WHERE MaSP = '" + xh.MaSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }
        /***************************************THÔNG TIN VỀ CẬP NHẬT XUẤT HÀNG SẢN PHẨM*************************************************/
        public int CapNhat1(string maSP, int soLuongXuatMoi, int soLuongXuatCu)
        {
            // Cập nhật số lượng sản phẩm trong bảng SanPham
            string sql = "UPDATE SanPham SET SoLuong = SoLuong + " + soLuongXuatCu + " - " + soLuongXuatMoi + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhat2(string maSP, int soLuongXuatMoi)
        {
            // Cập nhật số lượng xuất hàng trong bảng XuatHang
            string sql = "UPDATE XuatHang SET SoLuongXuat = " + soLuongXuatMoi + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int LaySoLuongXuatCu(string maSP)
        {
            int soLuongXuatCu = 0;
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
                        soLuongXuatCu = Convert.ToInt32(reader["SoLuongXuat"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn số lượng xuất cũ: " + ex.Message);
                }
            }
            return soLuongXuatCu;
        }

        /************************************THÔNG TIN VỀ XÓA XUẤT HẢNG SẢN PHẨM******************************************/
        public DataTable Search1(string s)
        {
            string sql = "SELECT * FROM XuatHang WHERE TenSP LIKE N'%" + s + "%' OR MaSP LIKE'%" + s + "%'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }

        public int XoaXuatHang(string MaSP)
        {
            string sql = "DELETE XuatHang WHERE MaSP ='" + MaSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int CapNhatXoa(string maSP, int soLuongSauXoa)
        {
            string sql = "UPDATE SanPham SET SoLuong = " + soLuongSauXoa + " WHERE MaSP = '" + maSP + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int LaySoLuongBanDau(string maSP)
        {
            int soLuongBanDau = 0;

            string sql = "SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP";

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
                        soLuongBanDau = Convert.ToInt32(reader["SoLuong"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn số lượng sản phẩm cũ: " + ex.Message);
                }
            }
            return soLuongBanDau;
        }
    }
}
