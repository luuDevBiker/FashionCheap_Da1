
namespace _3_GUI
{
    partial class FrmThongTinDonHang
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
            this.dgvDonHuy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHuy
            // 
            this.dgvDonHuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHuy.Location = new System.Drawing.Point(0, 0);
            this.dgvDonHuy.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDonHuy.Name = "dgvDonHuy";
            this.dgvDonHuy.RowHeadersWidth = 62;
            this.dgvDonHuy.RowTemplate.Height = 33;
            this.dgvDonHuy.Size = new System.Drawing.Size(814, 395);
            this.dgvDonHuy.TabIndex = 0;
            // 
            // FrmDonHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(814, 395);
            this.Controls.Add(this.dgvDonHuy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDonHuy";
            this.Text = "FrmBaoCaoLoiNhuan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHuy;
    }
}