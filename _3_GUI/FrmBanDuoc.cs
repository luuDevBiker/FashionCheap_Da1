using _2_BUS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FrmBanDuoc : Form
    {
        public FrmBanDuoc(List<Order_OrderDetail> lst)
        {
            InitializeComponent();
            loadData(lst);
        }
        private void loadData(List<Order_OrderDetail> lst)
        {
            dgvSanPhamBanDuoc.ColumnCount = 3;
            var row = 0;
            dgvSanPhamBanDuoc.Columns[row++].Name = "Tên sản phẩm";
            dgvSanPhamBanDuoc.Columns[row++].Name = "Mã Sản phẩm";
            dgvSanPhamBanDuoc.Columns[row++].Name = "Số lượng";
            dgvSanPhamBanDuoc.Rows.Clear();
            var countProduct = lst.Sum(x => x.OrderDetail.quantity);
            lst.ForEach(x =>
            {
                dgvSanPhamBanDuoc.Rows.Add(
                    x.ProductDetail.Product.products_Name,
                    x.ProductDetail.ProductVariant.Products_Code,
                    countProduct
                    );
            });
        }
    }
}
