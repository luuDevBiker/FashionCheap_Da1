using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class OPTIONS
    {
        public int id_Option { get; set; }
        public string option_Name { get; set; }
        public bool status_Delete { get; set; }
       public virtual  ICollection<PRODUCTS_OPTIONS> OptionsesProducts { get; set; }
       public virtual  ICollection<OPTIONS_VALUES> OptionsValueses{ get; set; }

       
    }
}