using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IService_BUS;
using _2_BUS.Models;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;

namespace _2_BUS.Service_BUS
{
    public class QLOrDerService : IQLOrderService
    {
        private IOderDetailService _iQlOrderDetailService;
        private IOderService _iQlOrderService;
        private IProduct_Service _iQlProduct;
        private IEmployeeService _iEmployee;
        private ICustomerService _iCustomer;
        private IProductService _iProductService;
        public List<CUSTOMERS> _lstCustomer;
        public List<EMPLOYEES> _lstEmployee;
        private List<ORDERS> _lstOrderses;
        private List<ORDER_DETAILS> _lstOrderDetailses;
        public List<Order_OrderDetail> _lstOrder_OrderDetail;
        public List<ProductDetail> _lstProductDetail;
        private IProductVariantservice _iProductVariant;
        public static bool _statusSave = true;

        public QLOrDerService()
        {
            _iProductService = new Product_Service();
            _iCustomer = new CUSTOMERS_Service();
            _iQlOrderService = new ORDERS_Service();
            _iQlOrderDetailService = new ORDER_DETAILS_Service();
            _lstOrder_OrderDetail = new List<Order_OrderDetail>();
            _iQlProduct = new Service_formSP();
            _iEmployee = new EMPLOYEES_Service();
            _iProductVariant = new ProductsVariants_Service();
            _lstCustomer = _iCustomer.getListORDERS();
            _lstEmployee = _iEmployee.getListEMPLOYEES();
            _lstProductDetail = _iQlProduct.LoadDatafromDAL();
            _lstOrderses = _iQlOrderService.getListORDERS();
            _lstOrderDetailses = _iQlOrderDetailService.getListORDERS();
            GetDb();
            JoinTable();
        }

        public List<Order_OrderDetail> JoinTable()
        {
            var lst = _lstOrderDetailses
                .Join(_lstOrderses, od => od.id_Order, o => o.id_Order, (od, o) => new { o, od })
                .Join(_lstCustomer, i => i.o.id_Customer, ct => ct.id_Customer, (i, ct) => new { i.o, i.od, ct })
                .Join(_lstEmployee, i => i.o.id_Employee, e => e.id_Employee, (i, e) => new { i.o, i.od, i.ct, e })
                .Join(_lstProductDetail, i => (i.od.id_Product, i.od.id_Variant), pd => (pd.Product.id_Product, pd.ProductVariant.id_Variant), (i, pd) => new { i.od, i.o, i.e, i.ct, pd })
                .ToList();
            _lstOrder_OrderDetail.Clear();
            lst.ForEach(x =>
            {
                Order_OrderDetail item = new Order_OrderDetail();
                item.Customer = x.ct;
                item.Employee = x.e;
                item.Order = x.o;
                item.OrderDetail = x.od;
                item.ProductDetail = x.pd;
                item.Status = true;
                _lstOrder_OrderDetail.Add(item);
            });
            return _lstOrder_OrderDetail;
        }





        public string add(ORDERS orders)
        {
            _statusSave = false;
            _lstOrderses.Add(orders);
            return _iQlOrderService.AddORDERS(orders);
        }

        public string EditHd(ORDERS orders)
        {
            return null;

        }

        public string Remove(ORDERS orders)
        {
            return null;
        }

        public string Save()
        {
            _statusSave = true;
            return _iQlOrderService.SaveORDERS();
        }


        public List<ORDERS> Search(string ten)
        {
            return null;
        }

        public List<ORDERS> GetlstOrderses()
        {
            return _iQlOrderService.getListORDERS();

        }
        public void GetDb()
        {

        }

        List<ORDERS> IQLOrderService.GetlstOrderses()
        {
            return null;
        }

        public List<PRODUCTS_VARIANTS> getListProduct()
        {
            return _iProductVariant.getListProductses();
        }

        public List<PRODUCTS> getProduct()
        {
            var lst = _iProductService.getListProductses();
            return lst;
        }
    }
}
