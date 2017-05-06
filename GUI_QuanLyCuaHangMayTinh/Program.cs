using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GUI_QuanLyCuaHangMayTinh;
using GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy;

namespace GUI_QuanLyCuaHangMayTinh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_DangNhap());
        }
    }
}
