using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.IService_BUS;
using _2_BUS.Service_BUS;

namespace _3_GUI
{
    public partial class FormQuenMatKhau : Form
    {
        IQLEmployeesService employeeService;
        string email;
        List<EMPLOYEES> lstEMPLOYEES;
        private string hemail = "trangptph15762@fpt.edu.vn";
        private string haha = "Gửi mail Từ Phần Mềm quản lí bán hàng";
        private string hihi;
        private string a;

        public FormQuenMatKhau(string tk)
        {
            InitializeComponent();
            employeeService = new QLEmployessService();
            email = tk;
            lstEMPLOYEES = new List<EMPLOYEES>();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            var m = employeeService.GetlstEmployeeses().Where(c => c.Email == email).Select(c => c.PassWord)
                .FirstOrDefault();
            if (txt_mxn.Text==m)
            {
                if (txt_nlmk.Text==txt_mkm.Text)
                {
                    var nv = employeeService.GetlstEmployeeses().Where(c => c.Email == txt_email.Text).FirstOrDefault();
                    nv.PassWord = txt_nlmk.Text;
                    employeeService.GetlstEmployeeses();
                    employeeService.Save();
                    MessageBox.Show("Đổi Mật Khẩu Thành công");
                    FormDangNhap mm = new FormDangNhap();
                    this.Hide();
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("mật khẩu phải trùng nhau ");
                }
            }
            else
            {
                MessageBox.Show("mã xác nhận không chính xác ");
            }
           
        }

        public string ramdomMK()
        {
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");
            return s;
        }


        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
            txt_nlmk.Visible = false;
            txt_mkm.Visible = false;
            txt_mxn.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btn_DoiMatKhau.Visible = false;
        }

        public void guiMail(string Mail)
        {
            MailMessage mess = new MailMessage(hemail, email, haha, hihi);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("trangptph15762@fpt.edu.vn", "phithitrang2706");
            client.Send(mess);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var eMPLOYEES = employeeService.GetlstEmployeeses().Where(c => c.Email ==txt_email.Text).Select(c => c.Email)
                .FirstOrDefault();
            if (eMPLOYEES == txt_email.Text)
            {
                email = txt_email.Text;
                a = ramdomMK();
                hihi = "mã xác nhận của bạn là: " + a;
                guiMail(txt_email.Text);
                MessageBox.Show("gửi mail Thành Công ", "thông báo");
                var nv = employeeService.GetlstEmployeeses().Where(c => c.Email == txt_email.Text).FirstOrDefault();
                nv.PassWord = a;
                employeeService.GetlstEmployeeses();
                employeeService.Save();
                txt_nlmk.Visible = true;
                txt_mkm.Visible = true;
                txt_mxn.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btn_DoiMatKhau.Visible = true;
                txt_email.Visible = false;
                button3.Visible = false;
                label6.Visible = false;
            }
        }
    }
}
