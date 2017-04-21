using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLyCuaHangMayTinh;
using DTO_QuanLyCuaHangMayTinh;
using GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy;


namespace GUI_QuanLyCuaHangMayTinh
{
    public partial class fr_DangNhap : Form
    {
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        BUS_NhanVien busnv = new BUS_NhanVien();
        string manhanvien;

        public fr_DangNhap()
        {
            InitializeComponent();
        }

        private void fr_DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            DTO_TaiKhoan taikhoan = new DTO_TaiKhoan();
            taikhoan.maNhanVien = txtTenDangNhap.Text;
            taikhoan.matKhau = txtMatKhau.Text;
            bool dangnhapdung = bustk.kiemTraDangNhap(taikhoan);

            if (dangnhapdung)
            {
                manhanvien = taikhoan.maNhanVien;
                string manhomnhanvien = busnv.layMaNhomNhanVien(taikhoan.maNhanVien);

                if (manhomnhanvien == "ql")
                {
                    this.Hide();
                    new fr_ManHinhChinh().ShowDialog();
                    this.Show();
                }

                //if (LoaiNhanVien == "Nhân viên quản lý")
                //{
                //    timer.Stop();
                //    MH_Chinh_QuanLy ManHinhQuanLy = new QuanLy.MH_Chinh_QuanLy();
                //    this.Hide();
                //    ManHinhQuanLy.ShowDialog();
                //}

                //if (LoaiNhanVien == "Quản kho")
                //{
                //    timer.Stop();
                //    MH_Chinh_QuanKho ManHinhQuanKho = new QuanKho.MH_Chinh_QuanKho();
                //    this.Hide();
                //    ManHinhQuanKho.Show();
                //}


            }
            else
            {
                //lbThongBaoDanhNhap.Visible = true;
                //lbThongBaoDanhNhap.Text = "Mã số hoặc mật khẩu không hợp lệ, xin kiểm tra lại!";
                MessageBox.Show("dang nhap Sai");
            }
        }


    }
    }