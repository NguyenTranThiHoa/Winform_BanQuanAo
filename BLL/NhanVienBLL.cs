using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH.BLL
{
    public class NhanVienBLL
    {
        private ConnectData connectData = new ConnectData();
        public DataTable LoadNV()
        {
            string sql = "select * from NhanVien";
            DataTable dt = connectData .GetData(sql);
            return dt;
        }
        public DataTable LoadDataSearch(string keyword)
        {
            string sql = "select * from NhanVien where MaNV like '%" + keyword + "%' OR TenNV like N'%" + keyword + "%'";
            DataTable dt = connectData.GetData(sql);
            return dt;
        }
        public int DeleteNV(string manv)
        {
            string sql = "delete NhanVien where MaNV='" + manv + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }
        public int InsertNV(NhanVienModel nv)
        {
            string sql = "insert into NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SoDienThoai) values ('" + nv.maNV + "',N'" + nv.tenNV + "',N'" + nv.ngaysinh + "',N'" + nv.gioitinh + "',N'" + nv.diachi + "',N'" + nv.sodt + "')";
            int res = connectData.ChangeData(sql);
            return res;
        }

        public int UpdateNV(NhanVienModel nv)
        {
            string sql = "update NhanVien set TenNV=N'" + nv.tenNV + "',NgaySinh='" + nv.ngaysinh + "',GioiTinh=N'" + nv.gioitinh + "',DiaChi='" + nv.diachi + "',SoDienThoai=N'" + nv.sodt + "' where MaKH='" + nv.maNV + "'";
            int res = connectData.ChangeData(sql);
            return res;
        }
    }
}
