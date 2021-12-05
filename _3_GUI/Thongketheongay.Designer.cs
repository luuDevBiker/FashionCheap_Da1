
namespace _3_GUI
{
    partial class FrmThongketheongay
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
            this.dgvTkNgay = new System.Windows.Forms.DataGridView();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbDaGiao = new System.Windows.Forms.RadioButton();
            this.rdbDaHuy = new System.Windows.Forms.RadioButton();
            this.dgvSpHD = new System.Windows.Forms.DataGridView();
            this.mcloc = new System.Windows.Forms.MonthCalendar();
            this.btnLocHoadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTkNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTkNgay
            // 
            this.dgvTkNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTkNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTkNgay.Location = new System.Drawing.Point(19, 24);
            this.dgvTkNgay.Name = "dgvTkNgay";
            this.dgvTkNgay.RowHeadersWidth = 51;
            this.dgvTkNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTkNgay.Size = new System.Drawing.Size(1225, 418);
            this.dgvTkNgay.TabIndex = 0;
            this.dgvTkNgay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTkNgay_CellContentClick);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(1312, 78);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(163, 24);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Tất cả các đơn hàng";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbDaGiao
            // 
            this.rdbDaGiao.AutoSize = true;
            this.rdbDaGiao.Location = new System.Drawing.Point(1312, 170);
            this.rdbDaGiao.Name = "rdbDaGiao";
            this.rdbDaGiao.Size = new System.Drawing.Size(178, 24);
            this.rdbDaGiao.TabIndex = 1;
            this.rdbDaGiao.TabStop = true;
            this.rdbDaGiao.Text = "tất cả các đơn đã giao";
            this.rdbDaGiao.UseVisualStyleBackColor = true;
            this.rdbDaGiao.CheckedChanged += new System.EventHandler(this.rdbDaGiao_CheckedChanged);
            // 
            // rdbDaHuy
            // 
            this.rdbDaHuy.AutoSize = true;
            this.rdbDaHuy.Location = new System.Drawing.Point(1312, 261);
            this.rdbDaHuy.Name = "rdbDaHuy";
            this.rdbDaHuy.Size = new System.Drawing.Size(171, 24);
            this.rdbDaHuy.TabIndex = 1;
            this.rdbDaHuy.TabStop = true;
            this.rdbDaHuy.Text = "tất cả các đơn đã hủy";
            this.rdbDaHuy.UseVisualStyleBackColor = true;
            this.rdbDaHuy.CheckedChanged += new System.EventHandler(this.rdbDaHuy_CheckedChanged);
            // 
            // dgvSpHD
            // 
            this.dgvSpHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpHD.Location = new System.Drawing.Point(19, 448);
            this.dgvSpHD.Name = "dgvSpHD";
            this.dgvSpHD.RowHeadersWidth = 51;
            this.dgvSpHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpHD.Size = new System.Drawing.Size(1225, 418);
            this.dgvSpHD.TabIndex = 0;
            // 
            // mcloc
            // 
            this.mcloc.Location = new System.Drawing.Point(1257, 448);
            this.mcloc.Name = "mcloc";
            this.mcloc.TabIndex = 2;
            // 
            // btnLocHoadon
            // 
            this.btnLocHoadon.Location = new System.Drawing.Point(1338, 718);
            this.btnLocHoadon.Name = "btnLocHoadon";
            this.btnLocHoadon.Size = new System.Drawing.Size(181, 39);
            this.btnLocHoadon.TabIndex = 3;
            this.btnLocHoadon.Text = "Lọc Hóa Đơn";
            this.btnLocHoadon.UseVisualStyleBackColor = true;
            this.btnLocHoadon.Click += new System.EventHandler(this.btnLocHoadon_Click);
            // 
            // FrmThongketheongay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1537, 891);
            this.Controls.Add(this.btnLocHoadon);
            this.Controls.Add(this.mcloc);
            this.Controls.Add(this.rdbDaHuy);
            this.Controls.Add(this.rdbDaGiao);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.dgvSpHD);
            this.Controls.Add(this.dgvTkNgay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmThongketheongay";
            this.Text = "Thongketheongay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTkNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTkNgay;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbDaGiao;
        private System.Windows.Forms.RadioButton rdbDaHuy;
        private System.Windows.Forms.DataGridView dgvSpHD;
        private System.Windows.Forms.MonthCalendar mcloc;
        private System.Windows.Forms.Button btnLocHoadon;
    }
}