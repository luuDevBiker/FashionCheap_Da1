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
    public class QLOrDerService:IQLOrderService
    {
        private IQLOrderService _iQlOrderService;
        private List<ORDERS> _getlstOrderses;
        public static bool _statusSave = true;

        public QLOrDerService()
        {
            _iQlOrderService = new QLOrDerService();
            _getlstOrderses = new List<ORDERS>();
            GetDb();
        }
        public string add(ORDERS orders)
        {
            _statusSave = false;
            _getlstOrderses.Add(orders);
            return _iQlOrderService.add(orders);
        }

        public string EditHd(ORDERS orders)
        {
            _statusSave = false;
            int index = _getlstOrderses.FindIndex(c => c == orders);
            _getlstOrderses[index] = orders;
            return _iQlOrderService.EditHd(orders);
        }

        public string Remove(ORDERS orders)
        {
            _statusSave = false;
            int index = _getlstOrderses.FindIndex(c => c.id_Customer == orders.id_Customer);
            _getlstOrderses[index] = orders;
            return _iQlOrderService.Remove(orders);
        }

        public string Save()
        {
            _statusSave = true;
            return _iQlOrderService.Save();
        }


        public List<ORDERS> Search(string ten)
        {
            return _getlstOrderses.Where(c => c.amount_Pay.StartsWith(ten)).ToList();
        }

        public List<ORDERS> GetlstOrderses()
        {
            return _getlstOrderses;
        }
        public void GetDb()
        {
            _getlstOrderses = _iQlOrderService.GetlstOrderses();
        }

        List<ORDERS> IQLOrderService.GetlstOrderses()
        {
            return _getlstOrderses;
        }
    }
}
