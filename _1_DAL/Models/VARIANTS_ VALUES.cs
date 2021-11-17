using System.Collections.Generic;
using System.Data.SqlTypes;

namespace DAL_DataAccessLayers
{
    public class VARIANTS_VALUES
    {
        public int id_Product { get; set; }
        public int id_Variant { get; set; }
        public int id_Option { get; set; }
        public int id_Values { get; set; }

        public bool status_Delete { get; set; }
        public virtual PRODUCTS_VARIANTS ProductsVariants { get; set; }
        public virtual PRODUCTS_OPTIONS ProductsOptions { get; set; }
        public virtual OPTIONS_VALUES OptionsValues { get; set; }
       public virtual IMAGES_PRODUCTS ImageProducts { get; set; }
        public virtual  ICollection<ORDER_DETAILS> VariantValues { get; set; }
    }
}