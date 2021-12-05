using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.Models;
using DAL_DataAccessLayers;

namespace _2_BUS.IService_BUS
{
    public interface IQLOrderService
    {
        public string add(ORDERS orders);
        public string EditHd(ORDERS orders);
        public string Remove(ORDERS orders);
        public string Save();
        public List<PRODUCTS_VARIANTS> getListProduct();
        public List<PRODUCTS> getProduct();
        public List<ORDERS> Search(string nv);
        public List<ORDERS> GetlstOrderses();
        public void GetDb();
        public List<Order_OrderDetail> JoinTable();
    }
}
