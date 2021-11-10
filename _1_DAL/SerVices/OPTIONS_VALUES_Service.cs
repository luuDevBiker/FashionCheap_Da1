using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class OPTIONS_VALUES_Service:IOptionValueService
    {
        private DbContext_FC db;

        public OPTIONS_VALUES_Service()
        {
            db = new DbContext_FC();
        }

        public List<OPTIONS_VALUES> getListOptionValue()
        {
            try
            {
                
                return db.OptionsValueses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddOptionValue(OPTIONS_VALUES sp)
        {
            sp.status_Delete = true;
            try
            {
                db.OptionsValueses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditOptionValue(OPTIONS_VALUES sp)
        {
            try
            {
                db.OptionsValueses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteOptionValue(OPTIONS_VALUES sp)
        {
            sp.status_Delete = false;
            try
            {
                db.OptionsValueses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveOptionValue()
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