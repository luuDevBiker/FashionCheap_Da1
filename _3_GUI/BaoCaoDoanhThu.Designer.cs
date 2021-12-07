
namespace _3_GUI
{
    partial class FrmBaoCaoDoanhYhu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbTKNgay = new System.Windows.Forms.RadioButton();
            this.rdbThang = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.mcTime = new System.Windows.Forms.MonthCalendar();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.lblSoDon = new System.Windows.Forms.Label();
            this.rdbNow = new System.Windows.Forms.RadioButton();
            this.lblSoSP = new System.Windows.Forms.Label();
            this.lblSoDonHuy = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.pnDonHuy = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Thống Kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1360, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn kiểu thống kê theo:";
            // 
            // rdbTKNgay
            // 
            this.rdbTKNgay.AutoSize = true;
            this.rdbTKNgay.Location = new System.Drawing.Point(1341, 324);
            this.rdbTKNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTKNgay.Name = "rdbTKNgay";
            this.rdbTKNgay.Size = new System.Drawing.Size(161, 24);
            this.rdbTKNgay.TabIndex = 3;
            this.rdbTKNgay.TabStop = true;
            this.rdbTKNgay.Text = "Thống kê theo ngày";
            this.rdbTKNgay.UseVisualStyleBackColor = true;
            this.rdbTKNgay.CheckedChanged += new System.EventHandler(this.rdbTKNgay_CheckedChanged);
            // 
            // rdbThang
            // 
            this.rdbThang.AutoSize = true;
            this.rdbThang.Location = new System.Drawing.Point(1341, 374);
            this.rdbThang.Margin = new System.Windows.Forms.Padding(2);
            this.rdbThang.Name = "rdbThang";
            this.rdbThang.Size = new System.Drawing.Size(167, 24);
            this.rdbThang.TabIndex = 4;
            this.rdbThang.TabStop = true;
            this.rdbThang.Text = "Thống kê theo tháng";
            this.rdbThang.UseVisualStyleBackColor = true;
            this.rdbThang.CheckedChanged += new System.EventHandler(this.rdbThang_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(1341, 428);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(158, 24);
            this.rdbNam.TabIndex = 5;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Thống kê theo năm";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(1452, 746);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(147, 37);
            this.btnDoanhThu.TabIndex = 12;
            this.btnDoanhThu.Text = "Xem Doanh Thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // mcTime
            // 
            this.mcTime.Location = new System.Drawing.Point(1341, 496);
            this.mcTime.Name = "mcTime";
            this.mcTime.TabIndex = 15;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDoanhThu.Location = new System.Drawing.Point(12, 389);
            this.dgvDoanhThu.MultiSelect = false;
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 29;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1294, 436);
            this.dgvDoanhThu.TabIndex = 13;
            this.dgvDoanhThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellClick);
            // 
            // lblSoDon
            // 
            this.lblSoDon.AutoSize = true;
            this.lblSoDon.Location = new System.Drawing.Point(47, 138);
            this.lblSoDon.Name = "lblSoDon";
            this.lblSoDon.Size = new System.Drawing.Size(12, 20);
            this.lblSoDon.TabIndex = 16;
            this.lblSoDon.Text = ".";
            // 
            // rdbNow
            // 
            this.rdbNow.AutoSize = true;
            this.rdbNow.Location = new System.Drawing.Point(1341, 277);
            this.rdbNow.Name = "rdbNow";
            this.rdbNow.Size = new System.Drawing.Size(152, 24);
            this.rdbNow.TabIndex = 17;
            this.rdbNow.TabStop = true;
            this.rdbNow.Text = "Thống kê hôm nay";
            this.rdbNow.UseVisualStyleBackColor = true;
            this.rdbNow.CheckedChanged += new System.EventHandler(this.rdbNow_CheckedChanged);
            // 
            // lblSoSP
            // 
            this.lblSoSP.AutoSize = true;
            this.lblSoSP.Location = new System.Drawing.Point(47, 196);
            this.lblSoSP.Name = "lblSoSP";
            this.lblSoSP.Size = new System.Drawing.Size(12, 20);
            this.lblSoSP.TabIndex = 18;
            this.lblSoSP.Text = ".";
            // 
            // lblSoDonHuy
            // 
            this.lblSoDonHuy.AutoSize = true;
            this.lblSoDonHuy.Location = new System.Drawing.Point(47, 254);
            this.lblSoDonHuy.Name = "lblSoDonHuy";
            this.lblSoDonHuy.Size = new System.Drawing.Size(12, 20);
            this.lblSoDonHuy.TabIndex = 18;
            this.lblSoDonHuy.Text = ".";
            this.lblSoDonHuy.Click += new System.EventHandler(this.lblSoDonHuy_Click);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(47, 324);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(12, 20);
            this.lblDoanhThu.TabIndex = 18;
            this.lblDoanhThu.Text = ".";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(47, 82);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(12, 20);
            this.lblNgay.TabIndex = 16;
            this.lblNgay.Text = ".";
            // 
            // pnDonHuy
            // 
            this.pnDonHuy.Location = new System.Drawing.Point(394, 51);
            this.pnDonHuy.Name = "pnDonHuy";
            this.pnDonHuy.Size = new System.Drawing.Size(912, 323);
            this.pnDonHuy.TabIndex = 19;
            // 
            // FrmBaoCaoDoanhYhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1621, 837);
            this.Controls.Add(this.pnDonHuy);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblSoDonHuy);
            this.Controls.Add(this.lblSoSP);
            this.Controls.Add(this.rdbNow);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblSoDon);
            this.Controls.Add(this.mcTime);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.rdbThang);
            this.Controls.Add(this.rdbTKNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBaoCaoDoanhYhu";
            this.Text = "BaoCaoDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTKNgay;
        private System.Windows.Forms.RadioButton rdbThang;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.MonthCalendar mcTime;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label lblSoDon;
        private System.Windows.Forms.RadioButton rdbNow;
        private System.Windows.Forms.Label lblSoSP;
        private System.Windows.Forms.Label lblSoDonHuy;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Panel pnDonHuy;
    }
}