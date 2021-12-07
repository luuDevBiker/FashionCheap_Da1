using DAL_DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService_BUS
{
    public interface ITKSanPham
    {
        public List<ORDER_DETAILS> _getListOrderDetails();
        
    }
}
