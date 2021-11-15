using _2_BUS.Models;
using DAL_DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService_BUS
{
    interface LoginIServiec
    {
        List<EMPLOYEES> getLstEMPLOYEES();
        List<Login> getLstDangNhap();
        void guiMail(string Mail);
    }
}
