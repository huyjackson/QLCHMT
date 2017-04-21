using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy
{
    public partial class fr_ManHinhChinh : Form
    {
        public fr_ManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnQuanLyNhaSanXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nhà sản xuất");
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("danh mục");
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nhân viên");
        }

        private void btnQuanLyHangHoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr_QuanLyHangHoa qlhanghoa = new fr_QuanLyHangHoa();
            qlhanghoa.ShowDialog();
        }
    }
}
