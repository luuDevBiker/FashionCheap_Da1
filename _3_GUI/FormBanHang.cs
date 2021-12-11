using _2_BUS.IService_BUS;
using _2_BUS.Service_BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.Models;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;


namespace _3_GUI
{
    public partial class FormBanHang : Form
    {
        private IQLOrderService _iQLOrder;
        private IQLCustomerService _iqLCustomer;
        private IProduct_Service _iproduct_Service;
        private List<ORDERS> _lstOrders;
        private List<ORDER_DETAILS> _lstOrder_Details;
        private IQLCustomerService _lstCustomerService;
        private IQLEmployeesService _iqLEmployees;
        // private IOderDetailService _lstOderDetailService;
        private IQLOrderService _lsOrderService;
        private List<CUSTOMERS> _lstcustomerses;
        private List<EMPLOYEES> _lstEmployeeses;
        private List<PRODUCTS> _lstProducts;
        private List<PRODUCTS_VARIANTS> _lstProducts_variants;
        private List<VARIANTS_VALUES> _lstVariants_values;
        private List<PRODUCTS_OPTIONS> _lstProducts_option;
        private List<ProductDetail> _lstProductDetails;
        private IOderService _iQlOrderService;
        private IOderDetailService _lstOderDetailService;
        public string email = FormDangNhap.email;
        private int toancuc;
        private string _idhoadon;
        private int whenClick;
        private TinhTien _Tinhtien;
        private int tong;
        private string _id;
        private bool checkGiohang = false;
        private IProduct_Service PS_BUS;

        //private List<OPTIONS> _lstOptions;
        //private List<OPTIONS_VALUES> _lstOption_values;
        public FormBanHang()
        {
            InitializeComponent();
            _iQLOrder = new QLOrDerService();
            _iqLCustomer = new QLCustomerService();
            PS_BUS = new Service_formSP();
            _lstOrders = new List<ORDERS>();
            _lstOrder_Details = new List<ORDER_DETAILS>();
            _lstCustomerService = new QLCustomerService();
            _iqLEmployees = new QLEmployessService();
            _lstProducts = new List<PRODUCTS>();
            _lsOrderService = new QLOrDerService();
            _lstcustomerses = new List<CUSTOMERS>();
            _lstOderDetailService = new ORDER_DETAILS_Service();
            _Tinhtien = new TinhTien();
            _lstEmployeeses = new List<EMPLOYEES>();
            _lstProducts_variants = new List<PRODUCTS_VARIANTS>();
            _lstVariants_values = new List<VARIANTS_VALUES>();
            _lstProducts_option = new List<PRODUCTS_OPTIONS>();
            _lstProductDetails = new List<ProductDetail>();
            _iQlOrderService = new ORDERS_Service();
            _iproduct_Service = new Service_formSP();
            foreach (var x in _lstCustomerService.GetlstCustomerses())
            {
                cbxTenKhachhang.Items.Add(x.customer_Name);
                cbxTenKhachhang.SelectedIndex = 0;
            }
            txtMaNhanVien.Text = Convert.ToString(_iqLEmployees.GetlstEmployeeses().Where(c => c.Email == email).Select(c => c.id_Employee).FirstOrDefault());
            foreach (var x in _lstCustomerService.GetlstCustomerses())
            {
                cbxKhachHang1.Items.Add(x.customer_Name);
                cbxKhachHang1.SelectedIndex = 0;
            }
            txtMaNhanVien.Text = Convert.ToString(_iqLEmployees.GetlstEmployeeses().Where(c => c.Email == email).Select(c => c.id_Employee).FirstOrDefault());
            loadSP();
            LoadGioHang();
            loadHoaDonCho();
            cbxPhuongThucThanhToan.Items.Add("ATM");
            cbxPhuongThucThanhToan.Items.Add("Tiền mặt");
            cbxPhuongThucThanhToan.SelectedIndex = 0;
            dgrid_sp.Enabled = false;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();


        }

        void loadSP()
        {
            dgrid_sp.ColumnCount = 6;
            var row = 0;
            dgrid_sp.Columns[0].Name = "ID_Product";
            dgrid_sp.Columns["ID_Product"].Visible = false;
            dgrid_sp.Columns[1].Name = "ID_Variant";
            dgrid_sp.Columns["ID_Variant"].Visible = false;
            dgrid_sp.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_sp.Columns[3].Name = "Mã Sản Phẩm";
            dgrid_sp.Columns[4].Name = "Giá Bán";
            dgrid_sp.Columns[5].Name = "Tồn Kho";
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "select";
                button.HeaderText = "select";
                button.Text = ("select");
                button.UseColumnTextForButtonValue = true;
                this.dgrid_sp.Columns.Add(button);
            }
            dgrid_sp.Rows.Clear();

