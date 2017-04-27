using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyCuaHangMayTinh;


namespace BUS_QuanLyCuaHangMayTinh
{
    public class BUS_NhaSanXuat
    {
        DAO_NhaSanXuat daonsx = new DAO_NhaSanXuat();

        public string layMaNhaSanXuat(string tennhasanxuat)
        {
            return daonsx.layMaNhaSanXuat(tennhasanxuat);
        }

        public List<string> layDanhSach()
        {
            return daonsx.layDanhSach();
        }

        public string layTen(string maso)
        {
            return daonsx.layTen(maso);
        }

    }
}
