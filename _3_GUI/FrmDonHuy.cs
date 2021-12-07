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
    public partial class FrmDonHuy : Form
    {
        private List<Order_OrderDetail> _lstOrderDetail;
        public FrmDonHuy(List<Order_OrderDetail> lst)
        {
            InitializeComponent();
            _lstOrderDetail = lst;
            loadData(lst);
        }
        private void loadData(List<Order_OrderDetail> lst)
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
