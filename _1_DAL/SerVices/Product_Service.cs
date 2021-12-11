using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class Product_Service: IProductService
    {
        private DbContext_FC db;
        public Product_Service()
        {
            
            db = new DbContext_FC();
        }

        public List<PRODUCTS> getListProductses()
        {
            try
            {
                return  db.Productses.ToList();
            }
            catch
            {
                return null;
            }
        }

        public string AddProduct(PRODUCTS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Productses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditProduct(PRODUCTS sp)
        {
            try
            {
                db.Productses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteProduct(PRODUCTS sp)
        {
            sp.status_Delete = false;
            try
            {

                db.Productses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveProduct()
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