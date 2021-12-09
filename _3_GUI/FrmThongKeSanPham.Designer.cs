
namespace _3_GUI
{
    partial class FrmThongKeSanPham
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
            this.rdbTatCaSanPham = new System.Windows.Forms.RadioButton();
            this.rdbSanPhamBanChay = new System.Windows.Forms.RadioButton();
            this.rdbSanPhamE = new System.Windows.Forms.RadioButton();
            this.DGV_TKSanPham = new System.Windows.Forms.DataGridView();
            this.rdbSanPhamNhieuNhat = new System.Windows.Forms.RadioButton();
            this.rdbSanPhamItNhat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TKSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbTatCaSanPham
            // 
            this.rdbTatCaSanPham.AutoSize = true;
            this.rdbTatCaSanPham.Location = new System.Drawing.Point(1013, 191);
            this.rdbTatCaSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTatCaSanPham.Name = "rdbTatCaSanPham";
            this.rdbTatCaSanPham.Size = new System.Drawing.Size(138, 24);
            this.rdbTatCaSanPham.TabIndex = 0;
            this.rdbTatCaSanPham.TabStop = true;
            this.rdbTatCaSanPham.Text = "Tất cả sản phẩm";
            this.rdbTatCaSanPham.UseVisualStyleBackColor = true;
            this.rdbTatCaSanPham.CheckedChanged += new System.EventHandler(this.rdbTatCaSanPham_CheckedChanged);
            // 
            // rdbSanPhamBanChay
            // 
            this.rdbSanPhamBanChay.AutoSize = true;
            this.rdbSanPhamBanChay.Location = new System.Drawing.Point(1013, 269);
            this.rdbSanPhamBanChay.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSanPhamBanChay.Name = "rdbSanPhamBanChay";
            this.rdbSanPhamBanChay.Size = new System.Drawing.Size(158, 24);
            this.rdbSanPhamBanChay.TabIndex = 1;
            this.rdbSanPhamBanChay.TabStop = true;
            this.rdbSanPhamBanChay.Text = "Sản Phẩm bán chạy";
            this.rdbSanPhamBanChay.UseVisualStyleBackColor = true;
            // 
            // rdbSanPhamE
            // 
            this.rdbSanPhamE.AutoSize = true;
            this.rdbSanPhamE.Location = new System.Drawing.Point(1013, 229);
            this.rdbSanPhamE.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSanPhamE.Name = "rdbSanPhamE";
            this.rdbSanPhamE.Size = new System.Drawing.Size(207, 24);
            this.rdbSanPhamE.TabIndex = 2;
            this.rdbSanPhamE.TabStop = true;
            this.rdbSanPhamE.Text = "Sản Phẩm không bán được";
            this.rdbSanPhamE.UseVisualStyleBackColor = true;
            // 
            // DGV_TKSanPham
            // 
            this.DGV_TKSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TKSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TKSanPham.Location = new System.Drawing.Point(11, 11);
            this.DGV_TKSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_TKSanPham.Name = "DGV_TKSanPham";
            this.DGV_TKSanPham.RowHeadersWidth = 62;
            this.DGV_TKSanPham.RowTemplate.Height = 33;
            this.DGV_TKSanPham.Size = new System.Drawing.Size(959, 575);
            this.DGV_TKSanPham.TabIndex = 3;
            // 
            // rdbSanPhamNhieuNhat
            // 
            this.rdbSanPhamNhieuNhat.AutoSize = true;
            this.rdbSanPhamNhieuNhat.Location = new System.Drawing.Point(1013, 312);
            this.rdbSanPhamNhieuNhat.Name = "rdbSanPhamNhieuNhat";
            this.rdbSanPhamNhieuNhat.Size = new System.Drawing.Size(228, 24);
            this.rdbSanPhamNhieuNhat.TabIndex = 4;
            this.rdbSanPhamNhieuNhat.TabStop = true;
            this.rdbSanPhamNhieuNhat.Text = "Sản phẩm có số lượng > 1000";
            this.rdbSanPhamNhieuNhat.UseVisualStyleBackColor = true;
            // 
            // rdbSanPhamItNhat
            // 
            this.rdbSanPhamItNhat.AutoSize = true;
            this.rdbSanPhamItNhat.Location = new System.Drawing.Point(1013, 354);
            this.rdbSanPhamItNhat.Name = "rdbSanPhamItNhat";
            this.rdbSanPhamItNhat.Size = new System.Drawing.Size(228, 24);
            this.rdbSanPhamItNhat.TabIndex = 4;
            this.rdbSanPhamItNhat.TabStop = true;
            this.rdbSanPhamItNhat.Text = "Sản phẩm có số lượng < 1000";
            this.rdbSanPhamItNhat.UseVisualStyleBackColor = true;
            // 
            // FrmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1272, 597);
            this.Controls.Add(this.rdbSanPhamItNhat);
            this.Controls.Add(this.rdbSanPhamNhieuNhat);
            this.Controls.Add(this.DGV_TKSanPham);
            this.Controls.Add(this.rdbSanPhamE);
            this.Controls.Add(this.rdbSanPhamBanChay);
            this.Controls.Add(this.rdbTatCaSanPham);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmThongKeSanPham";
            this.Text = "FrmThongKeSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TKSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTatCaSanPham;
        private System.Windows.Forms.RadioButton rdbSanPhamBanChay;
        private System.Windows.Forms.RadioButton rdbSanPhamE;
        private System.Windows.Forms.DataGridView DGV_TKSanPham;
        private System.Windows.Forms.RadioButton rdbSanPhamNhieuNhat;
        private System.Windows.Forms.RadioButton rdbSanPhamItNhat;
    }
}