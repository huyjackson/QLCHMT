using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyCuaHangMayTinh;
using BUS_QuanLyCuaHangMayTinh;

namespace GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy
{
    public partial class fr_CapNhatHangHoa : Form
    {
        DTO_HangHoa hanghoa = fr_QuanLyHangHoa.hanghoadangchon;
        BUS_LoaiHangHoa lhh = new BUS_LoaiHangHoa();
        BUS_NhaSanXuat sx = new BUS_NhaSanXuat();
        BUS_HangHoa hh = new BUS_HangHoa();

        public fr_CapNhatHangHoa()
        {
            InitializeComponent();
        }



        private void fr_CapNhatHangHoa_Load(object sender, EventArgs e)
        {
            AcceptButton = btnCapNhat;
            CNghiepVu.taoComboboxLoaiHangHoa(cbLoaiHangHoa);
            CNghiepVu.taoComboboxNhaSanXuat(cbNhaSanXuat);

            if(hanghoa.maHangHoa != null)
            {
                picAnhHangHoa.Image = CNghiepVu.layAnh(hanghoa.hinhAnh);
                txtMaHangHoa.Text = hanghoa.maHangHoa;
                txtTenHangHoa.Text = hanghoa.tenHangHoa;
                dtNgayNhapHang.Value = hanghoa.ngayNhap;
                txtGiaGoc.Text = hanghoa.giaNhap.ToString();
                txtGiaBan.Text = hanghoa.giaBan.ToString();
                txtSoLuong.Text = hanghoa.soLuongTrongKho.ToString();
                cbLoaiHangHoa.Text = lhh.layTen(hanghoa.maNhomHangHoa);
                cbNhaSanXuat.Text = sx.layTen(hanghoa.maNhaSanXuat);
            }
        }

        protected DTO_HangHoa layThongTin()
        {
            DTO_HangHoa hanghoa = new DTO_HangHoa();

            hanghoa.maHangHoa = txtMaHangHoa.Text;
            hanghoa.tenHangHoa = txtTenHangHoa.Text;
            hanghoa.ngayNhap = dtNgayNhapHang.Value;
            hanghoa.giaNhap = int.Parse(txtGiaGoc.Text);
            hanghoa.giaBan = int.Parse(txtGiaBan.Text);
            hanghoa.soLuongTrongKho = int.Parse(txtSoLuong.Text);
            hanghoa.soLuongTrungBay = 10;
            hanghoa.maNhomHangHoa = lhh.layMaLoaiHangHoa(cbLoaiHangHoa.Text);
            hanghoa.maNhaSanXuat = sx.layMaNhaSanXuat(cbNhaSanXuat.Text);
            hanghoa.hinhAnh = CNghiepVu.chuyenHinhAnhThanhNhiPhan(picAnhHangHoa.Image);
            hanghoa.ghiChu = string.Empty;
            hanghoa.tinhTrang = 1;

            return hanghoa;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (hh.capNhat(layThongTin()))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.FileName = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnhHangHoa.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
