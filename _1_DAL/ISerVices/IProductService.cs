using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
    public interface IProductService
    {
        List<PRODUCTS> getListProductses();
        string AddProduct(PRODUCTS sp);
        string EditProduct(PRODUCTS sp);
        string DeleteProduct(PRODUCTS sp);
        string SaveProduct();
    }
}
