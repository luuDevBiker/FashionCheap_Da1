using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace DAL_DataAccessLayers
{
    public class VARIANTS_VALUES
    {
        public int id_Product { get; set; }
        public int id_Variant { get; set; }
        public int id_Option { get; set; }
        public int id_Values { get; set; }
        public int id_Image { get; set; }
        [Column(TypeName = "money")]
        public int import_Price { get; set; }
        [Column(TypeName = "money")]
        public int price { get; set; }
        public int quantity { get; set; }
        public bool status_Delete { get; set; }
        public virtual PRODUCTS_VARIANTS IdProductsVariants { get; set; }
        public virtual PRODUCTS_OPTIONS IdProductsOptions { get; set; }
        public virtual OPTIONS_VALUES IdoOptionsValues { get; set; }
       public virtual IMAGES_PRODUCTS idImage { get; set; }
        public virtual  ICollection<ORDER_DETAILS> variant_Values { get; set; }
    }
}