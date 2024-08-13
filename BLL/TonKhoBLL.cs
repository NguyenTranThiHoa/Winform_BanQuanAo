using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHOP_CDH.DTO;
using SHOP_CDH.DAL;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOP_CDH.BLL
{
    public class TonKhoBLL
    {
        private ConnectData connectData = new ConnectData(); // Tạo một instance của lớp ConnectData
        public SqlConnection GetConnect()
        {
            string chuoiKN = @"Data Source=DESKTOP-57Q2OCR\SQLEXPRESS01;Initial Catalog=QLBH_QA;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(chuoiKN);
            return conn;
        }

        /*********************************Load dữ liệu tồn kho**************************************/
    }
}
