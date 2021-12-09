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

        void loadAllList()
        {
            _lstProductses = PS.getListProductses();
            _lstOptionsValueses = OV.getListOptionValue();
            _lsOptionses = OS.getListOption();
            _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
            _lsProductsOptionses = PO.getListProductsesOptions();
            _lstProductsVariantses = PV.getListProductses();

        }
        void clearall()
        {
            _lsOptionses.Clear();
            _lsProductsOptionses.Clear();
            _lstOptionsValueses.Clear();
            _lstProductsVariantses.Clear();
            _lstProductses.Clear();
            _lstVariantsValueses.Clear();
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



        public List<OPTIONS> getCountOptionloadtong()
        {
            var list = _lsOptionses; return list;
        }
        public List<PRODUCTS_OPTIONS> getCountOption(int a)
        {
            var list = _lsProductsOptionses.Where(c => c.id_Product == a).ToList();
            return list;
        }

        public List<ProductDetail> LoadDatafromDAL()
        {
            _litSanPhamCuThes.Clear();
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
        {// thêm Product Vảiant
            int idProduct = a.Product.id_Product;
            PV.AddProductVarriant(a.ProductVariant);
            PV.SaveProductVarriant();
            //-----------------------------------------
            for (int i = 0; i < a.Option.Count; i++)
            {//-------------- Thêm vảo  OPtion--------------
                int beu = a.Option[i].id_Option;
                string aa = a.Option[i].option_Name;
                a.Option[i].status_Delete = true;
                if (OS.getListOption().Any(c => c.option_Name == a.Option[i].option_Name) == false)
                {
                    OS.AddOption(a.Option[i]);
                    OS.SaveOption();
                }
                else
                {
                    var b = OS.getListOption()[OS.getListOption().FindIndex(c => c.option_Name == a.Option[i].option_Name)];
                    b.status_Delete = true;
                    OS.EditOption(b);
                    OS.SaveOption();
                }

                //
                //-------------- Thêm vảo  OPtion vaLues--------------

                int newId_OPtion = OS.getListOption().Where(c => c.option_Name == a.Option[i].option_Name).Select(c => c.id_Option).FirstOrDefault();
                a.OptionValue[i].id_Option = newId_OPtion;
                string beuValue = a.OptionValue[i].option_Values;
                a.OptionValue[i].status_Delete = true;
                if (OV.getListOptionValue().Any(c => c.option_Values == beuValue && c.id_Option == newId_OPtion) == false)
                {
                    OV.AddOptionValue(a.OptionValue[i]);
                    OV.SaveOptionValue();
                }
                else
                {
                    var b = OV.getListOptionValue()[OV.getListOptionValue().FindIndex(c => c.option_Values == beuValue && c.id_Option == newId_OPtion)];
                    b.status_Delete = true;
                    OV.EditOptionValue(b);
                    OV.SaveOptionValue();
                }
                //a.OptionValue[i].id_Option = OS.getListOption().Where(c => c.option_Name == a.Option[i].option_Name).Select(c => c.id_Option).FirstOrDefault();
                //OV.AddOptionValue(a.OptionValue[i]);
                //OV.SaveOptionValue();
                //
                //-------------- Thêm vảo Product OPtion--------------

                //  var aIdProduct = a.ProductOption[i].id_Product;
                PRODUCTS_OPTIONS newProductOption = new PRODUCTS_OPTIONS();
                newProductOption.id_Product = idProduct;
                newProductOption.id_Option = newId_OPtion;
                newProductOption.status_Delete = true;
                // _lsProductsOptionses.Add(newProductOption);
                if (PO.getListProductsesOptions().Any(c => c.id_Option == newProductOption.id_Option && c.id_Product == newProductOption.id_Product) == false)
                {
                    PO.AddProductOptions(newProductOption);
                    PO.SaveProductOptions();
                }
                else
                {
                    var b = PO.getListProductsesOptions()[PO.getListProductsesOptions().FindIndex(c => c.id_Option == newProductOption.id_Option && c.id_Product == newProductOption.id_Product)];
                    b.status_Delete = true;
                    PO.EditProductOptions(b);
                    PO.SaveProductOptions();
                }
                //
                //--------------- Thêm vào Variant values-------------
                int testbeu = a.Product.id_Product;
                int testbeu2 = PV.getListProductses().Where(c => c.Products_Code == a.ProductVariant.Products_Code).Select(c => c.id_Variant).FirstOrDefault();
                int testbeu3 = OS.getListOption().Where(c => c.option_Name == a.Option[i].option_Name).Select(c => c.id_Option).FirstOrDefault();
                int testbeu4 = OV.getListOptionValue()
                    .Where(c => c.option_Values == a.OptionValue[i].option_Values &&
                                c.id_Option == a.OptionValue[i].id_Option).Select(c => c.id_Values).FirstOrDefault();
                VARIANTS_VALUES newVariantsValues = new VARIANTS_VALUES();
                newVariantsValues.id_Product = a.Product.id_Product;
                newVariantsValues.id_Variant = PV.getListProductses().Where(c => c.Products_Code == a.ProductVariant.Products_Code).Select(c => c.id_Variant).FirstOrDefault();
                newVariantsValues.id_Option = OS.getListOption().Where(c => c.option_Name == a.Option[i].option_Name).Select(c => c.id_Option).FirstOrDefault();
                newVariantsValues.id_Values = OV.getListOptionValue()
                    .Where(c => c.option_Values == a.OptionValue[i].option_Values &&
                                c.id_Option == a.OptionValue[i].id_Option).Select(c => c.id_Values).FirstOrDefault();
                newVariantsValues.status_Delete = true;
                // _lstVariantsValueses.Add(newVariantsValues);
                if (Vv.getListVARIANTS_VALUES().Any(c => c.id_Product == testbeu && c.id_Option == testbeu3
                && c.id_Variant == testbeu2 && c.id_Values == testbeu4) == false)
                {
                    Vv.AddVARIANTS_VALUES(newVariantsValues);
                    Vv.SaveVARIANTS_VALUES();
                }
                else
                {
                    var b = Vv.getListVARIANTS_VALUES()[Vv.getListVARIANTS_VALUES().FindIndex(c => c.id_Product == testbeu && c.id_Option == testbeu3
                        && c.id_Variant == testbeu2 && c.id_Values == testbeu4)];
                    b.status_Delete = true;
                    Vv.EditVARIANTS_VALUES(b);
                    Vv.SaveVARIANTS_VALUES();
                }
            }
            clearall();
            loadAllList();
            LoadDatafromDAL();
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


        #region ProDucts
        public List<PRODUCTS> GetListProductses()
        {
            return PS.getListProductses();
        }
        public string addNamePRO(PRODUCTS a)
        {
            a.status_Delete = true;
            _lstProductses.Add(a);
            if (PS.getListProductses().Any(c => c.products_Name == a.products_Name) == false)
            {
                PS.AddProduct(a);
                return PS.SaveProduct();
            }
            else
            {
                var b = PS.getListProductses()[PS.getListProductses().FindIndex(c => c.products_Name == a.products_Name)];
                b.status_Delete = true;
                PS.EditProduct(b);
                return PS.SaveProduct();
            }
        }

        public string editNamePro(PRODUCTS a)
        {
            _lstProductses[_lstProductses.FindIndex(c => c.id_Product == a.id_Product)] = a;
            PS.EditProduct(a);
            return PS.SaveProduct();
        }

        public string RemoveNamePro(PRODUCTS a)
        {
            string thichnhau = a.products_Name;
            _lstProductses.RemoveAt(_lstProductses.FindIndex(c => c.id_Product == a.id_Product));
            PS.DeleteProduct(a);
            return PS.SaveProduct();
        }

        #endregion
        /// ////////////////////////
        #region Variant
        public List<PRODUCTS_VARIANTS> GetListProductVariantses()
        {
            return PV.getListProductses();
        }
        public string addVariant(PRODUCTS_VARIANTS a)
        {
            a.status_Delete = true;
            _lstProductsVariantses.Add(a);
            if (PV.getListProductses().Any(c => c.Products_Code == a.Products_Code) == false)
            {
                PV.AddProductVarriant(a);
                return PV.SaveProductVarriant();
            }
            else
            {
                var b = PV.getListProductses()[PV.getListProductses().FindIndex(c => c.Products_Code == a.Products_Code)];
                b.status_Delete = true;
                PV.EditProductVarriant(b);
                return PV.SaveProductVarriant();
            }
        }

        public string editVariant(PRODUCTS_VARIANTS a)
        {
            _lstProductsVariantses[_lstProductsVariantses.FindIndex(c => c.id_Variant == a.id_Variant)] = a;
            PV.EditProductVarriant(a);
            return PV.SaveProductVarriant();
        }

        public string RemoveVariant(PRODUCTS_VARIANTS a)
        {

            _lstProductsVariantses.RemoveAt(_lstProductsVariantses.FindIndex(c => c.id_Variant == a.id_Variant));
            PV.DeleteProductVarriant(a);
            return PV.SaveProductVarriant();
        }

        #endregion
        /// //////////
        #region OPtions
        public List<OPTIONS> GetListoOptionses()
        {
            return OS.getListOption();
        }
        public string addOPtion(OPTIONS a)
        {
            a.status_Delete = true;
            _lsOptionses.Add(a);
            if (OS.getListOption().Any(c => c.option_Name == a.option_Name) == false)
            {
                OS.AddOption(a);
                return OS.SaveOption();
            }
            else
            {
                var b = OS.getListOption()[OS.getListOption().FindIndex(c => c.option_Name == a.option_Name)];
                b.status_Delete = true;
                OS.EditOption(b);
                return OS.SaveOption();
            }
        }

        public string editOption(OPTIONS a)
        {
            _lsOptionses[_lsOptionses.FindIndex(c => c.id_Option == a.id_Option)] = a;
            OS.EditOption(a);
            return OS.SaveOption();
        }

        public string RemoveOPtion(OPTIONS a)
        {

            _lsOptionses.RemoveAt(_lsOptionses.FindIndex(c => c.id_Option == a.id_Option));
            OS.DeleteOption(a);
            return OS.SaveOption();
        }

        #endregion
        //////////////////////
        #region OPtion_Value
        public List<OPTIONS_VALUES> GetListoOptionvValueses()
        {
            return OV.getListOptionValue();
        }
        public string addOPtion_Value(OPTIONS_VALUES a)
        {
            string dd = a.option_Values;
            int dda = a.id_Option;

            a.status_Delete = true;
            _lstOptionsValueses.Add(a);
            if (OV.getListOptionValue().Any(c => c.id_Values == a.id_Values && c.id_Option == a.id_Option) == false)
            {
                OV.AddOptionValue(a);
                return OV.SaveOptionValue();
            }
            else
            {
                var b = OV.getListOptionValue()[OV.getListOptionValue().FindIndex(c => c.id_Values == a.id_Values && c.id_Option == a.id_Option)];
                b.status_Delete = true;
                OV.EditOptionValue(b);
                return OV.SaveOptionValue();
            }
        }

        public string editOption_Value(OPTIONS_VALUES a)
        {
            _lstOptionsValueses[_lstOptionsValueses.FindIndex(c => c.id_Values == a.id_Values && c.id_Option == a.id_Option)] = a;
            OV.EditOptionValue(a);
            return OV.SaveOptionValue();
        }

        public string RemoveOPtion_values(OPTIONS_VALUES a)
        {

            _lstOptionsValueses.RemoveAt(_lstOptionsValueses.FindIndex(c => c.id_Values == a.id_Values && c.id_Option == a.id_Option));
            OV.DeleteOptionValue(a);
            return OS.SaveOption();
        }

        #endregion
        /// 
        #region PRoduct_OPtions
        public List<PRODUCTS_OPTIONS> GetLisoProductsOptionses()
        {
            return PO.getListProductsesOptions();
        }
        public string addProduct_OPtion(PRODUCTS_OPTIONS a)
        {
            a.status_Delete = true;
            _lsProductsOptionses.Add(a);
            if (PO.getListProductsesOptions().Any(c => c.id_Option == a.id_Option && c.id_Product == a.id_Product) == false)
            {
                PO.AddProductOptions(a);
                return PO.SaveProductOptions();
            }
            else
            {
                var b = PO.getListProductsesOptions()[PO.getListProductsesOptions().FindIndex(c => c.id_Option == a.id_Option && c.id_Product == a.id_Product)];
                b.status_Delete = true;
                PO.EditProductOptions(b);
                return PO.SaveProductOptions();
            }
        }

        public string editProduct_Option(PRODUCTS_OPTIONS a)
        {
            _lsProductsOptionses[_lsProductsOptionses.FindIndex(c => c.id_Option == a.id_Option && c.id_Product == a.id_Product)] = a;
            PO.EditProductOptions(a);
            return PO.SaveProductOptions();
        }

        public string RemoveProduct_OPtion(PRODUCTS_OPTIONS a)
        {

            _lsProductsOptionses.RemoveAt(_lsProductsOptionses.FindIndex(c => c.id_Option == a.id_Option && c.id_Product == a.id_Product));
            PO.DeleteProductOptions(a);
            return PO.SaveProductOptions();
        }

        #endregion
        //----------------------

        #region VAriant_Valuse
        public List<VARIANTS_VALUES> GetLisvVariantsValueses()
        {
            return Vv.getListVARIANTS_VALUES();
        }
        public string addVariant_value(VARIANTS_VALUES a)
        {
            a.status_Delete = true;
            _lstVariantsValueses.Add(a);
            if (Vv.getListVARIANTS_VALUES().Any(c => c.id_Product == a.id_Product && c.id_Option == a.id_Option && c.id_Variant == a.id_Variant && c.id_Values == a.id_Values) == false)
            {
                Vv.AddVARIANTS_VALUES(a);
                return Vv.SaveVARIANTS_VALUES();
            }
            else
            {
                var b = Vv.getListVARIANTS_VALUES()[Vv.getListVARIANTS_VALUES().FindIndex(c => c.id_Product == a.id_Product && c.id_Option == a.id_Option && c.id_Variant == a.id_Variant && c.id_Values == a.id_Values)];
                b.status_Delete = true;
                Vv.EditVARIANTS_VALUES(b);
                return Vv.SaveVARIANTS_VALUES();
            }
        }

        public string editVariant_values(VARIANTS_VALUES a)
        {

            _lstVariantsValueses[_lstVariantsValueses.FindIndex(c => c.id_Product == a.id_Product && c.id_Variant == a.id_Variant)] = a;
            Vv.EditVARIANTS_VALUES(a);
            return Vv.SaveVARIANTS_VALUES();
        }

        public string RemoveVariant_values(VARIANTS_VALUES a)
        {

            _lstVariantsValueses.RemoveAt(_lstVariantsValueses.FindIndex(c => c.id_Product == a.id_Product && c.id_Option == a.id_Option && c.id_Variant == a.id_Variant && c.id_Values == a.id_Values));
            Vv.DeleteVARIANTS_VALUES(a);
            return Vv.SaveVARIANTS_VALUES();
        }

        #endregion

        public void save()
        {
            PS.SaveProduct();
            PO.SaveProductOptions();
            PV.SaveProductVarriant();
            OS.SaveOption();
            OV.SaveOptionValue();
            Vv.SaveVARIANTS_VALUES();
        }
    }
}
