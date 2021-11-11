using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
   public interface IOderDetailService
    {
        List<ORDER_DETAILS> getListORDERS();
        string AddORDER_DETAILS(ORDER_DETAILS sp);
        string EditORDER_DETAILS(ORDER_DETAILS sp);
        string DeleteORDER_DETAILS(ORDER_DETAILS sp);
        string SaveORDER_DETAILS();
    }
}
