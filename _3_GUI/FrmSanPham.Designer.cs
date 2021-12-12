
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
            this.data_TenSanPham1 = new System.Windows.Forms.DataGridView();
            this.data_TenSanPham = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNameSp = new System.Windows.Forms.TextBox();
            this.btn_XoaName = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.data_CacPhienBan = new System.Windows.Forms.GroupBox();
            this.data_CacPhienBan1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbPhienbanMoi = new System.Windows.Forms.GroupBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lblTenSpLoad = new System.Windows.Forms.Label();
            this.btn_xoaVariant = new System.Windows.Forms.Button();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.btn_Editvariant = new System.Windows.Forms.Button();
            this.btn_AddVariant = new System.Windows.Forms.Button();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.txt_Masp = new System.Windows.Forms.TextBox();
            this.txt_giaBan = new System.Windows.Forms.TextBox();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txt_giaNhap = new System.Windows.Forms.TextBox();
            this.data_ThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.data_ThongTinSanPham1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).BeginInit();
            this.data_TenSanPham.SuspendLayout();
            this.data_CacPhienBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CacPhienBan1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbPhienbanMoi.SuspendLayout();
            this.data_ThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinSanPham1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TenSanPham1
            // 
            this.data_TenSanPham1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TenSanPham1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_TenSanPham1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TenSanPham1.Location = new System.Drawing.Point(5, 24);
            this.data_TenSanPham1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_TenSanPham1.Name = "data_TenSanPham1";
            this.data_TenSanPham1.RowHeadersWidth = 62;
            this.data_TenSanPham1.RowTemplate.Height = 33;
            this.data_TenSanPham1.Size = new System.Drawing.Size(323, 241);
            this.data_TenSanPham1.TabIndex = 1;
            this.data_TenSanPham1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TenSanPham1_CellClick);
            // 
            // data_TenSanPham
            // 
            this.data_TenSanPham.Controls.Add(this.btnClear);
            this.data_TenSanPham.Controls.Add(this.txtNameSp);
            this.data_TenSanPham.Controls.Add(this.btn_XoaName);
            this.data_TenSanPham.Controls.Add(this.button4);
            this.data_TenSanPham.Controls.Add(this.button5);
            this.data_TenSanPham.Controls.Add(this.data_TenSanPham1);
            this.data_TenSanPham.Location = new System.Drawing.Point(17, 11);
            this.data_TenSanPham.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_TenSanPham.Name = "data_TenSanPham";
            this.data_TenSanPham.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_TenSanPham.Size = new System.Drawing.Size(341, 391);
            this.data_TenSanPham.TabIndex = 2;
            this.data_TenSanPham.TabStop = false;
            this.data_TenSanPham.Text = "Danh Sách hàng kinh doanh";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(258, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 29);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNameSp
            // 
            this.txtNameSp.Location = new System.Drawing.Point(28, 285);
            this.txtNameSp.Name = "txtNameSp";
            this.txtNameSp.PlaceholderText = "Tên sản phẩm";
            this.txtNameSp.Size = new System.Drawing.Size(284, 27);
            this.txtNameSp.TabIndex = 10;
            this.txtNameSp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNameSp_MouseClick);
            // 
            // btn_XoaName
            // 
            this.btn_XoaName.Location = new System.Drawing.Point(174, 339);
            this.btn_XoaName.Name = "btn_XoaName";
            this.btn_XoaName.Size = new System.Drawing.Size(78, 29);
            this.btn_XoaName.TabIndex = 9;
            this.btn_XoaName.Text = "Xóa";
            this.btn_XoaName.UseVisualStyleBackColor = true;
            this.btn_XoaName.Click += new System.EventHandler(this.btn_XoaName_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "Thêm ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // data_CacPhienBan
            // 
            this.data_CacPhienBan.Controls.Add(this.data_CacPhienBan1);
            this.data_CacPhienBan.Location = new System.Drawing.Point(5, 22);
            this.data_CacPhienBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan.Name = "data_CacPhienBan";
            this.data_CacPhienBan.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan.Size = new System.Drawing.Size(539, 357);
            this.data_CacPhienBan.TabIndex = 3;
            this.data_CacPhienBan.TabStop = false;
            this.data_CacPhienBan.Text = "các thuộc tính";
            // 
            // data_CacPhienBan1
            // 
            this.data_CacPhienBan1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_CacPhienBan1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_CacPhienBan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CacPhienBan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_CacPhienBan1.Location = new System.Drawing.Point(2, 23);
            this.data_CacPhienBan1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan1.Name = "data_CacPhienBan1";
            this.data_CacPhienBan1.RowHeadersWidth = 62;
            this.data_CacPhienBan1.RowTemplate.Height = 33;
            this.data_CacPhienBan1.Size = new System.Drawing.Size(535, 331);
            this.data_CacPhienBan1.TabIndex = 2;
            this.data_CacPhienBan1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CacPhienBan1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grbPhienbanMoi);
            this.groupBox2.Controls.Add(this.data_CacPhienBan);
            this.groupBox2.Location = new System.Drawing.Point(373, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1167, 389);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Sản Phẩm";
            // 
            // grbPhienbanMoi
            // 
            this.grbPhienbanMoi.Controls.Add(this.txt_SoLuong);
            this.grbPhienbanMoi.Controls.Add(this.lblTenSpLoad);
            this.grbPhienbanMoi.Controls.Add(this.btn_xoaVariant);
            this.grbPhienbanMoi.Controls.Add(this.lblTenSp);
            this.grbPhienbanMoi.Controls.Add(this.btn_Editvariant);
            this.grbPhienbanMoi.Controls.Add(this.btn_AddVariant);
            this.grbPhienbanMoi.Controls.Add(this.lblGiaban);
            this.grbPhienbanMoi.Controls.Add(this.txt_Masp);
            this.grbPhienbanMoi.Controls.Add(this.txt_giaBan);
            this.grbPhienbanMoi.Controls.Add(this.lblMaSp);
            this.grbPhienbanMoi.Controls.Add(this.lblGiaNhap);
            this.grbPhienbanMoi.Controls.Add(this.lblSoLuong);
            this.grbPhienbanMoi.Controls.Add(this.txt_giaNhap);
            this.grbPhienbanMoi.Location = new System.Drawing.Point(549, 22);
            this.grbPhienbanMoi.Name = "grbPhienbanMoi";
            this.grbPhienbanMoi.Size = new System.Drawing.Size(371, 355);
            this.grbPhienbanMoi.TabIndex = 16;
            this.grbPhienbanMoi.TabStop = false;
            this.grbPhienbanMoi.Text = "Biến thể sản phẩm";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(146, 143);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(178, 27);
            this.txt_SoLuong.TabIndex = 9;
            // 
            // lblTenSpLoad
            // 
            this.lblTenSpLoad.AutoSize = true;
            this.lblTenSpLoad.Location = new System.Drawing.Point(146, 46);
            this.lblTenSpLoad.Name = "lblTenSpLoad";
            this.lblTenSpLoad.Size = new System.Drawing.Size(0, 20);
            this.lblTenSpLoad.TabIndex = 15;
            // 
            // btn_xoaVariant
            // 
            this.btn_xoaVariant.Location = new System.Drawing.Point(259, 315);
            this.btn_xoaVariant.Name = "btn_xoaVariant";
            this.btn_xoaVariant.Size = new System.Drawing.Size(96, 29);
            this.btn_xoaVariant.TabIndex = 6;
            this.btn_xoaVariant.Text = "Xóa";
            this.btn_xoaVariant.UseVisualStyleBackColor = true;
            this.btn_xoaVariant.Click += new System.EventHandler(this.btn_xoaVariant_Click);
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(35, 46);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(100, 20);
            this.lblTenSp.TabIndex = 15;
            this.lblTenSp.Text = "Tên sản phẩm";
            // 
            // btn_Editvariant
            // 
            this.btn_Editvariant.Location = new System.Drawing.Point(145, 315);
            this.btn_Editvariant.Name = "btn_Editvariant";
            this.btn_Editvariant.Size = new System.Drawing.Size(96, 29);
            this.btn_Editvariant.TabIndex = 5;
            this.btn_Editvariant.Text = "Sửa";
            this.btn_Editvariant.UseVisualStyleBackColor = true;
            this.btn_Editvariant.Click += new System.EventHandler(this.btn_Editvariant_Click);
            // 
            // btn_AddVariant
            // 
            this.btn_AddVariant.Location = new System.Drawing.Point(16, 315);
            this.btn_AddVariant.Name = "btn_AddVariant";
            this.btn_AddVariant.Size = new System.Drawing.Size(96, 29);
            this.btn_AddVariant.TabIndex = 4;
            this.btn_AddVariant.Text = "Thêm ";
            this.btn_AddVariant.UseVisualStyleBackColor = true;
            this.btn_AddVariant.Click += new System.EventHandler(this.btn_AddVariant_Click);
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Location = new System.Drawing.Point(33, 250);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(60, 20);
            this.lblGiaban.TabIndex = 14;
            this.lblGiaban.Text = "Giá Bán";
            // 
            // txt_Masp
            // 
            this.txt_Masp.Location = new System.Drawing.Point(146, 86);
            this.txt_Masp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Masp.Name = "txt_Masp";
            this.txt_Masp.Size = new System.Drawing.Size(178, 27);
            this.txt_Masp.TabIndex = 7;
            // 
            // txt_giaBan
            // 
            this.txt_giaBan.Location = new System.Drawing.Point(146, 246);
            this.txt_giaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_giaBan.Name = "txt_giaBan";
            this.txt_giaBan.Size = new System.Drawing.Size(178, 27);
            this.txt_giaBan.TabIndex = 13;
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Location = new System.Drawing.Point(33, 90);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(99, 20);
            this.lblMaSp.TabIndex = 8;
            this.lblMaSp.Text = "Mã Sản Phẩm";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Location = new System.Drawing.Point(33, 198);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(71, 20);
            this.lblGiaNhap.TabIndex = 12;
            this.lblGiaNhap.Text = "Giá Nhập";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(33, 147);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(72, 20);
            this.lblSoLuong.TabIndex = 10;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txt_giaNhap
            // 
            this.txt_giaNhap.Location = new System.Drawing.Point(146, 194);
            this.txt_giaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_giaNhap.Name = "txt_giaNhap";
            this.txt_giaNhap.Size = new System.Drawing.Size(178, 27);
            this.txt_giaNhap.TabIndex = 11;
            // 
            // data_ThongTinSanPham
            // 
            this.data_ThongTinSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.data_ThongTinSanPham.Controls.Add(this.data_ThongTinSanPham1);
            this.data_ThongTinSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data_ThongTinSanPham.Location = new System.Drawing.Point(11, 408);
            this.data_ThongTinSanPham.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_ThongTinSanPham.Name = "data_ThongTinSanPham";
            this.data_ThongTinSanPham.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_ThongTinSanPham.Size = new System.Drawing.Size(1291, 389);
            this.data_ThongTinSanPham.TabIndex = 4;
            this.data_ThongTinSanPham.TabStop = false;
            this.data_ThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // data_ThongTinSanPham1
            // 
            this.data_ThongTinSanPham1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ThongTinSanPham1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_ThongTinSanPham1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongTinSanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_ThongTinSanPham1.Location = new System.Drawing.Point(2, 23);
            this.data_ThongTinSanPham1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_ThongTinSanPham1.Name = "data_ThongTinSanPham1";
            this.data_ThongTinSanPham1.RowHeadersWidth = 62;
            this.data_ThongTinSanPham1.RowTemplate.Height = 33;
            this.data_ThongTinSanPham1.Size = new System.Drawing.Size(1287, 363);
            this.data_ThongTinSanPham1.TabIndex = 2;
            this.data_ThongTinSanPham1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ThongTinSanPham1_CellClick_1);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1305, 797);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.data_ThongTinSanPham);
            this.Controls.Add(this.data_TenSanPham);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).EndInit();
            this.data_TenSanPham.ResumeLayout(false);
            this.data_TenSanPham.PerformLayout();
            this.data_CacPhienBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_CacPhienBan1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grbPhienbanMoi.ResumeLayout(false);
            this.grbPhienbanMoi.PerformLayout();
            this.data_ThongTinSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinSanPham1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.DataGridView data_TenSanPham1;
        private System.Windows.Forms.GroupBox data_TenSanPham;
        private System.Windows.Forms.GroupBox data_CacPhienBan;
        private System.Windows.Forms.DataGridView data_CacPhienBan1;
        private System.Windows.Forms.GroupBox data_ThongTinSanPham;
        private System.Windows.Forms.DataGridView data_ThongTinSanPham1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_xoaVariant;
        private System.Windows.Forms.Button btn_Editvariant;
        private System.Windows.Forms.Button btn_AddVariant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XoaName;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.TextBox txt_giaBan;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txt_giaNhap;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lblMaSp;
        private System.Windows.Forms.TextBox txt_Masp;
        private System.Windows.Forms.TextBox txtNameSp;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblTenSpLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grbPhienbanMoi;
    }
}