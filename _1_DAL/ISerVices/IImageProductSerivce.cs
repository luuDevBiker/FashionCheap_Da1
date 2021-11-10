using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
    interface IImageProductSerivce
    {
        List<IMAGES_PRODUCTS> getListImageS();
        string AddImage(IMAGES_PRODUCTS sp);
        string EditImage(IMAGES_PRODUCTS sp);
        string DeleteImage(IMAGES_PRODUCTS sp);
        string SaveImage();
    }
}
