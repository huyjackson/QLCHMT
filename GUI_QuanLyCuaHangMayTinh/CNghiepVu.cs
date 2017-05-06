using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QuanLyCuaHangMayTinh;
using DTO_QuanLyCuaHangMayTinh;
using System.Windows.Forms;

namespace GUI_QuanLyCuaHangMayTinh
{
    public class CNghiepVu
    {
        static BUS_LoaiHangHoa buslhh = new BUS_LoaiHangHoa();
        static BUS_NhaSanXuat busnsx = new BUS_NhaSanXuat();


        public static byte[] chuyenHinhAnhThanhNhiPhan(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public static Bitmap layAnh(byte[] nhiPhan)
        {
            if (nhiPhan.Length > 100)
            {
                MemoryStream Luong = new MemoryStream(nhiPhan);
                Bitmap Hinh = (Bitmap)Bitmap.FromStream(Luong);
                return Hinh;
            }
            else
            {
                return null;
            }
        }

        public static void taoComboboxLoaiHangHoa(ComboBox combobox)
        {
            string[] dsloaihanghoa = buslhh.layDanhSach().ToArray();
            for (int i = 0; i < dsloaihanghoa.Length; i++)
            {
                combobox.Items.Add(dsloaihanghoa[i]);
            }
            combobox.SelectedIndex = 0;
        }

        public static void taoComboboxNhaSanXuat(ComboBox combobox)
        {
            //string[] dsnhasanxuat = busnsx.layDanhSach().ToArray();
            //for (int i = 0; i < dsnhasanxuat.Length; i++)
            //{
            //    combobox.Items.Add(dsnhasanxuat[i]);
            //}
            //combobox.SelectedIndex = 0;
        }
    }
}
