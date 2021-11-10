using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class OPTIONS_Service:IOptionService
    {
        private DbContext_FC db;

        public OPTIONS_Service()
        {
            db = new DbContext_FC();
        }


        public List<OPTIONS> getListOption()
        {
            try
            {
                return db.Optionses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddOption(OPTIONS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.Optionses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditOption(OPTIONS sp)
        {
            
            try
            {
                db.Optionses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteOption(OPTIONS sp)
        {
            sp.status_Delete = false;
            try
            {
                db.Optionses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveOption()
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