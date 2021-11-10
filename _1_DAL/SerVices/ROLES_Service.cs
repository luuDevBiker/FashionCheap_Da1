using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class ROLES_Service:IROLES_Service
    {
        private DbContext_FC db;

        public ROLES_Service()
        {
            db = new DbContext_FC();
        }

        public List<ROLES> getListORDERS()
        {
            try
            {
                return db.Roleses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddORDERS(ROLES sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Roleses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditORDERS(ROLES sp)
        {
          
            try
            {
                db.Roleses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteORDERS(ROLES sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Roleses.Update(sp);
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