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
    public partial class fr_QuanLyHangHoa : Form
    {
        public fr_QuanLyHangHoa()
        {
            InitializeComponent();
        }


        protected void DinhDinhDangBang()
        {
            if (dgvDanhSachDoChoi.RowCount > 0)
            {
                for (int i = 0; i < dgvDanhSachDoChoi.Rows.Count; i++)
                {
                    dgvDanhSachDoChoi.Rows[i].Height = 80;
                    ((DataGridViewImageColumn)dgvDanhSachDoChoi.Columns[9]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dgvDanhSachDoChoi.Columns["HinhAnh"].Width = 80;
                }

                dgvDanhSachDoChoi.DefaultCellStyle.WrapMode = DataGridViewTriState.True; //cài chế độ Wrap cho các ô dữ liệu
                dgvDanhSachDoChoi.Columns["MaDoChoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDanhSachDoChoi.Columns["SoLuongTrongKho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDanhSachDoChoi.Columns["SoLuongNgoaiQuay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        protected void HienThiDuLieuLenBang()
        {
            //dgvDanhSachDoChoi.DataSource = DichVu.LayDanhSachThongTinDoChoi().Tables[0];
            DinhDinhDangBang();
        }

        private void btThemDoChoiMoi_Click(object sender, EventArgs e)
        {

            fr_ThemHangHoa themhanghoa = new fr_ThemHangHoa();
            themhanghoa.ShowDialog();
            //try
            //{
            //    MH_ThemDoChoi ManHinhThemDoChoi = new MH_ThemDoChoi();
            //    ManHinhThemDoChoi.ShowDialog();

            //    if (MH_ThemDoChoi.MaDoChoi == "")
            //    {

            //    }
            //    else
            //    {
            //        HienThiDuLieuLenBang();
            //        int dongMoiXuLy = XuLy.InDongVuaXuLy(MH_ThemDoChoi.MaDoChoi, dgvDanhSachDoChoi);
            //        ChonDongTrongBang(null, dongMoiXuLy);
            //    }
            //}
            //catch { }
        }
    }
}
