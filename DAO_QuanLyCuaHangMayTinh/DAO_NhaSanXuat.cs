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

        public DataSet layDanhSachNhaSanXuat()
        {
            string cautruyvan = (@"select * from tb_NhaSanXuat");
            DataSet dt = new DataSet();
            DataTable tb = KetNoiDataBase.layBang(cautruyvan);
            dt.Tables.Add(tb);
            return dt;
        }

        public string layTen(string maso)
        {
            return KetNoiDataBase.layGiaTri(@"select TenNhaSanXuat from tb_NhaSanXuat where MaNhaSanXuat = '" + maso + "' and TinhTrang = 1");
        }

    }
}