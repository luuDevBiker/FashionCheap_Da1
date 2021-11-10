using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayers.IServices
{
    interface IEmployeeService
    {
        List<EMPLOYEES> getListEMPLOYEES();
        string AddEMPLOYEES(EMPLOYEES sp);
        string EditEMPLOYEES(EMPLOYEES sp);
        string DeleteEMPLOYEES(EMPLOYEES sp);
        string SaveOEMPLOYEES();
    }
}
