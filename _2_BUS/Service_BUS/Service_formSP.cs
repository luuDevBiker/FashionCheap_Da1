using System.Collections.Generic;
using System.Linq;
using _2_BUS.IService_BUS;
using _2_BUS.Models;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;

namespace _2_BUS.Service_BUS
{
    public class Service_formSP : IProduct_Service
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
        private List<ProductDetail> _litSanPhamCuThes;

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
            _litSanPhamCuThes = new List<ProductDetail>();
        }

        public string addImage()
        {
            throw new System.NotImplementedException();
        }

        public string addNewProduct(string name)
        {
            PRODUCTS prd = new PRODUCTS();
            prd.products_Name = name;
            prd.status_Delete = false;
            PS.AddProduct(prd);
            return "Successful";
        }

        public List<OPTIONS> getCountOption()
        {
            var list = _lsOptionses;
            return list;
        }

        public List<ProductDetail> LoadDatafromDAL()
        {
            var lisdtOption = _lstVariantsValueses
                .Join(_lstOptionsValueses, vv => vv.id_Values, ov => ov.id_Values, (vv, ov) => new { vv, ov })
                .Join(_lsOptionses, i => i.ov.id_Option, o => o.id_Option, (i, o) => new { i.vv, i.ov, o })
                .Join(_lstProductses, i => i.vv.id_Product, p => p.id_Product, (i, p) => new { i.vv, i.ov, i.o, p })
                .Join(_lstProductsVariantses, i => i.vv.id_Variant, pv => pv.id_Variant, (i, pv) => new { i.vv, i.p, i.o, i.ov, pv })
                .ToList();
            _lstProductsVariantses.ForEach(y =>
            {
                var x = new ProductDetail();
                x.Product = _lstProductses.Where(x => x.id_Product == y.id_Product).FirstOrDefault();
                x.ProductVariant = y;
                lisdtOption.Where(i => i.vv.id_Variant == y.id_Variant).ToList().ForEach(z =>
                  {
                      x.VariantValue.Add(z.vv);
                      x.Option.Add(z.o);
                      x.OptionValue.Add(z.ov);
                  });
                var list1 = lisdtOption.Where(x => x.vv.id_Variant == y.id_Variant).ToList();
                _lstImagesProductses.Where(x => x.id_variant == y.id_Variant).ToList().ForEach(z =>
                  {
                      x.ImageProduct.Add(z);
                  });
                //trạng thái có phải là dữ liệu cũ có trong database hay không nếu cũ : true : false
                x.Status = true;
                _litSanPhamCuThes.Add(x);
            });

            return _litSanPhamCuThes;


        }
    }
}
