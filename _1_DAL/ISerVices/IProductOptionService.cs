using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
   public interface IProductOptionService
    {
        List<PRODUCTS_OPTIONS> getListProductsesOptions();
        string AddProductOptions(PRODUCTS_OPTIONS sp);
        string EditProductOptions(PRODUCTS_OPTIONS sp);
        string DeleteProductOptions(PRODUCTS_OPTIONS sp);
        string SaveProductOptions();
    }
}
