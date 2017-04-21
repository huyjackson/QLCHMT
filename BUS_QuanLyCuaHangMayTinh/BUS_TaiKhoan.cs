using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_QuanLyCuaHangMayTinh;
using DAO_QuanLyCuaHangMayTinh;

namespace BUS_QuanLyCuaHangMayTinh
{
    public class BUS_TaiKhoan
    {
        DAO_TaiKhoan daotk = new DAO_TaiKhoan();

        public bool kiemTraDangNhap(DTO_TaiKhoan taikhoan)
        {
            return daotk.kiemTraDangNhap(taikhoan);
        }
    }
}
