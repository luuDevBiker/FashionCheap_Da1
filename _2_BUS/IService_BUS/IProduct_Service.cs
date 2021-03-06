using System.Collections.Generic;
using _2_BUS.Models;
using DAL_DataAccessLayers;
namespace _2_BUS.IService_BUS
{
    public interface IProduct_Service
    {
        public List<ProductDetail> LoadDatafromDAL();

        public string addProductDetail(ProductDetail productDetail);

        public string editProductDetail(ProductDetail productDetail);

        public string removeProductDetail(ProductDetail productDetail);

        public string addProductVariant(ProductDetail productDetail);
        public string editProductVariant(ProductDetail productDetail);
        public string removeProductVariant(ProductDetail productDetail);

        public string updateQuantity(ProductDetail productDetail);
        #region code anh kieu
        public List<PRODUCTS_OPTIONS> getCountOption(int a);
        public List<OPTIONS> getCountOptionloadtong();
        public string Addnew(ProductDetail a);
        public string EditProduct_Variant(ProductDetail a);
        public string DEleteProVariant(ProductDetail a);
        public string addImage();
        public string addNewProduct(string name);
        public All_List AllListPRO();


        #region ProDuct

        public List<PRODUCTS> GetListProductses();
        public string addNamePRO(PRODUCTS a);
        public string editNamePro(PRODUCTS a);
        public string RemoveNamePro(PRODUCTS a);

        #endregion

        #region ProDuc_Variant

        public List<PRODUCTS_VARIANTS> GetListProductVariantses();
        public string addVariant(PRODUCTS_VARIANTS a);
        public string editVariant(PRODUCTS_VARIANTS a);
        public string RemoveVariant(PRODUCTS_VARIANTS a);

        #endregion

        #region option
        public List<OPTIONS> GetListoOptionses();
        public string addOPtion(OPTIONS a);
        public string editOption(OPTIONS a);
        public string RemoveOPtion(OPTIONS a);
        #endregion

        #region option value
        public List<OPTIONS_VALUES> GetListoOptionvValueses();
        public string addOPtion_Value(OPTIONS_VALUES a);
        public string editOption_Value(OPTIONS_VALUES a);
        public string RemoveOPtion_values(OPTIONS_VALUES a);

        #endregion

        #region product option
        public List<PRODUCTS_OPTIONS> GetLisoProductsOptionses();
        public string addProduct_OPtion(PRODUCTS_OPTIONS a);
        public string editProduct_Option(PRODUCTS_OPTIONS a);
        public string RemoveProduct_OPtion(PRODUCTS_OPTIONS a);

        #endregion

        #region variant value
        public List<VARIANTS_VALUES> GetLisvVariantsValueses();
        public string addVariant_value(VARIANTS_VALUES a);
        public string editVariant_values(VARIANTS_VALUES a);
        public string RemoveVariant_values(VARIANTS_VALUES a);
        #endregion

        #endregion
        public void save();
    }
}