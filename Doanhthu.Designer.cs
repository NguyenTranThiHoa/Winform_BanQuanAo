namespace SHOP_CDH
{
    partial class Doanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doanhthu));
            this.btn_donhang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_doanhthu = new System.Windows.Forms.DataGridView();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dangxuat = new System.Windows.Forms.Button();
            this.btn_thoatnv = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_hanghoa = new System.Windows.Forms.Button();
            this.txt_loinhuan = new System.Windows.Forms.TextBox();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soluongban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_xuatfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanhthu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_donhang
            // 
            this.btn_donhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_donhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_donhang.Location = new System.Drawing.Point(26, 233);
            this.btn_donhang.Name = "btn_donhang";
            this.btn_donhang.Size = new System.Drawing.Size(158, 37);
            this.btn_donhang.TabIndex = 3;
            this.btn_donhang.Text = "Quản lý đơn hàng";
            this.btn_donhang.UseVisualStyleBackColor = true;
            this.btn_donhang.Click += new System.EventHandler(this.btn_donhang_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 311);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_doanhthu
            // 
            this.dataGridView_doanhthu.AllowUserToAddRows = false;
            this.dataGridView_doanhthu.AllowUserToDeleteRows = false;
            this.dataGridView_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.SoLuongDaBan,
            this.ThanhTien,
            this.LoiNhuan});
            this.dataGridView_doanhthu.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView_doanhthu.Location = new System.Drawing.Point(217, 316);
            this.dataGridView_doanhthu.Name = "dataGridView_doanhthu";
            this.dataGridView_doanhthu.ReadOnly = true;
            this.dataGridView_doanhthu.RowHeadersWidth = 51;
            this.dataGridView_doanhthu.RowTemplate.Height = 24;
            this.dataGridView_doanhthu.Size = new System.Drawing.Size(1017, 328);
            this.dataGridView_doanhthu.TabIndex = 42;
            this.dataGridView_doanhthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_doanhthu_CellClick);
            // 
            // Thang
            // 
            this.Thang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // SoLuongDaBan
            // 
            this.SoLuongDaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongDaBan.DataPropertyName = "SoLuongDaBan";
            this.SoLuongDaBan.HeaderText = "Số lượng đã bán";
            this.SoLuongDaBan.MinimumWidth = 6;
            this.SoLuongDaBan.Name = "SoLuongDaBan";
            this.SoLuongDaBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "DoanhThu";
            this.ThanhTien.HeaderText = "Doanh thu";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // LoiNhuan
            // 
            this.LoiNhuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoiNhuan.DataPropertyName = "LoiNhuan";
            this.LoiNhuan.HeaderText = "Lợi nhuận";
            this.LoiNhuan.MinimumWidth = 6;
            this.LoiNhuan.Name = "LoiNhuan";
            this.LoiNhuan.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_Dangxuat);
            this.panel1.Controls.Add(this.btn_thoatnv);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_donhang);
            this.panel1.Controls.Add(this.btn_hanghoa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 726);
            this.panel1.TabIndex = 40;
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dangxuat.Location = new System.Drawing.Point(26, 562);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Size = new System.Drawing.Size(158, 37);
            this.btn_Dangxuat.TabIndex = 49;
            this.btn_Dangxuat.Text = "Đăng xuất";
            this.btn_Dangxuat.UseVisualStyleBackColor = true;
            // 
            // btn_thoatnv
            // 
            this.btn_thoatnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoatnv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoatnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_thoatnv.Location = new System.Drawing.Point(26, 624);
            this.btn_thoatnv.Name = "btn_thoatnv";
            this.btn_thoatnv.Size = new System.Drawing.Size(158, 39);
            this.btn_thoatnv.TabIndex = 41;
            this.btn_thoatnv.Text = "Thoát";
            this.btn_thoatnv.UseVisualStyleBackColor = false;
            this.btn_thoatnv.Click += new System.EventHandler(this.btn_thoatnv_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thongke.ForeColor = System.Drawing.Color.Red;
            this.btn_thongke.Location = new System.Drawing.Point(26, 478);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(158, 36);
            this.btn_thongke.TabIndex = 6;
            this.btn_thongke.Text = "Thống kê doanh thu";
            this.btn_thongke.UseVisualStyleBackColor = true;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nhanvien.Location = new System.Drawing.Point(26, 403);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(158, 34);
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
            this.btn_khachhang.Size = new System.Drawing.Size(158, 32);
            this.btn_khachhang.TabIndex = 4;
            this.btn_khachhang.Text = "Quản lý khách hàng";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_hanghoa
            // 
            this.btn_hanghoa.BackColor = System.Drawing.Color.White;
            this.btn_hanghoa.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_hanghoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_hanghoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_hanghoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hanghoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_hanghoa.Location = new System.Drawing.Point(26, 159);
            this.btn_hanghoa.Name = "btn_hanghoa";
            this.btn_hanghoa.Size = new System.Drawing.Size(158, 36);
            this.btn_hanghoa.TabIndex = 2;
            this.btn_hanghoa.Text = "Quản lý hàng hóa";
            this.btn_hanghoa.UseVisualStyleBackColor = false;
            this.btn_hanghoa.Click += new System.EventHandler(this.btn_hanghoa_Click);
            // 
            // txt_loinhuan
            // 
            this.txt_loinhuan.BackColor = System.Drawing.Color.MistyRose;
            this.txt_loinhuan.Location = new System.Drawing.Point(622, 173);
            this.txt_loinhuan.Name = "txt_loinhuan";
            this.txt_loinhuan.Size = new System.Drawing.Size(214, 27);
            this.txt_loinhuan.TabIndex = 10;
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.BackColor = System.Drawing.Color.MistyRose;
            this.txt_doanhthu.Location = new System.Drawing.Point(622, 89);
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.Size = new System.Drawing.Size(214, 27);
            this.txt_doanhthu.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(505, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lợi nhuận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(505, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doanh thu";
            // 
            // txt_soluongban
            // 
            this.txt_soluongban.BackColor = System.Drawing.Color.MistyRose;
            this.txt_soluongban.Location = new System.Drawing.Point(157, 173);
            this.txt_soluongban.Name = "txt_soluongban";
            this.txt_soluongban.Size = new System.Drawing.Size(187, 27);
            this.txt_soluongban.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng đã bán";
            // 
            // txt_thang
            // 
            this.txt_thang.BackColor = System.Drawing.Color.MistyRose;
            this.txt_thang.Location = new System.Drawing.Point(157, 97);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(187, 27);
            this.txt_thang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(355, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu bán hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_xuatfile);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.txt_loinhuan);
            this.panel3.Controls.Add(this.txt_doanhthu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_soluongban);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_thang);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(212, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 295);
            this.panel3.TabIndex = 41;
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.BackColor = System.Drawing.Color.Yellow;
            this.btn_xuatfile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xuatfile.ForeColor = System.Drawing.Color.Purple;
            this.btn_xuatfile.Location = new System.Drawing.Point(622, 234);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(108, 39);
            this.btn_xuatfile.TabIndex = 49;
            this.btn_xuatfile.Text = "Xuất file";
            this.btn_xuatfile.UseVisualStyleBackColor = false;
            this.btn_xuatfile.Click += new System.EventHandler(this.btn_xuatfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(113, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập vào tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Location = new System.Drawing.Point(288, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 27);
            this.textBox1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1225, 10);
            this.panel4.TabIndex = 43;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 132);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // Doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 732);
            this.Controls.Add(this.dataGridView_doanhthu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Doanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanhthu";
            this.Load += new System.EventHandler(this.Doanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanhthu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_donhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_doanhthu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_hanghoa;
        private System.Windows.Forms.TextBox txt_loinhuan;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soluongban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_thoatnv;
        private System.Windows.Forms.Button btn_xuatfile;
        private System.Windows.Forms.Button btn_Dangxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiNhuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}