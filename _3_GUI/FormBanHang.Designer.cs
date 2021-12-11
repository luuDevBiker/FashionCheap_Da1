
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
            this.lblPhuongThucThanhToan = new System.Windows.Forms.Label();
            this.cbxPhuongThucThanhToan = new System.Windows.Forms.ComboBox();
            this.cbxTenKhachhang = new System.Windows.Forms.ComboBox();
            this.DateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienHoanLai = new System.Windows.Forms.TextBox();
            this.txtKhachThanhToan = new System.Windows.Forms.TextBox();
            this.txtKhachCanTra = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblHoanLai = new System.Windows.Forms.Label();
            this.lblKhachTra = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTongTra = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
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
            this.groupBox3.Location = new System.Drawing.Point(10, 434);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(805, 381);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Sản Phẩm Mua";
            // 
            // dgrid_sp
            // 
            this.dgrid_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_sp.Location = new System.Drawing.Point(2, 22);
            this.dgrid_sp.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_sp.Name = "dgrid_sp";
            this.dgrid_sp.RowHeadersWidth = 62;
            this.dgrid_sp.RowTemplate.Height = 33;
            this.dgrid_sp.Size = new System.Drawing.Size(801, 357);
            this.dgrid_sp.TabIndex = 0;
            this.dgrid_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sp_CellContentClick);
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
            this.dgrid_giohang.AllowUserToAddRows = false;
            this.dgrid_giohang.AllowUserToDeleteRows = false;
            this.dgrid_giohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_giohang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_giohang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_giohang.Location = new System.Drawing.Point(2, 22);
            this.dgrid_giohang.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_giohang.Name = "dgrid_giohang";
            this.dgrid_giohang.RowHeadersWidth = 62;
            this.dgrid_giohang.RowTemplate.Height = 33;
            this.dgrid_giohang.Size = new System.Drawing.Size(801, 376);
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
            this.tabControl1.Size = new System.Drawing.Size(449, 754);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.tabPage1.Controls.Add(this.lblPhuongThucThanhToan);
            this.tabPage1.Controls.Add(this.cbxPhuongThucThanhToan);
            this.tabPage1.Controls.Add(this.cbxTenKhachhang);
            this.tabPage1.Controls.Add(this.DateNgayTao);
            this.tabPage1.Controls.Add(this.txtSoTienHoanLai);
            this.tabPage1.Controls.Add(this.txtKhachThanhToan);
            this.tabPage1.Controls.Add(this.txtKhachCanTra);
            this.tabPage1.Controls.Add(this.txtGiamGia);
            this.tabPage1.Controls.Add(this.txtTongTien);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.lblHoanLai);
            this.tabPage1.Controls.Add(this.lblKhachTra);
            this.tabPage1.Controls.Add(this.lblGiamGia);
            this.tabPage1.Controls.Add(this.lblTongTra);
            this.tabPage1.Controls.Add(this.lblTongTien);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtMaNhanVien);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(441, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn";
            this.tabPage1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseMove);
            // 
            // lblPhuongThucThanhToan
            // 
            this.lblPhuongThucThanhToan.AutoSize = true;
            this.lblPhuongThucThanhToan.Location = new System.Drawing.Point(2, 446);
            this.lblPhuongThucThanhToan.Name = "lblPhuongThucThanhToan";
            this.lblPhuongThucThanhToan.Size = new System.Drawing.Size(169, 20);
            this.lblPhuongThucThanhToan.TabIndex = 19;
            this.lblPhuongThucThanhToan.Text = "phương thức thanh toán";
            // 
            // cbxPhuongThucThanhToan
            // 
            this.cbxPhuongThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhuongThucThanhToan.FormattingEnabled = true;
            this.cbxPhuongThucThanhToan.Location = new System.Drawing.Point(198, 443);
            this.cbxPhuongThucThanhToan.Name = "cbxPhuongThucThanhToan";
            this.cbxPhuongThucThanhToan.Size = new System.Drawing.Size(238, 28);
            this.cbxPhuongThucThanhToan.TabIndex = 18;
            // 
            // cbxTenKhachhang
            // 
            this.cbxTenKhachhang.FormattingEnabled = true;
            this.cbxTenKhachhang.Location = new System.Drawing.Point(198, 16);
            this.cbxTenKhachhang.Name = "cbxTenKhachhang";
            this.cbxTenKhachhang.Size = new System.Drawing.Size(238, 28);
            this.cbxTenKhachhang.TabIndex = 17;
            // 
            // DateNgayTao
            // 
            this.DateNgayTao.CalendarFont = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateNgayTao.Location = new System.Drawing.Point(198, 104);
            this.DateNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.DateNgayTao.Name = "DateNgayTao";
            this.DateNgayTao.Size = new System.Drawing.Size(238, 27);
            this.DateNgayTao.TabIndex = 16;
            // 
            // txtSoTienHoanLai
            // 
            this.txtSoTienHoanLai.Location = new System.Drawing.Point(198, 384);
            this.txtSoTienHoanLai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienHoanLai.Name = "txtSoTienHoanLai";
            this.txtSoTienHoanLai.Size = new System.Drawing.Size(238, 27);
            this.txtSoTienHoanLai.TabIndex = 15;
            // 
            // txtKhachThanhToan
            // 
            this.txtKhachThanhToan.Location = new System.Drawing.Point(198, 326);
            this.txtKhachThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachThanhToan.Name = "txtKhachThanhToan";
            this.txtKhachThanhToan.Size = new System.Drawing.Size(238, 27);
            this.txtKhachThanhToan.TabIndex = 14;
            this.txtKhachThanhToan.TextChanged += new System.EventHandler(this.tbxKhachThanhToan_TextChanged);
            // 
            // txtKhachCanTra
            // 
            this.txtKhachCanTra.Location = new System.Drawing.Point(198, 263);
            this.txtKhachCanTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachCanTra.Name = "txtKhachCanTra";
            this.txtKhachCanTra.Size = new System.Drawing.Size(238, 27);
            this.txtKhachCanTra.TabIndex = 13;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(198, 212);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(238, 27);
            this.txtGiamGia.TabIndex = 12;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(198, 156);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(238, 27);
            this.txtTongTien.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(126)))), ((int)(((byte)(124)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(296, 661);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "   Thanh Toán";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHoanLai
            // 
            this.lblHoanLai.AutoSize = true;
            this.lblHoanLai.Location = new System.Drawing.Point(2, 382);
            this.lblHoanLai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoanLai.Name = "lblHoanLai";
            this.lblHoanLai.Size = new System.Drawing.Size(121, 20);
            this.lblHoanLai.TabIndex = 10;
            this.lblHoanLai.Text = "Số Tiền Hoàn Lại";
            // 
            // lblKhachTra
            // 
            this.lblKhachTra.AutoSize = true;
            this.lblKhachTra.Location = new System.Drawing.Point(4, 329);
            this.lblKhachTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhachTra.Name = "lblKhachTra";
            this.lblKhachTra.Size = new System.Drawing.Size(129, 20);
            this.lblKhachTra.TabIndex = 9;
            this.lblKhachTra.Text = "Khách Thanh Toán";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(4, 207);
            this.lblGiamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(69, 20);
            this.lblGiamGia.TabIndex = 7;
            this.lblGiamGia.Text = "Giảm giá";
            // 
            // lblTongTra
            // 
            this.lblTongTra.AutoSize = true;
            this.lblTongTra.Location = new System.Drawing.Point(3, 265);
            this.lblTongTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTra.Name = "lblTongTra";
            this.lblTongTra.Size = new System.Drawing.Size(102, 20);
            this.lblTongTra.TabIndex = 8;
            this.lblTongTra.Text = "Khách Cần Trả";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(4, 151);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(126)))), ((int)(((byte)(124)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "   Tạo Hóa Đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(198, 60);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(238, 27);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 19);
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
            this.tabPage2.Size = new System.Drawing.Size(441, 721);
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
            this.cbxKhachHang1.Location = new System.Drawing.Point(138, 130);
            this.cbxKhachHang1.Name = "cbxKhachHang1";
            this.cbxKhachHang1.Size = new System.Drawing.Size(134, 28);
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
            this.tbxSdt.Location = new System.Drawing.Point(138, 357);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(137, 27);
            this.tbxSdt.TabIndex = 13;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(138, 278);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(137, 27);
            this.tbxDiaChi.TabIndex = 12;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Location = new System.Drawing.Point(138, 204);
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
            this.groupBox2.Location = new System.Drawing.Point(1284, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(387, 758);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn Chờ";
            // 
            // Data_HoaDonCho
            // 
            this.Data_HoaDonCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_HoaDonCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_HoaDonCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_HoaDonCho.Location = new System.Drawing.Point(2, 22);
            this.Data_HoaDonCho.Margin = new System.Windows.Forms.Padding(2);
            this.Data_HoaDonCho.Name = "Data_HoaDonCho";
            this.Data_HoaDonCho.RowHeadersWidth = 62;
            this.Data_HoaDonCho.RowTemplate.Height = 33;
            this.Data_HoaDonCho.Size = new System.Drawing.Size(383, 734);
            this.Data_HoaDonCho.TabIndex = 0;
            this.Data_HoaDonCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_HoaDonCho_CellClick);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1682, 819);
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
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblKhachTra;
        private System.Windows.Forms.Label lblTongTra;
        private System.Windows.Forms.Label lblHoanLai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Data_HoaDonCho;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgrid_sp;
        private System.Windows.Forms.DateTimePicker DateNgayTao;
        private System.Windows.Forms.TextBox txtSoTienHoanLai;
        private System.Windows.Forms.TextBox txtKhachThanhToan;
        private System.Windows.Forms.TextBox txtKhachCanTra;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.TextBox tbxMaHoaDon;
        private System.Windows.Forms.ComboBox cbxTenKhachhang;
        private System.Windows.Forms.ComboBox cbxKhachHang1;
        private System.Windows.Forms.DateTimePicker DataNgayTao1;
        private System.Windows.Forms.Label lblPhuongThucThanhToan;
        private System.Windows.Forms.ComboBox cbxPhuongThucThanhToan;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label lblGiamGia;
    }
}