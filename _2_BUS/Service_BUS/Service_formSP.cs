using System.Collections.Generic;
using System.Linq;
using _2_BUS.IService_BUS;
using _2_BUS.Models;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;

namespace _2_BUS.Service_BUS
{
    public class Service_formSP:IProduct_Service
    {
        private IProductService PS;
        private IProductVariantservice PV;
        private IProductOptionService PO;
        private IOptionService OS;
        private IOptionValueService OV;
        private IVariantValuesService Vv;
        private IImageProductSerivce Image;
        private List<PRODUCTS> _lstProductses;
        private List<PRODUCTS_VARIANTS> _lstProductsVariantses;
        private List<PRODUCTS_OPTIONS> _lsProductsOptionses;
        private List<IMAGES_PRODUCTS> _lstImagesProductses;
        private List<VARIANTS_VALUES> _lstVariantsValueses;
        private List<OPTIONS> _lsOptionses;
        private List<OPTIONS_VALUES> _lstOptionsValueses;
        private List<SanPhamCuThe> _litSanPhamCuThes;

        public Service_formSP()
        {
            PS = new Product_Service();
            _lstProductses = new List<PRODUCTS>();
            _lstProductses = PS.getListProductses();
            //
            PV = new ProductsVariants_Service();
            _lstProductsVariantses = new List<PRODUCTS_VARIANTS>();
            _lstProductsVariantses = PV.getListProductses();
            //
            PO = new ProductOptions_Service();
            _lsProductsOptionses = new List<PRODUCTS_OPTIONS>();
            _lsProductsOptionses = PO.getListProductsesOptions();
            //
            Image = new Images_Service();
            _lstImagesProductses = new List<IMAGES_PRODUCTS>();
            _lstImagesProductses = Image.getListImageS();
            //
            Vv = new VARIANTS_VALUES_Service();
            _lstVariantsValueses = new List<VARIANTS_VALUES>();
            _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
            //
            OS = new OPTIONS_Service();
            _lsOptionses = new List<OPTIONS>();
            _lsOptionses = OS.getListOption();
            //
            OV = new OPTIONS_VALUES_Service();
            _lstOptionsValueses = new List<OPTIONS_VALUES>();
            _lstOptionsValueses = OV.getListOptionValue();
            //
            _litSanPhamCuThes = new List<SanPhamCuThe>();
        }

        public List<SanPhamCuThe> LoadDatafromDAL()
        {
            var akaka = (from a in _lstVariantsValueses
                join b in _lstOptionsValueses on a.id_Option & a.id_Values equals b.id_Option & b.id_Values
                join c in _lsOptionses on b.id_Option equals c.id_Option
                join d in _lsProductsOptionses on a.id_Option & a.id_Product equals d.id_Option & d.id_Product
                join e in _lstProductsVariantses on a.id_Variant & a.id_Product equals e.id_Variant & e.id_Product
                join f in _lstProductses on e.id_Product equals f.id_Product
                select new { f.products_Name, b.option_Values, a.quantity, a.import_Price, a.price }).ToList();
            foreach (var x in akaka)
            {
                SanPhamCuThe a = new SanPhamCuThe(x.products_Name, x.option_Values, x.quantity, x.import_Price,
                    x.price);
                _litSanPhamCuThes.Add(a);
            }

            return _litSanPhamCuThes;


        }
    }
}
   