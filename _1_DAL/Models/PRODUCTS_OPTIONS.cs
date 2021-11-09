using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DataAccessLayers
{
   
    public class PRODUCTS_OPTIONS
    {
        public int id_Product { get; set; }
        public int id_Option { get; set; }
        public bool status_Delete { get; set; }
        
        public virtual PRODUCTS Productses { get; set; }
      
        public virtual OPTIONS Optionses { get; set; }
        public ICollection<VARIANTS_VALUES> Product_OPtion { get; set; }
        
    }
}