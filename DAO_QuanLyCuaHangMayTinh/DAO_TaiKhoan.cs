using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyCuaHangMayTinh;

namespace DAO_QuanLyCuaHangMayTinh
{
    public class DAO_TaiKhoan
    {
        public bool kiemTraDangNhap(DTO_TaiKhoan TaiKhoan)
        {
            string GiaTri = KetNoiDataBase.layGiaTri("select MaNhanVien from tb_TaiKhoan where MaNhanVien = '"+TaiKhoan.maNhanVien+"' and TinhTrang = 1 and MatKhau = '"+TaiKhoan.matKhau+"'");

   
            if (GiaTri == TaiKhoan.maNhanVien)
                return true;
            else
                return false;
        }

    }
}
