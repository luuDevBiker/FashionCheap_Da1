
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
            this.btn_XoaName = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.data_CacPhienBan = new System.Windows.Forms.GroupBox();
            this.data_CacPhienBan1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_giaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_giaNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.đù = new System.Windows.Forms.Label();
            this.txt_Masp = new System.Windows.Forms.TextBox();
            this.btn_AddVariant = new System.Windows.Forms.Button();
            this.btn_Editvariant = new System.Windows.Forms.Button();
            this.btn_xoaVariant = new System.Windows.Forms.Button();
            this.data_ThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.data_ThongTinSanPham1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).BeginInit();
            this.data_TenSanPham.SuspendLayout();
            this.data_CacPhienBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CacPhienBan1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.data_TenSanPham1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TenSanPham1_CellContentClick);
            // 
            // data_TenSanPham
            // 
            this.data_TenSanPham.Controls.Add(this.btn_XoaName);
            this.data_TenSanPham.Controls.Add(this.button4);
            this.data_TenSanPham.Controls.Add(this.button5);
            this.data_TenSanPham.Controls.Add(this.data_TenSanPham1);
            this.data_TenSanPham.Location = new System.Drawing.Point(17, 11);
            this.data_TenSanPham.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_TenSanPham.Name = "data_TenSanPham";
            this.data_TenSanPham.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_TenSanPham.Size = new System.Drawing.Size(341, 325);
            this.data_TenSanPham.TabIndex = 2;
            this.data_TenSanPham.TabStop = false;
            this.data_TenSanPham.Text = "Danh Sách hàng kinh doanh";
            // 
            // btn_XoaName
            // 
            this.btn_XoaName.Location = new System.Drawing.Point(233, 284);
            this.btn_XoaName.Name = "btn_XoaName";
            this.btn_XoaName.Size = new System.Drawing.Size(78, 29);
            this.btn_XoaName.TabIndex = 9;
            this.btn_XoaName.Text = "Xóa";
            this.btn_XoaName.UseVisualStyleBackColor = true;
            this.btn_XoaName.Click += new System.EventHandler(this.btn_XoaName_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 284);
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
            this.data_CacPhienBan.Location = new System.Drawing.Point(401, 8);
            this.data_CacPhienBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan.Name = "data_CacPhienBan";
            this.data_CacPhienBan.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan.Size = new System.Drawing.Size(753, 325);
            this.data_CacPhienBan.TabIndex = 3;
            this.data_CacPhienBan.TabStop = false;
            this.data_CacPhienBan.Text = "các thuộc tính";
            // 
            // data_CacPhienBan1
            // 
            this.data_CacPhienBan1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_CacPhienBan1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_CacPhienBan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CacPhienBan1.Location = new System.Drawing.Point(14, 27);
            this.data_CacPhienBan1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan1.Name = "data_CacPhienBan1";
            this.data_CacPhienBan1.RowHeadersWidth = 62;
            this.data_CacPhienBan1.RowTemplate.Height = 33;
            this.data_CacPhienBan1.Size = new System.Drawing.Size(717, 288);
            this.data_CacPhienBan1.TabIndex = 2;
         
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_CacPhienBan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_giaBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_giaNhap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.đù);
            this.groupBox2.Controls.Add(this.txt_Masp);
            this.groupBox2.Controls.Add(this.btn_AddVariant);
            this.groupBox2.Controls.Add(this.btn_Editvariant);
            this.groupBox2.Controls.Add(this.btn_xoaVariant);
            this.groupBox2.Location = new System.Drawing.Point(373, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1167, 338);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giá Bán";
            // 
            // txt_giaBan
            // 
            this.txt_giaBan.Location = new System.Drawing.Point(167, 196);
            this.txt_giaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_giaBan.Name = "txt_giaBan";
            this.txt_giaBan.Size = new System.Drawing.Size(178, 27);
            this.txt_giaBan.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giá Nhập";
            // 
            // txt_giaNhap
            // 
            this.txt_giaNhap.Location = new System.Drawing.Point(167, 144);
            this.txt_giaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_giaNhap.Name = "txt_giaNhap";
            this.txt_giaNhap.Size = new System.Drawing.Size(178, 27);
            this.txt_giaNhap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số Lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(167, 93);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(178, 27);
            this.txt_SoLuong.TabIndex = 9;
            // 
            // đù
            // 
            this.đù.AutoSize = true;
            this.đù.Location = new System.Drawing.Point(54, 40);
            this.đù.Name = "đù";
            this.đù.Size = new System.Drawing.Size(99, 20);
            this.đù.TabIndex = 8;
            this.đù.Text = "Mã Sản Phẩm";
            // 
            // txt_Masp
            // 
            this.txt_Masp.Location = new System.Drawing.Point(167, 36);
            this.txt_Masp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Masp.Name = "txt_Masp";
            this.txt_Masp.Size = new System.Drawing.Size(178, 27);
            this.txt_Masp.TabIndex = 7;
            // 
            // btn_AddVariant
            // 
            this.btn_AddVariant.Location = new System.Drawing.Point(37, 265);
            this.btn_AddVariant.Name = "btn_AddVariant";
            this.btn_AddVariant.Size = new System.Drawing.Size(96, 29);
            this.btn_AddVariant.TabIndex = 4;
            this.btn_AddVariant.Text = "Thêm ";
            this.btn_AddVariant.UseVisualStyleBackColor = true;
            this.btn_AddVariant.Click += new System.EventHandler(this.btn_AddVariant_Click);
            // 
            // btn_Editvariant
            // 
            this.btn_Editvariant.Location = new System.Drawing.Point(166, 265);
            this.btn_Editvariant.Name = "btn_Editvariant";
            this.btn_Editvariant.Size = new System.Drawing.Size(96, 29);
            this.btn_Editvariant.TabIndex = 5;
            this.btn_Editvariant.Text = "Sửa";
            this.btn_Editvariant.UseVisualStyleBackColor = true;
            this.btn_Editvariant.Click += new System.EventHandler(this.btn_Editvariant_Click);
            // 
            // btn_xoaVariant
            // 
            this.btn_xoaVariant.Location = new System.Drawing.Point(280, 265);
            this.btn_xoaVariant.Name = "btn_xoaVariant";
            this.btn_xoaVariant.Size = new System.Drawing.Size(96, 29);
            this.btn_xoaVariant.TabIndex = 6;
            this.btn_xoaVariant.Text = "Xóa";
            this.btn_xoaVariant.UseVisualStyleBackColor = true;
            this.btn_xoaVariant.Click += new System.EventHandler(this.btn_xoaVariant_Click);
            // 
            // data_ThongTinSanPham
            // 
            this.data_ThongTinSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.data_ThongTinSanPham.Controls.Add(this.data_ThongTinSanPham1);
            this.data_ThongTinSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data_ThongTinSanPham.Location = new System.Drawing.Point(17, 357);
            this.data_ThongTinSanPham.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_ThongTinSanPham.Name = "data_ThongTinSanPham";
            this.data_ThongTinSanPham.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_ThongTinSanPham.Size = new System.Drawing.Size(1531, 475);
            this.data_ThongTinSanPham.TabIndex = 4;
            this.data_ThongTinSanPham.TabStop = false;
            this.data_ThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // data_ThongTinSanPham1
            // 
            this.data_ThongTinSanPham1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ThongTinSanPham1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_ThongTinSanPham1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongTinSanPham1.Location = new System.Drawing.Point(3, 27);
            this.data_ThongTinSanPham1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_ThongTinSanPham1.Name = "data_ThongTinSanPham1";
            this.data_ThongTinSanPham1.RowHeadersWidth = 62;
            this.data_ThongTinSanPham1.RowTemplate.Height = 33;
            this.data_ThongTinSanPham1.Size = new System.Drawing.Size(1507, 440);
            this.data_ThongTinSanPham1.TabIndex = 2;
            this.data_ThongTinSanPham1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ThongTinSanPham1_CellClick_1);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1552, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.data_ThongTinSanPham);
            this.Controls.Add(this.data_TenSanPham);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).EndInit();
            this.data_TenSanPham.ResumeLayout(false);
            this.data_CacPhienBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_CacPhienBan1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_giaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label đù;
        private System.Windows.Forms.TextBox txt_Masp;
    }
}