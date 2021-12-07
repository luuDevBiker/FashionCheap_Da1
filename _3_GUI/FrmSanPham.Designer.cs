
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddVariant = new System.Windows.Forms.Button();
            this.btn_Editvariant = new System.Windows.Forms.Button();
            this.btn_xoaVariant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XoaDD = new System.Windows.Forms.Button();
            this.btn_newoption = new System.Windows.Forms.Button();
            this.tbx_optionName = new System.Windows.Forms.TextBox();
            this.data_CacPhienBan1 = new System.Windows.Forms.DataGridView();
            this.data_ThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.data_ThongTinSanPham1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).BeginInit();
            this.data_TenSanPham.SuspendLayout();
            this.data_CacPhienBan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CacPhienBan1)).BeginInit();
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
            this.data_CacPhienBan.Controls.Add(this.groupBox2);
            this.data_CacPhienBan.Controls.Add(this.groupBox1);
            this.data_CacPhienBan.Controls.Add(this.data_CacPhienBan1);
            this.data_CacPhienBan.Location = new System.Drawing.Point(361, 11);
            this.data_CacPhienBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan.Name = "data_CacPhienBan";
            this.data_CacPhienBan.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan.Size = new System.Drawing.Size(1026, 325);
            this.data_CacPhienBan.TabIndex = 3;
            this.data_CacPhienBan.TabStop = false;
            this.data_CacPhienBan.Text = "Chi Tiết Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AddVariant);
            this.groupBox2.Controls.Add(this.btn_Editvariant);
            this.groupBox2.Controls.Add(this.btn_xoaVariant);
            this.groupBox2.Location = new System.Drawing.Point(896, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 163);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Sản Phẩm";
            // 
            // btn_AddVariant
            // 
            this.btn_AddVariant.Location = new System.Drawing.Point(13, 48);
            this.btn_AddVariant.Name = "btn_AddVariant";
            this.btn_AddVariant.Size = new System.Drawing.Size(96, 29);
            this.btn_AddVariant.TabIndex = 4;
            this.btn_AddVariant.Text = "Thêm ";
            this.btn_AddVariant.UseVisualStyleBackColor = true;
            this.btn_AddVariant.Click += new System.EventHandler(this.btn_AddVariant_Click);
            // 
            // btn_Editvariant
            // 
            this.btn_Editvariant.Location = new System.Drawing.Point(13, 83);
            this.btn_Editvariant.Name = "btn_Editvariant";
            this.btn_Editvariant.Size = new System.Drawing.Size(96, 29);
            this.btn_Editvariant.TabIndex = 5;
            this.btn_Editvariant.Text = "Sửa";
            this.btn_Editvariant.UseVisualStyleBackColor = true;
            this.btn_Editvariant.Click += new System.EventHandler(this.btn_Editvariant_Click);
            // 
            // btn_xoaVariant
            // 
            this.btn_xoaVariant.Location = new System.Drawing.Point(13, 117);
            this.btn_xoaVariant.Name = "btn_xoaVariant";
            this.btn_xoaVariant.Size = new System.Drawing.Size(96, 29);
            this.btn_xoaVariant.TabIndex = 6;
            this.btn_xoaVariant.Text = "Xóa";
            this.btn_xoaVariant.UseVisualStyleBackColor = true;
            this.btn_xoaVariant.Click += new System.EventHandler(this.btn_xoaVariant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XoaDD);
            this.groupBox1.Controls.Add(this.btn_newoption);
            this.groupBox1.Controls.Add(this.tbx_optionName);
            this.groupBox1.Location = new System.Drawing.Point(896, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cột Đặc Điểm";
            // 
            // btn_XoaDD
            // 
            this.btn_XoaDD.Location = new System.Drawing.Point(13, 99);
            this.btn_XoaDD.Name = "btn_XoaDD";
            this.btn_XoaDD.Size = new System.Drawing.Size(96, 31);
            this.btn_XoaDD.TabIndex = 8;
            this.btn_XoaDD.Text = "Xóa ";
            this.btn_XoaDD.UseVisualStyleBackColor = true;
            this.btn_XoaDD.Click += new System.EventHandler(this.btn_XoaDD_Click);
            // 
            // btn_newoption
            // 
            this.btn_newoption.Location = new System.Drawing.Point(13, 61);
            this.btn_newoption.Name = "btn_newoption";
            this.btn_newoption.Size = new System.Drawing.Size(96, 31);
            this.btn_newoption.TabIndex = 3;
            this.btn_newoption.Text = "thêm";
            this.btn_newoption.UseVisualStyleBackColor = true;
            this.btn_newoption.Click += new System.EventHandler(this.btn_newoption_Click);
            // 
            // tbx_optionName
            // 
            this.tbx_optionName.Location = new System.Drawing.Point(13, 28);
            this.tbx_optionName.Name = "tbx_optionName";
            this.tbx_optionName.Size = new System.Drawing.Size(95, 27);
            this.tbx_optionName.TabIndex = 7;
            // 
            // data_CacPhienBan1
            // 
            this.data_CacPhienBan1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_CacPhienBan1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_CacPhienBan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CacPhienBan1.Location = new System.Drawing.Point(11, 24);
            this.data_CacPhienBan1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.data_CacPhienBan1.Name = "data_CacPhienBan1";
            this.data_CacPhienBan1.RowHeadersWidth = 62;
            this.data_CacPhienBan1.RowTemplate.Height = 33;
            this.data_CacPhienBan1.Size = new System.Drawing.Size(879, 289);
            this.data_CacPhienBan1.TabIndex = 2;
            this.data_CacPhienBan1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CacPhienBan1_CellClick);
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
            this.data_ThongTinSanPham.Size = new System.Drawing.Size(1370, 403);
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
            this.data_ThongTinSanPham1.Size = new System.Drawing.Size(1360, 371);
            this.data_ThongTinSanPham1.TabIndex = 2;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1402, 701);
            this.Controls.Add(this.data_ThongTinSanPham);
            this.Controls.Add(this.data_CacPhienBan);
            this.Controls.Add(this.data_TenSanPham);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).EndInit();
            this.data_TenSanPham.ResumeLayout(false);
            this.data_CacPhienBan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CacPhienBan1)).EndInit();
            this.data_ThongTinSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTinSanPham1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJControls.RJToggleButton tbDark;
        private System.Windows.Forms.DataGridView data_TenSanPham1;
        private System.Windows.Forms.GroupBox data_TenSanPham;
        private System.Windows.Forms.GroupBox data_CacPhienBan;
        private System.Windows.Forms.DataGridView data_CacPhienBan1;
        private System.Windows.Forms.GroupBox data_ThongTinSanPham;
        private System.Windows.Forms.DataGridView data_ThongTinSanPham1;
        private System.Windows.Forms.Button btn_newoption;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_XoaDD;
        private System.Windows.Forms.TextBox tbx_optionName;
        private System.Windows.Forms.Button btn_xoaVariant;
        private System.Windows.Forms.Button btn_Editvariant;
        private System.Windows.Forms.Button btn_AddVariant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XoaName;
    }
}