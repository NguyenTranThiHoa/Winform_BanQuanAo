using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using System.Windows.Forms;
using SHOP_CDH.DAL;
using SHOP_CDH.DTO;

namespace SHOP_CDH.BLL
{
    public class DoanhthuBLL
    {
        private ConnectData connectData = new ConnectData();

        public DoanhthuBLL()
        {
            connectData = new ConnectData();
        }

        public List<DoanhthuDTO> GetDoanhthuData()
        {
            List<DoanhthuDTO> doanhthuList = new List<DoanhthuDTO>();

            for (int i = 1; i <= 12; i++)
            {
                string sql = "SELECT " +
                       "MONTH(HD.NgayLapHD) AS Thang, " +
                       "SUM(CT.SoLuongBan) AS SoLuongDaBan, " +
                       "SUM(CT.ThanhTien) AS DoanhThu, " +
                       "SUM(CT.ThanhTien - SP.GiaBan) AS LoiNhuan " +
                       "FROM " +
                       "HoaDon1 HD " +
                       "JOIN " +
                       "ChiTietHD CT ON HD.MaHD = CT.MaHD " +
                       "JOIN " +
                       "SanPham SP ON CT.MaSP = SP.MaSP " +
                       "WHERE " +
                       "YEAR(HD.NgayLapHD) = 2024 " +
                       "AND " +
                       "MONTH(HD.NgayLapHD) = " + i +
                       "GROUP BY " +
                       "MONTH(HD.NgayLapHD)";

                DoanhthuDTO doanhthu = connectData.GetDoanhthuInfo(sql);

                // Kiểm tra null trước khi gán giá trị cho các thuộc tính
                if (doanhthu != null)
                {
                    doanhthu.Thang = i.ToString();
                    doanhthuList.Add(doanhthu);
                }
            }

            return doanhthuList;
        }
    }

}