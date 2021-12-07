
namespace _3_GUI
{
    partial class FrmBanDuoc
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
            this.dgvSanPhamBanDuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanDuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPhamBanDuoc
            // 
            this.dgvSanPhamBanDuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPhamBanDuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamBanDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPhamBanDuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPhamBanDuoc.Name = "dgvSanPhamBanDuoc";
            this.dgvSanPhamBanDuoc.RowHeadersWidth = 51;
            this.dgvSanPhamBanDuoc.RowTemplate.Height = 29;
            this.dgvSanPhamBanDuoc.Size = new System.Drawing.Size(762, 360);
            this.dgvSanPhamBanDuoc.TabIndex = 0;
            // 
            // FrmBanDuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(762, 360);
            this.Controls.Add(this.dgvSanPhamBanDuoc);
            this.Name = "FrmBanDuoc";
            this.Text = "Sản Phẩm Bán Được";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanDuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPhamBanDuoc;
    }
}