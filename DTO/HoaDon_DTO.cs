using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;

namespace SHOP_CDH.DTO
{
    public class HoaDon_DTO
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime? NgayLapHD { get; set; }
    }
}
