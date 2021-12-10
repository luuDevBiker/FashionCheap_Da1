using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayers;

namespace _2_BUS.IService_BUS
{
    public interface IQLEmployeesService
    {
        public string add(EMPLOYEES employees);
        public string Update(EMPLOYEES employees);
        public string Remove(EMPLOYEES employees);
        public string Save();
        public List<EMPLOYEES> Search(string nv);
        public List<EMPLOYEES> GetlstEmployeeses();
        public void GetLst();
        string[] NamSinh();
        void EditEMPLOYEES(EMPLOYEES pass);
    }
}
