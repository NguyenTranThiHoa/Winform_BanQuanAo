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

namespace SHOP_CDH.BLL
{
    public class NhaCungCapBLL
    {
        private ConnectData data = new ConnectData();
        public DataTable LoadNCC()
        {
            string sql = "select * from NhaCungCap";
            DataTable dt = data.GetData(sql);
            return dt;
        }
        public DataTable LoadDataSearch(string keyword)
        {
            string sql = "select * from NhaCungCap where MaNhaCC like '%" + keyword + "%' OR TenNhaCC like N'%" + keyword + "%'";
            DataTable dt = data.GetData(sql);
            return dt;
        }
        public int DeleteNCC(string mancc)
        {
            string sql = "delete NhaCungCap where MaNhaCC='" + mancc + "'";
            int res = data.ChangeData(sql);
            return res;
        }


        public int InsertNCC(NhaCungCapModel ncc)
        {
            string sql = "insert into NhaCungCap(MaNhaCC,TenNhaCC,SoDienThoai,DiaChi) values ('" + ncc.maNCC + "',N'" + ncc.tenNCC + "',N'" + ncc.sdtNCC + "','" + ncc.diachiNCC + "')";
            int res = data.ChangeData(sql);
            return res;
        }
        public int UpdateNCC(NhaCungCapModel ncc)
        {
            string sql = "update NhaCungCap set TenNhaCC=N'" + ncc.tenNCC + "',SoDienThoai=N'" + ncc.sdtNCC + "',DiaChi=N'" + ncc.diachiNCC + "' where MaNhaCC='" + ncc.maNCC + "'";

            int res = data.ChangeData(sql);
            return res;
        }
    }
}
