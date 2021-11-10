using System.Collections.Generic;

namespace DAL_DataAccessLayers.IServices
{
    public interface IROLES_EMPLOYEE_Service
    {
        List<ROLES_EMPLOYEE> getListORDERS();
        string AddORDERS(ROLES_EMPLOYEE sp);
        string EditORDERS(ROLES_EMPLOYEE sp);
        string DeleteORDERS(ROLES_EMPLOYEE sp);
        string SaveORDERS();
    }
}