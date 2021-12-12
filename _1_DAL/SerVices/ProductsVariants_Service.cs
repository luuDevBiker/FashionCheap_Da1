using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class ProductsVariants_Service:IProductVariantservice
    {
        private DbContext_FC db;

        public ProductsVariants_Service()
        {
            db = new DbContext_FC();
        }

        public List<PRODUCTS_VARIANTS> getListProductses()
        {
            try
            {
                var lst = db.ProductsVariantses.ToList();
                return lst;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddProductVarriant(PRODUCTS_VARIANTS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.ProductsVariantses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditProductVarriant(PRODUCTS_VARIANTS sp)
        {
            try
            {
                db.ProductsVariantses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteProductVarriant(PRODUCTS_VARIANTS sp)
        {
            sp.status_Delete = false;
            try
            {
                db.ProductsVariantses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveProductVarriant()
        {
            try
            {
                db.SaveChanges();
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}