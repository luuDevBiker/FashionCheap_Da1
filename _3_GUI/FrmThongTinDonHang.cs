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
    public partial class FrmThongTinDonHang : Form
    {
        private List<Order_OrderDetail> _lstOrderDetail;
        public FrmThongTinDonHang(List<Order_OrderDetail> lst, int option)
        {
            InitializeComponent();
            _lstOrderDetail = lst;
            if (option == 3)
            {
                loadDataDonHuy(lst);
            }
            else if (option == 2)
            {
                loadDataSanPhamBanDuoc(lst);
            }
            else if (option == 1)
            {
                loadDataSoDonBanDuoc(lst);
            }
        }

        private void loadDataDonHuy(List<Order_OrderDetail> lst)
        {
            dgvDonHuy.ColumnCount = 5;
            var row = 0;
            dgvDonHuy.Columns[row++].Name = "Mã nhân viên";
            dgvDonHuy.Columns[row++].Name = "Tên nhân viên";
            dgvDonHuy.Columns[row++].Name = "Số điện thoại khách hàng";
            dgvDonHuy.Columns[row++].Name = "Tên khách hàng";
            dgvDonHuy.Columns[row++].Name = "Note";
            dgvDonHuy.Rows.Clear();

            lst.ForEach(x =>
            {
                dgvDonHuy.Rows.Add(x.Employee.id_Employee, x.Employee.employee_Name, x.Customer.numberPhone, x.Customer.customer_Name, x.Order.status);
            });
        }
        private void loadDataSanPhamBanDuoc(List<Order_OrderDetail> lst)
        {
            dgvDonHuy.ColumnCount = 3;
            var row = 0;
            dgvDonHuy.Columns[row++].Name = "Tên sản phẩm";
            dgvDonHuy.Columns[row++].Name = "Mã Sản phẩm";
            dgvDonHuy.Columns[row++].Name = "Số lượng";
            dgvDonHuy.Rows.Clear();
            var countProduct = lst.Sum(x => x.OrderDetail.quantity);
            lst.ForEach(x =>
            {
                dgvDonHuy.Rows.Add(
                    x.ProductDetail.Product.products_Name,
                    x.ProductDetail.ProductVariant.Products_Code,
                    countProduct
                    );
            });
        }
        private void loadDataSoDonBanDuoc(List<Order_OrderDetail> lst)
        {
            dgvDonHuy.ColumnCount = 5;
            var row = 0;
            dgvDonHuy.Columns[row++].Name = "Mã nhân viên";
            dgvDonHuy.Columns[row++].Name = "Tên nhân viên";
            dgvDonHuy.Columns[row++].Name = "Số điện thoại khách hàng";
            dgvDonHuy.Columns[row++].Name = "Tên khách hàng";
            dgvDonHuy.Columns[row++].Name = "Note";
            dgvDonHuy.Rows.Clear();

            lst.ForEach(x =>
            {
                dgvDonHuy.Rows.Add(x.Employee.id_Employee, x.Employee.employee_Name, x.Customer.numberPhone, x.Customer.customer_Name, x.Order.status);
            });
        }
    }
}
