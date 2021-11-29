using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class GuiMailHangLoat : Form
    {
        Attachment attach = null;
        public GuiMailHangLoat()
        {
            InitializeComponent();
        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_File.Text = dialog.FileName;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(txt_File.Text);
                    attach = new Attachment(txt_File.Text);

                }
                catch
                {

                }
                StreamReader sr = new StreamReader(txt_To.Text);

                string email;
                while ((email = sr.ReadLine()) != null)
                {
                    GuiMail(txt_TenDangNhap.Text, email, txt_Subject.Text, txt_Message.Text, attach);
                }
                sr.Close();
            }
            );
            thread.Start();
        }
        //gửi mail theo các thông tin truyền vào 
        void GuiMail(string from, string to, string subject,string message, Attachment file =null )
        {

            //MailMessage mess = new MailMessage(from, to, subject, message);
            //if( attach!= null )
            //{
            //    mess.Attachments.Add(attach);
            //}    
            //SmtpClient client = new SmtpClient("stmp.gmail.com", 587);
            //client.EnableSsl = true;
            //client.Credentials = new NetworkCredential(txt_TenDangNhap.Text,txt_MatKhau.Text);
            //client.Send(mess);
            MailMessage mailMessage = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mailMessage.Attachments.Add(attach);
            }
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(txt_TenDangNhap.Text, txt_MatKhau.Text);
            smtpClient.Send(mailMessage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_To.Text = dialog.FileName;
            }
        }
    }
}
