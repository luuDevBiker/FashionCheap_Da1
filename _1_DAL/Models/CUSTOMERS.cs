using System;
using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class CUSTOMERS
    {
        public int id_Customer { get; set; }
        public string customer_Name { get; set; }
        public bool sex { get; set; }
        public int account_Number { get; set; }
        public string customer_Type { get; set; }
        public string address { get; set; }
        public string numberPhone { get; set; }
        public string email { get; set; }
        public bool status { get; set; }
        public bool status_Delete { get; set; }
        public virtual ICollection<ORDERS> Orders { get; set; }
    }
}