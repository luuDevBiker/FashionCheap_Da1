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
    public class TKSanPham : ITKSanPham
    {
        IOderDetailService oderDetailService;
        List<ORDER_DETAILS> _lstorderDetails;
        public TKSanPham()
        {
            oderDetailService = new ORDER_DETAILS_Service();
            _lstorderDetails = oderDetailService.getListORDERS();
        }

        public List<ORDER_DETAILS> _getListOrderDetails()
        {
            return _lstorderDetails;


        }
    }
}
