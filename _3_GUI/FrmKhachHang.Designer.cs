
namespace _3_GUI
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.CheckBox();
            this.cbxNu = new System.Windows.Forms.CheckBox();
            this.cbxKhac = new System.Windows.Forms.CheckBox();
            this.tbxsdt = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxGmail = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Data_KhachHang = new System.Windows.Forms.DataGridView();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.tbDark = new RJControls.RJToggleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxTenKhachHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gmail";
            // 
            // cbxNam
            // 
            this.cbxNam.AutoSize = true;
            this.cbxNam.Location = new System.Drawing.Point(138, 70);
            this.cbxNam.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(63, 24);
            this.cbxNam.TabIndex = 7;
            this.cbxNam.Text = "Nam";
            this.cbxNam.UseVisualStyleBackColor = true;
            this.cbxNam.Click += new System.EventHandler(this.cbxNam_Click);
            // 
            // cbxNu
            // 
            this.cbxNu.AutoSize = true;
            this.cbxNu.Location = new System.Drawing.Point(231, 70);
            this.cbxNu.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNu.Name = "cbxNu";
            this.cbxNu.Size = new System.Drawing.Size(51, 24);
            this.cbxNu.TabIndex = 8;
            this.cbxNu.Text = "Nữ";
            this.cbxNu.UseVisualStyleBackColor = true;
            this.cbxNu.Click += new System.EventHandler(this.cbxNu_Click);
            // 
            // cbxKhac
            // 
            this.cbxKhac.AutoSize = true;
            this.cbxKhac.Location = new System.Drawing.Point(318, 70);
            this.cbxKhac.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKhac.Name = "cbxKhac";
            this.cbxKhac.Size = new System.Drawing.Size(63, 24);
            this.cbxKhac.TabIndex = 9;
            this.cbxKhac.Text = "Khác";
            this.cbxKhac.UseVisualStyleBackColor = true;
            this.cbxKhac.Click += new System.EventHandler(this.cbxKhac_Click);
            // 
            // tbxsdt
            // 
            this.tbxsdt.Location = new System.Drawing.Point(182, 118);
            this.tbxsdt.Margin = new System.Windows.Forms.Padding(2);
            this.tbxsdt.Name = "tbxsdt";
            this.tbxsdt.Size = new System.Drawing.Size(121, 27);
            this.tbxsdt.TabIndex = 10;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(182, 169);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(121, 27);
            this.tbxDiaChi.TabIndex = 11;
            // 
            // tbxGmail
            // 
            this.tbxGmail.Location = new System.Drawing.Point(182, 218);
            this.tbxGmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGmail.Name = "tbxGmail";
            this.tbxGmail.Size = new System.Drawing.Size(121, 27);
            this.tbxGmail.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Pink;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(450, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 49);
            this.btnThem.TabIndex = 13;
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
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(450, 118);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 49);
            this.btnSua.TabIndex = 14;
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
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(450, 199);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Data_KhachHang
            // 
            this.Data_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_KhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_KhachHang.Location = new System.Drawing.Point(10, 261);
            this.Data_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.Data_KhachHang.Name = "Data_KhachHang";
            this.Data_KhachHang.RowHeadersWidth = 62;
            this.Data_KhachHang.RowTemplate.Height = 33;
            this.Data_KhachHang.Size = new System.Drawing.Size(855, 232);
            this.Data_KhachHang.TabIndex = 16;
            this.Data_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_KhachHang_CellContentClick);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(626, 37);
            this.tbxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(176, 27);
            this.tbxTimKiem.TabIndex = 17;
            this.tbxTimKiem.Text = "Tìm Kiếm";
            this.tbxTimKiem.TextChanged += new System.EventHandler(this.tbxTimKiem_TextChanged);
            // 
            // tbDark
            // 
            this.tbDark.AutoSize = true;
            this.tbDark.Location = new System.Drawing.Point(24, 10);
            this.tbDark.Margin = new System.Windows.Forms.Padding(2);
            this.tbDark.MinimumSize = new System.Drawing.Size(36, 18);
            this.tbDark.Name = "tbDark";
            this.tbDark.OffBackColor = System.Drawing.Color.Gray;
            this.tbDark.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbDark.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbDark.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbDark.Size = new System.Drawing.Size(36, 18);
            this.tbDark.TabIndex = 18;
            this.tbDark.UseVisualStyleBackColor = true;
            this.tbDark.CheckedChanged += new System.EventHandler(this.tbDark_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cbxTenKhachHang
            // 
            this.cbxTenKhachHang.FormattingEnabled = true;
            this.cbxTenKhachHang.Location = new System.Drawing.Point(182, 18);
            this.cbxTenKhachHang.Name = "cbxTenKhachHang";
            this.cbxTenKhachHang.Size = new System.Drawing.Size(151, 28);
            this.cbxTenKhachHang.TabIndex = 28;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.cbxTenKhachHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbDark);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.Data_KhachHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxGmail);
            this.Controls.Add(this.tbxDiaChi);
            this.Controls.Add(this.tbxsdt);
            this.Controls.Add(this.cbxKhac);
            this.Controls.Add(this.cbxNu);
            this.Controls.Add(this.cbxNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.Data_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxNam;
        private System.Windows.Forms.CheckBox cbxNu;
        private System.Windows.Forms.CheckBox cbxKhac;
        private System.Windows.Forms.TextBox tbxsdt;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxGmail;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView Data_KhachHang;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private RJControls.RJToggleButton tbDark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxTenKhachHang;
    }
}