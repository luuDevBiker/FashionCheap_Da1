using System.Collections.Generic;
using _2_BUS.Models;
using DAL_DataAccessLayers;
namespace _2_BUS.IService_BUS
{
    public interface IProduct_Service
    {
        public List<ProductDetail> LoadDatafromDAL();
        public List<OPTIONS> getCountOption();
        public string addImage();
        public string addNewProduct(string name);
        public All_List AllListPRO();
        public List<PRODUCTS_VARIANTS> GetListProductVariantses();
        public string addVariant(PRODUCTS_VARIANTS a);
        public string editVariant(PRODUCTS_VARIANTS a);
        public string RemoveVariant(PRODUCTS_VARIANTS a);
        public List<OPTIONS> GetListoOptionses();
        public string addOPtion(OPTIONS a);
        public string editOption(OPTIONS a);
        public string RemoveOPtion(OPTIONS a);
        public List<OPTIONS_VALUES> GetListoOptionvValueses();
        public string addOPtion_Value(OPTIONS_VALUES a);
        public string editProduct_Option(OPTIONS_VALUES a);
        public string RemoveProduct_OPtion(OPTIONS_VALUES a);
        public List<PRODUCTS_OPTIONS> GetLisoProductsOptionses();
        public string addProduct_OPtion(PRODUCTS_OPTIONS a);
        public string editProduct_Option(PRODUCTS_OPTIONS a);
        public string RemoveProduct_OPtion(PRODUCTS_OPTIONS a);
        public List<VARIANTS_VALUES> GetLisvVariantsValueses();
        public string addVariant_value(VARIANTS_VALUES a);
        public string editVariant_values(VARIANTS_VALUES a);
        public string RemoveVariant_values(VARIANTS_VALUES a);
        public void save();
    }
}