using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DAL;

namespace SHOP_CDH.DTO
{
    public class HangHoaModel
    {
        public string Masp { get; set; }

        public string Tensp { get; set; }

        public int Giaban { get; set; }

        public int Soluong { get; set; }

        public string Danhmuc { get; set; }

        public string Size { get; set; }

        public string Hinhanh { get; set; }

        public string Nhacungcap { get; set; }
    }
}
