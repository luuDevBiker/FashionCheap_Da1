
namespace _3_GUI
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrid_sp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrid_giohang = new System.Windows.Forms.DataGridView();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxTenKhachhang = new System.Windows.Forms.ComboBox();
            this.DateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.tbxSoTienHoanLai = new System.Windows.Forms.TextBox();
            this.tbxKhachThanhToan = new System.Windows.Forms.TextBox();
            this.tbxKhachCanTra = new System.Windows.Forms.TextBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataNgayTao1 = new System.Windows.Forms.DateTimePicker();
            this.cbxKhachHang1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.tbxMaHoaDon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Data_HoaDonCho = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giohang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_HoaDonCho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrid_sp);
            this.groupBox3.Location = new System.Drawing.Point(25, 434);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(790, 381);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Sản Phẩm Mua";
            // 
            // dgrid_sp
            // 
            this.dgrid_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sp.Location = new System.Drawing.Point(13, 24);
            this.dgrid_sp.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_sp.Name = "dgrid_sp";
            this.dgrid_sp.RowHeadersWidth = 62;
            this.dgrid_sp.RowTemplate.Height = 33;
            this.dgrid_sp.Size = new System.Drawing.Size(764, 346);
            this.dgrid_sp.TabIndex = 0;
            this.dgrid_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sp_CellContentClick);
            this.dgrid_sp.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sp_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_giohang);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(805, 400);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ Hàng";
            // 
            // dgrid_giohang
            // 
            this.dgrid_giohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_giohang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_giohang.Location = new System.Drawing.Point(5, 34);
            this.dgrid_giohang.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_giohang.Name = "dgrid_giohang";
            this.dgrid_giohang.RowHeadersWidth = 62;
            this.dgrid_giohang.RowTemplate.Height = 33;
            this.dgrid_giohang.Size = new System.Drawing.Size(786, 358);
            this.dgrid_giohang.TabIndex = 0;
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(831, 20);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(289, 27);
            this.tbxTimKiem.TabIndex = 4;
            this.tbxTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(831, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(291, 754);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.tabPage1.Controls.Add(this.cbxTenKhachhang);
            this.tabPage1.Controls.Add(this.DateNgayTao);
            this.tabPage1.Controls.Add(this.tbxSoTienHoanLai);
            this.tabPage1.Controls.Add(this.tbxKhachThanhToan);
            this.tabPage1.Controls.Add(this.tbxKhachCanTra);
            this.tabPage1.Controls.Add(this.tbxTongTien);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbxMaNhanVien);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(283, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn";
            // 
            // cbxTenKhachhang
            // 
            this.cbxTenKhachhang.FormattingEnabled = true;
            this.cbxTenKhachhang.Location = new System.Drawing.Point(127, 66);
            this.cbxTenKhachhang.Name = "cbxTenKhachhang";
            this.cbxTenKhachhang.Size = new System.Drawing.Size(151, 28);
            this.cbxTenKhachhang.TabIndex = 17;
            // 
            // DateNgayTao
            // 
            this.DateNgayTao.CalendarFont = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateNgayTao.Location = new System.Drawing.Point(96, 215);
            this.DateNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.DateNgayTao.Name = "DateNgayTao";
            this.DateNgayTao.Size = new System.Drawing.Size(185, 27);
            this.DateNgayTao.TabIndex = 16;
            // 
            // tbxSoTienHoanLai
            // 
            this.tbxSoTienHoanLai.Location = new System.Drawing.Point(150, 557);
            this.tbxSoTienHoanLai.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSoTienHoanLai.Name = "tbxSoTienHoanLai";
            this.tbxSoTienHoanLai.Size = new System.Drawing.Size(121, 27);
            this.tbxSoTienHoanLai.TabIndex = 15;
            // 
            // tbxKhachThanhToan
            // 
            this.tbxKhachThanhToan.Location = new System.Drawing.Point(150, 499);
            this.tbxKhachThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.tbxKhachThanhToan.Name = "tbxKhachThanhToan";
            this.tbxKhachThanhToan.Size = new System.Drawing.Size(121, 27);
            this.tbxKhachThanhToan.TabIndex = 14;
            this.tbxKhachThanhToan.TextChanged += new System.EventHandler(this.tbxKhachThanhToan_TextChanged);
            // 
            // tbxKhachCanTra
            // 
            this.tbxKhachCanTra.Location = new System.Drawing.Point(150, 436);
            this.tbxKhachCanTra.Margin = new System.Windows.Forms.Padding(2);
            this.tbxKhachCanTra.Name = "tbxKhachCanTra";
            this.tbxKhachCanTra.Size = new System.Drawing.Size(121, 27);
            this.tbxKhachCanTra.TabIndex = 13;
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Location = new System.Drawing.Point(150, 367);
            this.tbxTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.Size = new System.Drawing.Size(121, 27);
            this.tbxTongTien.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(126)))), ((int)(((byte)(124)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(90, 646);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "   Thanh Toán";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 546);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Tiền Hoàn Lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 499);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khách Thanh Toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khách Cần Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng Tiền";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(126)))), ((int)(((byte)(124)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(81, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "   Tạo Hóa Đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxMaNhanVien
            // 
            this.tbxMaNhanVien.Location = new System.Drawing.Point(143, 140);
            this.tbxMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaNhanVien.Name = "tbxMaNhanVien";
            this.tbxMaNhanVien.Size = new System.Drawing.Size(121, 27);
            this.tbxMaNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.tabPage2.Controls.Add(this.DataNgayTao1);
            this.tabPage2.Controls.Add(this.cbxKhachHang1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tbxSdt);
            this.tabPage2.Controls.Add(this.tbxDiaChi);
            this.tabPage2.Controls.Add(this.tbxMaNV);
            this.tabPage2.Controls.Add(this.tbxMaHoaDon);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(283, 721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đặt Hàng";
            // 
            // DataNgayTao1
            // 
            this.DataNgayTao1.Location = new System.Drawing.Point(18, 476);
            this.DataNgayTao1.Name = "DataNgayTao1";
            this.DataNgayTao1.Size = new System.Drawing.Size(250, 27);
            this.DataNgayTao1.TabIndex = 18;
            // 
            // cbxKhachHang1
            // 
            this.cbxKhachHang1.FormattingEnabled = true;
            this.cbxKhachHang1.Location = new System.Drawing.Point(121, 130);
            this.cbxKhachHang1.Name = "cbxKhachHang1";
            this.cbxKhachHang1.Size = new System.Drawing.Size(151, 28);
            this.cbxKhachHang1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(126)))), ((int)(((byte)(124)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(69, 546);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 56);
            this.button4.TabIndex = 16;
            this.button4.Text = "    Đặt Hàng";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(126)))), ((int)(((byte)(124)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(69, 632);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 56);
            this.button3.TabIndex = 7;
            this.button3.Text = "In";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbxSdt
            // 
            this.tbxSdt.Location = new System.Drawing.Point(149, 357);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(134, 27);
            this.tbxSdt.TabIndex = 13;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(149, 278);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(134, 27);
            this.tbxDiaChi.TabIndex = 12;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Location = new System.Drawing.Point(146, 204);
            this.tbxMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.Size = new System.Drawing.Size(134, 27);
            this.tbxMaNV.TabIndex = 11;
            // 
            // tbxMaHoaDon
            // 
            this.tbxMaHoaDon.Location = new System.Drawing.Point(138, 59);
            this.tbxMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaHoaDon.Name = "tbxMaHoaDon";
            this.tbxMaHoaDon.Size = new System.Drawing.Size(134, 27);
            this.tbxMaHoaDon.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 440);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Ngày Tạo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 357);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Số Điện Thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Địa Chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Khách Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Data_HoaDonCho);
            this.groupBox2.Location = new System.Drawing.Point(1127, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(397, 758);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn Chờ";
            // 
            // Data_HoaDonCho
            // 
            this.Data_HoaDonCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_HoaDonCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_HoaDonCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenKH,
            this.SĐT,
            this.TrangThai});
            this.Data_HoaDonCho.Location = new System.Drawing.Point(5, 24);
            this.Data_HoaDonCho.Margin = new System.Windows.Forms.Padding(2);
            this.Data_HoaDonCho.Name = "Data_HoaDonCho";
            this.Data_HoaDonCho.RowHeadersWidth = 62;
            this.Data_HoaDonCho.RowTemplate.Height = 33;
            this.Data_HoaDonCho.Size = new System.Drawing.Size(387, 230);
            this.Data_HoaDonCho.TabIndex = 0;
            this.Data_HoaDonCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_HoaDonCho_CellClick);
            this.Data_HoaDonCho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_HoaDonCho_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            // 
            // SĐT
            // 
            this.SĐT.HeaderText = "Số Điện Thoại";
            this.SĐT.MinimumWidth = 8;
            this.SĐT.Name = "SĐT";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1534, 819);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giohang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_HoaDonCho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_sanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrid_giohang;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewImageColumn ha;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Data_HoaDonCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SĐT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgrid_sp;
        private System.Windows.Forms.DateTimePicker DateNgayTao;
        private System.Windows.Forms.TextBox tbxSoTienHoanLai;
        private System.Windows.Forms.TextBox tbxKhachThanhToan;
        private System.Windows.Forms.TextBox tbxKhachCanTra;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.TextBox tbxMaHoaDon;
        private System.Windows.Forms.ComboBox cbxTenKhachhang;
        private System.Windows.Forms.ComboBox cbxKhachHang1;
        private System.Windows.Forms.DateTimePicker DataNgayTao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}