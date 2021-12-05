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
    public partial class FrmMain : Form
    {
        
        public FrmMain()
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
            OpenChildForm(new FrmKhachHang(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien(), sender);
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FrmH(), sender);
        //}
        

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormDangKi frmDangKi = new FormDangKi();
            frmDangKi.ShowDialog();
        }
    

        private void button9_Click(object sender, EventArgs e)
        {
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.ShowDialog();
        }




        int x = 20, y = 10, a = 1;

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDon(), sender);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lblTitle.Location = new Point(x, y);
                if (x >= 536)
                {
                    a = -1;
                    
                }
                if (x <= 10)
                {
                    a = 1;
                    
                }
            }
            catch (Exception ex)
            { }
        }
       
    }
}
