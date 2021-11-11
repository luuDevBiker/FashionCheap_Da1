using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
   public interface IOptionValueService
    {
        List<OPTIONS_VALUES> getListOptionValue();
        string AddOptionValue(OPTIONS_VALUES sp);
        string EditOptionValue(OPTIONS_VALUES sp);
        string DeleteOptionValue(OPTIONS_VALUES sp);
        string SaveOptionValue();
    }
}
