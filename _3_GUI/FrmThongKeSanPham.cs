using _2_BUS.IService_BUS;
using _2_BUS.Models;
using _2_BUS.Service_BUS;
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
    public partial class FrmThongKeSanPham : Form
    {
        private IProduct_Service _iProductService;
        private List<ProductDetail> _lstProductDetail;
        private List<ProductDetail> _lsSPban;



        public FrmThongKeSanPham()
        {
            InitializeComponent();
            _iProductService = new Service_formSP();
            _lsSPban = _iProductService.LoadDatafromDAL();
            _lstProductDetail = _iProductService.LoadDatafromDAL();
            loadDataTatCa();
        }

        private void loadDataTatCa()
        {
            DGV_TKSanPham.ColumnCount = 7;
            var row = 0;
            DGV_TKSanPham.Columns[row].Name = "Id Sản Phẩm";
            DGV_TKSanPham.Columns[row++].Visible = false;
            DGV_TKSanPham.Columns[row].Name = "Id variant ";
            DGV_TKSanPham.Columns[row++].Visible = false;
            DGV_TKSanPham.Columns[row++].Name = "Tên Sản Phẩm";
            DGV_TKSanPham.Columns[row++].Name = "Mã sản phẩm";
            DGV_TKSanPham.Columns[row++].Name = "Số Lượng";
            DGV_TKSanPham.Columns[row++].Name = "Gía Nhập";
            DGV_TKSanPham.Columns[row++].Name = "Gía Bán";
            DGV_TKSanPham.Rows.Clear();
        }

        private void rdbTatCaSanPham_CheckedChanged(object sender, EventArgs e)
        {
            loadDataTatCa();
            _lstProductDetail.ForEach(x =>
            {
                DGV_TKSanPham.Rows.Add(
                    x.ProductVariant.id_Product,
                    x.ProductVariant.id_Variant,
                    x.Product.products_Name,
                    x.ProductVariant.Products_Code,
                    x.ProductVariant.quantity,
                    x.ProductVariant.import_Price,
                    x.ProductVariant.price
                    );
            });
        }

        private void rdbSanPhamE_CheckedChanged(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString().Split(" ")[0];

        }
    }
}
