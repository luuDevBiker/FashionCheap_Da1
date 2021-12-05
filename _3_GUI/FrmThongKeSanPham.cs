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
        private IProduct_Service _SP;
        private List<ProductDetail> _lstProductDetail;
        private ITKSanPham tKSanPham;
        private List<ProductDetail> _lsSPban;



        public FrmThongKeSanPham()
        {
            InitializeComponent();
            _lstProductDetail = new List<ProductDetail>();
            _SP = new Service_formSP();
            tKSanPham = new TKSanPham();
            _lsSPban = new List<ProductDetail>();
            _lsSPban = _SP.LoadDatafromDAL();

        }

        private void FrmThongKeSanPham_Load(object sender, EventArgs e)
        {

        }

        private void loadDataTatCa(List<ProductDetail> TrangHoaiDuc)
        {
            DGV_TKSanPham.ColumnCount = 9 + _SP.getCountOption().Count();
            var row = 0;
            DGV_TKSanPham.Columns[row++].Name = "Tên Sản Phẩm";
            DGV_TKSanPham.Columns[row++].Name = "Mã sản phẩm";
            DGV_TKSanPham.Columns[row++].Name = "Số Lượng";
            DGV_TKSanPham.Columns[row++].Name = "Gía Nhập";
            DGV_TKSanPham.Columns[row++].Name = "Gía Bán";
            DGV_TKSanPham.Columns[row].Name = "Id Sản Phẩm";
            DGV_TKSanPham.Columns[row++].Visible = false;
            DGV_TKSanPham.Columns[row].Name = "Id variant ";
            DGV_TKSanPham.Columns[row++].Visible = false;
            DGV_TKSanPham.Rows.Clear();
            foreach (var x in TrangHoaiDuc)
            {
                List<string> objcell = new List<string>();
                objcell.Add(x.Product.products_Name);
                objcell.Add(x.ProductVariant.Products_Code);
                objcell.Add(x.ProductVariant.quantity + "");
                objcell.Add(x.ProductVariant.import_Price + "");
                objcell.Add(x.ProductVariant.price + "");
                objcell.Add(x.ProductVariant.id_Product + "");
                objcell.Add(x.ProductVariant.id_Variant + "");
                DGV_TKSanPham.Rows.Add(objcell.ToArray());

            }
            _lstProductDetail.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            List<DTTam> lstidPV = new List<DTTam>();

            if (radioButton1.Checked == true)
            {
                foreach (var x in tKSanPham._getListOrderDetails())
                {
                    DTTam tenbien = new DTTam(x.id_Product, x.id_Variant);
                    lstidPV.Add(tenbien);
                }

                foreach (var x in lstidPV)
                {
                    var tenbien1 = _SP.LoadDatafromDAL()
                        .Where(c => c.Product.id_Product == x.A && c.ProductVariant.id_Variant == x.B).FirstOrDefault();
                    _lstProductDetail.Add(tenbien1);
                }
                //_lstProductDetail = _SP.LoadDatafromDAL()
                //    .Where(c => c.Product.id_Product == a && c.ProductVariant.id_Variant == t).ToList();
                loadDataTatCa(_lstProductDetail);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<DTTam> lstidPV = new List<DTTam>();
            if (radioButton2.Checked == true)
            {
                foreach (var x in tKSanPham._getListOrderDetails())
                {
                    DTTam tenbien = new DTTam(x.id_Product, x.id_Variant);
                    lstidPV.Add(tenbien);
                }

                foreach (var x in lstidPV.GroupBy(c => c.B).ToList())
                {
                    //var tenbien1 = _SP.LoadDatafromDAL()
                    //    .Where(c => c.Product.id_Product == x.A && c.ProductVariant.id_Variant == x.B).FirstOrDefault();
                    //_lstProductDetail.Add(tenbien1);
                }
                //_lstProductDetail = _SP.LoadDatafromDAL()
                //    .Where(c => c.Product.id_Product == a && c.ProductVariant.id_Variant == t).ToList();
              //  loadDataTatCa();

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                List<ProductDetail> akaThiCHAnNhau = new List<ProductDetail>();
                akaThiCHAnNhau = _lsSPban;
                List<int> nhau = new List<int>();
                tKSanPham._getListOrderDetails();
                foreach (var VARIABLE in tKSanPham._getListOrderDetails())
                {
                    int ThichRuou = VARIABLE.id_Variant;
                    nhau.Add(ThichRuou);// timg ID sản phẩm đã được bán
                }
                foreach (var VARIABLE in nhau )
                {
                    int aFindIndex = akaThiCHAnNhau.FindIndex(c =>
                       c.ProductVariant.id_Variant == VARIABLE); // tìm vị trí sản phẩm đã được bán trong danh sách sản phẩm
                    akaThiCHAnNhau.RemoveAt(aFindIndex);// xóa sản phẩm đã được bán
                }
                loadDataTatCa(akaThiCHAnNhau);
                akaThiCHAnNhau.Clear();
                
            }
        }
    }
}
