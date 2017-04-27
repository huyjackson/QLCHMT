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
    public partial class fr_ThemHangHoa : Form
    {

        BUS_LoaiHangHoa buslhh = new BUS_LoaiHangHoa();
        BUS_NhaSanXuat busnsx = new BUS_NhaSanXuat();
        BUS_HangHoa bushh = new BUS_HangHoa();

        public fr_ThemHangHoa()
        {
            InitializeComponent();
        }

        private void fr_ThemHangHoa_Load(object sender, EventArgs e)
        {
            AcceptButton = btThemAnh;
            txtMaHangHoa.Text = bushh.taoMaSoMoi();
            CNghiepVu.taoComboboxLoaiHangHoa(cbLoaiHangHoa);
            CNghiepVu.taoComboboxNhaSanXuat(cbNhaSanXuat);
        }

        protected void clearForm()
        {
            foreach(Control ctr in groupBoxThongTin.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }

            txtMaHangHoa.Text = bushh.taoMaSoMoi();
        }

        protected DTO_HangHoa layThongTin()
        {
            DTO_HangHoa hanghoa = new DTO_HangHoa();

            hanghoa.maHangHoa = bushh.taoMaSoMoi();
            hanghoa.tenHangHoa = txtTenHangHoa.Text;
            hanghoa.ngayNhap = dtNgayNhapHang.Value;
            hanghoa.giaNhap = int.Parse(txtGiaGoc.Text);
            hanghoa.giaBan = int.Parse(txtGiaBan.Text);
            hanghoa.soLuongTrongKho = int.Parse(txtSoLuong.Text);
            hanghoa.soLuongTrungBay = 10;
            hanghoa.maNhomHangHoa = buslhh.layMaLoaiHangHoa(cbLoaiHangHoa.Text);
            hanghoa.maNhaSanXuat = busnsx.layMaNhaSanXuat(cbNhaSanXuat.Text);
            hanghoa.hinhAnh = CNghiepVu.chuyenHinhAnhThanhNhiPhan(picAnhHangHoa.Image);
            hanghoa.ghiChu = string.Empty;
            hanghoa.tinhTrang = 1;

            return hanghoa;
        }


        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HangHoa hanghoa = layThongTin();
                bool ktthemmoi = bushh.themMoi(hanghoa);
                if (ktthemmoi == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Thông tin đầu vào sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btThemAnh_Click(object sender, EventArgs e)
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
