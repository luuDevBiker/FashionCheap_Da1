using System.Collections.Generic;
using _2_BUS.Models;

namespace _2_BUS.IService_BUS
{
    public interface IProduct_Service
    {
        public List<SanPhamCuThe> LoadDatafromDAL();
    }
}