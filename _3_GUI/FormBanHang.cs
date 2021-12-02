﻿using _2_BUS.IService_BUS;
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



namespace _3_GUI
{
    public partial class FormBanHang : Form
    {
        private IQLOrderService _iQLOrder;
        private IQLCustomerService _iqLCustomer;
        private IProduct_Service _iproduct_Service;
       
        private IQLCustomerService _lstCustomerService;
        public string email = FormDangNhap.email;
        private string _id;

        private IProduct_Service PS_BUS;

        //private List<OPTIONS> _lstOptions;
        //private List<OPTIONS_VALUES> _lstOption_values;
        public FormBanHang()
        {
            InitializeComponent();
            _iQLOrder = new QLOrDerService();
            _iqLCustomer = new QLCustomerService();
            PS_BUS = new Service_formSP();
            
            _lstCustomerService = new QLCustomerService();
            //_lstOptions = new List<OPTIONS>();
            //_lstOption_values =
            foreach (var x in _lstCustomerService.GetlstCustomerses())
            {
                cbxTenKhachhang.Items.Add(x.customer_Name);
                cbxTenKhachhang.SelectedIndex = 0;
            }
           // tbxMaNhanVien.Text = Convert.ToString(_iqLEmployees.GetlstEmployeeses().Where(c => c.Email == email).Select(c => c.id_Employee).FirstOrDefault()) ;
            loadSP();
            LoadGioHang();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //this.panel1.Controls.Add(childForm);
            //this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        //    void LoadData()
        //    {
        //        dgrid_sp.ColumnCount = 7;
        //        var row = 0;
        //        dgrid_sp.Columns[row++].Name = "Tên Sản Phẩm";
        //        dgrid_sp.Columns[row++].Name = "Mã Sản Phẩm";
        //        dgrid_sp.Columns[row++].Name = "Số Lượng";
        //        dgrid_sp.Columns[row++].Name = "Giá Bán";
        //        dgrid_sp.Columns[row++].Name = "Hình ảnh";
        //        dgrid_sp.Columns[row++].Name = "Thêm giỏ hàng";
        //        DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
        //        ArrayList row1 = new ArrayList();
        //        row1 = new ArrayList();
        //        row1.Add("Thêm");
        //        row1.Add("Sửa");
        //        row1.Add("Xóa");
        //        DataGridViewComboBoxColumn cbo = new DataGridViewComboBoxColumn();
        //        cbo.HeaderText = "Chức Năng";
        //        cbo.Name = "cbo";
        //        cbo.Items.AddRange(row1.ToArray());
        //        dgrid_sp.Columns.Add(cbo);
        //        DataGridViewButtonColumn button = new DataGridViewButtonColumn();
        //        {
        //            button.Name = "btn_dgv";
        //            button.HeaderText = "OK";
        //            button.Text = ("OK");
        //            button.UseColumnTextForButtonValue = true;
        //            this.dgrid_sp.Columns.Add(button);
        //        }
        //        dgrid_sp.Rows.Clear();

        //        foreach (var x in PS_BUS.LoadDatafromDAL())
        //        {
        //            List<string> objcell = new List<string>();
        //            objcell.Add(x.Product.products_Name);
        //            objcell.Add(x.ProductVariant.Products_Code);
        //            objcell.Add(x.ProductVariant.quantity + "");
        //            //objcell.Add(x.ProductVariant.import_Price + "");
        //            objcell.Add(x.ProductVariant.price + "");
        //            objcell.Add(x.ImageProduct + "");
        //            objcell.Add(x.ProductVariant.id_Product + "");
        //            //objcell.Add(x.ProductVariant.id_Variant + "");
        //            x.OptionValue.ForEach(i =>
        //            {
        //                objcell.Add(i.id_Option + "");
        //                objcell.Add(i.id_Values + "");
        //                objcell.Add(i.option_Values + "");
        //            });
        //            dgrid_sp.Rows.Add(objcell.ToArray());

        //        }
        //}
        void loadSP()
        {
            dgrid_sp.ColumnCount = 6;
            // var row = 0;
            dgrid_sp.Columns[0].Name = "ID_Product";
            dgrid_sp.Columns["ID_Product"].Visible = false;
            dgrid_sp.Columns[1].Name = "ID_Variant";
            dgrid_sp.Columns["ID_Variant"].Visible = false;
            dgrid_sp.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_sp.Columns[3].Name = "Mã Sản Phẩm";
            dgrid_sp.Columns[4].Name = "Giá Bán";
            dgrid_sp.Columns[5].Name = "Tồn Kho";

            //PS_BUS.getCountOption().ForEach(x =>
            //{

            //    dgrid_sp.Columns[row++].Name = "Id option " + x.id_Option;
            //    dgrid_sp.Columns["Id option " + x.id_Option].Visible = false;
            //    dgrid_sp.Columns[row++].Name = "Id Value" + x.id_Option;
            //    dgrid_sp.Columns["Id Value" + x.id_Option].Visible = false;
            //    dgrid_sp.Columns[row++].Name = x.option_Name;
            //});
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
                //  objcell.Add(x.ProductVariant.quantity + "");
                //objcell.Add(x.ProductVariant.import_Price + "");
                objcell.Add(x.ProductVariant.price + "");
                objcell.Add(x.ProductVariant.quantity + "");
                //objcell.Add(x.ProductVariant.id_Product + "");
                //objcell.Add(x.ProductVariant.id_Variant + "");

                dgrid_sp.Rows.Add(objcell.ToArray());

            }
        }

