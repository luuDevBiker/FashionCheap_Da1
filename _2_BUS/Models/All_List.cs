using System.Collections.Generic;
using DAL_DataAccessLayers;

namespace _2_BUS.Models
{
    public class All_List

    {
        private List<PRODUCTS> _lstProductses;
        private List<PRODUCTS_VARIANTS> _lstProductsVariantses;
        private List<PRODUCTS_OPTIONS> _lsProductsOptionses;
        private List<VARIANTS_VALUES> _lstVariantsValueses;
        private List<OPTIONS> _lsOptionses;
        private List<OPTIONS_VALUES> _lstOptionsValueses;

        public All_List()
        {
            
        }

        public All_List(List<PRODUCTS> lstProductses, List<PRODUCTS_VARIANTS> lstProductsVariantses, List<PRODUCTS_OPTIONS> lsProductsOptionses, List<VARIANTS_VALUES> lstVariantsValueses, List<OPTIONS> lsOptionses, List<OPTIONS_VALUES> lstOptionsValueses)
        {
            _lstProductses = lstProductses;
            _lstProductsVariantses = lstProductsVariantses;
            _lsProductsOptionses = lsProductsOptionses;
            _lstVariantsValueses = lstVariantsValueses;
            _lsOptionses = lsOptionses;
            _lstOptionsValueses = lstOptionsValueses;
        }

        public List<PRODUCTS> LstProductses
        {
            get => _lstProductses;
            set => _lstProductses = value;
        }

        public List<PRODUCTS_VARIANTS> LstProductsVariantses
        {
            get => _lstProductsVariantses;
            set => _lstProductsVariantses = value;
        }

        public List<PRODUCTS_OPTIONS> LsProductsOptionses
        {
            get => _lsProductsOptionses;
            set => _lsProductsOptionses = value;
        }

        public List<VARIANTS_VALUES> LstVariantsValueses
        {
            get => _lstVariantsValueses;
            set => _lstVariantsValueses = value;
        }

        public List<OPTIONS> LsOptionses
        {
            get => _lsOptionses;
            set => _lsOptionses = value;
        }

        public List<OPTIONS_VALUES> LstOptionsValueses
        {
            get => _lstOptionsValueses;
            set => _lstOptionsValueses = value;
        }
    }
}