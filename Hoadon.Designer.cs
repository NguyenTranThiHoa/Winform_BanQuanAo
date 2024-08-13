namespace SHOP_CDH
{
    partial class Hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadon));
            this.btn_xoahd = new System.Windows.Forms.Button();
            this.btn_suasp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manvhd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makhhd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.dataGridView_tthd = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dangxuat = new System.Windows.Forms.Button();
            this.btn_thoatsp = new System.Windows.Forms.Button();
            this.btn_donhang = new System.Windows.Forms.Button();
            this.btn_hanghoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_huysp = new System.Windows.Forms.Button();
            this.btn_xuatExecl = new System.Windows.Forms.Button();
            this.btn_luuhd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tthd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoahd
            // 
            this.btn_xoahd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_xoahd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoahd.ForeColor = System.Drawing.Color.Black;
            this.btn_xoahd.Location = new System.Drawing.Point(776, 681);
            this.btn_xoahd.Name = "btn_xoahd";
            this.btn_xoahd.Size = new System.Drawing.Size(88, 39);
            this.btn_xoahd.TabIndex = 36;
            this.btn_xoahd.Text = "Xóa";
            this.btn_xoahd.UseVisualStyleBackColor = false;
            this.btn_xoahd.Click += new System.EventHandler(this.btn_xoahd_Click);
            // 
            // btn_suasp
            // 
            this.btn_suasp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suasp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_suasp.ForeColor = System.Drawing.Color.Navy;
            this.btn_suasp.Location = new System.Drawing.Point(475, 680);
            this.btn_suasp.Name = "btn_suasp";
            this.btn_suasp.Size = new System.Drawing.Size(88, 39);
            this.btn_suasp.TabIndex = 35;
            this.btn_suasp.Text = "Cập nhật";
            this.btn_suasp.UseVisualStyleBackColor = false;
            this.btn_suasp.Click += new System.EventHandler(this.btn_suasp_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_manvhd);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_makhhd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_mahd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(206, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 295);
            this.panel3.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(622, 173);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(214, 27);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(505, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tìm kiếm";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox2.Location = new System.Drawing.Point(622, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 27);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.LightSalmon;
            this.txt_tongtien.Location = new System.Drawing.Point(157, 241);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(187, 27);
            this.txt_tongtien.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(321, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thông tin hóa đơn";
            // 
            // txt_manvhd
            // 
            this.txt_manvhd.BackColor = System.Drawing.Color.MistyRose;
            this.txt_manvhd.Location = new System.Drawing.Point(622, 89);
            this.txt_manvhd.Name = "txt_manvhd";
            this.txt_manvhd.Size = new System.Drawing.Size(214, 27);
            this.txt_manvhd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(505, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày lập HD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(505, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã nhân viên";
            // 
            // txt_makhhd
            // 
            this.txt_makhhd.BackColor = System.Drawing.Color.MistyRose;
            this.txt_makhhd.Location = new System.Drawing.Point(157, 173);
            this.txt_makhhd.Name = "txt_makhhd";
            this.txt_makhhd.Size = new System.Drawing.Size(187, 27);
            this.txt_makhhd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã khách hàng";
            // 
            // txt_mahd
            // 
            this.txt_mahd.BackColor = System.Drawing.Color.MistyRose;
            this.txt_mahd.Location = new System.Drawing.Point(157, 97);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(187, 27);
            this.txt_mahd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn";
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xemchitiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xemchitiet.ForeColor = System.Drawing.Color.Purple;
            this.btn_xemchitiet.Location = new System.Drawing.Point(287, 680);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(124, 39);
            this.btn_xemchitiet.TabIndex = 34;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = false;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_themsp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Location = new System.Drawing.Point(-2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1225, 10);
            this.panel4.TabIndex = 33;
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
            // btn_nhanvien
            // 
            this.btn_nhanvien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nhanvien.Location = new System.Drawing.Point(26, 403);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(158, 37);
            this.btn_nhanvien.TabIndex = 5;
            this.btn_nhanvien.Text = "Quản lý nhân viên";
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_khachhang.Location = new System.Drawing.Point(26, 318);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(158, 37);
            this.btn_khachhang.TabIndex = 4;
            this.btn_khachhang.Text = "Quản lý khách hàng";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // dataGridView_tthd
            // 
            this.dataGridView_tthd.AllowUserToAddRows = false;
            this.dataGridView_tthd.AllowUserToDeleteRows = false;
            this.dataGridView_tthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD,
            this.ThanhTien});
            this.dataGridView_tthd.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView_tthd.Location = new System.Drawing.Point(211, 315);
            this.dataGridView_tthd.Name = "dataGridView_tthd";
            this.dataGridView_tthd.ReadOnly = true;
            this.dataGridView_tthd.RowHeadersWidth = 51;
            this.dataGridView_tthd.RowTemplate.Height = 24;
            this.dataGridView_tthd.Size = new System.Drawing.Size(1017, 328);
            this.dataGridView_tthd.TabIndex = 32;
            this.dataGridView_tthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tthd_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
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
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập hóa đơn";
            this.NgayLapHD.MinimumWidth = 6;
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Tổng tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThanhTien.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_Dangxuat);
            this.panel1.Controls.Add(this.btn_thoatsp);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_donhang);
            this.panel1.Controls.Add(this.btn_hanghoa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 726);
            this.panel1.TabIndex = 30;
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dangxuat.Location = new System.Drawing.Point(26, 569);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Size = new System.Drawing.Size(158, 37);
            this.btn_Dangxuat.TabIndex = 40;
            this.btn_Dangxuat.Text = "Đăng xuất";
            this.btn_Dangxuat.UseVisualStyleBackColor = true;
            // 
            // btn_thoatsp
            // 
            this.btn_thoatsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoatsp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoatsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_thoatsp.Location = new System.Drawing.Point(26, 637);
            this.btn_thoatsp.Name = "btn_thoatsp";
            this.btn_thoatsp.Size = new System.Drawing.Size(158, 37);
            this.btn_thoatsp.TabIndex = 40;
            this.btn_thoatsp.Text = "Thoát";
            this.btn_thoatsp.UseVisualStyleBackColor = false;
            this.btn_thoatsp.Click += new System.EventHandler(this.btn_thoatsp_Click);
            // 
            // btn_donhang
            // 
            this.btn_donhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_donhang.ForeColor = System.Drawing.Color.Red;
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
            this.btn_hanghoa.Location = new System.Drawing.Point(26, 168);
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
            // btn_huysp
            // 
            this.btn_huysp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_huysp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huysp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_huysp.Location = new System.Drawing.Point(927, 681);
            this.btn_huysp.Name = "btn_huysp";
            this.btn_huysp.Size = new System.Drawing.Size(88, 39);
            this.btn_huysp.TabIndex = 38;
            this.btn_huysp.Text = "Hủy bỏ";
            this.btn_huysp.UseVisualStyleBackColor = false;
            this.btn_huysp.Click += new System.EventHandler(this.btn_huysp_Click);
            // 
            // btn_xuatExecl
            // 
            this.btn_xuatExecl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xuatExecl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xuatExecl.ForeColor = System.Drawing.Color.Green;
            this.btn_xuatExecl.Location = new System.Drawing.Point(1066, 680);
            this.btn_xuatExecl.Name = "btn_xuatExecl";
            this.btn_xuatExecl.Size = new System.Drawing.Size(100, 39);
            this.btn_xuatExecl.TabIndex = 39;
            this.btn_xuatExecl.Text = "Xuất Excel";
            this.btn_xuatExecl.UseVisualStyleBackColor = false;
            this.btn_xuatExecl.Click += new System.EventHandler(this.btn_xuatExecl_Click);
            // 
            // btn_luuhd
            // 
            this.btn_luuhd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_luuhd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luuhd.ForeColor = System.Drawing.Color.Green;
            this.btn_luuhd.Location = new System.Drawing.Point(629, 681);
            this.btn_luuhd.Name = "btn_luuhd";
            this.btn_luuhd.Size = new System.Drawing.Size(88, 39);
            this.btn_luuhd.TabIndex = 40;
            this.btn_luuhd.Text = "Lưu lại";
            this.btn_luuhd.UseVisualStyleBackColor = false;
            this.btn_luuhd.Click += new System.EventHandler(this.btn_luuhd_Click);
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
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 732);
            this.Controls.Add(this.btn_luuhd);
            this.Controls.Add(this.btn_xuatExecl);
            this.Controls.Add(this.btn_huysp);
            this.Controls.Add(this.btn_xoahd);
            this.Controls.Add(this.btn_suasp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_xemchitiet);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_tthd);
            this.Controls.Add(this.panel1);
            this.Name = "Hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoadon";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tthd)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_xoahd;
        private System.Windows.Forms.Button btn_suasp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_manvhd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_makhhd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.DataGridView dataGridView_tthd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_donhang;
        private System.Windows.Forms.Button btn_hanghoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thoatsp;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_huysp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btn_Dangxuat;
        private System.Windows.Forms.Button btn_xuatExecl;
        private System.Windows.Forms.Button btn_luuhd;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}