            foreach (var x in PS_BUS.LoadDatafromDAL())
            {
                List<string> objcell = new List<string>();
                objcell.Add(Convert.ToString(x.Product.id_Product));
                objcell.Add(Convert.ToString(x.ProductVariant.id_Variant));
                objcell.Add(x.Product.products_Name);
                objcell.Add(x.ProductVariant.Products_Code);
                objcell.Add(x.ProductVariant.price + "");
                objcell.Add(x.ProductVariant.quantity + "");

                dgrid_sp.Rows.Add(objcell.ToArray());


            }
        }

        void LoadGioHang()
        {
            dgrid_giohang.ColumnCount = 6;
            var row = 0;
            dgrid_giohang.Columns[row].Name = "ID_Product";
            dgrid_giohang.Columns[row++].Visible = false;
            dgrid_giohang.Columns[row].Name = "ID_Variant";
            dgrid_giohang.Columns[row].Visible = false;
            dgrid_giohang.Columns[row++].Name = "ID_Sku";
            dgrid_giohang.Columns[row++].HeaderText = "Mã sản phẩm";
            dgrid_giohang.Columns[row].Name = "quantity";
            dgrid_giohang.Columns[row++].HeaderText = "Số Lượng";
            dgrid_giohang.Columns[row].Name = "price";
            dgrid_giohang.Columns[row++].HeaderText = "Đơn Giá";
            dgrid_giohang.Columns[row].Name = "total_Pay";
            dgrid_giohang.Columns[row++].HeaderText = "Tổng Tiền";
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "Delete";
                button.HeaderText = "Delete";

                button.Text = ("Delete");
                button.UseColumnTextForButtonValue = true;
                dgrid_giohang.Columns.Add(button);
            }
            dgrid_giohang.Rows.Clear();
            foreach (var x in _lstProductDetails)
            {
                List<string> objcell = new List<string>();
                objcell.Add(x.Product.id_Product+"");
                objcell.Add(x.ProductVariant.id_Variant+"");
                objcell.Add(x.ProductVariant.Products_Code);
                objcell.Add(x.ProductVariant.quantity + "");
                objcell.Add(x.ProductVariant.price + "");
                objcell.Add(Convert.ToString(x.ProductVariant.price * x.ProductVariant.quantity));

                dgrid_giohang.Rows.Add(objcell.ToArray());
            }
            float sum = _lstProductDetails.Sum(x => x.ProductVariant.quantity * x.ProductVariant.price);
            tong = Convert.ToInt32(sum);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            txtTongTien.Text = sum.ToString("#,###", cul.NumberFormat);
            txtKhachCanTra.Text = sum.ToString("#,###", cul.NumberFormat);
            txtGiamGia.Text = 0.ToString("#,###", cul.NumberFormat);
        }

        void loadHoaDonCho()
        {
            Data_HoaDonCho.ColumnCount = 3;
            var row = 0;
            Data_HoaDonCho.Columns[row].Name = "Id_Order";
            Data_HoaDonCho.Columns[row++].Visible = false;
            Data_HoaDonCho.Columns[row].Name = "numberPhoneCustommer";
            Data_HoaDonCho.Columns[row++].HeaderText = "Số điện thoại khách Hàng";
            Data_HoaDonCho.Columns[row].Name = "Id_Employee";
            Data_HoaDonCho.Columns[row++].HeaderText = "Mã nhân viên";
            Data_HoaDonCho.Rows.Clear();
            var lst = _iQlOrderService.getListORDERS().Where(c => c.order_status != 1).ToList();
            foreach (var x in lst)
            {
                Data_HoaDonCho.Rows.Add(
                    x.id_Order,
                    _iqLCustomer.GetlstCustomerses().Where(c => c.id_Customer == x.id_Customer).Select(c => c.numberPhone).FirstOrDefault(),
                    "NV-NTXZ " + x.id_Employee
                    );
            }
        }


        private void dgrid_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == dgrid_sp.Columns["select"].Index)
            {
                int a = Convert.ToInt32(dgrid_sp.Rows[row].Cells["ID_Product"].Value.ToString());
                int b = Convert.ToInt32(dgrid_sp.Rows[row].Cells["ID_Variant"].Value.ToString());
                ProductDetail productDetail = new ProductDetail();

                productDetail = PS_BUS.LoadDatafromDAL().FirstOrDefault(c => c.Product.id_Product == a &&
                                                                             c.ProductVariant.id_Variant == b);
                var checkitem = _lstProductDetails.FindIndex(c => c.Product.id_Product == a &&
                                                                  c.ProductVariant.id_Variant == b);
                if (checkitem < 0)
                {
                    productDetail.ProductVariant.quantity = 1;
                    var x = productDetail;
                    _lstProductDetails.Add(x);

                }
                else
                {
                    _lstProductDetails[checkitem].ProductVariant.quantity = _lstProductDetails[checkitem].ProductVariant.quantity += 1;
                }
                LoadGioHang();
            }
        }

        private void validate()
        {
            txtGiamGia.Text = txtGiamGia.Text.Length == 0 ? "0" : txtGiamGia.Text;
            txtKhachCanTra.Text = txtKhachCanTra.Text.Length == 0 ? "0" : txtKhachCanTra.Text;
            txtKhachThanhToan.Text = txtKhachThanhToan.Text.Length == 0 ? "0" : txtKhachThanhToan.Text;
            txtSoTienHoanLai.Text = txtSoTienHoanLai.Text.Length == 0 ? "0" : txtSoTienHoanLai.Text;
            txtTongTien.Text = txtTongTien.Text.Length == 0 ? "0" : txtTongTien.Text;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            validate();
            var idKh = _iqLCustomer.GetlstCustomerses().Where(c => c.customer_Name == cbxTenKhachhang.Text)
                .Select(c => c.id_Customer).FirstOrDefault();
            var idnv = _iqLEmployees.GetlstEmployeeses().Where(c => c.id_Employee == Convert.ToInt32(txtMaNhanVien.Text))
                .Select(c => c.id_Employee).FirstOrDefault();
            ORDERS orders = new ORDERS();
            orders.id_Customer = idKh;
            orders.id_Employee = 2;
            //orders.id_Employee = idnv;
            orders.order_Time = Convert.ToDateTime(DateTime.Now);
            orders.discount = int.Parse(txtGiamGia.Text);
            orders.refunds = int.Parse(txtSoTienHoanLai.Text);
            orders.amount_Pay = int.Parse(txtTongTien.Text);
            orders.paying_Customer = int.Parse(txtKhachThanhToan.Text);
            orders.total_pay = int.Parse(txtKhachCanTra.Text);
            orders.payments = cbxPhuongThucThanhToan.Text;
            orders.order_status = 0;
            orders.status = ".";
            orders.status_Delete = false;
            //or.AddORDERS(orders);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQLOrder.add(orders);
                MessageBox.Show(_iQLOrder.Save());
                _lstOrders = _iQLOrder.GetlstOrderses();
            }
            loadHoaDonCho();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var ls = _iQlOrderService.getListORDERS().Where(c => c.id_Order == Convert.ToInt32(toancuc)).FirstOrDefault();
            ls.order_status = 1;
            _iQlOrderService.EditORDERS(ls);
            _iQlOrderService.SaveORDERS();
            for (int i = 0; i < dgrid_giohang.Rows.Count; i++)
            {
                var row = dgrid_giohang.Rows[i];
                ORDER_DETAILS orderDetails = new ORDER_DETAILS();
                orderDetails.id_Order = toancuc;
                orderDetails.id_Product = int.Parse(row.Cells[0].Value + "");
                orderDetails.id_Variant = int.Parse(row.Cells[1].Value + "");
                orderDetails.quantity = int.Parse(row.Cells[3].Value + "");
                orderDetails.unit_Price = int.Parse(row.Cells[4].Value + "");
                orderDetails.price_Each = int.Parse(row.Cells[5].Value + "");
                orderDetails.Discount = 0;
                orderDetails.status_Delete = false;
                _lstOderDetailService.AddORDER_DETAILS(orderDetails);
                var producDetail = new ProductDetail();
                producDetail.ProductVariant.id_Variant = int.Parse(row.Cells[1].Value + "");
                producDetail.ProductVariant.quantity = int.Parse(row.Cells[3].Value + "");
                producDetail.Product.id_Product = int.Parse(row.Cells[0].Value + "");
                PS_BUS.updateQuantity(producDetail);
            }
            MessageBox.Show(_lstOderDetailService.SaveORDER_DETAILS(), "Thông Báo");
            LoadGioHang();
            loadHoaDonCho();
            loadSP();
            dgrid_sp.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = printDocument1;
            //DialogResult result = printDialog1.ShowDialog();
            //if (result == DialogResult.OK) ;
            //{
            //    printDocument1.Print();
            //}
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "" + _iQLOrder.JoinTable().Select(x => x.ProductDetail.Product.id_Product).FirstOrDefault() + "",
                "Thông báo");
            EMPLOYEES employees = new EMPLOYEES();
            employees.address = tbxDiaChi.Text;
            employees.NumberPhone = tbxSdt.Text;

            MessageBox.Show("Bạn có muốn in hóa đơn không", "Có");
        }

        void loadataSearch(string Tensp)
        {
            PS_BUS.LoadDatafromDAL();
            dgrid_sp.ColumnCount = 6;
            var row = 0;
            dgrid_sp.Columns[0].Name = "ID_Product";
            dgrid_sp.Columns["ID_Product"].Visible = false;
            dgrid_sp.Columns[1].Name = "ID_Variant";
            dgrid_sp.Columns["ID_Variant"].Visible = false;
            dgrid_sp.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_sp.Columns[3].Name = "Mã Sản Phẩm";
            dgrid_sp.Columns[4].Name = "Giá Bán";
            dgrid_sp.Columns[5].Name = "Tồn Kho";
            foreach (var x in PS_BUS.LoadDatafromDAL())
            {
                dgrid_sp.Rows.Add(x.Product, x.ProductVariant);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hóa Đơn Bán ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(10, 10));
            e.Graphics.DrawString("" + "Tên Khách Hàng :" + Convert.ToString(cbxTenKhachhang.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("" + "Mã Nhân Viên :" + Convert.ToString(txtMaNhanVien.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("" + "Ngày Tạo :" + Convert.ToString(DateNgayTao.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("" + "Tổng Tiền :" + Convert.ToString(txtTongTien.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("" + "Khách Cần Trả  :" + Convert.ToString(txtKhachCanTra.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("" + "Khách Thanh Toán :" + Convert.ToString(txtKhachThanhToan.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("" + "Số Tiền Hoàn Lại :" + Convert.ToString(txtSoTienHoanLai.Text) + "", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("OFFICE ADDRESS", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 150));
        }

        private void tabPage1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                txtSoTienHoanLai.Text = int.Parse(txtKhachThanhToan.Text.Split(" ")[0]) - int.Parse(txtTongTien.Text) + "";
                txtKhachCanTra.Text = int.Parse(txtTongTien.Text.Split(" ")[0]) - int.Parse(txtGiamGia.Text.Split(" ")[0]) + "";
            }
            catch
            {
                return;
            }
        }

        private void Data_HoaDonCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgrid_giohang.Rows.Clear();
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            toancuc = Convert.ToInt32(Data_HoaDonCho.Rows[index].Cells[0].Value.ToString());
            dgrid_sp.Enabled = true;
        }

        private void dgrid_giohang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var row = dgrid_giohang.Rows[index];
            var id_Product = int.Parse(row.Cells[0].Value + "");
            var id_Variant = int.Parse(row.Cells[1].Value + "");
            var productDetail = PS_BUS.LoadDatafromDAL().Where(x => x.ProductVariant.id_Product == id_Product
                && x.ProductVariant.id_Product == id_Product)
                .FirstOrDefault();
            var quantity = int.Parse(row.Cells[3].Value + "");
            var quantityInCart = PS_BUS.LoadDatafromDAL().Where(x => x.ProductVariant.id_Product == id_Product
                && x.ProductVariant.id_Product == id_Product).Select(x => x.ProductVariant.quantity).FirstOrDefault();
            if (quantity > quantityInCart)
            {
                MessageBox.Show($"Số lượng trong kho không đủ !","Cảnh báo");
            }
            productDetail.ProductVariant.quantity = quantity;
            LoadGioHang();   
        }

        private void dgrid_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var indexRow = e.RowIndex;
            var indexColumn = e.ColumnIndex;
            var row = dgrid_giohang.Rows[indexRow];
            var id_Product = int.Parse(row.Cells[0].Value + "");
            var id_Variant = int.Parse(row.Cells[1].Value + "");
            if (indexColumn == 6)
            {
                var address = _lstProductDetails.FindIndex(x => x.ProductVariant.id_Product == id_Product
                    && x.ProductVariant.id_Variant == id_Variant);
                _lstProductDetails.RemoveAt(address);
            }
            LoadGioHang();
        }
    }
}