using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyCuaHangMayTinh;
using DAO_QuanLyCuaHangMayTinh;


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
    }
}
