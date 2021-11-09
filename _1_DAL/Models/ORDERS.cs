using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace DAL_DataAccessLayers
{
    public class ORDERS
    {
        public int id_Order { get; set; }
        public int id_Customer { get; set; }
        public int id_Employee { get; set; }
        public DateTime order_Time{ get; set; }
        public string discount{ get; set; }
        public string amount_Pay{ get; set; }
        [Column(TypeName = "money")]
        public int paying_Customer{ get; set; }
        [Column(TypeName = "money")]
        public int refunds{ get; set; }
        public string payments{ get; set; }
        public bool status_Delete{ get; set; }
        public virtual CUSTOMERS Customers { get; set; }
        public virtual EMPLOYEES Employees { get; set; }
       // public ICollection<ORDER_DETAILS> ODerCollection { get; set; }
    }
}