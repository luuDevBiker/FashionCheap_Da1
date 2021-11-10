using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
    interface ICustomerService
    {
        List<CUSTOMERS> getListORDERS();
        string AddORDERS(CUSTOMERS sp);
        string EditORDERS(CUSTOMERS sp);
        string DeleteORDERS(CUSTOMERS sp);
        string SaveORDERS();
    }
}
