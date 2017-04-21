using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyCuaHangMayTinh;
using System.Data.SqlClient;
using System.Data;

namespace DAO_QuanLyCuaHangMayTinh
{
    class DAO_ChiTietPhieu
    {
        public void themChiTietPhieuHang(DTO_ChiTietPhieu ctPhieu)
        {
            string cauLenhTruyVan = (@"INSERT INTO tb_ChiTietPhieu VALUES(@MaPhieu,@MaDoChoi,@SoLuong)");
            SqlCommand SqlCom = new SqlCommand(cauLenhTruyVan, KetNoiDataBase.ketNoi);
            SqlCom.Parameters.Add(new SqlParameter("@MaPhieu", (object)ctPhieu.maPhieu));
            SqlCom.Parameters.Add(new SqlParameter("@MaDoChoi", (object)ctPhieu.maHangHoa));
            SqlCom.Parameters.Add(new SqlParameter("@SoLuong", (object)ctPhieu.soLuong));
            KetNoiDataBase.moKetNoi();
            SqlCom.ExecuteNonQuery();
            KetNoiDataBase.dongKetNoi();
        }
    }
}
