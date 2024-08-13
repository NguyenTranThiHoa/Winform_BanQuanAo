using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;

namespace SHOP_CDH.DTO
{
    public class ChiTietHD_DTO
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; }
        public string Size { get; set; }
    }
}
