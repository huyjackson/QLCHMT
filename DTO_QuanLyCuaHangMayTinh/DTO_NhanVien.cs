using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCuaHangMayTinh
{
    public class DTO_NhanVien
    {
        public string maNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public byte[] hinhAnh { get; set; }
        public int gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public int soDienThoai { get; set; }
        public string diaCHi { get; set; }
        public string maNhomNhanVien { get; set; }
        public DateTime ngayVaoLam { get; set; }
        public DateTime ngayTraLuongCuoiCung { get; set; }
        public int tinhTrang { get; set; }
    }
}
