using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;
namespace SHOP_CDH.DTO
{
    public class NhanVienModel
    {
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public DateTime? ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public string sodt { get; set; }
    }
}
