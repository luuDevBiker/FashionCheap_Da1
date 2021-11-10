using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayers.DBContex_FC;
using DAL_DataAccessLayers.IServices;

namespace DAL_DataAccessLayers.Service
{
    public class Images_Service:IImageProductSerivce
    {
        private DbContext_FC db;

        public Images_Service()
        {
            db = new DbContext_FC();
        }

        public List<IMAGES_PRODUCTS> getListImageS()
        {
            try
            {
               return db.ImagesProductses.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string AddImage(IMAGES_PRODUCTS sp)
        {
            sp.status_Delete = true;
            try
            {
                db.ImagesProductses.Add(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string EditImage(IMAGES_PRODUCTS sp)
        {
            
            try
            {
                db.ImagesProductses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteImage(IMAGES_PRODUCTS sp)
        {
            sp.status_Delete = false;
            try
            {
                db.ImagesProductses.Update(sp);
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string SaveImage()
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