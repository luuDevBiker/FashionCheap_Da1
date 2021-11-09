using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class PRODUCTS
    {
        public int id_Product { get; set; }
        public string products_Name { get; set; }
        public bool status_Delete { get; set; }
        //collect Navigation
        public virtual ICollection<PRODUCTS_OPTIONS> ProductsOptions { get; set; }
        public virtual ICollection<PRODUCTS_VARIANTS> ProductsVariantses { get; set; }

    }
}