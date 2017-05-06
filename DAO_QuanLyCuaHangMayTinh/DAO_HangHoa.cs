using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyCuaHangMayTinh;
using System.Data.SqlClient;
using System.Data;

namespace DAO_QuanLyCuaHangMayTinh
{
    public class DAO_HangHoa
    {

        public bool themMoi(DTO_HangHoa hanghoa)
        {
            try
            {
                string CauLenhTruyVan = (@"INSERT INTO tb_HangHoa VALUES (@MaHangHoa, @TenHangHoa, @MaNhaSanXuat, @MaLoaiHangHoa, 
                @HinhAnh, @NgayNhap, @GiaNhap, @GiaBan, @SoLuongTrongKho, @SoLuongTrungBay, @GhiChu, @TinhTrang)");

                //truyền giá trị vào câu truy vấn
                SqlCommand SqlCom = new SqlCommand(CauLenhTruyVan, KetNoiDataBase.ketNoi);
                SqlCom.Parameters.Add(new SqlParameter("@MaHangHoa", (object)hanghoa.maHangHoa));
                SqlCom.Parameters.Add(new SqlParameter("@TenHangHoa", (object)hanghoa.tenHangHoa));
                SqlCom.Parameters.Add(new SqlParameter("@MaNhaSanXuat", (object)hanghoa.maNhaSanXuat));
                SqlCom.Parameters.Add(new SqlParameter("@MaLoaiHangHoa", (object)hanghoa.maNhomHangHoa));
                SqlCom.Parameters.Add(new SqlParameter("@HinhAnh", (object)hanghoa.hinhAnh));
                SqlCom.Parameters.Add(new SqlParameter("@NgayNhap", (object)hanghoa.ngayNhap));
                SqlCom.Parameters.Add(new SqlParameter("@GiaNhap", (object)hanghoa.giaNhap));
                SqlCom.Parameters.Add(new SqlParameter("@GiaBan", (object)hanghoa.giaBan));
                SqlCom.Parameters.Add(new SqlParameter("@SoLuongTrongKho", (object)hanghoa.soLuongTrongKho));
                SqlCom.Parameters.Add(new SqlParameter("@SoLuongTrungBay", (object)hanghoa.soLuongTrungBay));
                SqlCom.Parameters.Add(new SqlParameter("@GhiChu", (object)hanghoa.ghiChu));
                SqlCom.Parameters.Add(new SqlParameter("@TinhTrang", (object)hanghoa.tinhTrang));

                //thực hiện câu truy vấn trên
                KetNoiDataBase.moKetNoi();
                SqlCom.ExecuteNonQuery();
                KetNoiDataBase.dongKetNoi();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public string taoMaSoMoi()
        {
            string MaCuoiCung = KetNoiDataBase.layGiaTri(@"SELECT MaHangHoa FROM tb_HangHoa ORDER BY MaHangHoa DESC");
            string ChuoiKyTuDau = "hh";
            if (MaCuoiCung == "")
                return ChuoiKyTuDau + "000";
            int KyTuSoTiepTheo = int.Parse(MaCuoiCung.Remove(0, ChuoiKyTuDau.Length)) + 1;
            int ChieuDaiKyTuSo = MaCuoiCung.Length - ChuoiKyTuDau.Length;
            string ChuoiSoKhong = "";
            for (int i = 1; i <= ChieuDaiKyTuSo; i++)
            {
                if (KyTuSoTiepTheo < Math.Pow(10, i))
                {
                    for (int j = 1; j <= ChieuDaiKyTuSo - i; i++)
                    {
                        ChuoiSoKhong += "0";
                    }
                    return ChuoiKyTuDau + ChuoiSoKhong + KyTuSoTiepTheo.ToString();
                }
            }
            return ChuoiKyTuDau + KyTuSoTiepTheo;
        }

        public DataSet layThongTinHangHoa()
        {
            DataSet dt = new DataSet();
            DataTable tb = KetNoiDataBase.layBang(@"select MaHangHoa, TenHangHoa, TenNhaSanXuat, TenLoaiHangHoa, NgayNhap, GiaNhap, GiaBan, SoLuongTrongKho, SoLuongTrungBay, hh.GhiChu, HinhAnh from tb_HangHoa hh, tb_LoaiHangHoa lhh, tb_NhaSanXuat sx where hh.MaNhaSanXuat = sx.MaNhaSanXuat and hh.MaLoaiHangHoa = lhh.MaLoaiHangHoa and hh.TinhTrang = 1");
            dt.Tables.Add(tb);
            return dt;
        }

        public bool xoa(DTO_HangHoa hanghoa)
        {
            try
            {
                KetNoiDataBase.thucThiCauLenh("UPDATE tb_HangHoa SET TinhTrang = 0 WHERE MaHangHoa = '" + hanghoa.maHangHoa + "'");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool capNhat(DTO_HangHoa hanghoa)
        {
            try
            {
                string CauLenhTruyVan = (@"UPDATE tb_HangHoa SET TenHangHoa = @TenHangHoa
                                                                    , MaNhaSanXuat = @MaNhaSanXuat
                                                                    , MaLoaiHangHoa = @MaLoaiHangHoa
                                                                    , HinhAnh = @HinhAnh
                                                                    , NgayNhap = @NgayNhap
                                                                    , GiaNhap = @GiaNhap
                                                                    , GiaBan = @GiaBan
                                                                    , SoLuongTrongKho = @SoLuongTrongKho
                                                                    , SoLuongTrungBay = @SoLuongTrungBay
                                                                    , GhiChu = @GhiChu
                                                                    , TinhTrang = @TinhTrang WHERE MaHangHoa = @MaHangHoa");

                //truyền giá trị vào câu truy vấn
                SqlCommand SqlCom = new SqlCommand(CauLenhTruyVan, KetNoiDataBase.ketNoi);
                SqlCom.Parameters.Add(new SqlParameter("@MaHangHoa", (object)hanghoa.maHangHoa));
                SqlCom.Parameters.Add(new SqlParameter("@TenHangHoa", (object)hanghoa.tenHangHoa));
                SqlCom.Parameters.Add(new SqlParameter("@MaNhaSanXuat", (object)hanghoa.maNhaSanXuat));
                SqlCom.Parameters.Add(new SqlParameter("@MaLoaiHangHoa", (object)hanghoa.maNhomHangHoa));
                SqlCom.Parameters.Add(new SqlParameter("@HinhAnh", (object)hanghoa.hinhAnh));
                SqlCom.Parameters.Add(new SqlParameter("@NgayNhap", (object)hanghoa.ngayNhap));
                SqlCom.Parameters.Add(new SqlParameter("@GiaNhap", (object)hanghoa.giaNhap));
                SqlCom.Parameters.Add(new SqlParameter("@GiaBan", (object)hanghoa.giaBan));
                SqlCom.Parameters.Add(new SqlParameter("@SoLuongTrongKho", (object)hanghoa.soLuongTrongKho));
                SqlCom.Parameters.Add(new SqlParameter("@SoLuongTrungBay", (object)hanghoa.soLuongTrungBay));
                SqlCom.Parameters.Add(new SqlParameter("@GhiChu", (object)hanghoa.ghiChu));
                SqlCom.Parameters.Add(new SqlParameter("@TinhTrang", (object)hanghoa.tinhTrang));

                //thực hiện câu truy vấn trên
                KetNoiDataBase.moKetNoi();
                SqlCom.ExecuteNonQuery();
                KetNoiDataBase.dongKetNoi();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
