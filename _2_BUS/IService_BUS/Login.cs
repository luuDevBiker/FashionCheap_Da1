using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayers;

namespace _2_BUS.IService_BUS
{
    public interface Login
    {
        List<EMPLOYEES> getlstEMPLOYEES();
        List<Login> getlstLogin();
        void GuiMail(string mail);

    }
}
