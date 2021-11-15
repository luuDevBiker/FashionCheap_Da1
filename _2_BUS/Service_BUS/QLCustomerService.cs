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
    public class QLCustomerService:IQLCustomerService
    {
        private ICustomerService _iqlQlCustomerService;
        private List<CUSTOMERS> _getlstCustomerses;
        public static bool _statusSave = true;

        public QLCustomerService()
        {
            _iqlQlCustomerService = new CUSTOMERS_Service();
            _getlstCustomerses = new List<CUSTOMERS>();
            GetDb();
        }
        public string add(CUSTOMERS customers)
        {
            _statusSave = false;
            _getlstCustomerses.Add(customers);
            return _iqlQlCustomerService.AddORDERS(customers);
        }

        public string EditKH(CUSTOMERS customers)
        {
            _statusSave = false;
            int index = _getlstCustomerses.FindIndex(c => c == customers);
            _getlstCustomerses[index] = customers;
            return _iqlQlCustomerService.EditORDERS(customers);
        }

        public string Remove(CUSTOMERS customers)
        {
            _statusSave = false;
            int index = _getlstCustomerses.FindIndex(c => c.id_Customer == customers.id_Customer);
            _getlstCustomerses[index] = customers;
            return _iqlQlCustomerService.DeleteORDERS(customers);
        }

        public string Save()
        {
            _statusSave = true;
            return _iqlQlCustomerService.SaveORDERS();
        }


        public List<CUSTOMERS> Search(string ten)
        {
            return _getlstCustomerses.Where(c => c.customer_Name.StartsWith(ten)).ToList();
        }

        public List<CUSTOMERS> GetlstCustomerses()
        {
            return _getlstCustomerses;
        }

        public void GetDb()
        {
            _getlstCustomerses = _iqlQlCustomerService.getListORDERS();
        }
    }
}
