
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
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDayNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TKSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbTatCaSanPham
            // 
            this.rdbTatCaSanPham.AutoSize = true;
            this.rdbTatCaSanPham.Location = new System.Drawing.Point(1003, 17);
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
            this.rdbSanPhamBanChay.Location = new System.Drawing.Point(1003, 95);
            this.rdbSanPhamBanChay.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSanPhamBanChay.Name = "rdbSanPhamBanChay";
            this.rdbSanPhamBanChay.Size = new System.Drawing.Size(252, 24);
            this.rdbSanPhamBanChay.TabIndex = 1;
            this.rdbSanPhamBanChay.TabStop = true;
            this.rdbSanPhamBanChay.Text = "Sản Phẩm bán chạy trong 6 tháng";
            this.rdbSanPhamBanChay.UseVisualStyleBackColor = true;
            this.rdbSanPhamBanChay.CheckedChanged += new System.EventHandler(this.rdbSanPhamBanChay_CheckedChanged);
            // 
            // rdbSanPhamE
            // 
            this.rdbSanPhamE.AutoSize = true;
            this.rdbSanPhamE.Location = new System.Drawing.Point(1003, 55);
            this.rdbSanPhamE.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSanPhamE.Name = "rdbSanPhamE";
            this.rdbSanPhamE.Size = new System.Drawing.Size(301, 24);
            this.rdbSanPhamE.TabIndex = 2;
            this.rdbSanPhamE.TabStop = true;
            this.rdbSanPhamE.Text = "Sản Phẩm không bán được trong 6 tháng";
            this.rdbSanPhamE.UseVisualStyleBackColor = true;
            this.rdbSanPhamE.CheckedChanged += new System.EventHandler(this.rdbSanPhamE_CheckedChanged);
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
            this.rdbSanPhamNhieuNhat.Location = new System.Drawing.Point(1003, 138);
            this.rdbSanPhamNhieuNhat.Name = "rdbSanPhamNhieuNhat";
            this.rdbSanPhamNhieuNhat.Size = new System.Drawing.Size(228, 24);
            this.rdbSanPhamNhieuNhat.TabIndex = 4;
            this.rdbSanPhamNhieuNhat.TabStop = true;
            this.rdbSanPhamNhieuNhat.Text = "Sản phẩm có số lượng > 1000";
            this.rdbSanPhamNhieuNhat.UseVisualStyleBackColor = true;
            this.rdbSanPhamNhieuNhat.CheckedChanged += new System.EventHandler(this.rdbSanPhamNhieuNhat_CheckedChanged);
            // 
            // rdbSanPhamItNhat
            // 
            this.rdbSanPhamItNhat.AutoSize = true;
            this.rdbSanPhamItNhat.Location = new System.Drawing.Point(1003, 180);
            this.rdbSanPhamItNhat.Name = "rdbSanPhamItNhat";
            this.rdbSanPhamItNhat.Size = new System.Drawing.Size(228, 24);
            this.rdbSanPhamItNhat.TabIndex = 4;
            this.rdbSanPhamItNhat.TabStop = true;
            this.rdbSanPhamItNhat.Text = "Sản phẩm có số lượng < 1000";
            this.rdbSanPhamItNhat.UseVisualStyleBackColor = true;
            this.rdbSanPhamItNhat.CheckedChanged += new System.EventHandler(this.rdbSanPhamItNhat_CheckedChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(1005, 303);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(250, 27);
            this.dtpTime.TabIndex = 5;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(1177, 543);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(159, 42);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc danh sách";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1005, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "lọc danh sách từ ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1005, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "đến ngày :";
            // 
            // lblDayNow
            // 
            this.lblDayNow.AutoSize = true;
            this.lblDayNow.Location = new System.Drawing.Point(1005, 409);
            this.lblDayNow.Name = "lblDayNow";
            this.lblDayNow.Size = new System.Drawing.Size(0, 20);
            this.lblDayNow.TabIndex = 7;
            // 
            // FrmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1348, 597);
            this.Controls.Add(this.lblDayNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dtpTime);
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
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDayNow;
    }
}