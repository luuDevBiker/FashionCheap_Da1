using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IService_BUS;
using _2_BUS.Models;
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
        private NhanVien nhanVien;
        private IROLES_EMPLOYEE_Service _rolesEmployeeService;
        private List<ROLES_EMPLOYEE> _listRolesEmployees;
        private ROLES_EMPLOYEE _rolesEmployee;
        public QLEmployessService()
        {
            _iEmployeeService = new EMPLOYEES_Service();
            _getlstEmployeeses = new List<EMPLOYEES>();
           
            nhanVien = new NhanVien();
            _rolesEmployeeService = new ROLES_EMPLOYEE_Service();
            _listRolesEmployees = new List<ROLES_EMPLOYEE>();
            _rolesEmployee = new ROLES_EMPLOYEE();
            _getlstEmployeeses = _iEmployeeService.getListEMPLOYEES();
            _listRolesEmployees = _rolesEmployeeService.getListORDERS();
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
            return _iEmployeeService.DeleteEMPLOYEES(employees);
        }

        public string Save()
        {
            
            return _iEmployeeService.SaveOEMPLOYEES();
        }

        public List<EMPLOYEES> Search(string ten)
        {
            return _getlstEmployeeses.Where(c => c.employee_Name.StartsWith(ten)).ToList();
        }

        public List<EMPLOYEES> GetlstEmployeeses()
        {
            foreach (var x in _getlstEmployeeses)
            {
                string nv = x.employee_Name;
                string nv1 = x.address;
            }
            return _getlstEmployeeses;

        }

        public void GetLst()
        {
            _getlstEmployeeses = _iEmployeeService.getListEMPLOYEES();
        }

        public string[] NamSinh()
        {
            string[] arrYears = new string[2021 - 1900];
                int temp = 1900;
                for (int i = 0; i < arrYears.Length; i++)
                {
                    arrYears[i] = temp.ToString();
                    temp++;
                }

                return arrYears;
            
        }

        public void EditEMPLOYEES(EMPLOYEES pass)
        {
            //throw new NotImplementedException();
        }

        private List<NhanVien> getlistviewNhanViens()
        {
            var lst = (from _iEmployeeService in _getlstEmployeeses
                join _rolesEmployeeService in _listRolesEmployees on _iEmployeeService.id_Employee equals
                    _rolesEmployeeService.id_Employee
                select new NhanVien(_rolesEmployeeService, _iEmployeeService, _iEmployeeService.employee_Name,
                    _iEmployeeService.Email, _rolesEmployeeService.id_Roles)).ToList();
            return lst;
        }

        public List<NhanVien> getNhanViens()
        {
            try
            {
                return getlistviewNhanViens();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
