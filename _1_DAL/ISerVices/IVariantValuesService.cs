using System.Collections.Generic;

namespace DAL_DataAccessLayers.IServices
{
    public interface IVariantValuesService
    {
        List<VARIANTS_VALUES> getListVARIANTS_VALUES();
        string AddVARIANTS_VALUES(VARIANTS_VALUES sp);
        string EditVARIANTS_VALUES(VARIANTS_VALUES sp);
        string DeleteVARIANTS_VALUES(VARIANTS_VALUES sp);
        string SaveVARIANTS_VALUES();
    }
}