using _2_BUS.IService_BUS;
using _2_BUS.Models;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service_BUS
{
     public class LoginService : LoginIServiec
    {
        List<Login> lstLogin;
        List<EMPLOYEES> lstEMPLOYEES;
        private IEmployeeService _employeeService;
      
        public LoginService()
        {
            lstEMPLOYEES = new List<EMPLOYEES>();
            lstLogin = new List<Login>();
            _employeeService = new EMPLOYEES_Service();
            getLstEMPLOYEES();
            getLstDangNhap();
            
        }

        //public List<Login> getListEMPLOYEES()
        //{
        //    foreach (var x in lstEMPLOYEES)
        //    {
        //        Login login = new Login();
        //        login.PassWord = x.PassWord;
        //        login.Email = x.Email;
        //        login.id_Employee = x.id_Employee;
        //        lstLogin.Add(login);
        //    }
        //    return lstLogin;
        //}

        public List<Login> getLstDangNhap()
        {
            foreach (var x in lstEMPLOYEES)
            {
                Login login = new Login();
                login.PassWord = x.PassWord;
                login.Email = x.Email;
                login.id_Employee = x.id_Employee;
                lstLogin.Add(login);
            }
            return lstLogin;
        }

        public List<EMPLOYEES> getLstEMPLOYEES()
        {
            return lstEMPLOYEES = _employeeService.getListEMPLOYEES();
        }

        public void guiMail(string Mail)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);//tạo services (587 mã số sẻvices)
            NetworkCredential cred = new NetworkCredential("trangptph15762@fpt.edu.vn", "phithitrang2706");// tạo tk gửi mail
            MailMessage mailMessage = new MailMessage();// gọi tài khoản gửi
            mailMessage.From = new MailAddress("trangptph15762@fpt.edu.vn");// form gửi mail
            mailMessage.To.Add(Mail);
            mailMessage.Subject = "Bạn đã sử dụng chức năng quên mật khẩu";//tiều đề mail
            mailMessage.Body = "Mật khẩu mới của bạn là 345";// nội dung mail
            smtpClient.Credentials = cred;
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);// gọi gửi mail
            EMPLOYEES temp = new EMPLOYEES(); // khởi tạo đối tượng 
            temp = lstEMPLOYEES.Where(c => c.Email == Mail).FirstOrDefault();// gọi đối tượng tài khoản muốn thay đổi
            temp.PassWord = ("345");// mã hóa mật khẩu gửi mail
            _employeeService.EditEMPLOYEES(temp);// update lại
        }
    }
}
