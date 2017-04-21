using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyCuaHangMayTinh;

namespace BUS_QuanLyCuaHangMayTinh
{
    public class BUS_NhanVien
    {
        DAO_NhanVien daonv = new DAO_NhanVien();

        public string layMaNhomNhanVien(string manhanvien)
        {
            return daonv.layMaNhomNhanVien(manhanvien);
        }
    }
}
