using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.IService_BUS;
using _2_BUS.Service_BUS;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;

namespace _3_GUI
{
    public partial class FrmHoaDon : Form
    {
        private IQLOrderService _iQLOrder;
        private IQLCustomerService _iqLCustomer;
        private IQLEmployeesService _iqLEmployees;
        private IProductService _iqlProductService;
        private List<CUSTOMERS> _lstcustomerses;
        private List<EMPLOYEES> _lstEmployeeses;
        private List<VARIANTS_VALUES> _lsVariantsValueses;
        private List<ORDERS> _lstOrderses;
        private List<ORDER_DETAILS> _lstOrderDetailses;
        private List<PRODUCTS_VARIANTS> _lstProductsVariantses;
        private List<PRODUCTS> _lstProductses;
        private IOderService or = new ORDERS_Service();
        private IOderService _iOderService;
        private IQLCustomerService _lstCustomerService;
        public string email = FormDangNhap.email;

        private int id_Hoadon;
        public FrmHoaDon()
        {
            InitializeComponent();
            _lstcustomerses = new List<CUSTOMERS>();
            _lstEmployeeses = new List<EMPLOYEES>();
            _lsVariantsValueses = new List<VARIANTS_VALUES>();
            _lstOrderses = new List<ORDERS>();
            _lstCustomerService = new QLCustomerService();
            _lstOrderDetailses = new List<ORDER_DETAILS>();
            _lstProductsVariantses = new List<PRODUCTS_VARIANTS>();
            _lstProductses = new List<PRODUCTS>();
            _iQLOrder = new QLOrDerService();
            _iqLCustomer = new QLCustomerService();
            _iqLEmployees = new QLEmployessService();
            _iOderService = new ORDERS_Service();
            _iqlProductService = new Product_Service();
            // _lstCustomerService = new QLCustomerService();
            foreach (var x in _lstCustomerService.GetlstCustomerses())
            {
                cbxKhachHang.Items.Add(x.customer_Name);
                cbxKhachHang.SelectedIndex = 0;
            }
            tbxNvThanhToan.Text = Convert.ToString(_iqLEmployees.GetlstEmployeeses().Where(c => c.Email == email).Select(c => c.id_Employee).FirstOrDefault());
            loadata();
        }
        
