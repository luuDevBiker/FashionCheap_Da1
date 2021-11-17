using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class IMAGES_PRODUCTS
    {
        public int id_Image { get; set; }
        public int id_variant { get; set; }
        public string imge_Path { get; set; }
        public bool status_Delete { get; set; }
        public PRODUCTS_VARIANTS ProductVariants { get; set; }
    }
}