using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class EMPLOYEES_Service:IEmployeeService
    {
        private DbContext_FC db;

        public EMPLOYEES_Service()
        {
            db = new DbContext_FC();
        }

        public List<EMPLOYEES> getListEMPLOYEES()
        {
            try
            {
                return db.Employeeses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddEMPLOYEES(EMPLOYEES sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Employeeses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditEMPLOYEES(EMPLOYEES sp)
        {
          
            try
            {
                db.Employeeses.Update(sp);
                db.SaveChanges();
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteEMPLOYEES(EMPLOYEES sp)
        {
            sp.status_Delete = false;
            try
            {
                db.Employeeses.Update(sp);
                db.SaveChanges();
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveOEMPLOYEES()
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