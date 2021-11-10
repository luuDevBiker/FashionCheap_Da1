using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class ORDER_DETAILS_Service:IOderDetailService
    {
        private DbContext_FC db;

        public ORDER_DETAILS_Service()
        {
            db = new DbContext_FC();
        }

        public List<ORDER_DETAILS> getListORDERS()
        {
            try
            {
                return db.OrderDetailses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddORDER_DETAILS(ORDER_DETAILS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.OrderDetailses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditORDER_DETAILS(ORDER_DETAILS sp)
        {
            
            try
            {
                db.OrderDetailses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteORDER_DETAILS(ORDER_DETAILS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.OrderDetailses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveORDER_DETAILS()
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