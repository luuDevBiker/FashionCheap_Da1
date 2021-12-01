using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public string Addnew(ProductDetail a)
        {
            _litSanPhamCuThes.Add(a);
            PS.AddProduct(a.Product);
            PV.AddProductVarriant(a.ProductVariant);
            foreach (var VARIABLE in a.Option)
            {
                OS.AddOption(VARIABLE);
            }

            foreach (var VARIABLE in a.ProductOption)
            {
                PO.AddProductOptions(VARIABLE);
            }

            foreach (var VARIABLE in a.OptionValue)
            {
                OV.AddOptionValue(VARIABLE);
            }

            foreach (var VARIABLE in a.VariantValue)
            {
                Vv.AddVARIANTS_VALUES(VARIABLE);
            }

            return "thêm thành công";
        }

        public string EditProduct(ProductDetail a)
        {
            int vt = _litSanPhamCuThes.FindIndex(c =>
                c.Product.id_Product == a.Product.id_Product &&
                c.ProductVariant.id_Variant == a.ProductVariant.id_Variant);
            _litSanPhamCuThes[vt] = a;

            PS.EditProduct(a.Product);
            PV.EditProductVarriant(a.ProductVariant);
            foreach (var VARIABLE in a.Option)
            {
                OS.EditOption(VARIABLE);
            }

            foreach (var VARIABLE in a.ProductOption)
            {
                PO.EditProductOptions(VARIABLE);
            }

            foreach (var VARIABLE in a.OptionValue)
            {
                OV.EditOptionValue(VARIABLE);
            }

            foreach (var VARIABLE in a.VariantValue)
            {
                Vv.EditVARIANTS_VALUES(VARIABLE);
            }

            return " Sửa Thành Công";
        }
        public All_List AllListPRO()
        {
            All_List a = new All_List(_lstProductses, _lstProductsVariantses, _lsProductsOptionses, _lstVariantsValueses, _lsOptionses, _lstOptionsValueses);

            return a;
        }
    }
}
