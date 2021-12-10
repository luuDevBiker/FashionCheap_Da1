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
        private List<Order_OrderDetail> _lstOrder_ODetail;
        private IQLOrderService _iOrderService;
        private DateTime _time;

        public FrmThongKeSanPham()
        {
            InitializeComponent();
            _iProductService = new Service_formSP();
            _lsSPban = new List<ProductDetail>();
            _lstProductDetail = _iProductService.LoadDatafromDAL();
            _iOrderService = new QLOrDerService();
            _lstOrder_ODetail = _iOrderService.JoinTable();
            _time = DateTime.Now;
            lblDayNow.Text = _time.ToString().Split(" ")[0];
            loadDataTatCa(0);
        }

        private void loadDataTatCa(int option)
        {
            if (option == 0)
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
            else if (option == 1)
            {
                DGV_TKSanPham.ColumnCount = 9;
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
                DGV_TKSanPham.Columns[row++].Name = "Đã bán được";
                DGV_TKSanPham.Columns[row++].Name = "Tăng trưởng";
                DGV_TKSanPham.Rows.Clear();
            }

        }
        private void rdbTatCaSanPham_CheckedChanged(object sender, EventArgs e)
        {
            loadDataTatCa(0);
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
            loadDataTatCa(0);
            var time = DateTime.Now;
            //.ToString().Split(" ")[0]
            var month = time.Month;
            var year = time.Year;
            if (month - 6 < 0)
            {
                month = 12 + month - 6;
                year--;
            }
            else
            {
                month -= 6;
            }
            var lstProduct = _lstOrder_ODetail
                .Where(x => x.Order.order_Time.Month >= month
                    && x.Order.order_Time.Year >= year)
                .ToList()
                .Where(x => x.Order.order_Time.Month <= time.Month
                    && x.Order.order_Time.Year <= time.Year)
                .GroupBy(c => c.OrderDetail.id_Product)
                .Select(x => x.First())
                .ToList();
            var lstProductCopy = _lstProductDetail
                .GroupBy(x => x.Product.id_Product)
                .Select(x => x.First())
                .ToList();
            lstProduct.ForEach(x =>
            {
                var index = lstProductCopy.FindIndex(v => v.Product.id_Product == x.ProductDetail.Product.id_Product);
                lstProductCopy.RemoveAt(index);
            });
            lstProductCopy.ForEach(x =>
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

        private void rdbSanPhamBanChay_CheckedChanged(object sender, EventArgs e)
        {
            loadDataTatCa(0);
            var time = DateTime.Now;
            //.ToString().Split(" ")[0]
            var month = time.Month;
            var year = time.Year;
            if (month - 6 < 0)
            {
                month = 12 + month - 6;
                year--;
            }
            else
            {
                month -= 6;
            }
            var lstProduct = _lstOrder_ODetail
                .Where(x => x.Order.order_Time.Month >= month
                    && x.Order.order_Time.Year >= year)
                .ToList()
                .Where(x => x.Order.order_Time.Month <= time.Month
                    && x.Order.order_Time.Year <= time.Year)
                .GroupBy(c => c.OrderDetail.id_Product)
                .Select(x => x.First())
                .ToList();
            var lstProductCopy = _lstProductDetail
                .GroupBy(x => x.Product.id_Product)
                .Select(x => x.First())
                .ToList();
            var lstProductDetail = new List<ProductDetail>();
            lstProduct.ForEach(x =>
            {
                lstProductDetail.Add(lstProductCopy.Where(z => z.Product.id_Product == x.ProductDetail.Product.id_Product).FirstOrDefault());
            });
            lstProductDetail.ForEach(x =>
            {
                DGV_TKSanPham.Rows.Add(
                    x.ProductVariant.id_Product,
                    x.ProductVariant.id_Variant,
                    x.Product.products_Name,
                    x.ProductVariant.Products_Code,
                    x.ProductVariant.quantity,
                    x.ProductVariant.import_Price,
                    x.ProductVariant.price);
            });
        }

        private void rdbSanPhamNhieuNhat_CheckedChanged(object sender, EventArgs e)
        {
            loadDataTatCa(0);
            var lstProductDetail = _lstProductDetail
                .Where(x => x.ProductVariant.quantity >= 1000)
                .GroupBy(x => x.ProductVariant.id_Variant)
                .Select(x => x.First())
                .ToList();

            lstProductDetail.ForEach(x =>
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
        private void rdbSanPhamItNhat_CheckedChanged(object sender, EventArgs e)
        {
            loadDataTatCa(0);
            var lstProductDetail = _lstProductDetail
                .Where(x => x.ProductVariant.quantity < 1000)
                .GroupBy(x => x.ProductVariant.id_Variant)
                .Select(x => x.First())
                .ToList();

            lstProductDetail.ForEach(x =>
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
        private void btnLoc_Click(object sender, EventArgs e)
        {
            loadDataTatCa(0);
            var time = dtpTime.Value;

            if (time.Year > _time.Year 
                || (time.Month > _time.Month && time.Year == _time.Year) 
                || (time.Day > _time.Day && time.Month == _time.Month && time.Year == _time.Year)
                )
            {
                MessageBox.Show("Kiểm tra lại thời gian !!", "Lỗi Thời Gian");
                return;
            }
            //.ToString().Split(" ")[0]
            var month = time.Month;
            var year = time.Year;
            var lstProduct = _lstOrder_ODetail
                .Where(x => x.Order.order_Time.Month >= month
                    && x.Order.order_Time.Year >= year)
                .ToList()
                .Where(x => x.Order.order_Time.Month <= _time.Month
                    && x.Order.order_Time.Year <= _time.Year)
                .GroupBy(c => c.OrderDetail.id_Product)
                .Select(x => x.First())
                .ToList();
            var lstProductCopy = _lstProductDetail
                .GroupBy(x => x.Product.id_Product)
                .Select(x => x.First())
                .ToList();
            var lstProductDetail = new List<ProductDetail>();
            lstProduct.ForEach(x =>
            {
                lstProductDetail.Add(lstProductCopy.Where(z => z.Product.id_Product == x.ProductDetail.Product.id_Product).FirstOrDefault());
            });
            lstProductDetail.ForEach(x =>
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


    }
}
