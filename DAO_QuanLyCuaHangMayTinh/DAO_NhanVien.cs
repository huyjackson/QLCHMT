﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyCuaHangMayTinh
{
    public class DAO_NhanVien
    {

        public string layMaNhomNhanVien(string manhanvien)
        {
            return KetNoiDataBase.layGiaTri("select MaLoaiNhanVien from tb_NhanVien where MaNhanVien = '"+ manhanvien +"'");
        }
    }
}
