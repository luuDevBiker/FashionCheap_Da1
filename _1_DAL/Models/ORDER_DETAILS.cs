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
        // số lượng
        public int quantity { get; set; }
        [Column(TypeName = "money")]
        // giá tổng tiền của sản phẩm
        public int unit_Price { get; set; }
        // giá bán 
        [Column(TypeName = "money")]
        public int price_Each { get; set; }
        // giảm giá
        [Column(TypeName = "money")]
        public int Discount { get; set; }
        public bool status_Delete { get; set; }
        public virtual PRODUCTS_VARIANTS ProductVariants { get; set; }
        public virtual ORDERS Orders{ get; set; }

        public virtual PRODUCTS Products { get; set; }
    }
}