using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chang
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _2HoTro(), sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _5dangki(), sender);
        }
    

        private void button9_Click(object sender, EventArgs e)
        {
             OpenChildForm(new _7dangnhap(), sender);
        }
        
    }
}
