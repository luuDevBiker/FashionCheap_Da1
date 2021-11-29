using _2_BUS.IService_BUS;
using _2_BUS.Service_BUS;
using DAL_DataAccessLayers;
using System;
using System.Collections;
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
    public partial class FormBanHang : Form
    {
        private IQLOrderService _iQLOrder;
        private IQLCustomerService _iqLCustomer;
        private IProduct_Service _iproduct_Service;
        private List<ORDERS> _lstOrders;
        private List<ORDER_DETAILS> _lstOrder_Details;
        private IQLEmployeesService _iqLEmployees;
        private List<PRODUCTS> _lstProducts;
        private List<PRODUCTS_VARIANTS> _lstProducts_variants;
        private List<VARIANTS_VALUES> _lstVariants_values;
        private List<PRODUCTS_OPTIONS> _lstProducts_option;
        private IProduct_Service PS_BUS;
        public FormBanHang()
        {
            InitializeComponent();
            _iQLOrder = new QLOrDerService();
            _iqLCustomer = new QLCustomerService();
            PS_BUS = new  Service_formSP();
            _iqLEmployees = new QLEmployessService();
            _lstOrders = new List<ORDERS>();
            _lstOrder_Details = new List<ORDER_DETAILS>();
            _lstProducts = new List<PRODUCTS>();
            _lstProducts_variants = new List<PRODUCTS_VARIANTS>();
            _lstVariants_values = new List<VARIANTS_VALUES>();
            _lstProducts_option = new List<PRODUCTS_OPTIONS>();

            loadSP();

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
            dgrid_sp.ColumnCount = 4;
            var row = 0;
            dgrid_sp.Columns[row++].Name = "Tên Sản Phẩm";
            dgrid_sp.Columns[row++].Name = "Mã Sản Phẩm";
            dgrid_sp.Columns[row++].Name = "Giá Bán";
            dgrid_sp.Columns[row++].Name = "Hình ảnh";
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "";
                button.Text = ("thêm vào giỏ hàng");
                button.UseColumnTextForButtonValue = true;
                this.dgrid_sp.Columns.Add(button);
            }
            dgrid_sp.Rows.Clear();

            foreach (var x in PS_BUS.LoadDatafromDAL())
            {
                List<string> objcell = new List<string>();
                objcell.Add(x.Product.products_Name);
                objcell.Add(x.ProductVariant.Products_Code);
                //  objcell.Add(x.ProductVariant.quantity + "");
                //objcell.Add(x.ProductVariant.import_Price + "");
                objcell.Add(x.ProductVariant.price + "");
                objcell.Add(x.ImageProduct + "");
                //objcell.Add(x.ProductVariant.id_Product + "");
                //objcell.Add(x.ProductVariant.id_Variant + "");

                dgrid_sp.Rows.Add(objcell.ToArray());

            }
        }

        void LoadGioHang()
        {
            dgrid_sanpham.ColumnCount = 6;
            dgrid_giohang.Columns[0].Name = "ID";
            dgrid_giohang.Columns[0].Visible = false;
            dgrid_giohang.Columns[1].Name = "Mã sản phẩm";
            dgrid_giohang.Columns[2].Name = "Tên sản phẩm";
            dgrid_giohang.Columns[3].Name = "Số lượng";
            dgrid_giohang.Columns[4].Name = "Đơn giá";
            dgrid_giohang.Columns[5].Name = "Thành tiền";
            dgrid_giohang.Rows.Clear();
            foreach (var x in _iQLOrder.GetlstOrderses())
            {
                //dgrid_giohang.Rows.Add(x., x.Product.products_Name, x.ProductVariant.price,
                //    x.ProductVariant.quantity, x.ImageProduct);

            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Xác nhận";
            buttonColumn.Text = "Sửa";
            buttonColumn.Name = "Sửa";
            buttonColumn.UseColumnTextForButtonValue = true;

            dgrid_giohang.Columns.Add(buttonColumn);
        }

        private void dgrid_giohang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_giohang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_sanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (_lstOrder_Details.Where(x =>
                    x.id_Product == Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString())).Select(
                    x => x.id_Product).FirstOrDefault() !=
                Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString()))
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + _iQLOrder.JoinTable().Select(x => x.ProductDetail.Product.id_Product).FirstOrDefault() + "", "Thông báo");
        }

        
    }
        }
    
