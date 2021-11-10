using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class ORDERS_Service:IOderService
    {
        private DbContext_FC db;

        public ORDERS_Service()
        {
            db = new DbContext_FC();
        }
        public List<ORDERS> getListORDERS()
        {
            try
            {
                return db.Orderses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddORDERS(ORDERS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Orderses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditORDERS(ORDERS sp)
        {
            
            try
            {
                db.Orderses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteORDERS(ORDERS sp)
        {
            sp.status_Delete = false;
            try
            {
                db.Orderses.Update(sp);
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