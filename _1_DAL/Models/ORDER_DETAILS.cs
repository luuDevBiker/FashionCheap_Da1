using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

using Microsoft.EntityFrameworkCore;

namespace DAL_DataAccessLayers
{
    [Keyless]
    public class ORDER_DETAILS
    {
        public int id_Order { get; set; }
        public int id_Product { get; set; }
        public int id_Variant { get; set; }
        public int id_Option { get; set; }
        public int id_Values { get; set; }

        public int quantity { get; set; }
        [Column(TypeName = "money")]
        public int unit_Price { get; set; }
        [Column(TypeName = "money")]
        public int price_Each { get; set; }
        public string Discount { get; set; }
        public bool status_Delete { get; set; }
        public virtual VARIANTS_VALUES VariantsValues { get; set; }
        public virtual ORDERS Orders{ get; set; }


    }
}