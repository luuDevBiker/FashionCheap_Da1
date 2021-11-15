using _2_BUS.IService_BUS;
using _2_BUS.Models;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service_BUS
{
     public class LoginService : LoginIServiec
    {
        List<Login> lstLogin;
        List<EMPLOYEES> lstEMPLOYEES;
        IEmployeeService employeeService;
        ChucNang cn;
        public LoginService()
        {
            lstEMPLOYEES = new List<EMPLOYEES>();
            lstLogin = new List<Login>();
            employeeService = new EmployeeService();
            getLstEMPLOYEES();
            getLstDangNhap();
            cn = new ChucNang();
        }
      

        public List<EMPLOYEES> getLstEMPLOYEES()
        {
            throw new NotImplementedException();
        }

        public void guiMail(string Mail)
        {
            throw new NotImplementedException();
        }
    }
}
