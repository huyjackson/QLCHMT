using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyCuaHangMayTinh
{
    public class DAO_NhaSanXuat
    {
        public string layMaNhaSanXuat(string tennhasanxuat)
        {
            return KetNoiDataBase.layGiaTri(@"select MaNhaSanXuat from tb_NhaSanXuat where TenNhaSanXuat= N'" + tennhasanxuat + "'");
        }

        public List<string> layDanhSach()
        {
            List<string> danhsach = new List<string>();

            string CauLenhTruyVan = (@"select TenNhaSanXuat from tb_NhaSanXuat");

            KetNoiDataBase.moKetNoi();

            SqlCommand sqlCMD = new SqlCommand(CauLenhTruyVan, KetNoiDataBase.ketNoi);

            IDataReader dtReader = sqlCMD.ExecuteReader();

            while (dtReader.Read())
            {
                danhsach.Add((string)dtReader["TenNhaSanXuat"]);
            }

            KetNoiDataBase.dongKetNoi();

            return danhsach;
        }

        public string layTen(string maso)
        {
            return KetNoiDataBase.layGiaTri(@"select TenNhaSanXuat from tb_NhaSanXuat where MaNhaSanXuat = '" + maso + "' and TinhTrang = 1");
        }

    }
}