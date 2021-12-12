
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

            //
            PV = new ProductsVariants_Service();
            _lstProductsVariantses = new List<PRODUCTS_VARIANTS>();

            //
            PO = new ProductOptions_Service();
            _lsProductsOptionses = new List<PRODUCTS_OPTIONS>();

            //
            Image = new Images_Service();
            _lstImagesProductses = new List<IMAGES_PRODUCTS>();
            _lstImagesProductses = Image.getListImageS();
            //
            Vv = new VARIANTS_VALUES_Service();
            _lstVariantsValueses = new List<VARIANTS_VALUES>();

            //
            OS = new OPTIONS_Service();
            _lsOptionses = new List<OPTIONS>();

            //
            OV = new OPTIONS_VALUES_Service();
            _lstOptionsValueses = new List<OPTIONS_VALUES>();
            //
            loadAllList();
            //
            _litSanPhamCuThes = new List<ProductDetail>();
        }

        void loadAllList()
        {
            _lstProductses = PS.getListProductses().Where(c => c.status_Delete == true).ToList();
            _lstOptionsValueses = OV.getListOptionValue().Where(c => c.status_Delete == true).ToList(); ;
            _lsOptionses = OS.getListOption().Where(c => c.status_Delete == true).ToList(); ;
            _lstVariantsValueses = Vv.getListVARIANTS_VALUES().Where(c => c.status_Delete == true).ToList(); ;
            _lsProductsOptionses = PO.getListProductsesOptions().Where(c => c.status_Delete == true).ToList(); ;
            _lstProductsVariantses = PV.getListProductses().Where(c => c.status_Delete == true).ToList(); ;

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
            var lst = new List<ProductDetail>();
            lst = _litSanPhamCuThes;
            return lst;

        }


        public string addProductDetail(ProductDetail productDetail)
        {
            try
            {
                PS.AddProduct(productDetail.Product);
                PS.SaveProduct();
                _lstProductses = PS.getListProductses();
                var idProduct = _lstProductses
                    .Where(x => x.products_Name.ToUpper() == productDetail.Product.products_Name.ToUpper())
                    .Select(o => o.id_Product)
                    .FirstOrDefault();

                productDetail.Option.ForEach(x =>
                {
                    var checkoption = _lsOptionses
                        .Where(z => z.option_Name.ToUpper() == x.option_Name.ToUpper())
                        .ToList();
                    if (checkoption.Count == 0)
                    {
                        var option = new OPTIONS();
                        option.option_Name = x.option_Name;
                        OS.AddOption(option);
                    }
                });
                OS.SaveOption();
                _lsOptionses = OS.getListOption();
                productDetail.Option.ForEach(x =>
                {
                    var idOption = _lsOptionses
                    .Where(z => z.option_Name.ToUpper() == x.option_Name.ToUpper())
                    .Select(v => v.id_Option)
                    .FirstOrDefault();
                    var productOption = new PRODUCTS_OPTIONS();
                    productOption.id_Option = idOption;
                    productOption.id_Product = idProduct;
                    var statusAdd = PO.AddProductOptions(productOption);
                });
                PO.SaveProductOptions();
                _lsProductsOptionses = PO.getListProductsesOptions();
                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error addProductDetail : " + e;
            }
        }

        public string editProductDetail(ProductDetail productDetail)
        {
            try
            {
                var idProduct = productDetail.Product.id_Product;
                //-------------------------------------------------
                productDetail.Option.ForEach(x =>
                {
                    var checkoption = _lsOptionses
                        .Where(z => z.option_Name.ToUpper() == x.option_Name.ToUpper())
                        .ToList();
                    if (checkoption.Count == 0)
                    {
                        var option = new OPTIONS();
                        option.option_Name = x.option_Name;
                        OS.AddOption(option);
                    }
                });
                OS.SaveOption();
                _lsOptionses = OS.getListOption();
                //-------------------------------------------------
                _lsProductsOptionses
                    .Where(x => x.id_Product == productDetail.Product.id_Product)
                    .ToList()
                    .ForEach(x =>
                        {
                            var variantValue = _lstVariantsValueses.Where(v => v.id_Product == x.id_Product && v.id_Option == x.id_Option).ToList();
                            variantValue.ForEach(x =>
                            {
                                var statusdeleteVariantValue = Vv.DeleteVARIANTS_VALUES(x);
                            });
                            var statusDelate = PO.DeleteProductOptions(x);
                        });
                PO.SaveProductOptions();
                Vv.SaveVARIANTS_VALUES();
                _lsProductsOptionses = PO.getListProductsesOptions();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                //-------------------------------------------------
                productDetail.Option.ForEach(x =>
                {
                    var idOption = _lsOptionses
                        .Where(v => v.option_Name.ToUpper() == x.option_Name.ToUpper())
                        .Select(x => x.id_Option)
                        .FirstOrDefault();
                    var checkConstrain = _lsProductsOptionses
                    .Where(v => v.id_Option == idOption && v.id_Product == idProduct)
                    .FirstOrDefault();
                    if (checkConstrain == null)
                    {
                        var productOption = new PRODUCTS_OPTIONS();
                        productOption.id_Option = idOption;
                        productOption.id_Product = idProduct;
                        var statusAdd = PO.AddProductOptions(productOption);
                    }
                    else
                    {
                        checkConstrain.status_Delete = true;
                        PO.EditProductOptions(checkConstrain);
                        _lstVariantsValueses
                        .Where(x => x.id_Option == checkConstrain.id_Option
                            && x.id_Product == checkConstrain.id_Product)
                        .ToList()
                        .ForEach(v =>
                        {
                            v.status_Delete = true;
                            Vv.EditVARIANTS_VALUES(v);
                        });
                    }
                });
                var statusSaveProductoption = PO.SaveProductOptions();
                var statusSaveDeletevariantValue = Vv.SaveVARIANTS_VALUES();
                _lsProductsOptionses = PO.getListProductsesOptions();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error editProductDetail : " + e;
            }
        }

        public string removeProductDetail(ProductDetail productDetail)
        {
            try
            {
                var product = _lstProductses.Where(x => x.products_Name.ToUpper() == productDetail.Product.products_Name.ToUpper()).FirstOrDefault();
                PS.DeleteProduct(product);
                PS.SaveProduct();
                _lstProductses = PS.getListProductses();
                //----------------------------------------------------------
                var lstProductOption = _lsProductsOptionses.Where(x => x.id_Product == product.id_Product).ToList();
                lstProductOption.ForEach(x =>
                {
                    PO.DeleteProductOptions(x);
                    var lstVariantValue = _lstVariantsValueses
                    .Where(v => v.id_Option == x.id_Option
                        && v.id_Product == x.id_Product)
                    .ToList();
                    lstVariantValue.ForEach(b =>
                    {
                        var status = Vv.DeleteVARIANTS_VALUES(b);
                    });
                });
                var status = Vv.SaveVARIANTS_VALUES();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                var status2 = PO.SaveProductOptions();
                _lsProductsOptionses = PO.getListProductsesOptions();
                //----------------------------------------------------------
                _lstProductsVariantses.Where(x => x.id_Product == product.id_Product)
                    .ToList()
                    .ForEach(x =>
                    {
                        PV.DeleteProductVarriant(x);
                    });
                PV.SaveProductVarriant();
                _lstProductsVariantses = PV.getListProductses();
                //----------------------------------------------------------
                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error removeProductDetail : " + e;
            }
        }
        public string addProductVariant(ProductDetail productDetail)
        {
            try
            {
                PV.AddProductVarriant(productDetail.ProductVariant);
                PV.SaveProductVarriant();
                _lstProductsVariantses = PV.getListProductses();
                var idProductVariant = _lstProductsVariantses
                    .Where(xc => xc.Products_Code.ToUpper() == productDetail.ProductVariant.Products_Code.ToUpper())
                    .FirstOrDefault();
                //--------------------------------------------------------
                productDetail.OptionValue.ForEach(x =>
                {
                    var vValue = _lstOptionsValueses
                    .Where(m => m.option_Values.ToUpper() == x.option_Values.ToUpper()
                        && m.id_Option == x.id_Option)
                    .ToList();
                    if (vValue.Count == 0)
                    {
                        var optionValue = new OPTIONS_VALUES();
                        optionValue.id_Option = x.id_Option;
                        optionValue.option_Values = x.option_Values;
                        var status1 = OV.AddOptionValue(optionValue);
                    }
                    var status = OV.SaveOptionValue();
                    _lstOptionsValueses = OV.getListOptionValue();
                });
                //--------------------------------------------------------
                productDetail.OptionValue.ForEach(x =>
                {
                    var value = _lstOptionsValueses
                    .Where(v => v.option_Values.ToUpper() == x.option_Values.ToUpper()
                        && v.id_Option == x.id_Option)
                    .FirstOrDefault();
                    var varintValue = new VARIANTS_VALUES();
                    varintValue.id_Variant = idProductVariant.id_Variant;
                    varintValue.id_Product = idProductVariant.id_Product;
                    varintValue.id_Values = value.id_Values;
                    varintValue.id_Option = x.id_Option;
                    var status1 = Vv.AddVARIANTS_VALUES(varintValue);
                });
                Vv.SaveVARIANTS_VALUES();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error addProductVariant : " + e;
            }
        }

        public string editProductVariant(ProductDetail productDetail)
        {
            try
            {
                var idVariantValue = productDetail.ProductVariant.id_Variant;
                var idPoduct = productDetail.ProductVariant.id_Product;
                PV.EditProductVarriant(productDetail.ProductVariant);
                PV.SaveProductVarriant();
                _lstProductsVariantses = PV.getListProductses();
                //---------------------------------------------------
                productDetail.OptionValue.ForEach(x =>
                {
                    var vValue = _lstOptionsValueses
                    .Where(m => m.option_Values.ToUpper() == x.option_Values.ToUpper()
                        && m.id_Option == x.id_Option)
                    .ToList();
                    if (vValue.Count == 0)
                    {
                        var optionValue = new OPTIONS_VALUES();
                        optionValue.id_Option = x.id_Option;
                        optionValue.option_Values = x.option_Values;
                        var status1 = OV.AddOptionValue(optionValue);
                    }
                    var status = OV.SaveOptionValue();
                    _lstOptionsValueses = OV.getListOptionValue();
                });
                //---------------------------------------------------
                _lstVariantsValueses
                    .Where(x => x.id_Variant == idVariantValue
                        && x.id_Product == idPoduct)
                    .ToList()
                    .ForEach(x =>
                    {
                        Vv.DeleteVARIANTS_VALUES(x);
                    });
                var status1 = Vv.SaveVARIANTS_VALUES();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                //---------------------------------------------------
                productDetail.OptionValue.ForEach(x =>
                {
                    var value = _lstOptionsValueses
                    .Where(v => v.option_Values.ToUpper() == x.option_Values.ToUpper()
                        && v.id_Option == x.id_Option)
                    .FirstOrDefault();
                    var variantValue = _lstVariantsValueses.Where(
                        xc => xc.id_Option == value.id_Option
                        && xc.id_Values == value.id_Values
                        && xc.id_Variant == idVariantValue
                        && xc.id_Product == idPoduct
                        ).FirstOrDefault();
                    if (variantValue == null)
                    {
                        var vValue = new VARIANTS_VALUES();
                        vValue.id_Variant = idVariantValue;
                        vValue.id_Product = idPoduct;
                        vValue.id_Values = value.id_Values;
                        vValue.id_Option = x.id_Option;
                        var status1 = Vv.AddVARIANTS_VALUES(vValue);
                    }
                    else
                    {
                        variantValue.status_Delete = true;
                        var status1 = Vv.EditVARIANTS_VALUES(variantValue);
                    }

                });
                var status = Vv.SaveVARIANTS_VALUES();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                //---------------------------------------------------
                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error editProductVariant : " + e;
            }
        }

        public string removeProductVariant(ProductDetail productDetail)
        {
            try
            {
                var idVariantValue = productDetail.ProductVariant.id_Variant;
                var idPoduct = productDetail.ProductVariant.id_Product;
                var productVariant = _lstProductsVariantses.Where(x => x.id_Variant == idVariantValue
                    && x.id_Product == idPoduct).FirstOrDefault();
                //---------------------------------------------------------
                PV.DeleteProductVarriant(productVariant);
                var status = PV.SaveProductVarriant();
                _lstProductsVariantses = PV.getListProductses();
                //---------------------------------------------------------
                var lstVariantValue = _lstVariantsValueses
                    .Where(x => x.id_Product == idPoduct
                    && x.id_Variant == idVariantValue)
                    .ToList();
                lstVariantValue
                    .ForEach(x =>
                    {
                        Vv.DeleteVARIANTS_VALUES(x);
                    });
                Vv.SaveVARIANTS_VALUES();
                _lstVariantsValueses = Vv.getListVARIANTS_VALUES();
                //---------------------------------------------------------

                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error removeProductVariant : " + e;
            }
        }
        public string updateQuantity(ProductDetail productDetail)
        {
            try
            {
                var prv = new ProductsVariants_Service();
                var lst = prv.getListProductses();
                var productVariant = lst
                    .Where(x => x.id_Product == productDetail.Product.id_Product
                        && x.id_Variant == productDetail.ProductVariant.id_Variant).FirstOrDefault();
                productVariant.quantity = productVariant.quantity - productDetail.ProductVariant.quantity;
                prv.EditProductVarriant(productVariant);
                prv.SaveProductVarriant();
                _lstProductsVariantses = prv.getListProductses();
                return "Successful";
            }
            catch (System.Exception e)
            {
                return "Error updateQuantity : " + e;
            }
        }
        #region Code anh Kieu

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
        #region product

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

        #endregion

        #region product option
        public List<PRODUCTS_OPTIONS> getCountOption(int a)
        {
            var list = _lsProductsOptionses.Where(c => c.id_Product == a).ToList();
            return list;
        }
        #endregion

        #region product detail
        public string Addnew(ProductDetail a)
        {
            // thêm Product Variant
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

        public string EditProduct_Variant(ProductDetail a)
        {
            int idProduct = a.Product.id_Product;
            var ProVariantEdit = PV.getListProductses().FirstOrDefault(c => c.id_Variant == a.ProductVariant.id_Variant);
            ProVariantEdit.Products_Code = a.ProductVariant.Products_Code;
            ProVariantEdit.quantity = a.ProductVariant.quantity;
            ProVariantEdit.import_Price = a.ProductVariant.import_Price;
            ProVariantEdit.price = a.ProductVariant.price;

            PV.EditProductVarriant(ProVariantEdit);
            PV.SaveProductVarriant();
            //-----------------------------------------
            for (int i = 0; i < a.Option.Count; i++)
            {
                //-------------- Sửa  OPtion--------------
                var optionEdit = OS.getListOption().FirstOrDefault(c => c.option_Name == a.Option[i].option_Name);
                optionEdit.option_Name = a.Option[i].option_Name;
                optionEdit.status_Delete = true;
                if (OS.getListOption().Any(c => c.option_Name == a.Option[i].option_Name) == false)
                {
                    OS.AddOption(optionEdit);
                    OS.SaveOption();
                }
                else
                {

                    OS.EditOption(optionEdit);
                    OS.SaveOption();
                }

                //
                //-------------- Thêm vảo  OPtion vaLues--------------
                OPTIONS_VALUES optionsValuesEdit = new OPTIONS_VALUES();
                // Tìm dòng thuộc tính ban đầu
                optionsValuesEdit = OV.getListOptionValue().FirstOrDefault(c => c.id_Option == a.Option[i].id_Option && c.id_Values == a.OptionValue[i].id_Values);
                optionsValuesEdit.id_Option = OS.getListOption().Where(c => c.option_Name == a.Option[i].option_Name).Select(c => c.id_Option).FirstOrDefault(); ;

                //a.OptionValue[i].status_Delete = true;

                if (OV.getListOptionValue().Any(c => c.option_Values == optionsValuesEdit.option_Values) == false)
                {

                    optionsValuesEdit.option_Values = a.OptionValue[i].option_Values;
                    OV.AddOptionValue(optionsValuesEdit);
                    OV.SaveOptionValue();
                }
                else
                {
                    optionsValuesEdit.id_Values = OV.getListOptionValue() // gán Id value mới 
                                           .Where(c => c.option_Values == a.OptionValue[i].option_Values).Select(c => c.id_Values)
                                           .FirstOrDefault();

                    optionsValuesEdit.option_Values = a.OptionValue[i].option_Values;
                    OV.EditOptionValue(optionsValuesEdit);
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
                newProductOption.id_Option = optionEdit.id_Option;
                newProductOption.status_Delete = true;
                // _lsProductsOptionses.Add(newProductOption);
                if (PO.getListProductsesOptions().Any(c => c.id_Option == newProductOption.id_Option && c.id_Product == newProductOption.id_Product) == false)
                {
                    PO.AddProductOptions(newProductOption);
                    PO.SaveProductOptions();
                }
                else
                {

                    PO.EditProductOptions(newProductOption);
                    PO.SaveProductOptions();
                }
                //
                //--------------- Sửa Variant values-------------

                VARIANTS_VALUES newVariantsValues = new VARIANTS_VALUES();
                newVariantsValues = Vv.getListVARIANTS_VALUES().FirstOrDefault(c =>
                    c.id_Product == a.Product.id_Product && c.id_Variant == a.ProductVariant.id_Variant &&
                    c.id_Option == a.Option[i].id_Option && c.id_Values == a.OptionValue[i].id_Values);

                if (Vv.getListVARIANTS_VALUES().Any(c => c.id_Product == newVariantsValues.id_Product && c.id_Variant == newVariantsValues.id_Variant && c.id_Option == a.Option[i].id_Option))
                {


                    newVariantsValues.id_Values = OV.getListOptionValue()
                        .Where(c => c.option_Values == a.OptionValue[i].option_Values &&
                                    c.id_Option == a.OptionValue[i].id_Option).Select(c => c.id_Values).FirstOrDefault();
                    Vv.EditVARIANTS_VALUES(newVariantsValues);
                    Vv.SaveVARIANTS_VALUES();

                }
                else
                {
                    newVariantsValues.id_Option = OS.getListOption().Where(c => c.option_Name == a.Option[i].option_Name).Select(c => c.id_Option).FirstOrDefault();
                    newVariantsValues.id_Values = OV.getListOptionValue()
                        .Where(c => c.option_Values == a.OptionValue[i].option_Values).Select(c => c.id_Values).FirstOrDefault();

                    Vv.AddVARIANTS_VALUES(newVariantsValues);
                    Vv.SaveVARIANTS_VALUES();
                }
                save();
            }
            clearall();
            loadAllList();
            LoadDatafromDAL();
            return "Sửa thành công";
        }

        public string DEleteProVariant(ProductDetail a)
        {
            for (int i = 0; i < a.Option.Count; i++)
            {
                VARIANTS_VALUES newVariantsValues = new VARIANTS_VALUES();
                newVariantsValues = Vv.getListVARIANTS_VALUES().FirstOrDefault(c =>
                    c.id_Product == a.Product.id_Product &&
                    c.id_Variant == a.ProductVariant.id_Variant &&
                    c.id_Option == a.Option[i].id_Option &&
                    c.id_Values == a.OptionValue[i].id_Values);
                Vv.DeleteVARIANTS_VALUES(newVariantsValues);
                ////////////////////////////////////////////////////////////////////---------------------------------------------------------------
                PRODUCTS_OPTIONS newProductsOptions = new PRODUCTS_OPTIONS();
                newProductsOptions = PO.getListProductsesOptions().FirstOrDefault(c =>
                    c.id_Product == a.Product.id_Product && c.id_Option == a.Option[i].id_Option);
                PO.DeleteProductOptions(newProductsOptions);

                ////////////////////////////////////////////////////////////////////---------------------------------------------------------------
                OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();
                newOptionsValues = OV.getListOptionValue().FirstOrDefault(c => c.id_Option == a.Option[i].id_Option && c.id_Values == a.OptionValue[i].id_Values);
                OV.DeleteOptionValue(newOptionsValues);
                ////////////////////////////////////////////////////////////////////-----------------------------------------------

                OPTIONS newOptions = new OPTIONS();
                newOptions = OS.getListOption().FirstOrDefault(c => c.id_Option == a.Option[i].id_Option);
                OS.DeleteOption(newOptions);
            }
            PRODUCTS_VARIANTS newProductsVariants = new PRODUCTS_VARIANTS();
            newProductsVariants = PV.getListProductses().FirstOrDefault(c =>
                c.id_Variant == a.ProductVariant.id_Variant && c.id_Product == a.Product.id_Product);
            PV.DeleteProductVarriant(newProductsVariants);

            clearall();
            loadAllList();
            LoadDatafromDAL();
            return " Xóa Thành Công";


        }

        #endregion

        #region tap nham

        public All_List AllListPRO()
        {
            All_List a = new All_List(_lstProductses, _lstProductsVariantses, _lsProductsOptionses, _lstVariantsValueses, _lsOptionses, _lstOptionsValueses);

            return a;
        }

        #endregion

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
        #endregion
    }
}
