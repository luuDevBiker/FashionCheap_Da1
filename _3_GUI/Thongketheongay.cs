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

namespace _3_GUI
{
    public partial class FrmThongketheongay : Form
    {
        private IQLOrderService _iQLOrder;
        private List<Order_OrderDetail> _lstItem;
        public FrmThongketheongay()
        {
            InitializeComponent();
            _iQLOrder = new QLOrDerService();
            _lstItem = _iQLOrder.JoinTable();
        }
        private void loadData()
        {
            dgvTkNgay.ColumnCount = 7;
            var row = 0;
            dgvTkNgay.Columns[row].Name = "ID_Order";
            dgvTkNgay.Columns[row++].Visible = false;
            dgvTkNgay.Columns[row++].Name = "Ngày";
            dgvTkNgay.Columns[row++].Name = "Mã khách hàng";
            dgvTkNgay.Columns[row++].Name = "Mã nhân viên";
            dgvTkNgay.Columns[row++].Name = "Thành tiền";
            dgvTkNgay.Columns[row++].Name = "Trạng thái";
            dgvTkNgay.Columns[row++].Name = "Note";
            dgvTkNgay.Rows.Clear();
            dgvSpHD.Rows.Clear();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "Detail";
                button.HeaderText = "Detail";
                button.Text = ("Detail");
                button.UseColumnTextForButtonValue = true;
                this.dgvTkNgay.Columns.Add(button);
            }
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
            var lstItem = _lstItem.GroupBy(x => x.Order.order_Time).Select(i => i.First()).ToList();
            lstItem.ForEach(x =>
            {
                dgvTkNgay.Rows.Add(x.Order.id_Order, x.Order.order_Time, x.Customer.numberPhone, x.Employee.id_Employee, x.Order.total_pay, x.Order.order_status == 0 ? "Đã thanh toán " : "Đã hủy", x.Order.status);
            });
        }

        private void dgvTkNgay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSpHD.ColumnCount = 5;
            var row = 0;
            dgvSpHD.Columns[row++].Name = "Tên sản phẩm";
            dgvSpHD.Columns[row++].Name = "Mã sản phẩm";
            dgvSpHD.Columns[row++].Name = "Số lượng";
            dgvSpHD.Columns[row++].Name = "Giá";
            dgvSpHD.Columns[row++].Name = "Thành tiền";
            dgvSpHD.Rows.Clear();
            var index = e.RowIndex;
            var indexColumn = e.ColumnIndex;
            var lstPr = _iQLOrder.getProduct();
            
            if (index < 0) return;
            if (indexColumn == 7)
            {
                var id_order = dgvTkNgay.Rows[index].Cells[0].Value + "";
                var lstOrderDetail = _lstItem.Where(x => x.Order.id_Order == int.Parse(id_order)).ToList();
                var productvv = _lstItem.Select(x => x.ProductDetail).ToList();
                lstOrderDetail.ForEach(x =>
                {
                    var name = lstPr.Where(z => z.id_Product == x.OrderDetail.id_Product).First();
                    var code = productvv.Where(z => z.ProductVariant.id_Variant == x.OrderDetail.id_Variant).First();
                    dgvSpHD.Rows.Add(
                        name.products_Name,
                        code.ProductVariant.Products_Code,
                        x.OrderDetail.quantity,
                        x.OrderDetail.price_Each,
                        x.OrderDetail.quantity * x.OrderDetail.price_Each);
                });

            }

        }

        private void rdbDaGiao_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
            var lstItem = _lstItem.Where(i=>i.Order.order_status == 0).GroupBy(x => x.Order.order_Time).Select(i => i.First()).ToList();
            lstItem.ForEach(x =>
            {
                dgvTkNgay.Rows.Add(x.Order.id_Order, x.Order.order_Time, x.Customer.numberPhone, x.Employee.id_Employee, x.Order.total_pay, x.Order.order_status == 0 ? "Đã thanh toán " : "Đã hủy", x.Order.status);
            });
        }

        private void rdbDaHuy_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
            var lstItem = _lstItem.Where(i => i.Order.order_status == 1).GroupBy(x => x.Order.order_Time).Select(i => i.First()).ToList();
            lstItem.ForEach(x =>
            {
                dgvTkNgay.Rows.Add(x.Order.id_Order, x.Order.order_Time, x.Customer.numberPhone, x.Employee.id_Employee, x.Order.total_pay, x.Order.order_status == 0 ? "Đã thanh toán " : "Đã hủy", x.Order.status);
            });
        }

        private void btnLocHoadon_Click(object sender, EventArgs e)
        {
            var time = mcloc.SelectionRange.Start.ToString().Split(" ")[0];
            loadData();
            if (rdbAll.Checked)
            {
                var lstItem = _lstItem.Where(i => i.Order.order_Time.ToString().Split(" ")[0] == time).GroupBy(x => x.Order.order_Time).Select(i => i.First()).ToList();
                lstItem.ForEach(x =>
                {
                    dgvTkNgay.Rows.Add(x.Order.id_Order, x.Order.order_Time, x.Customer.numberPhone, x.Employee.id_Employee, x.Order.total_pay, x.Order.order_status == 0 ? "Đã thanh toán " : "Đã hủy", x.Order.status);
                });
            }
            if (rdbDaGiao.Checked)
            {
                var lstItem = _lstItem.Where(i => i.Order.order_status == 0 && i.Order.order_Time.ToString().Split(" ")[0] == time).GroupBy(x => x.Order.order_Time).Select(i => i.First()).ToList();
                lstItem.ForEach(x =>
                {
                    dgvTkNgay.Rows.Add(x.Order.id_Order, x.Order.order_Time, x.Customer.numberPhone, x.Employee.id_Employee, x.Order.total_pay, x.Order.order_status == 0 ? "Đã thanh toán " : "Đã hủy", x.Order.status);
                });
            }
            if (rdbDaHuy.Checked)
            {
                var lstItem = _lstItem.Where(i => i.Order.order_status == 1 && i.Order.order_Time.ToString().Split(" ")[0] == time).GroupBy(x => x.Order.order_Time).Select(i => i.First()).ToList();
                lstItem.ForEach(x =>
                {
                    dgvTkNgay.Rows.Add(x.Order.id_Order, x.Order.order_Time, x.Customer.numberPhone, x.Employee.id_Employee, x.Order.total_pay, x.Order.order_status == 0 ? "Đã thanh toán " : "Đã hủy", x.Order.status);
                });
            }
        }
    }
}

