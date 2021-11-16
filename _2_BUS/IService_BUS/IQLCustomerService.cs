using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayers;

namespace _2_BUS.IService_BUS
{
    public interface IQLCustomerService
    {
        public string add(CUSTOMERS customers);
        public string EditKH(CUSTOMERS customers);
        public string Remove(CUSTOMERS customers);
        public string Save();
        public List<CUSTOMERS> Search(string nv);
        public List<CUSTOMERS> GetlstCustomerses();
        public void GetDb();
    }
}
