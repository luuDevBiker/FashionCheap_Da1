using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class ProductOptions_Service:IProductOptionService
    {
        private DbContext_FC db;

        public ProductOptions_Service()
        {
            db = new DbContext_FC();
        }

        public List<PRODUCTS_OPTIONS> getListProductsesOptions()
        {
            try
            {
                return  db.ProductsOptionses.ToList();
            }
            catch
            {
                return null;
            }
        }

        public string AddProductOptions(PRODUCTS_OPTIONS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.ProductsOptionses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditProductOptions(PRODUCTS_OPTIONS sp)
        {
            try
            {
                db.ProductsOptionses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteProductOptions(PRODUCTS_OPTIONS sp)
        {
            sp.status_Delete = false;
            try
            {
                db.ProductsOptionses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveProductOptions()
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