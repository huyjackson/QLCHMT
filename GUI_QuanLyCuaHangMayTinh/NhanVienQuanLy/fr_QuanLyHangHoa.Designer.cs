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
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btThemHangHoa = new System.Windows.Forms.Button();
            this.dgvDanhSachHangHoa = new System.Windows.Forms.DataGridView();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTrongKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTrungBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Location = new System.Drawing.Point(425, 24);
            this.btnInDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(107, 41);
            this.btnInDanhSach.TabIndex = 5;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(289, 24);
            this.btnSuaThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(107, 41);
            this.btnSuaThongTin.TabIndex = 6;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(155, 24);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btThemHangHoa
            // 
            this.btThemHangHoa.Location = new System.Drawing.Point(21, 22);
            this.btThemHangHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemHangHoa.Name = "btThemHangHoa";
            this.btThemHangHoa.Size = new System.Drawing.Size(105, 43);
            this.btThemHangHoa.TabIndex = 8;
            this.btThemHangHoa.Text = "Thêm";
            this.btThemHangHoa.UseVisualStyleBackColor = true;
            this.btThemHangHoa.Click += new System.EventHandler(this.btThemHangHoa_Click);
            // 
            // dgvDanhSachHangHoa
            // 
            this.dgvDanhSachHangHoa.AllowUserToAddRows = false;
            this.dgvDanhSachHangHoa.AllowUserToDeleteRows = false;
            this.dgvDanhSachHangHoa.AllowUserToResizeColumns = false;
            this.dgvDanhSachHangHoa.AllowUserToResizeRows = false;
            this.dgvDanhSachHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.TenNhaSanXuat,
            this.TenLoaiHangHoa,
            this.NgayNhap,
            this.GiaNhap,
            this.GiaBan,
            this.SoLuongTrongKho,
            this.SoLuongTrungBay,
            this.GhiChu,
            this.HinhAnh});
            this.dgvDanhSachHangHoa.Location = new System.Drawing.Point(12, 119);
            this.dgvDanhSachHangHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachHangHoa.MultiSelect = false;
            this.dgvDanhSachHangHoa.Name = "dgvDanhSachHangHoa";
            this.dgvDanhSachHangHoa.ReadOnly = true;
            this.dgvDanhSachHangHoa.RowHeadersVisible = false;
            this.dgvDanhSachHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHangHoa.Size = new System.Drawing.Size(1019, 390);
            this.dgvDanhSachHangHoa.TabIndex = 4;
            this.dgvDanhSachHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHangHoa_CellClick);
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            this.MaHangHoa.HeaderText = "Mã số";
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.ReadOnly = true;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Tên";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            // 
            // TenNhaSanXuat
            // 
            this.TenNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhaSanXuat.DataPropertyName = "TenNhaSanXuat";
            this.TenNhaSanXuat.HeaderText = "Nhà sản xuất";
            this.TenNhaSanXuat.Name = "TenNhaSanXuat";
            this.TenNhaSanXuat.ReadOnly = true;
            // 
            // TenLoaiHangHoa
            // 
            this.TenLoaiHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiHangHoa.DataPropertyName = "TenLoaiHangHoa";
            this.TenLoaiHangHoa.HeaderText = "Loại hàng hóa";
            this.TenLoaiHangHoa.Name = "TenLoaiHangHoa";
            this.TenLoaiHangHoa.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // SoLuongTrongKho
            // 
            this.SoLuongTrongKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongTrongKho.DataPropertyName = "SoLuongTrongKho";
            this.SoLuongTrongKho.HeaderText = "Trong kho";
            this.SoLuongTrongKho.Name = "SoLuongTrongKho";
            this.SoLuongTrongKho.ReadOnly = true;
            // 
            // SoLuongTrungBay
            // 
            this.SoLuongTrungBay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongTrungBay.DataPropertyName = "SoLuongTrungBay";
            this.SoLuongTrungBay.HeaderText = "Trưng bày";
            this.SoLuongTrungBay.Name = "SoLuongTrungBay";
            this.SoLuongTrungBay.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btThemHangHoa);
            this.panel1.Controls.Add(this.btnInDanhSach);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSuaThongTin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 100);
            this.panel1.TabIndex = 9;
            // 
            // fr_QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDanhSachHangHoa);
            this.Name = "fr_QuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HÀNG HÓA";
            this.Load += new System.EventHandler(this.fr_QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btThemHangHoa;
        private System.Windows.Forms.DataGridView dgvDanhSachHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTrungBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.Panel panel1;
    }
}