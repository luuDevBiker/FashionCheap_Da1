using System;
using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class EMPLOYEES
    {
        public int  id_Employee { get; set; }
        public string employee_Name { get; set; }
        public bool sex{ get; set; }
        public DateTime bridDate{ get; set; }
        public string address{ get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public bool status { get; set; }
        public bool status_Delete { get; set; }
        public virtual ICollection<ORDERS> Orders { get; set; }
    }
}