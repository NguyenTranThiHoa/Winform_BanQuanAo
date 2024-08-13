using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH.DTO
{
    public class XuatHang_DTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongXuat { get; set; }
        public string DanhMuc { get; set; }
        public string Size { get; set; }
        public string HinhAnh { get; set; }
        public string NhaCungCap { get; set; }
    }
}
