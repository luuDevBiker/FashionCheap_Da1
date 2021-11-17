using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_DataAccessLayers;

namespace _3_GUI
{
    public partial class FrmKhuyenMai : Form
    {
        private List<CUSTOMERS> _lstcustomerses;
        private List<EMPLOYEES> _lstEmployeeses;
        private List<VARIANTS_VALUES> _lsVariantsValueses;
        private List<ORDERS> _lstOrderses;
        private List<ORDER_DETAILS> _lstOrderDetailses;
        private List<PRODUCTS_VARIANTS> _lstProductsVariantses;
        private List<PRODUCTS> _lstProductses;
        public FrmKhuyenMai()
        {
            InitializeComponent();
            _lstcustomerses = new List<CUSTOMERS>();
            _lstEmployeeses = new List<EMPLOYEES>();
            _lsVariantsValueses = new List<VARIANTS_VALUES>();
            _lstOrderses = new List<ORDERS>();
            _lstOrderDetailses = new List<ORDER_DETAILS>();
            _lstProductsVariantses = new List<PRODUCTS_VARIANTS>();
            _lstProductses = new List<PRODUCTS>();
        }

        void loadDB()
        {
            var lst = (from kh in _lstcustomerses join hd in _lstOrderses on kh.id_Customer equals hd.id_Customer
                join hdct in _lstOrderDetailses on hd.id_Order equals hdct.id_Order
                join sp in _lsVariantsValueses on hdct.id_Variant equals sp.id_Variant
                join spct in _lstProductsVariantses on sp.id_Variant equals spct.id_Variant
                join Sanpham in _lstProductses on spct.id_Product equals Sanpham.id_Product
                       select new
                {
                    TenKhuyenMai = hd.discount,
                    TenSanPham = Sanpham.products_Name,

                    
                }).ToList();
        }
       
    }
}
