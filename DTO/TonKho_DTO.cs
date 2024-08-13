using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;

namespace SHOP_CDH.DTO
{
    public class TonKho_DTO
    {
        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public int GiaNhap { get; set; }

        public int GiaBan { get; set; }

        public string DanhMuc { get; set; }

        public int SoLuongHangTon { get; set; }

        public string HinhAnh { get; set; }

        public string Nhacungcap { get; set; }

        public string Size { get; set; }
    }
}
