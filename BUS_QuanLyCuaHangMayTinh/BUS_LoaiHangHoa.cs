using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyCuaHangMayTinh;


namespace BUS_QuanLyCuaHangMayTinh
{
    public class BUS_LoaiHangHoa
    {
        DAO_LoaiHangHoa daolhh = new DAO_LoaiHangHoa();

        public string layMaLoaiHangHoa(string tennhomhanghoa)
        {
            return daolhh.layMaLoai(tennhomhanghoa);
        }

        public List<string> layDanhSach()
        {
            return daolhh.layDanhSach();
        }

        public string layTen(string maloai)
        {
            return daolhh.layTen(maloai);
        }

    }
}
