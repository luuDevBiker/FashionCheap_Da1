using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
   public interface IOderService
    {
        List<ORDERS> getListORDERS();
        string AddORDERS(ORDERS sp);
        string EditORDERS(ORDERS sp);
        string DeleteORDERS(ORDERS sp);
        string SaveORDERS();
    }
}
