namespace GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy
{
    partial class fr_QuanLyHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGiaTriTimKiem = new System.Windows.Forms.ComboBox();
            this.cbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.tbGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbChuaCoHang = new System.Windows.Forms.RadioButton();
            this.rbQuaySapHetHang = new System.Windows.Forms.RadioButton();
            this.rbKhoSapHetHang = new System.Windows.Forms.RadioButton();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.btInDanhSach = new System.Windows.Forms.Button();
            this.btSuaThongTin = new System.Windows.Forms.Button();
            this.btXoaDoChoi = new System.Windows.Forms.Button();
            this.btThemDoChoiMoi = new System.Windows.Forms.Button();
            this.dgvDanhSachDoChoi = new System.Windows.Forms.DataGridView();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaDoChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDoChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTrongKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNgoaiQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGiaTriTimKiem);
            this.groupBox2.Controls.Add(this.cbLoaiTimKiem);
            this.groupBox2.Controls.Add(this.tbGiaTriTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(568, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(463, 64);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cbGiaTriTimKiem
            // 
            this.cbGiaTriTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiaTriTimKiem.FormattingEnabled = true;
            this.cbGiaTriTimKiem.Location = new System.Drawing.Point(229, 23);
            this.cbGiaTriTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGiaTriTimKiem.Name = "cbGiaTriTimKiem";
            this.cbGiaTriTimKiem.Size = new System.Drawing.Size(214, 21);
            this.cbGiaTriTimKiem.TabIndex = 3;
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.Items.AddRange(new object[] {
            "Tên đồ chơi",
            "Mã đồ chơi",
            "Loại đồ chơi",
            "Nhà sản xuất"});
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(59, 23);
            this.cbLoaiTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(140, 21);
            this.cbLoaiTimKiem.TabIndex = 2;
            // 
            // tbGiaTriTimKiem
            // 
            this.tbGiaTriTimKiem.Location = new System.Drawing.Point(229, 25);
            this.tbGiaTriTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGiaTriTimKiem.Name = "tbGiaTriTimKiem";
            this.tbGiaTriTimKiem.Size = new System.Drawing.Size(214, 20);
            this.tbGiaTriTimKiem.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChuaCoHang);
            this.groupBox1.Controls.Add(this.rbQuaySapHetHang);
            this.groupBox1.Controls.Add(this.rbKhoSapHetHang);
            this.groupBox1.Controls.Add(this.rbTatCa);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1019, 59);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ xem";
            // 
            // rbChuaCoHang
            // 
            this.rbChuaCoHang.AutoSize = true;
            this.rbChuaCoHang.Location = new System.Drawing.Point(638, 22);
            this.rbChuaCoHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbChuaCoHang.Name = "rbChuaCoHang";
            this.rbChuaCoHang.Size = new System.Drawing.Size(92, 17);
            this.rbChuaCoHang.TabIndex = 1;
            this.rbChuaCoHang.TabStop = true;
            this.rbChuaCoHang.Text = "Chưa có hàng";
            this.rbChuaCoHang.UseVisualStyleBackColor = true;
            // 
            // rbQuaySapHetHang
            // 
            this.rbQuaySapHetHang.AutoSize = true;
            this.rbQuaySapHetHang.Location = new System.Drawing.Point(240, 23);
            this.rbQuaySapHetHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbQuaySapHetHang.Name = "rbQuaySapHetHang";
            this.rbQuaySapHetHang.Size = new System.Drawing.Size(115, 17);
            this.rbQuaySapHetHang.TabIndex = 0;
            this.rbQuaySapHetHang.TabStop = true;
            this.rbQuaySapHetHang.Text = "Quầy sắp hết hàng";
            this.rbQuaySapHetHang.UseVisualStyleBackColor = true;
            // 
            // rbKhoSapHetHang
            // 
            this.rbKhoSapHetHang.AutoSize = true;
            this.rbKhoSapHetHang.Location = new System.Drawing.Point(442, 23);
            this.rbKhoSapHetHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbKhoSapHetHang.Name = "rbKhoSapHetHang";
            this.rbKhoSapHetHang.Size = new System.Drawing.Size(111, 17);
            this.rbKhoSapHetHang.TabIndex = 0;
            this.rbKhoSapHetHang.TabStop = true;
            this.rbKhoSapHetHang.Text = "Kho Sắp hết hàng";
            this.rbKhoSapHetHang.UseVisualStyleBackColor = true;
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Location = new System.Drawing.Point(112, 23);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(56, 17);
            this.rbTatCa.TabIndex = 0;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            // 
            // btInDanhSach
            // 
            this.btInDanhSach.Location = new System.Drawing.Point(416, 120);
            this.btInDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInDanhSach.Name = "btInDanhSach";
            this.btInDanhSach.Size = new System.Drawing.Size(107, 41);
            this.btInDanhSach.TabIndex = 5;
            this.btInDanhSach.Text = "In danh sách";
            this.btInDanhSach.UseVisualStyleBackColor = true;
            // 
            // btSuaThongTin
            // 
            this.btSuaThongTin.Location = new System.Drawing.Point(280, 120);
            this.btSuaThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSuaThongTin.Name = "btSuaThongTin";
            this.btSuaThongTin.Size = new System.Drawing.Size(107, 41);
            this.btSuaThongTin.TabIndex = 6;
            this.btSuaThongTin.Text = "Sửa thông tin";
            this.btSuaThongTin.UseVisualStyleBackColor = true;
            // 
            // btXoaDoChoi
            // 
            this.btXoaDoChoi.Location = new System.Drawing.Point(146, 120);
            this.btXoaDoChoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoaDoChoi.Name = "btXoaDoChoi";
            this.btXoaDoChoi.Size = new System.Drawing.Size(105, 41);
            this.btXoaDoChoi.TabIndex = 7;
            this.btXoaDoChoi.Text = "Xóa";
            this.btXoaDoChoi.UseVisualStyleBackColor = true;
            // 
            // btThemDoChoiMoi
            // 
            this.btThemDoChoiMoi.Location = new System.Drawing.Point(12, 118);
            this.btThemDoChoiMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemDoChoiMoi.Name = "btThemDoChoiMoi";
            this.btThemDoChoiMoi.Size = new System.Drawing.Size(105, 43);
            this.btThemDoChoiMoi.TabIndex = 8;
            this.btThemDoChoiMoi.Text = "Thêm";
            this.btThemDoChoiMoi.UseVisualStyleBackColor = true;
            this.btThemDoChoiMoi.Click += new System.EventHandler(this.btThemDoChoiMoi_Click);
            // 
            // dgvDanhSachDoChoi
            // 
            this.dgvDanhSachDoChoi.AllowUserToAddRows = false;
            this.dgvDanhSachDoChoi.AllowUserToDeleteRows = false;
            this.dgvDanhSachDoChoi.AllowUserToResizeColumns = false;
            this.dgvDanhSachDoChoi.AllowUserToResizeRows = false;
            this.dgvDanhSachDoChoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachDoChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDoChoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HinhAnh,
            this.MaDoChoi,
            this.TenDoChoi,
            this.NgayNhap,
            this.GiaNhap,
            this.GiaBan,
            this.TenNhaSanXuat,
            this.TenLoaiDoChoi,
            this.SoLuongTrongKho,
            this.SoLuongNgoaiQuay});
            this.dgvDanhSachDoChoi.Location = new System.Drawing.Point(12, 169);
            this.dgvDanhSachDoChoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachDoChoi.Name = "dgvDanhSachDoChoi";
            this.dgvDanhSachDoChoi.ReadOnly = true;
            this.dgvDanhSachDoChoi.RowHeadersVisible = false;
            this.dgvDanhSachDoChoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDoChoi.Size = new System.Drawing.Size(1019, 363);
            this.dgvDanhSachDoChoi.TabIndex = 4;
            // 
            // HinhAnh
            // 
            this.HinhAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.FillWeight = 54.70953F;
            this.HinhAnh.HeaderText = "Ảnh đại diện";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaDoChoi
            // 
            this.MaDoChoi.DataPropertyName = "MaDoChoi";
            this.MaDoChoi.FillWeight = 507.6142F;
            this.MaDoChoi.HeaderText = "Mã số";
            this.MaDoChoi.Name = "MaDoChoi";
            this.MaDoChoi.ReadOnly = true;
            this.MaDoChoi.Width = 70;
            // 
            // TenDoChoi
            // 
            this.TenDoChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDoChoi.DataPropertyName = "TenDoChoi";
            this.TenDoChoi.FillWeight = 54.70953F;
            this.TenDoChoi.HeaderText = "Tên đồ chơi";
            this.TenDoChoi.Name = "TenDoChoi";
            this.TenDoChoi.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.FillWeight = 54.70953F;
            this.NgayNhap.HeaderText = "Ngày nhập hàng";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.FillWeight = 54.70953F;
            this.GiaNhap.HeaderText = "Giá gốc";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.FillWeight = 54.70953F;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // TenNhaSanXuat
            // 
            this.TenNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhaSanXuat.DataPropertyName = "TenNhaSanXuat";
            this.TenNhaSanXuat.FillWeight = 54.70953F;
            this.TenNhaSanXuat.HeaderText = "Nhà sản xuất";
            this.TenNhaSanXuat.Name = "TenNhaSanXuat";
            this.TenNhaSanXuat.ReadOnly = true;
            // 
            // TenLoaiDoChoi
            // 
            this.TenLoaiDoChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiDoChoi.DataPropertyName = "TenLoaiDoChoi";
            this.TenLoaiDoChoi.FillWeight = 54.70953F;
            this.TenLoaiDoChoi.HeaderText = "Loại đồ chơi";
            this.TenLoaiDoChoi.Name = "TenLoaiDoChoi";
            this.TenLoaiDoChoi.ReadOnly = true;
            // 
            // SoLuongTrongKho
            // 
            this.SoLuongTrongKho.DataPropertyName = "SoLuongTrongKho";
            this.SoLuongTrongKho.FillWeight = 54.70953F;
            this.SoLuongTrongKho.HeaderText = "Kho";
            this.SoLuongTrongKho.Name = "SoLuongTrongKho";
            this.SoLuongTrongKho.ReadOnly = true;
            this.SoLuongTrongKho.Width = 50;
            // 
            // SoLuongNgoaiQuay
            // 
            this.SoLuongNgoaiQuay.DataPropertyName = "SoLuongNgoaiQuay";
            this.SoLuongNgoaiQuay.FillWeight = 54.70953F;
            this.SoLuongNgoaiQuay.HeaderText = "Quầy";
            this.SoLuongNgoaiQuay.Name = "SoLuongNgoaiQuay";
            this.SoLuongNgoaiQuay.ReadOnly = true;
            this.SoLuongNgoaiQuay.Width = 50;
            // 
            // fr_QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btInDanhSach);
            this.Controls.Add(this.btSuaThongTin);
            this.Controls.Add(this.btXoaDoChoi);
            this.Controls.Add(this.btThemDoChoiMoi);
            this.Controls.Add(this.dgvDanhSachDoChoi);
            this.Name = "fr_QuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HÀNG HÓA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoChoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGiaTriTimKiem;
        private System.Windows.Forms.ComboBox cbLoaiTimKiem;
        private System.Windows.Forms.TextBox tbGiaTriTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChuaCoHang;
        private System.Windows.Forms.RadioButton rbQuaySapHetHang;
        private System.Windows.Forms.RadioButton rbKhoSapHetHang;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.Button btInDanhSach;
        private System.Windows.Forms.Button btSuaThongTin;
        private System.Windows.Forms.Button btXoaDoChoi;
        private System.Windows.Forms.Button btThemDoChoiMoi;
        private System.Windows.Forms.DataGridView dgvDanhSachDoChoi;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDoChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNgoaiQuay;
    }
}