﻿
namespace _3_GUI
{
    partial class ThongKe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêLợiNhuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelhome = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.báoCáoThốngKêDoanhThuToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.thốngKêLợiNhuậnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(267, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê bán hàng theo ngày";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // báoCáoThốngKêDoanhThuToolStripMenuItem
            // 
            this.báoCáoThốngKêDoanhThuToolStripMenuItem.Name = "báoCáoThốngKêDoanhThuToolStripMenuItem";
            this.báoCáoThốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(254, 29);
            this.báoCáoThốngKêDoanhThuToolStripMenuItem.Text = "Báo cáo thống kê doanh thu";
            this.báoCáoThốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê sản phẩm";
            this.thốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // thốngKêLợiNhuậnToolStripMenuItem
            // 
            this.thốngKêLợiNhuậnToolStripMenuItem.Name = "thốngKêLợiNhuậnToolStripMenuItem";
            this.thốngKêLợiNhuậnToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.thốngKêLợiNhuậnToolStripMenuItem.Text = "Thống kê lợi nhuận";
            this.thốngKêLợiNhuậnToolStripMenuItem.Click += new System.EventHandler(this.thốngKêLợiNhuậnToolStripMenuItem_Click);
            // 
            // panelhome
            // 
            this.panelhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelhome.Location = new System.Drawing.Point(0, 33);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(1255, 698);
            this.panelhome.TabIndex = 1;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1255, 731);
            this.Controls.Add(this.panelhome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêLợiNhuậnToolStripMenuItem;
        private System.Windows.Forms.Panel panelhome;
    }
}