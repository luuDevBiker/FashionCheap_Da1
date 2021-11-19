using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayers;

namespace _2_BUS.Models
{
    public class ProductDetail
    {
        public PRODUCTS Product { get; set; }
        public PRODUCTS_VARIANTS ProductVariant { get; set; }
        public List<OPTIONS> Option { get; set; }
        public List<PRODUCTS_OPTIONS> ProductOption { get; set; }
        public List<OPTIONS_VALUES> OptionValue { get; set; }
        public List<IMAGES_PRODUCTS> ImageProduct { get; set; }
        public List<VARIANTS_VALUES> VariantValue { get; set; }
        public ProductDetail()
        {
            Product = new PRODUCTS();
            ProductVariant = new PRODUCTS_VARIANTS();
            Option = new List<OPTIONS>();
            OptionValue = new List<OPTIONS_VALUES>();
            ProductOption = new List<PRODUCTS_OPTIONS>();
            ImageProduct = new List<IMAGES_PRODUCTS>();
            VariantValue = new List<VARIANTS_VALUES>();            
        }

        public ProductDetail(PRODUCTS product, PRODUCTS_VARIANTS productVariant, List<OPTIONS> option, List<PRODUCTS_OPTIONS> productOption, List<OPTIONS_VALUES> optionValue, List<IMAGES_PRODUCTS> imageProduct, List<VARIANTS_VALUES> variantValue)
        {
            Product = product;
            ProductVariant = productVariant;
            Option = option;
            ProductOption = productOption;
            OptionValue = optionValue;
            ImageProduct = imageProduct;
            VariantValue = variantValue;
        }
    }
}
