using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
   public interface IProductVariantservice
    {
        List<PRODUCTS_VARIANTS> getListProductses();
        string AddProductVarriant(PRODUCTS_VARIANTS sp);
        string EditProductVarriant(PRODUCTS_VARIANTS sp);
        string DeleteProductVarriant(PRODUCTS_VARIANTS sp);
        string SaveProductVarriant();
    }
}
