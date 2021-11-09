using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class PRODUCTS_VARIANTS
    {
        public int id_Product { get; set; } 
        public int id_Variant { get; set; } 
        public string sku_id { get; set; } 
        public bool status_Delete { get; set; }
        public PRODUCTS Products_variant { get; set; }
        public ICollection<VARIANTS_VALUES> ProductVariantses{ get; set; }
      
    }
}