        void LoadGioHang()
        {
            int soluong = 1;
            dgrid_giohang.ColumnCount = 5;
            var row = 0;
            dgrid_giohang.Columns[row++].Name = "Tên Sản Phẩm";
            dgrid_giohang.Columns[row++].Name = "Mã Sản Phẩm";
            dgrid_giohang.Columns[row++].Name = "Số Lượng";
            //PS_BUS.getCountOption().Where(c=>c.id_Option==2 && c.id_Option==4).Select (c=>c.option_Name).ToList(). ForEach(x =>
            //{

            //    dgrid_giohang.Columns[row++].Name = x;
            //});

            dgrid_giohang.Columns[row++].Name = "Đơn Giá";
            dgrid_giohang.Columns[row++].Name = "Tổng Tiền";
            //PS_BUS.getCountOption().ForEach(x =>
            //{
            //    dgrid_giohang.Columns[row].Name = "Id option " + x.id_Option;
            //    dgrid_giohang.Columns[row++].Visible = false;
            //    dgrid_giohang.Columns[row].Name = "Id Value" + x.id_Option;
            //    dgrid_giohang.Columns[row++].Visible = false;
            //    dgrid_giohang.Columns[row++].Name = x.option_Name;
            //});
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "es";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Add");
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                dgrid_giohang.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "Delete";
                button.HeaderText = "Delete";

                button.Text = ("Delete");
                button.UseColumnTextForButtonValue = true;
                this.dgrid_giohang.Columns.Add(button);
            }
            dgrid_giohang.Rows.Clear();
            //foreach (var x in _lstProductDetails)
            //{
            //    List<string> objcell = new List<string>();
            //    objcell.Add(x.Product.products_Name);
            //    objcell.Add(x.ProductVariant.Products_Code);
            //    objcell.Add("1");

            //    // objcell.Add(x.ProductVariant.quantity + "");
            //    //objcell.Add(x.ProductVariant.import_Price + "");
            //    //objcell.Add(x.OptionValue.Where(c => c.id_Option == 2).Select(c => c.option_Values)
            //    // x.OptionValue.Where(c => c.id_Option == 2 || c.id_Option == 4).Select(c => c.option_Values).ToList().ForEach(y => { objcell.Add(y + ""); });
            //    objcell.Add(x.ProductVariant.price + "");
            //    // objcell.Add(x.ImageProduct + "");
            //    //objcell.Add(x.ProductVariant.id_Product + "");
            //    //objcell.Add(x.ProductVariant.id_Variant + "");
            //    objcell.Add(Convert.ToString(x.ProductVariant.price * soluong));

            //    dgrid_giohang.Rows.Add(objcell.ToArray());

            //}
            float sum = 0;
            for (int i = 0; i < dgrid_giohang.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgrid_giohang.Rows[i].Cells[4].Value);
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            tbxTongTien.Text = sum.ToString("#,###", cul.NumberFormat) + " " + "VND";
            tbxKhachCanTra.Text = sum.ToString("#,###", cul.NumberFormat) + " " + "VND";
            tbxKhachThanhToan.Text = sum.ToString("#,###", cul.NumberFormat) + " " + "VND";
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
               // _lstProductDetails.Add(productDetail);
                LoadGioHang();
            }
        }
        private void dgrid_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int roxIndex = e.RowIndex;
            //var _id = int.Parse(dgrid_giohang.Rows[roxIndex].Cells[0].Value.ToString());
            //var a = int.Parse(dgrid_giohang.Rows[roxIndex].Cells[2].Value.ToString()) + 1;
            //PS_BUS.LoadDatafromDAL().Where(c => c.Product.id_Product == _id).Select(c => c.ProductVariant.quantity = a);
            //LoadGioHang();
        }

        private void dgrid_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_sanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            //if (_lstOrder_Details.Where(x =>
            //        x.id_Product == Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString())).Select(
            //        x => x.id_Product).FirstOrDefault() !=
            //    Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString()))

            //{
            //    //IDHH = Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString());
            //    //ORDER_DETAILS orderDetails = new ORDER_DETAILS()
            //    //{
            //    //    id_Order = _iQLOrder.JoinTable().Select(x => x.OrderDetail.id_Order).LastOrDefault() + 1,
            //    //     = 1,
            //    //    IdthongTinHangHoa = Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[1].Value.ToString()),
            //    //    TrangThai = 1,
            //    //    IdhoaDon = Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[6].Value.ToString())
            //}

            ;




        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "" + _iQLOrder.JoinTable().Select(x => x.ProductDetail.Product.id_Product).FirstOrDefault() + "",
                "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idKh = _iqLCustomer.GetlstCustomerses().Where(c => c.customer_Name == cbxTenKhachhang.Text)
                .Select(c => c.id_Customer).FirstOrDefault();
            //var idnv = _iqLEmployees.GetlstEmployeeses().Where(c => c.employee_Name == tbxMaNhanVien.Text)
            //    .Select(c => c.id_Employee).FirstOrDefault();
            //ORDERS orders = new ORDERS();
            //var idOrder = _iQLOrder.GetlstOrderses().Where(c => c.id_Order == tbxMaSp.Text).Select(c => c.id_Order)
            //    .FirstOrDefault();
          //  orders.order_Time = Convert.ToDateTime(DateNgayTao.Text);
            //orders.discount = Convert.ToInt32(tbxGiamGia.Text);
            //orders.refunds = Convert.ToInt32(tbxSoTienHoanLai.Text);
            //orders.amount_Pay = Convert.ToInt32(tbxKhachCanTra.Text);
            //orders.payments = tbxKhachThanhToan.Text;
          //  orders.status_Delete = false;
            //or.AddORDERS(orders);
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
              //  MessageBox.Show(_iQLOrder.add(orders));
            }

            LoadGioHang();
        }
    }
}



