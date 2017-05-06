namespace GUI_QuanLyCuaHangMayTinh.NhanVienQuanLy
{
    partial class fr_QuanLyNhaSanXuat
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
            this.dgvNhaSanXuat = new System.Windows.Forms.DataGridView();
            this.MaSoNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoNhaSanXuat = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaNSX = new System.Windows.Forms.Button();
            this.btnChinhSuaNSX = new System.Windows.Forms.Button();
            this.btnThemNSX = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhaSanXuat
            // 
            this.dgvNhaSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaSanXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoNhaSanXuat,
            this.TenNhaSanXuat,
            this.LogoNhaSanXuat});
            this.dgvNhaSanXuat.Location = new System.Drawing.Point(8, 19);
            this.dgvNhaSanXuat.Name = "dgvNhaSanXuat";
            this.dgvNhaSanXuat.RowHeadersVisible = false;
            this.dgvNhaSanXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaSanXuat.Size = new System.Drawing.Size(681, 266);
            this.dgvNhaSanXuat.TabIndex = 5;
            // 
            // MaSoNhaSanXuat
            // 
            this.MaSoNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSoNhaSanXuat.HeaderText = "Mã số";
            this.MaSoNhaSanXuat.Name = "MaSoNhaSanXuat";
            // 
            // TenNhaSanXuat
            // 
            this.TenNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhaSanXuat.HeaderText = "Tên nhà sản xuất";
            this.TenNhaSanXuat.Name = "TenNhaSanXuat";
            // 
            // LogoNhaSanXuat
            // 
            this.LogoNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LogoNhaSanXuat.HeaderText = "Hình ảnh đại diện";
            this.LogoNhaSanXuat.Name = "LogoNhaSanXuat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaNSX);
            this.groupBox1.Controls.Add(this.btnChinhSuaNSX);
            this.groupBox1.Controls.Add(this.btnThemNSX);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // btnXoaNSX
            // 
            this.btnXoaNSX.Location = new System.Drawing.Point(344, 25);
            this.btnXoaNSX.Name = "btnXoaNSX";
            this.btnXoaNSX.Size = new System.Drawing.Size(129, 32);
            this.btnXoaNSX.TabIndex = 3;
            this.btnXoaNSX.Text = "Xóa nhà sản xuất";
            this.btnXoaNSX.UseVisualStyleBackColor = true;
            // 
            // btnChinhSuaNSX
            // 
            this.btnChinhSuaNSX.Location = new System.Drawing.Point(171, 25);
            this.btnChinhSuaNSX.Name = "btnChinhSuaNSX";
            this.btnChinhSuaNSX.Size = new System.Drawing.Size(140, 32);
            this.btnChinhSuaNSX.TabIndex = 2;
            this.btnChinhSuaNSX.Text = "Cập nhật nhà sản xuất";
            this.btnChinhSuaNSX.UseVisualStyleBackColor = true;
            this.btnChinhSuaNSX.Click += new System.EventHandler(this.btnChinhSuaNSX_Click);
            // 
            // btnThemNSX
            // 
            this.btnThemNSX.Location = new System.Drawing.Point(8, 25);
            this.btnThemNSX.Name = "btnThemNSX";
            this.btnThemNSX.Size = new System.Drawing.Size(130, 32);
            this.btnThemNSX.TabIndex = 1;
            this.btnThemNSX.Text = "Thêm nhà sản xuất";
            this.btnThemNSX.UseVisualStyleBackColor = true;
            this.btnThemNSX.Click += new System.EventHandler(this.btnThemNSX_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhaSanXuat);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 291);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà sản xuất";
            // 
            // fr_QuanLyNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fr_QuanLyNhaSanXuat";
            this.Text = "fr_QuanLyNhaSanXuat";
            this.Load += new System.EventHandler(this.fr_QuanLyNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaSanXuat;
        private System.Windows.Forms.DataGridViewImageColumn LogoNhaSanXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaNSX;
        private System.Windows.Forms.Button btnChinhSuaNSX;
        private System.Windows.Forms.Button btnThemNSX;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}