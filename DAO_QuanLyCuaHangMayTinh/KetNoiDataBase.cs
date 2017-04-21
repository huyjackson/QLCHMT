using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO_QuanLyCuaHangMayTinh
{
    public class KetNoiDataBase
    {
        public static SqlConnection ketNoi;
        private static string ChuoiKetNoi = @"Data Source=DESKTOP-I3MUKIT\SQLEXPRESS;
            Initial Catalog=QLCHMT_1453017_1453025;Integrated Security=True";
        public static void moKetNoi()
        {
            if(ketNoi == null)
            {
                ketNoi = new SqlConnection(ChuoiKetNoi);
            }
            if(ketNoi.State != System.Data.ConnectionState.Open)
            {
                ketNoi.Open();
            }
        }

        public static void dongKetNoi()
        {
            if(ketNoi != null)
            {
                if (ketNoi.State == System.Data.ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        public static void thucThiCauLenh(string cauLenhTruyVan)
        {
            try
            {
                moKetNoi();
                SqlCommand sqlCmd = new SqlCommand(cauLenhTruyVan, ketNoi);
                sqlCmd.ExecuteNonQuery();
                dongKetNoi();
            }
            catch
            {
                throw;
            }
        }

        public static DataTable layBang(string cauLenhTruyVan)
        {
            try
            {
                moKetNoi();
                DataTable bang = new DataTable();
                SqlDataAdapter sqlDA = new SqlDataAdapter(cauLenhTruyVan, ketNoi);
                sqlDA.Fill(bang);
                dongKetNoi();
                return bang;
            }
            catch
            {
                return null;
            }
        } 

        public static string layGiaTri(string cauLenhTruyVan)
        {
            string ketQua = null;
            try
            {
                moKetNoi();
                SqlCommand sqlCmd = new SqlCommand(cauLenhTruyVan, ketNoi);
                ketQua = sqlCmd.ExecuteScalar().ToString();
                dongKetNoi();
                return ketQua;
            }
            catch
            {
                return "";
            }
        }
    }
}
