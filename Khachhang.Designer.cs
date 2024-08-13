namespace SHOP_CDH
{
    partial class Khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.dataGridView_khachhang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dangxuat = new System.Windows.Forms.Button();
            this.btn_thoatkh = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_donhang = new System.Windows.Forms.Button();
            this.btn_hanghoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_searchkh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdtkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_huykh = new System.Windows.Forms.Button();
            this.btn_luukh = new System.Windows.Forms.Button();
            this.btn_xoakh = new System.Windows.Forms.Button();
            this.btn_suakh = new System.Windows.Forms.Button();
            this.btn_themkh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_diachikh = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_nhanvien.Location = new System.Drawing.Point(26, 403);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(158, 37);
            this.btn_nhanvien.TabIndex = 5;
            this.btn_nhanvien.Text = "Quản lý nhân viên";
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.AllowUserToAddRows = false;
            this.dataGridView_khachhang.AllowUserToDeleteRows = false;
            this.dataGridView_khachhang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SoDienThoai,
            this.GioiTinh});
            this.dataGridView_khachhang.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(216, 400);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.ReadOnly = true;
            this.dataGridView_khachhang.RowHeadersWidth = 51;
            this.dataGridView_khachhang.RowTemplate.Height = 24;
            this.dataGridView_khachhang.Size = new System.Drawing.Size(1032, 253);
            this.dataGridView_khachhang.TabIndex = 42;
            this.dataGridView_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khachhang_CellClick);
            this.dataGridView_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khachhang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_Dangxuat);
            this.panel1.Controls.Add(this.btn_thoatkh);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_donhang);
            this.panel1.Controls.Add(this.btn_hanghoa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 726);
            this.panel1.TabIndex = 40;
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dangxuat.Location = new System.Drawing.Point(26, 565);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Size = new System.Drawing.Size(158, 37);
            this.btn_Dangxuat.TabIndex = 49;
            this.btn_Dangxuat.Text = "Đăng xuất";
            this.btn_Dangxuat.UseVisualStyleBackColor = true;
            this.btn_Dangxuat.Click += new System.EventHandler(this.btn_Dangxuat_Click);
            // 
            // btn_thoatkh
            // 
            this.btn_thoatkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoatkh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoatkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_thoatkh.Location = new System.Drawing.Point(26, 647);
            this.btn_thoatkh.Name = "btn_thoatkh";
            this.btn_thoatkh.Size = new System.Drawing.Size(158, 37);
            this.btn_thoatkh.TabIndex = 50;
            this.btn_thoatkh.Text = "Thoát";
            this.btn_thoatkh.UseVisualStyleBackColor = false;
            this.btn_thoatkh.Click += new System.EventHandler(this.btn_thoatkh_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thongke.Location = new System.Drawing.Point(26, 491);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(158, 37);
            this.btn_thongke.TabIndex = 6;
            this.btn_thongke.Text = "Thống kê doanh thu";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_khachhang.ForeColor = System.Drawing.Color.Red;
            this.btn_khachhang.Location = new System.Drawing.Point(26, 318);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(158, 37);
            this.btn_khachhang.TabIndex = 4;
            this.btn_khachhang.Text = "Quản lý khách hàng";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            // 
            // btn_donhang
            // 
            this.btn_donhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_donhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_donhang.Location = new System.Drawing.Point(26, 233);
            this.btn_donhang.Name = "btn_donhang";
            this.btn_donhang.Size = new System.Drawing.Size(158, 37);
            this.btn_donhang.TabIndex = 3;
            this.btn_donhang.Text = "Quản lý đơn hàng";
            this.btn_donhang.UseVisualStyleBackColor = true;
            this.btn_donhang.Click += new System.EventHandler(this.btn_donhang_Click);
            // 
            // btn_hanghoa
            // 
            this.btn_hanghoa.BackColor = System.Drawing.Color.White;
            this.btn_hanghoa.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_hanghoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_hanghoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_hanghoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hanghoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_hanghoa.Location = new System.Drawing.Point(26, 170);
            this.btn_hanghoa.Name = "btn_hanghoa";
            this.btn_hanghoa.Size = new System.Drawing.Size(158, 37);
            this.btn_hanghoa.TabIndex = 2;
            this.btn_hanghoa.Text = "Quản lý hàng hóa";
            this.btn_hanghoa.UseVisualStyleBackColor = false;
            this.btn_hanghoa.Click += new System.EventHandler(this.btn_hanghoa_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 311);
            this.panel2.TabIndex = 1;
            // 
            // txt_searchkh
            // 
            this.txt_searchkh.BackColor = System.Drawing.Color.MistyRose;
            this.txt_searchkh.Location = new System.Drawing.Point(560, 312);
            this.txt_searchkh.Name = "txt_searchkh";
            this.txt_searchkh.Size = new System.Drawing.Size(303, 27);
            this.txt_searchkh.TabIndex = 14;
            this.txt_searchkh.TextChanged += new System.EventHandler(this.txt_searchkh_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(285, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nhập mã khách hàng cần tìm";
            // 
            // txt_sdtkh
            // 
            this.txt_sdtkh.BackColor = System.Drawing.Color.MistyRose;
            this.txt_sdtkh.Location = new System.Drawing.Point(671, 173);
            this.txt_sdtkh.Name = "txt_sdtkh";
            this.txt_sdtkh.Size = new System.Drawing.Size(214, 27);
            this.txt_sdtkh.TabIndex = 9;
            this.txt_sdtkh.TextChanged += new System.EventHandler(this.txt_sdtkh_TextChanged);
            this.txt_sdtkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdtkh_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(74, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(544, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giới tính";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.BackColor = System.Drawing.Color.MistyRose;
            this.txt_tenkh.Location = new System.Drawing.Point(218, 173);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(223, 27);
            this.txt_tenkh.TabIndex = 5;
            this.txt_tenkh.TextChanged += new System.EventHandler(this.txt_tenkh_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(74, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khách hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.BackColor = System.Drawing.Color.MistyRose;
            this.txt_makh.Location = new System.Drawing.Point(218, 94);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(223, 27);
            this.txt_makh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(544, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(321, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thông tin khách hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Location = new System.Drawing.Point(-25, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1225, 10);
            this.panel4.TabIndex = 43;
            // 
            // btn_huykh
            // 
            this.btn_huykh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_huykh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huykh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_huykh.Location = new System.Drawing.Point(976, 672);
            this.btn_huykh.Name = "btn_huykh";
            this.btn_huykh.Size = new System.Drawing.Size(88, 39);
            this.btn_huykh.TabIndex = 48;
            this.btn_huykh.Text = "Hủy bỏ";
            this.btn_huykh.UseVisualStyleBackColor = false;
            this.btn_huykh.Click += new System.EventHandler(this.btn_huykh_Click);
            // 
            // btn_luukh
            // 
            this.btn_luukh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_luukh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luukh.ForeColor = System.Drawing.Color.Green;
            this.btn_luukh.Location = new System.Drawing.Point(816, 672);
            this.btn_luukh.Name = "btn_luukh";
            this.btn_luukh.Size = new System.Drawing.Size(88, 39);
            this.btn_luukh.TabIndex = 47;
            this.btn_luukh.Text = "Lưu lại";
            this.btn_luukh.UseVisualStyleBackColor = false;
            this.btn_luukh.Click += new System.EventHandler(this.btn_luukh_Click);
            // 
            // btn_xoakh
            // 
            this.btn_xoakh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_xoakh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoakh.ForeColor = System.Drawing.Color.Black;
            this.btn_xoakh.Location = new System.Drawing.Point(643, 672);
            this.btn_xoakh.Name = "btn_xoakh";
            this.btn_xoakh.Size = new System.Drawing.Size(88, 39);
            this.btn_xoakh.TabIndex = 46;
            this.btn_xoakh.Text = "Xóa";
            this.btn_xoakh.UseVisualStyleBackColor = false;
            this.btn_xoakh.Click += new System.EventHandler(this.btn_xoakh_Click);
            // 
            // btn_suakh
            // 
            this.btn_suakh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suakh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_suakh.ForeColor = System.Drawing.Color.Navy;
            this.btn_suakh.Location = new System.Drawing.Point(475, 672);
            this.btn_suakh.Name = "btn_suakh";
            this.btn_suakh.Size = new System.Drawing.Size(88, 39);
            this.btn_suakh.TabIndex = 45;
            this.btn_suakh.Text = "Cập nhật";
            this.btn_suakh.UseVisualStyleBackColor = false;
            this.btn_suakh.Click += new System.EventHandler(this.btn_suakh_Click);
            // 
            // btn_themkh
            // 
            this.btn_themkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_themkh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_themkh.ForeColor = System.Drawing.Color.Purple;
            this.btn_themkh.Location = new System.Drawing.Point(289, 672);
            this.btn_themkh.Name = "btn_themkh";
            this.btn_themkh.Size = new System.Drawing.Size(95, 39);
            this.btn_themkh.TabIndex = 44;
            this.btn_themkh.Text = "Thêm mới";
            this.btn_themkh.UseVisualStyleBackColor = false;
            this.btn_themkh.Click += new System.EventHandler(this.btn_themkh_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cmb_gioitinh);
            this.panel3.Controls.Add(this.txt_diachikh);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_searchkh);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_sdtkh);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_tenkh);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_makh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(211, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 388);
            this.panel3.TabIndex = 41;
            // 
            // cmb_gioitinh
            // 
            this.cmb_gioitinh.FormattingEnabled = true;
            this.cmb_gioitinh.Location = new System.Drawing.Point(671, 89);
            this.cmb_gioitinh.Name = "cmb_gioitinh";
            this.cmb_gioitinh.Size = new System.Drawing.Size(214, 27);
            this.cmb_gioitinh.TabIndex = 21;
            // 
            // txt_diachikh
            // 
            this.txt_diachikh.BackColor = System.Drawing.Color.MistyRose;
            this.txt_diachikh.Location = new System.Drawing.Point(218, 250);
            this.txt_diachikh.Name = "txt_diachikh";
            this.txt_diachikh.Size = new System.Drawing.Size(214, 27);
            this.txt_diachikh.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 132);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_khachhang);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_huykh);
            this.Controls.Add(this.btn_luukh);
            this.Controls.Add(this.btn_xoakh);
            this.Controls.Add(this.btn_suakh);
            this.Controls.Add(this.btn_themkh);
            this.Controls.Add(this.panel3);
            this.Name = "Khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.DataGridView dataGridView_khachhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_donhang;
        private System.Windows.Forms.Button btn_hanghoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_searchkh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdtkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_huykh;
        private System.Windows.Forms.Button btn_luukh;
        private System.Windows.Forms.Button btn_xoakh;
        private System.Windows.Forms.Button btn_suakh;
        private System.Windows.Forms.Button btn_themkh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_thoatkh;
        private System.Windows.Forms.TextBox txt_diachikh;
        private System.Windows.Forms.Button btn_Dangxuat;
        private System.Windows.Forms.ComboBox cmb_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}