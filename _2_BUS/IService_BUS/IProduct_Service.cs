using System.Collections.Generic;
using _2_BUS.Models;
using DAL_DataAccessLayers;
namespace _2_BUS.IService_BUS
{
    public interface IProduct_Service
    {
        public List<ProductDetail> LoadDatafromDAL();
        public List<OPTIONS> getCountOption();
    }
}