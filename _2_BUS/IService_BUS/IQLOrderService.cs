using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayers;

namespace _2_BUS.IService_BUS
{
    public interface IQLOrderService
    {
        public string add(ORDERS orders);
        public string EditHd(ORDERS orders);
        public string Remove(ORDERS orders);
        public string Save();
        public List<ORDERS> Search(string nv);
        public List<ORDERS> GetlstOrderses();
        public void GetDb();
    }
}
