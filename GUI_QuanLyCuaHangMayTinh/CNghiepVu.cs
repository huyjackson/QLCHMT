using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QuanLyCuaHangMayTinh
{
    public class CNghiepVu
    {

        public static byte[] ChuyenHinhAnhThanhNhiPhan(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
    }
}
