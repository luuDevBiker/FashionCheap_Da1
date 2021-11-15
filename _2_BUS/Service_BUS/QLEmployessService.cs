using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IService_BUS;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;

namespace _2_BUS.Service_BUS
{
    public class QLEmployessService:IQLEmployeesService
    {
        private IEmployeeService _iEmployeeService;
        private List<EMPLOYEES> _getlstEmployeeses;
        public static bool _StatusSave = true;
        public QLEmployessService()
        {
            _iEmployeeService = new EMPLOYEES_Service();
            _getlstEmployeeses = new List<EMPLOYEES>();
            GetLst();
        }

        public string add(EMPLOYEES employees)
        {
            _StatusSave = false;
            _getlstEmployeeses.Add(employees);
            return _iEmployeeService.AddEMPLOYEES(employees);
        }

        public string Update(EMPLOYEES employees)
        {
            _StatusSave = false;
            var index = _getlstEmployeeses.FindIndex(c => c == employees);
            _getlstEmployeeses[index] = employees;
            return _iEmployeeService.EditEMPLOYEES(employees);
        }

        public string Remove(EMPLOYEES employees)
        {
            _StatusSave = false;
            var index = _getlstEmployeeses.FindIndex(c => c == employees);
            _getlstEmployeeses[index] = employees;
            return _iEmployeeService.EditEMPLOYEES(employees);
        }

        public string Save()
        {
            _StatusSave = true;
            return _iEmployeeService.SaveOEMPLOYEES();
        }

        public List<EMPLOYEES> Search(string ten)
        {
            return _getlstEmployeeses.Where(c => c.employee_Name.StartsWith(ten)).ToList();
        }

        public List<EMPLOYEES> GetlstEmployeeses()
        {
            return _getlstEmployeeses;
        }

        public void GetLst()
        {
            _getlstEmployeeses = _iEmployeeService.getListEMPLOYEES();
        }
    }
}
