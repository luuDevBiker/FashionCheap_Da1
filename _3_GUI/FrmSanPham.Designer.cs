
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.data_Sanpham = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.lblMau = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblDacTinh = new System.Windows.Forms.Label();
            this.btnAddLoai = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnAddMau = new System.Windows.Forms.Button();
            this.btnThuongHieu = new System.Windows.Forms.Button();
            this.cbx_TheLoai = new System.Windows.Forms.ComboBox();
            this.cbx_MauSac = new System.Windows.Forms.ComboBox();
            this.cbx_ThuongHieu = new System.Windows.Forms.ComboBox();
            this.cbx_KichCo = new System.Windows.Forms.ComboBox();
            this.btnAddNewPrd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Sanpham
            // 
            this.data_Sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Sanpham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Sanpham.Location = new System.Drawing.Point(0, 353);
            this.data_Sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.data_Sanpham.Name = "data_Sanpham";
            this.data_Sanpham.RowHeadersWidth = 62;
            this.data_Sanpham.RowTemplate.Height = 33;
            this.data_Sanpham.Size = new System.Drawing.Size(992, 323);
            this.data_Sanpham.TabIndex = 0;
            this.data_Sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Sanpham_CellClick);
            this.data_Sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Sanpham_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Pink;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(433, 182);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 52);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Pink;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(433, 256);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 52);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Pink;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(832, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(814, 270);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(130, 27);
            this.tbxTimKiem.TabIndex = 4;
            this.tbxTimKiem.Text = "Tìm Kiếm";
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.BackColor = System.Drawing.Color.Pink;
            this.btnPhanloai.FlatAppearance.BorderSize = 0;
            this.btnPhanloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanloai.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhanloai.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanloai.Image")));
            this.btnPhanloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanloai.Location = new System.Drawing.Point(638, 182);
            this.btnPhanloai.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(112, 52);
            this.btnPhanloai.TabIndex = 8;
            this.btnPhanloai.Text = "     Phân Loại";
            this.btnPhanloai.UseVisualStyleBackColor = false;
            this.btnPhanloai.Click += new System.EventHandler(this.btnPhanloai_Click);
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(22, 30);
            this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(101, 20);
            this.lblTenSanPham.TabIndex = 9;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(369, 34);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(66, 20);
            this.lblTheLoai.TabIndex = 10;
            this.lblTheLoai.Text = "Thể loại ";
            this.lblTheLoai.Click += new System.EventHandler(this.lblTheLoai_Click);
            // 
            // lblThuongHieu
            // 
            this.lblThuongHieu.AutoSize = true;
            this.lblThuongHieu.Location = new System.Drawing.Point(687, 35);
            this.lblThuongHieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.Size = new System.Drawing.Size(95, 20);
            this.lblThuongHieu.TabIndex = 12;
            this.lblThuongHieu.Text = "Thương Hiệu";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(369, 116);
            this.lblNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(71, 20);
            this.lblNhap.TabIndex = 13;
            this.lblNhap.Text = "Giá Nhập";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Location = new System.Drawing.Point(684, 116);
            this.lblBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(60, 20);
            this.lblBan.TabIndex = 14;
            this.lblBan.Text = "Giá Bán";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(687, 73);
            this.lblsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(57, 20);
            this.lblsize.TabIndex = 15;
            this.lblsize.Text = "Kích cỡ";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(23, 111);
            this.lblSl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(72, 20);
            this.lblSl.TabIndex = 16;
            this.lblSl.Text = "Số Lượng";
            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.Location = new System.Drawing.Point(369, 70);
            this.lblMau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(65, 20);
            this.lblMau.TabIndex = 17;
            this.lblMau.Text = "Màu Sắc";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(137, 30);
            this.txtTenSp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(152, 27);
            this.txtTenSp.TabIndex = 18;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(458, 113);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.ReadOnly = true;
            this.txtNhap.Size = new System.Drawing.Size(152, 27);
            this.txtNhap.TabIndex = 22;
            // 
            // txtBan
            // 
            this.txtBan.Location = new System.Drawing.Point(786, 113);
            this.txtBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(152, 27);
            this.txtBan.TabIndex = 23;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(137, 106);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(152, 27);
            this.txtSL.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(61, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ảnh";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(195, 316);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 27);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(251, 316);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 27);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(139, 316);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 27);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(137, 70);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(152, 27);
            this.txtMaSP.TabIndex = 33;
            // 
            // lblDacTinh
            // 
            this.lblDacTinh.AutoSize = true;
            this.lblDacTinh.Location = new System.Drawing.Point(23, 70);
            this.lblDacTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDacTinh.Name = "lblDacTinh";
            this.lblDacTinh.Size = new System.Drawing.Size(50, 20);
            this.lblDacTinh.TabIndex = 32;
            this.lblDacTinh.Text = "Mã SP";
            // 
            // btnAddLoai
            // 
            this.btnAddLoai.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLoai.Location = new System.Drawing.Point(614, 30);
            this.btnAddLoai.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLoai.Name = "btnAddLoai";
            this.btnAddLoai.Size = new System.Drawing.Size(38, 27);
            this.btnAddLoai.TabIndex = 29;
            this.btnAddLoai.Text = "+";
            this.btnAddLoai.UseVisualStyleBackColor = true;
            // 
            // btnSize
            // 
            this.btnSize.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSize.Location = new System.Drawing.Point(942, 70);
            this.btnSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(38, 27);
            this.btnSize.TabIndex = 29;
            this.btnSize.Text = "+";
            this.btnSize.UseVisualStyleBackColor = true;
            // 
            // btnAddMau
            // 
            this.btnAddMau.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMau.Location = new System.Drawing.Point(614, 70);
            this.btnAddMau.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMau.Name = "btnAddMau";
            this.btnAddMau.Size = new System.Drawing.Size(38, 27);
            this.btnAddMau.TabIndex = 29;
            this.btnAddMau.Text = "+";
            this.btnAddMau.UseVisualStyleBackColor = true;
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThuongHieu.Location = new System.Drawing.Point(942, 34);
            this.btnThuongHieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(38, 27);
            this.btnThuongHieu.TabIndex = 29;
            this.btnThuongHieu.Text = "+";
            this.btnThuongHieu.UseVisualStyleBackColor = true;
            // 
            // cbx_TheLoai
            // 
            this.cbx_TheLoai.FormattingEnabled = true;
            this.cbx_TheLoai.Location = new System.Drawing.Point(458, 30);
            this.cbx_TheLoai.Name = "cbx_TheLoai";
            this.cbx_TheLoai.Size = new System.Drawing.Size(151, 28);
            this.cbx_TheLoai.TabIndex = 34;
            // 
            // cbx_MauSac
            // 
            this.cbx_MauSac.FormattingEnabled = true;
            this.cbx_MauSac.Location = new System.Drawing.Point(458, 67);
            this.cbx_MauSac.Name = "cbx_MauSac";
            this.cbx_MauSac.Size = new System.Drawing.Size(151, 28);
            this.cbx_MauSac.TabIndex = 34;
            // 
            // cbx_ThuongHieu
            // 
            this.cbx_ThuongHieu.FormattingEnabled = true;
            this.cbx_ThuongHieu.Location = new System.Drawing.Point(786, 32);
            this.cbx_ThuongHieu.Name = "cbx_ThuongHieu";
            this.cbx_ThuongHieu.Size = new System.Drawing.Size(151, 28);
            this.cbx_ThuongHieu.TabIndex = 34;
            // 
            // cbx_KichCo
            // 
            this.cbx_KichCo.FormattingEnabled = true;
            this.cbx_KichCo.Location = new System.Drawing.Point(786, 70);
            this.cbx_KichCo.Name = "cbx_KichCo";
            this.cbx_KichCo.Size = new System.Drawing.Size(151, 28);
            this.cbx_KichCo.TabIndex = 34;
            // 
            // btnAddNewPrd
            // 
            this.btnAddNewPrd.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewPrd.Location = new System.Drawing.Point(293, 31);
            this.btnAddNewPrd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewPrd.Name = "btnAddNewPrd";
            this.btnAddNewPrd.Size = new System.Drawing.Size(38, 27);
            this.btnAddNewPrd.TabIndex = 29;
            this.btnAddNewPrd.Text = "+";
            this.btnAddNewPrd.UseVisualStyleBackColor = true;
            this.btnAddNewPrd.Click += new System.EventHandler(this.btnAddNewPrd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Pink;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(638, 256);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(786, 270);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(992, 676);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbx_KichCo);
            this.Controls.Add(this.cbx_ThuongHieu);
            this.Controls.Add(this.cbx_MauSac);
            this.Controls.Add(this.cbx_TheLoai);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblDacTinh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddMau);
            this.Controls.Add(this.btnThuongHieu);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.btnAddNewPrd);
            this.Controls.Add(this.btnAddLoai);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.lblMau);
            this.Controls.Add(this.lblSl);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblThuongHieu);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.btnPhanloai);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.data_Sanpham);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Sanpham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblSl;
        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.TextBox txtSL;
        private RJControls.RJToggleButton tbDark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblDacTinh;
        private System.Windows.Forms.Button btnAddLoai;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnAddMau;
        private System.Windows.Forms.Button btnThuongHieu;
        private System.Windows.Forms.ComboBox cbx_TheLoai;
        private System.Windows.Forms.ComboBox cbx_MauSac;
        private System.Windows.Forms.ComboBox cbx_ThuongHieu;
        private System.Windows.Forms.ComboBox cbx_KichCo;
        private System.Windows.Forms.Button btnAddNewPrd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}