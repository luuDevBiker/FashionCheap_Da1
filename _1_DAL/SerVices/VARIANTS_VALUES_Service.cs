
using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class VARIANTS_VALUES_Service:IVariantValuesService
    {
        private DbContext_FC db;

        public VARIANTS_VALUES_Service()
        {
            db = new DbContext_FC();
        }

        public List<VARIANTS_VALUES> getListVARIANTS_VALUES()
        {
            try
            {
                return db.VariantsValueses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddVARIANTS_VALUES(VARIANTS_VALUES sp)
        {
            sp.status_Delete = true;
            try
            {
                db.VariantsValueses.Add(sp);
                return "sucessfull";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditVARIANTS_VALUES(VARIANTS_VALUES sp)
        {
            
            try
            {
                db.VariantsValueses.Update(sp);
                return "sucessfull";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteVARIANTS_VALUES(VARIANTS_VALUES sp)
        {
            sp.status_Delete = false;
            try
            {
                db.VariantsValueses.Update(sp);
                return "sucessfull";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveVARIANTS_VALUES()
        {
            
            try
            {
                db.SaveChanges();
                return "sucessfull";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}