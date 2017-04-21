using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyCuaHangMayTinh
{
    public class DAO_LoaiHangHoa
    {

        public string layMaLoai(string tennhomhanghoa)
        {
            return KetNoiDataBase.layGiaTri(@"select MaLoaiHangHoa from tb_LoaiHangHoa where TenLoaiHangHoa = N'" + tennhomhanghoa + "'");
        }

        public List<string> layDanhSach()
        {
            List<string> danhsach = new List<string>();

            string CauLenhTruyVan = (@"select TenLoaiHangHoa from tb_LoaiHangHoa");

            KetNoiDataBase.moKetNoi();

            SqlCommand sqlCMD = new SqlCommand(CauLenhTruyVan, KetNoiDataBase.ketNoi);

            IDataReader dtReader = sqlCMD.ExecuteReader();

            while (dtReader.Read())
            {
                danhsach.Add((string)dtReader["TenLoaiHangHoa"]);
            }

            KetNoiDataBase.dongKetNoi();

            return danhsach;
        }
    }
}
