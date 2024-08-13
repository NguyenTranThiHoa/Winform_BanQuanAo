using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;

namespace SHOP_CDH.DTO
{
    public class KhachHangModel
    {
        public string makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string sdtkhachhang { get; set; }
        public string diachikhachhang { get; set; }
        public string gioitinh { get; set; }
    }
}
