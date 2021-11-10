using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class CUSTOMERS_Service:ICustomerService
    {
        private DbContext_FC db;

        public CUSTOMERS_Service()
        {
            db = new DbContext_FC();
        }

        public List<CUSTOMERS> getListORDERS()
        {
            try
            {
                return db.Customerss.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddORDERS(CUSTOMERS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Customerss.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditORDERS(CUSTOMERS sp)
        {
           
            try
            {
                db.Customerss.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteORDERS(CUSTOMERS sp)
        {
            sp.status_Delete = false;
            try
            {
                db.Customerss.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveORDERS()
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