using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class ROLES_EMPLOYEE_Service:IROLES_EMPLOYEE_Service
    {
        private DbContext_FC db;

        public ROLES_EMPLOYEE_Service()
        {
            db = new DbContext_FC();
        }

        public List<ROLES_EMPLOYEE> getListORDERS()
        {
            try
            {
                return db.RolesEmployees.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddORDERS(ROLES_EMPLOYEE sp)
        {
            sp.status_Delete = true;
            try
            {
                db.RolesEmployees.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditORDERS(ROLES_EMPLOYEE sp)
        {
            
            try
            {
                db.RolesEmployees.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteORDERS(ROLES_EMPLOYEE sp)
        {
            sp.status_Delete = false;
            try
            {
                db.RolesEmployees.Update(sp);
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