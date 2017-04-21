using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyCuaHangMayTinh
{
    public class DTO_HangHoa
    {
        public string maHangHoa { get; set; }
        public string tenHangHoa { get; set; }
        public string maNhaSanXuat { get; set; }
        public string maNhomHangHoa { get; set; }
        public byte[] hinhAnh { get; set; }
        public DateTime ngayNhap { get; set; }
        public int giaNhap { get; set; }
        public int giaBan { get; set; }
        public int soLuongTrongKho { get; set; }
        public int soLuongTrungBay { get; set; }
        public string ghiChu { get; set; }
    }
}
