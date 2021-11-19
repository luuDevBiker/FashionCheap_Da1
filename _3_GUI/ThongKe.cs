using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelhome.Controls.Add(childForm);
            this.panelhome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thongketheongay(), sender);
        }

        private void báoCáoThốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCaoDoanhThu(), sender);
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKeSanPham(), sender);
        }

        private void thốngKêLợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBaoCaoLoiNhuan(), sender);
        }
    }
}
