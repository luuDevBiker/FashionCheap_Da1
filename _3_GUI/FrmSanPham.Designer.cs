
namespace _3_GUI
{
    partial class FrmSanPham
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
            this.data_Sanpham = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.tbxLocThuongHieu = new System.Windows.Forms.ComboBox();
            this.tbxLocMau = new System.Windows.Forms.ComboBox();
            this.tbxLocKichThuoc = new System.Windows.Forms.ComboBox();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblDacTinh = new System.Windows.Forms.Label();
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.lblMau = new System.Windows.Forms.Label();
            this.tbxTenSp = new System.Windows.Forms.TextBox();
            this.tbxTheLoai = new System.Windows.Forms.TextBox();
            this.tbxDacTinh = new System.Windows.Forms.TextBox();
            this.tbxThuonghieu = new System.Windows.Forms.TextBox();
            this.tbxNhap = new System.Windows.Forms.TextBox();
            this.tbxBan = new System.Windows.Forms.TextBox();
            this.tbxSl = new System.Windows.Forms.TextBox();
            this.tbxMau = new System.Windows.Forms.TextBox();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Sanpham
            // 
            this.data_Sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Sanpham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Sanpham.Location = new System.Drawing.Point(0, 441);
            this.data_Sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.data_Sanpham.Name = "data_Sanpham";
            this.data_Sanpham.RowHeadersWidth = 62;
            this.data_Sanpham.RowTemplate.Height = 33;
            this.data_Sanpham.Size = new System.Drawing.Size(1212, 404);
            this.data_Sanpham.TabIndex = 0;
            this.data_Sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Sanpham_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1086, 226);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1086, 300);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1086, 379);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(573, 381);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(413, 31);
            this.tbxTimKiem.TabIndex = 4;
            this.tbxTimKiem.Text = "Tìm Kiếm";
            // 
            // tbxLocThuongHieu
            // 
            this.tbxLocThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.tbxLocThuongHieu.FormattingEnabled = true;
            this.tbxLocThuongHieu.IntegralHeight = false;
            this.tbxLocThuongHieu.Items.AddRange(new object[] {
            "NEM ",
            "Chic-Land",
            "Seven AM",
            "K&K Fashion",
            "IVy Moda",
            "Eva de Eva",
            "Owen",
            "Pierre Cardin",
            "Top4man",
            "4men"});
            this.tbxLocThuongHieu.Location = new System.Drawing.Point(330, 245);
            this.tbxLocThuongHieu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLocThuongHieu.Name = "tbxLocThuongHieu";
            this.tbxLocThuongHieu.Size = new System.Drawing.Size(220, 33);
            this.tbxLocThuongHieu.TabIndex = 5;
            this.tbxLocThuongHieu.Text = "Lọc Theo Tên Thương Hiệu";
            this.tbxLocThuongHieu.TextChanged += new System.EventHandler(this.tbxLocThuongHieu_TextChanged);
            // 
            // tbxLocMau
            // 
            this.tbxLocMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.tbxLocMau.FormattingEnabled = true;
            this.tbxLocMau.IntegralHeight = false;
            this.tbxLocMau.Items.AddRange(new object[] {
            "Xanh",
            "Đỏ",
            "Đen ",
            "Trắng",
            "Tím",
            "Vàng"});
            this.tbxLocMau.Location = new System.Drawing.Point(330, 302);
            this.tbxLocMau.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLocMau.Name = "tbxLocMau";
            this.tbxLocMau.Size = new System.Drawing.Size(210, 33);
            this.tbxLocMau.TabIndex = 6;
            this.tbxLocMau.Text = "Lọc Theo Tên Màu Sắc";
            this.tbxLocMau.TextChanged += new System.EventHandler(this.tbxLocMau_TextChanged);
            // 
            // tbxLocKichThuoc
            // 
            this.tbxLocKichThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.tbxLocKichThuoc.FormattingEnabled = true;
            this.tbxLocKichThuoc.IntegralHeight = false;
            this.tbxLocKichThuoc.Items.AddRange(new object[] {
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43"});
            this.tbxLocKichThuoc.Location = new System.Drawing.Point(330, 381);
            this.tbxLocKichThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLocKichThuoc.Name = "tbxLocKichThuoc";
            this.tbxLocKichThuoc.Size = new System.Drawing.Size(210, 33);
            this.tbxLocKichThuoc.TabIndex = 7;
            this.tbxLocKichThuoc.Text = "Lọc Theo Kích Thước";
            this.tbxLocKichThuoc.TextChanged += new System.EventHandler(this.tbxLocKichThuoc_TextChanged);
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.Location = new System.Drawing.Point(766, 300);
            this.btnPhanloai.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(220, 34);
            this.btnPhanloai.TabIndex = 8;
            this.btnPhanloai.Text = "Phân Loại";
            this.btnPhanloai.UseVisualStyleBackColor = true;
            this.btnPhanloai.Click += new System.EventHandler(this.btnPhanloai_Click);
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(28, 38);
            this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(122, 25);
            this.lblTenSanPham.TabIndex = 9;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(28, 84);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(78, 25);
            this.lblTheLoai.TabIndex = 10;
            this.lblTheLoai.Text = "Thể loại ";
            // 
            // lblDacTinh
            // 
            this.lblDacTinh.AutoSize = true;
            this.lblDacTinh.Location = new System.Drawing.Point(29, 132);
            this.lblDacTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDacTinh.Name = "lblDacTinh";
            this.lblDacTinh.Size = new System.Drawing.Size(77, 25);
            this.lblDacTinh.TabIndex = 11;
            this.lblDacTinh.Text = "Đặc tính";
            // 
            // lblThuongHieu
            // 
            this.lblThuongHieu.AutoSize = true;
            this.lblThuongHieu.Location = new System.Drawing.Point(855, 42);
            this.lblThuongHieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.Size = new System.Drawing.Size(115, 25);
            this.lblThuongHieu.TabIndex = 12;
            this.lblThuongHieu.Text = "Thương Hiệu";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(855, 88);
            this.lblNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(85, 25);
            this.lblNhap.TabIndex = 13;
            this.lblNhap.Text = "Giá Nhập";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Location = new System.Drawing.Point(855, 141);
            this.lblBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(71, 25);
            this.lblBan.TabIndex = 14;
            this.lblBan.Text = "Giá Bán";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(472, 138);
            this.lblsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(68, 25);
            this.lblsize.TabIndex = 15;
            this.lblsize.Text = "Kích cỡ";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(461, 38);
            this.lblSl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(89, 25);
            this.lblSl.TabIndex = 16;
            this.lblSl.Text = "Số Lượng";
            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.Location = new System.Drawing.Point(461, 88);
            this.lblMau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(79, 25);
            this.lblMau.TabIndex = 17;
            this.lblMau.Text = "Màu Sắc";
            // 
            // tbxTenSp
            // 
            this.tbxTenSp.Location = new System.Drawing.Point(171, 38);
            this.tbxTenSp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTenSp.Name = "tbxTenSp";
            this.tbxTenSp.Size = new System.Drawing.Size(189, 31);
            this.tbxTenSp.TabIndex = 18;
            // 
            // tbxTheLoai
            // 
            this.tbxTheLoai.Location = new System.Drawing.Point(171, 81);
            this.tbxTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTheLoai.Name = "tbxTheLoai";
            this.tbxTheLoai.Size = new System.Drawing.Size(189, 31);
            this.tbxTheLoai.TabIndex = 19;
            // 
            // tbxDacTinh
            // 
            this.tbxDacTinh.Location = new System.Drawing.Point(171, 132);
            this.tbxDacTinh.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDacTinh.Name = "tbxDacTinh";
            this.tbxDacTinh.Size = new System.Drawing.Size(189, 31);
            this.tbxDacTinh.TabIndex = 20;
            // 
            // tbxThuonghieu
            // 
            this.tbxThuonghieu.Location = new System.Drawing.Point(982, 42);
            this.tbxThuonghieu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxThuonghieu.Name = "tbxThuonghieu";
            this.tbxThuonghieu.Size = new System.Drawing.Size(189, 31);
            this.tbxThuonghieu.TabIndex = 21;
            // 
            // tbxNhap
            // 
            this.tbxNhap.Location = new System.Drawing.Point(982, 88);
            this.tbxNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNhap.Name = "tbxNhap";
            this.tbxNhap.Size = new System.Drawing.Size(189, 31);
            this.tbxNhap.TabIndex = 22;
            // 
            // tbxBan
            // 
            this.tbxBan.Location = new System.Drawing.Point(982, 141);
            this.tbxBan.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBan.Name = "tbxBan";
            this.tbxBan.Size = new System.Drawing.Size(189, 31);
            this.tbxBan.TabIndex = 23;
            // 
            // tbxSl
            // 
            this.tbxSl.Location = new System.Drawing.Point(572, 38);
            this.tbxSl.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSl.Name = "tbxSl";
            this.tbxSl.Size = new System.Drawing.Size(189, 31);
            this.tbxSl.TabIndex = 24;
            // 
            // tbxMau
            // 
            this.tbxMau.Location = new System.Drawing.Point(572, 88);
            this.tbxMau.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMau.Name = "tbxMau";
            this.tbxMau.Size = new System.Drawing.Size(189, 31);
            this.tbxMau.TabIndex = 25;
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(572, 135);
            this.tbxSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(189, 31);
            this.tbxSize.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 148);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ảnh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1212, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.tbxMau);
            this.Controls.Add(this.tbxSl);
            this.Controls.Add(this.tbxBan);
            this.Controls.Add(this.tbxNhap);
            this.Controls.Add(this.tbxThuonghieu);
            this.Controls.Add(this.tbxDacTinh);
            this.Controls.Add(this.tbxTheLoai);
            this.Controls.Add(this.tbxTenSp);
            this.Controls.Add(this.lblMau);
            this.Controls.Add(this.lblSl);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblThuongHieu);
            this.Controls.Add(this.lblDacTinh);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.btnPhanloai);
            this.Controls.Add(this.tbxLocKichThuoc);
            this.Controls.Add(this.tbxLocMau);
            this.Controls.Add(this.tbxLocThuongHieu);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.data_Sanpham);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.data_Sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Sanpham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.ComboBox tbxLocThuongHieu;
        private System.Windows.Forms.ComboBox tbxLocMau;
        private System.Windows.Forms.ComboBox tbxLocKichThuoc;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblDacTinh;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblSl;
        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.TextBox tbxTenSp;
        private System.Windows.Forms.TextBox tbxTheLoai;
        private System.Windows.Forms.TextBox tbxDacTinh;
        private System.Windows.Forms.TextBox tbxThuonghieu;
        private System.Windows.Forms.TextBox tbxNhap;
        private System.Windows.Forms.TextBox tbxBan;
        private System.Windows.Forms.TextBox tbxSl;
        private System.Windows.Forms.TextBox tbxMau;
        private System.Windows.Forms.TextBox tbxSize;
        private RJControls.RJToggleButton tbDark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}