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
        [Column(TypeName = "money")]
        public int discount{ get; set; }
        [Column(TypeName = "money")]
        public int amount_Pay{ get; set; }
        [Column(TypeName = "money")]
        public int paying_Customer{ get; set; }
        [Column(TypeName = "money")]
        public int refunds{ get; set; }
        [Column(TypeName = "money")]
        public int total_pay{ get; set; }
        public string payments{ get; set; }
        public string status { get; set; }
        public int order_status { get; set; }
        public bool status_Delete{ get; set; }
        public virtual CUSTOMERS Customers { get; set; }
        public virtual EMPLOYEES Employees { get; set; }
        public virtual ICollection<ORDER_DETAILS> OrDerDetailses{ get; set; }
    }
}