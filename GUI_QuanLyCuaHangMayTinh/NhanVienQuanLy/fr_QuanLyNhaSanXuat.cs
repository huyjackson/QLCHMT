using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyCuaHangMayTinh;
using DTO_QuanLyCuaHangMayTinh;

namespace GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy
{
    public partial class fr_QuanLyNhaSanXuat : Form
    {

        BUS_NhaSanXuat busnsx = new BUS_NhaSanXuat();
        
        public fr_QuanLyNhaSanXuat()
        {
            InitializeComponent();
        }

        private void loadDanhSachNhaSanXuat()
        {
            dgvNhaSanXuat.DataSource = busnsx.layDanhSachNhaSanXuat().Tables[0];
        }

        private void fr_QuanLyNhaSanXuat_Load(object sender, EventArgs e)
        {
            loadDanhSachNhaSanXuat();
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {
            fr_ThemNhaSanXuat themnsx = new fr_ThemNhaSanXuat();
            themnsx.ShowDialog();
            loadDanhSachNhaSanXuat();
        }

        private void btnChinhSuaNSX_Click(object sender, EventArgs e)
        {
            fr_CapNhatNhaSanXuat capnhatnsx = new NhanVienQuanLy.fr_CapNhatNhaSanXuat();
            capnhatnsx.ShowDialog();
            loadDanhSachNhaSanXuat();
        }
    }
}
