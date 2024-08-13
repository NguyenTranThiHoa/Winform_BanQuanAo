using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOP_CDH.BLL;
using SHOP_CDH.DTO;


namespace SHOP_CDH.DAL
{
    public class ConnectData
    {
        public SqlConnection GetConnect()
        {
            string chuoiKN = @"Data Source=DESKTOP-57Q2OCR\SQLEXPRESS01;Initial Catalog=QLBH_QA;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(chuoiKN);
            return conn;
        }

        public DataTable GetData(string sql)
        {
            SqlConnection conn = GetConnect();
            SqlDataAdapter adat = new SqlDataAdapter(sql, conn);
            DataTable data = new DataTable();
            adat.Fill(data);
            return data;
        }

        public DoanhthuDTO GetDoanhthuInfo(string sql)
        {
            DoanhthuDTO doanhthu = new DoanhthuDTO();
            SqlConnection conn = GetConnect();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doanhthu.SoLuongDaBan = reader["SoLuongDaBan"].ToString();
                    doanhthu.DoanhThu = reader["DoanhThu"].ToString();
                    doanhthu.LoiNhuan = reader["LoiNhuan"].ToString();
                }

                return doanhthu; // Trả về đối tượng DoanhthuDTO sau khi đọc dữ liệu
            }
            catch (Exception ex)
            {
                // Xử lý exception (ví dụ: log lỗi)
                throw ex; // Ném lại exception để cho lớp gọi xử lý
            }
            finally
            {
                conn.Close(); // Đóng kết nối sau khi thực hiện xong công việc
            }
        }

        public int ChangeData(string sql)
        {
            SqlConnection conn = GetConnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }
            return 0;
        }



    }
}
