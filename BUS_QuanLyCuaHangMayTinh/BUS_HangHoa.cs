using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyCuaHangMayTinh;
using DAO_QuanLyCuaHangMayTinh;
using System.Data;

namespace BUS_QuanLyCuaHangMayTinh
{
    public class BUS_HangHoa
    {
        DAO_HangHoa daohh = new DAO_HangHoa();

        public bool themMoi(DTO_HangHoa hanghoa)
        {
            return daohh.themMoi(hanghoa);
        }

        public string taoMaSoMoi()
        {
            return daohh.taoMaSoMoi();
        }

        public DataSet layThongTinHangHoa()
        {
            return daohh.layThongTinHangHoa();
        }

        public bool xoa(DTO_HangHoa hanghoa)
        {
            return daohh.xoa(hanghoa);
        }

        public bool capNhat(DTO_HangHoa hanghoa)
        {
            return daohh.capNhat(hanghoa);
        }

    }
}