        private void tbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (tbDark.Checked)
            {
                this.BackColor = Color.Pink;

            }
            else
            {
                this.BackColor = Color.White;

            }
        }
        void loadata()
        {
            Data_HoaDon.ColumnCount = 14;
            Data_HoaDon.Columns[0].Name = "Id";
            Data_HoaDon.Columns[0].Visible = false;
            Data_HoaDon.Columns[1].Name = "Sản Phẩm";
            Data_HoaDon.Columns[2].Name = "Số Lượng";
            Data_HoaDon.Columns[3].Name = "Nhân Viên Thanh Toán";
            Data_HoaDon.Columns[4].Name = "Khách Hàng";
            Data_HoaDon.Columns[5].Name = "Ngày Mua Hàng";
            Data_HoaDon.Columns[6].Name = "Số Tiền Phải Trả";
            Data_HoaDon.Columns[7].Name = "Số Tiền Khách Đưa";
            Data_HoaDon.Columns[8].Name = "Số Tiền Hoàn Lại";
            Data_HoaDon.Columns[9].Name = "Giảm Giá";
            Data_HoaDon.Columns[10].Name = "Chiết Khấu";
            Data_HoaDon.Columns[11].Name = "Thanh Toán";
            Data_HoaDon.Columns[12].Name = "Phương Thức Thanh Toán";
            Data_HoaDon.Columns[13].Name = "Trạng Thái";
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Add");
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                Data_HoaDon.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.Data_HoaDon.Columns.Add(button);
            }
            Data_HoaDon.Rows.Clear();
            //var lst = (from nv in _lstEmployeeses
            //           join hd in _lstOrderses on nv.id_Employee equals hd.id_Employee
            //           join kh in _lstcustomerses on hd.id_Customer equals kh.id_Customer
            //           join hdct in _lstOrderDetailses on hd.id_Order equals hdct.id_Order
            //           join sp in _lsVariantsValueses on hdct.id_Variant equals sp.id_Variant
            //           join spct in _lstProductsVariantses on sp.id_Variant equals spct.id_Variant
            //           join Sanpham in _lstProductses on spct.id_Product equals Sanpham.id_Product
            //           select new
            //           {
            //               id = hd.id_Order,
            //               SanPham = Sanpham.products_Name,
            //               SoLuong = sp.quantity,
            //               kh = kh.customer_Name,
            //               NGayMuaHang = hd.order_Time,
            //               SoTienPhaiTra = hd.amount_Pay,
            //               SoTienHoanLai = hd.refunds,
            //               GiamGia = hd.discount,
            //               ThanhToan = hd.payments,
            //           }).ToList();
            //foreach (var x in lst)
            //{
            //    Data_HoaDon.Rows.Add(x.id, x.SanPham, x.SoLuong, x.kh, x.NGayMuaHang, x.SoTienPhaiTra, x.SoTienHoanLai,
            //        x.GiamGia, x.ThanhToan);
            //}
        }
        void loadataSearch(string ten)
        {
            _iOderService.getListORDERS();
            Data_HoaDon.ColumnCount = 14;
            Data_HoaDon.Columns[0].Name = "Id";
            Data_HoaDon.Columns[0].Visible = false;
            Data_HoaDon.Columns[1].Name = "Sản Phẩm";
            Data_HoaDon.Columns[2].Name = "Số Lượng";
            Data_HoaDon.Columns[3].Name = "Nhân Viên Thanh Toán";
            Data_HoaDon.Columns[4].Name = "Khách Hàng";
            Data_HoaDon.Columns[5].Name = "Ngày Mua Hàng";
            Data_HoaDon.Columns[6].Name = "Số Tiền Phải Trả";
            Data_HoaDon.Columns[7].Name = "Số Tiền Khách Đưa";
            Data_HoaDon.Columns[8].Name = "Số Tiền Hoàn Lại";
            Data_HoaDon.Columns[9].Name = "Giảm Giá";
            Data_HoaDon.Columns[10].Name = "Chiết Khấu";
            Data_HoaDon.Columns[11].Name = "Thanh Toán";
            Data_HoaDon.Columns[12].Name = "Phương Thức Thanh Toán";
            Data_HoaDon.Columns[13].Name = "Trạng Thái";
            Data_HoaDon.Rows.Clear();
            //foreach (var x in )
            //{
            //    Data_HoaDon.Rows.Add(x.id, x.SanPham, x.SoLuong, x.kh, x.NGayMuaHang, x.SoTienPhaiTra, x.SoTienHoanLai,
            //        x.GiamGia, x.ThanhToan);
            //}
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
        }
        private void Data_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            id_Hoadon = int.Parse(Data_HoaDon.Rows[index].Cells[0].Value.ToString());
            var hoadon = _lstOrderses.Where(c => c.id_Order == id_Hoadon).FirstOrDefault();
            tbxSanPham.Text = Data_HoaDon.Rows[index].Cells[1].Value.ToString();
            tbxSoLuong.Text = Data_HoaDon.Rows[index].Cells[2].Value.ToString();
            tbxNvThanhToan.Text = Data_HoaDon.Rows[index].Cells[3].Value.ToString();
            cbxKhachHang.Text = Data_HoaDon.Rows[index].Cells[4].Value.ToString();
            datetimeNgayMuaHang.Text = Data_HoaDon.Rows[index].Cells[5].Value.ToString();
            tbxSoTienTra.Text = Data_HoaDon.Rows[index].Cells[6].Value.ToString();
            tbxSoTienDua.Text = Data_HoaDon.Rows[index].Cells[7].Value.ToString();
            tbxSoTienHoanLai.Text = Data_HoaDon.Rows[index].Cells[8].Value.ToString();
            tbxGiamGia.Text = Data_HoaDon.Rows[index].Cells[9].Value.ToString();
            tbxTrieuKhau.Text = Data_HoaDon.Rows[index].Cells[10].Value.ToString();
            tbxThanhToan.Text = Data_HoaDon.Rows[index].Cells[11].Value.ToString();
            tbxPhuongThucThanhToan.Text = Data_HoaDon.Rows[index].Cells[12].Value.ToString();
            //if (hoadon. ==. "Nam")
            //{
            //    cbxNam.Checked = true;
            //}
            //else
            //{
            //    cbxNu.Checked = true;
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //ORDER_DETAILS orderDetails = new ORDER_DETAILS();
            //orderDetails.quantity = Convert.ToInt32(tbxSoluong.Text);
            //orderDetails.Discount = tbxChietkhau.Text;
            ORDERS orders = new ORDERS();
            orders.id_Customer = _lstEmployeeses.Where(c => c.employee_Name == cbxKhachHang.Text)
                .Select(c => c.id_Employee).FirstOrDefault();
            orders.id_Employee = _lstcustomerses.Where(c => c.customer_Name == cbxKhachHang.Text)
                .Select(c => c.id_Customer).FirstOrDefault();
            orders.order_Time = Convert.ToDateTime(DateTime.Now);
            orders.discount = 0;
            orders.refunds = 0;
            orders.amount_Pay = 0;
            orders.paying_Customer = 0;
            orders.total_pay = 0;
            orders.payments = "0";
            orders.order_status = 0;
            orders.status_Delete = false;
            //or.AddORDERS(orders);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iOderService.AddORDERS(orders));
            }
            loadata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var hoadon = _lstOrderses.Where(c => c.id_Order == id_Hoadon).FirstOrDefault();
            hoadon.order_Time = Convert.ToDateTime(datetimeNgayMuaHang.Text);
            hoadon.discount =Convert.ToInt32( tbxTrieuKhau.Text);
            hoadon.amount_Pay =Convert.ToInt32( tbxSoTienTra.Text);
            hoadon.payments = tbxThanhToan.Text;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iOderService.EditORDERS(hoadon));
            }
            loadata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //var kh = _iOderService.getListORDERS().Where(c => c.id_Customer == ).FirstOrDefault();
            //kh.address = tbxDiaChi.Text;
            //cbxNam.Checked = true;
            //if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
            //    "Thông báo !!!!!!!!!!!!!!!",
            //    MessageBoxButtons.YesNo) == DialogResult.Yes))
            //{
            //    MessageBox.Show(_iqlcustomersService.Remove(kh));
            //}
            //loadata();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            var idKh = _iqLCustomer.GetlstCustomerses().Where(c => c.customer_Name == cbxKhachHang.Text)
                .Select(c => c.id_Customer).FirstOrDefault();
            var idnv = _iqLEmployees.GetlstEmployeeses().Where(c => c.employee_Name == tbxNvThanhToan.Text)
                .Select(c => c.id_Employee).FirstOrDefault();

            ORDERS orders = new ORDERS();
            orders.id_Customer = idKh;
            orders.id_Employee = idnv;
            //var idOrder = _iQLOrder.GetlstOrderses().Where(c => c.id_Order == Convert.ToInt32()).Select(c => c.id_Order)
            //    .FirstOrDefault();
            orders.order_Time = Convert.ToDateTime(DateTime.Now);
            orders.discount = 0;
            orders.refunds = 0;
            orders.amount_Pay = 0;
            orders.paying_Customer = 0;
            orders.total_pay = 0;
            orders.payments = "0";
            orders.order_status = 0;
            orders.status_Delete = false;
            //or.AddORDERS(orders);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQLOrder.add(orders);
                MessageBox.Show(_iQLOrder.Save());
            }
            loadata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void cbxDaThanhToan_Click(object sender, EventArgs e)
        {
            if (cbxDaThanhToan.Checked = true)
            {
                cbxChuaThanhToan.Checked = false;
            }
        }

        private void cbxChuaThanhToan_Click(object sender, EventArgs e)
        {
            if (cbxChuaThanhToan.Checked = true)
            {
                cbxDaThanhToan.Checked = false;
            }
        }
    }
}
