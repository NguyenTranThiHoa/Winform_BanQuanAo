using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH.BLL
{
    public class KhachHangBLL
    {
        private ConnectData connectData = new ConnectData();
        public DataTable LoadKH()
        {
            string sql = "select * from KhachHang";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }
        public DataTable LoadDataSearch(string keyword)
        {
            string sql = "select * from KhachHang where MaKH like '%" + keyword + "%' OR TenKH like N'%" + keyword + "%'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }
        public int DeleteKH(string makh)
        {
            string sql = "delete KhachHang where MaKH='" + makh + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int ThemKH(KhachHangModel khachhang)
        {
            string sql = "INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDienThoai, GioiTinh) VALUES ('" +khachhang.makhachhang+ "', '"+ khachhang.tenkhachhang+"', '"+khachhang.diachikhachhang+"', '"+khachhang.sdtkhachhang+"', N'"+khachhang.gioitinh+"')";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int UpdateKH(KhachHangModel khang)
        {
            string sql = "UPDATE KhachHang SET TenKH=N'" + khang.tenkhachhang + "',DiaChi=N'" + khang.diachikhachhang + "',SoDienThoai='" + khang.sdtkhachhang + "',GioiTinh= '" + khang.gioitinh + "' where MaKH='" + khang.makhachhang + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }
    }
}
