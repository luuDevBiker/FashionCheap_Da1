using System.Collections.Generic;

namespace DAL_DataAccessLayers
{
    public class ROLES_EMPLOYEE
    {
        public int id_Employee { get; set; }
        public int id_Roles { get; set; }
        public bool status_Delete { get; set; }
        public virtual EMPLOYEES Employees { get; set; }
        public virtual ROLES Roleses { get; set; }
    }
}