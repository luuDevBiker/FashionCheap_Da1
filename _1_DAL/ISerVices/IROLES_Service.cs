using System.Collections.Generic;

namespace DAL_DataAccessLayers.IServices
{
    public interface IROLES_Service
    {
        List<ROLES> getListORDERS();
        string AddORDERS(ROLES sp);
        string EditORDERS(ROLES sp);
        string DeleteORDERS(ROLES sp);
        string SaveORDERS();
    }
}