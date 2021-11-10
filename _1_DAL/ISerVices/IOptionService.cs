using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
    interface IOptionService
    {
        List<OPTIONS> getListOption();
        string AddOption(OPTIONS sp);
        string EditOption(OPTIONS sp);
        string DeleteOption(OPTIONS sp);
        string SaveOption();
    }
}

