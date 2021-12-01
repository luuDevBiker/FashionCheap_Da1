using _2_BUS.Models;
using _2_BUS.Service_BUS;
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
    public partial class FormDangNhap : Form
    {
        LoginService loginIService;
        List<Login> logins;
        public static string email;
        public FormDangNhap()
        {
            InitializeComponent();
            loginIService = new LoginService();
            logins = loginIService.getLstDangNhap();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau frmQuenMK = new FormQuenMatKhau(txt_tendangnhap.Text);
            frmQuenMK.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logins.Any(c => c.Email == txt_tendangnhap.Text && c.PassWord == txt_Matkhau.Text ))
            {

                this.Hide();
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                email = txt_tendangnhap.Text;
                FrmMain frm = new FrmMain();
                frm.Show();

            }
            else if (logins.Any(c => c.Email == txt_tendangnhap.Text && c.PassWord == txt_Matkhau.Text))
            {
                this.Hide();
                FormQuenMatKhau doiMK = new FormQuenMatKhau(txt_tendangnhap.Text);
                doiMK.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác, vui lòng kiểm tra lại", "Thông báo");
            }
        }
    }
}
