using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IService_BUS;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;

namespace _2_BUS.Service_BUS
{
    public class Loginnn : Login
    {
        List<Login> _LstLogins;
        List<EMPLOYEES> _lstEmployees;
        IEmployeeService _EmployeeService;
       


        public Loginnn()
        {
            _LstLogins = new List<Login>();
            _lstEmployees = new List<EMPLOYEES>();
            // _EmployeeService = new EmployeeService();
            getlstEMPLOYEES();
            getlstLogin();
       
        }

        public List<EMPLOYEES> getlstEMPLOYEES()
        {
            foreach (var x in _lstEmployees)
            {
            //    Login login = new Login();
                
            }
           return ;
        }

        public List<Login> getlstLogin()
        {
            throw new NotImplementedException();
        }

        public void GuiMail(string mail)
        {
            throw new NotImplementedException();
        }
    }
}
