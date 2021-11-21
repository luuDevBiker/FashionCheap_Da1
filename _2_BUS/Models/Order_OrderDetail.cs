using DAL_DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Models
{
    public class Order_OrderDetail
    {
        public ORDERS Order{ get; set; }
        public ORDER_DETAILS OrderDetail{ get; set; }
        public CUSTOMERS Customer { get; set; }
        public EMPLOYEES Employee { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public bool Status { get; set; }

        public Order_OrderDetail()
        {
            Order = new ORDERS();
            OrderDetail = new ORDER_DETAILS();
            Customer = new CUSTOMERS();
            Employee = new EMPLOYEES();
            ProductDetail = new ProductDetail();
        }

        public Order_OrderDetail(ORDERS order, ORDER_DETAILS orderDetail, CUSTOMERS customer, EMPLOYEES employee, bool status,ProductDetail productDetail)
        {
            Order = order;
            OrderDetail = orderDetail;
            Customer = customer;
            Employee = employee;
            Status = status;
            ProductDetail = productDetail;
        }
    }
}
