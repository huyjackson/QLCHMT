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
    public partial class fr_QuanLyHangHoa : Form
    {
        BUS_HangHoa bushh = new BUS_HangHoa();
        BUS_NhaSanXuat bussx = new BUS_NhaSanXuat();
        BUS_LoaiHangHoa buslhh = new BUS_LoaiHangHoa();
        public static DTO_HangHoa hanghoadangchon;
        private int curr_row = 0;

        public fr_QuanLyHangHoa()
        {
            InitializeComponent();
        }


        protected void DinhDinhDangBang()
        {
            if (dgvDanhSachHangHoa.RowCount > 0)
            {
                for (int i = 0; i < dgvDanhSachHangHoa.Rows.Count; i++)
                {
                    dgvDanhSachHangHoa.Rows[i].Height = 80;
                    ((DataGridViewImageColumn)dgvDanhSachHangHoa.Columns[9]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dgvDanhSachHangHoa.Columns["HinhAnh"].Width = 80;
                }

                dgvDanhSachHangHoa.DefaultCellStyle.WrapMode = DataGridViewTriState.True; //cài chế độ Wrap cho các ô dữ liệu
                dgvDanhSachHangHoa.Columns["MaDoChoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDanhSachHangHoa.Columns["SoLuongTrongKho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDanhSachHangHoa.Columns["SoLuongNgoaiQuay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        protected void HienThiDuLieuLenBang()
        {
            //dgvDanhSachDoChoi.DataSource = DichVu.LayDanhSachThongTinDoChoi().Tables[0];
            DinhDinhDangBang();
        }

        private void btThemHangHoa_Click(object sender, EventArgs e)
        {
            fr_ThemHangHoa themhanghoa = new fr_ThemHangHoa();
            themhanghoa.ShowDialog();
            loadDanhSach();
        }

        private void loadDanhSach()
        {
            dgvDanhSachHangHoa.DataSource = bushh.layThongTinHangHoa().Tables[0];
            dgvDanhSachHangHoa.Rows[curr_row].Selected = true;
            dgvDanhSachHangHoa.CurrentCell = dgvDanhSachHangHoa.Rows[curr_row].Cells[0];
            var eventArgs = new DataGridViewCellEventArgs(0, curr_row);
            dgvDanhSachHangHoa_CellClick(null, eventArgs);
        }

        private void fr_QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            loadDanhSach();
        }

        private void dgvDanhSachHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            curr_row = e.RowIndex;
            if (curr_row >= 0)
            {
                hanghoadangchon = thongTinHangHoaTrenDong(curr_row);
            }
        }

        private DTO_HangHoa thongTinHangHoaTrenDong(int dong)
        {
            DTO_HangHoa hh = new DTO_HangHoa();
            hh.maHangHoa = dgvDanhSachHangHoa.Rows[dong].Cells["MaHangHoa"].Value.ToString();
            hh.tenHangHoa = dgvDanhSachHangHoa.Rows[dong].Cells["TenHangHoa"].Value.ToString();
            hh.maNhaSanXuat =  bussx.layMaNhaSanXuat(dgvDanhSachHangHoa.Rows[dong].Cells["TenNhaSanXuat"].Value.ToString());
            hh.maNhomHangHoa = buslhh.layMaLoaiHangHoa(dgvDanhSachHangHoa.Rows[dong].Cells["TenLoaiHangHoa"].Value.ToString());
            hh.ngayNhap = DateTime.Parse(dgvDanhSachHangHoa.Rows[dong].Cells["NgayNhap"].Value.ToString());
            hh.giaNhap = int.Parse(dgvDanhSachHangHoa.Rows[dong].Cells["GiaNhap"].Value.ToString());
            hh.giaBan= int.Parse(dgvDanhSachHangHoa.Rows[dong].Cells["GiaBan"].Value.ToString());
            hh.soLuongTrongKho = int.Parse(dgvDanhSachHangHoa.Rows[dong].Cells["SoLuongTrongKho"].Value.ToString());
            hh.soLuongTrungBay = int.Parse(dgvDanhSachHangHoa.Rows[dong].Cells["SoLuongTrungBay"].Value.ToString());
            hh.ghiChu = dgvDanhSachHangHoa.Rows[dong].Cells["GhiChu"].Value.ToString();
            hh.hinhAnh = (byte[])dgvDanhSachHangHoa.Rows[dong].Cells["HinhAnh"].Value;
            hh.tinhTrang = 1;
            return hh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(hanghoadangchon == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng thông tin?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bushh.xoa(hanghoadangchon))
            {
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvDanhSachHangHoa.DataSource = bushh.layThongTinHangHoa().Tables[0];
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (hanghoadangchon != null)
            {
                fr_CapNhatHangHoa capnhat = new fr_CapNhatHangHoa();
                capnhat.ShowDialog();
                loadDanhSach();
            }
        }
    }
}
