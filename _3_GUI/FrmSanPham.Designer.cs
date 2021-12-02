
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
            this.data_CacPhienBan = new System.Windows.Forms.GroupBox();
            this.data_CacPhienBan1 = new System.Windows.Forms.DataGridView();
            this.data_ThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.data_ThongTinSanPham1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).BeginInit();
            this.data_TenSanPham.SuspendLayout();
            this.data_CacPhienBan.SuspendLayout();
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
            this.data_TenSanPham1.Margin = new System.Windows.Forms.Padding(2);
            this.data_TenSanPham1.Name = "data_TenSanPham1";
            this.data_TenSanPham1.RowHeadersWidth = 62;
            this.data_TenSanPham1.RowTemplate.Height = 33;
            this.data_TenSanPham1.Size = new System.Drawing.Size(524, 290);
            this.data_TenSanPham1.TabIndex = 1;
            this.data_TenSanPham1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TenSanPham1_CellContentClick);
            // 
            // data_TenSanPham
            // 
            this.data_TenSanPham.Controls.Add(this.data_TenSanPham1);
            this.data_TenSanPham.Location = new System.Drawing.Point(17, 19);
            this.data_TenSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.data_TenSanPham.Name = "data_TenSanPham";
            this.data_TenSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.data_TenSanPham.Size = new System.Drawing.Size(542, 318);
            this.data_TenSanPham.TabIndex = 2;
            this.data_TenSanPham.TabStop = false;
            this.data_TenSanPham.Text = "Tên Sản Phẩm";
            // 
            // data_CacPhienBan
            // 
            this.data_CacPhienBan.Controls.Add(this.data_CacPhienBan1);
            this.data_CacPhienBan.Location = new System.Drawing.Point(590, 19);
            this.data_CacPhienBan.Margin = new System.Windows.Forms.Padding(2);
            this.data_CacPhienBan.Name = "data_CacPhienBan";
            this.data_CacPhienBan.Padding = new System.Windows.Forms.Padding(2);
            this.data_CacPhienBan.Size = new System.Drawing.Size(797, 318);
            this.data_CacPhienBan.TabIndex = 3;
            this.data_CacPhienBan.TabStop = false;
            this.data_CacPhienBan.Text = "Các Phiên Bản";
            // 
            // data_CacPhienBan1
            // 
            this.data_CacPhienBan1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_CacPhienBan1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_CacPhienBan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CacPhienBan1.Location = new System.Drawing.Point(12, 24);
            this.data_CacPhienBan1.Margin = new System.Windows.Forms.Padding(2);
            this.data_CacPhienBan1.Name = "data_CacPhienBan1";
            this.data_CacPhienBan1.RowHeadersWidth = 62;
            this.data_CacPhienBan1.RowTemplate.Height = 33;
            this.data_CacPhienBan1.Size = new System.Drawing.Size(780, 290);
            this.data_CacPhienBan1.TabIndex = 2;
            // 
            // data_ThongTinSanPham
            // 
            this.data_ThongTinSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.data_ThongTinSanPham.Controls.Add(this.data_ThongTinSanPham1);
            this.data_ThongTinSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data_ThongTinSanPham.Location = new System.Drawing.Point(17, 357);
            this.data_ThongTinSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.data_ThongTinSanPham.Name = "data_ThongTinSanPham";
            this.data_ThongTinSanPham.Padding = new System.Windows.Forms.Padding(2);
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
            this.data_ThongTinSanPham1.Location = new System.Drawing.Point(5, 24);
            this.data_ThongTinSanPham1.Margin = new System.Windows.Forms.Padding(2);
            this.data_ThongTinSanPham1.Name = "data_ThongTinSanPham1";
            this.data_ThongTinSanPham1.RowHeadersWidth = 62;
            this.data_ThongTinSanPham1.RowTemplate.Height = 33;
            this.data_ThongTinSanPham1.Size = new System.Drawing.Size(1360, 370);
            this.data_ThongTinSanPham1.TabIndex = 2;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1396, 760);
            this.Controls.Add(this.data_ThongTinSanPham);
            this.Controls.Add(this.data_CacPhienBan);
            this.Controls.Add(this.data_TenSanPham);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.data_TenSanPham1)).EndInit();
            this.data_TenSanPham.ResumeLayout(false);
            this.data_CacPhienBan.ResumeLayout(false);
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
    }
}