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
using _2_BUS.Models;


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
        private List<ProductDetail> _lstProductDetails;
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
            _iqLEmployees = new QLEmployessService();
            _lstOrders = new List<ORDERS>();
            _lstOrder_Details = new List<ORDER_DETAILS>();
            _lstProducts = new List<PRODUCTS>();
            _lstProducts_variants = new List<PRODUCTS_VARIANTS>();
            _lstVariants_values = new List<VARIANTS_VALUES>();
            _lstProducts_option = new List<PRODUCTS_OPTIONS>();
            _lstProductDetails = new List<ProductDetail>();
            //_lstOptions = new List<OPTIONS>();
            //_lstOption_values =

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
            foreach (var x in _lstProductDetails)
            {
                List<string> objcell = new List<string>();
                objcell.Add(x.Product.products_Name);
                objcell.Add(x.ProductVariant.Products_Code);
                objcell.Add("1");

                // objcell.Add(x.ProductVariant.quantity + "");
                //objcell.Add(x.ProductVariant.import_Price + "");
                //objcell.Add(x.OptionValue.Where(c => c.id_Option == 2).Select(c => c.option_Values)
                // x.OptionValue.Where(c => c.id_Option == 2 || c.id_Option == 4).Select(c => c.option_Values).ToList().ForEach(y => { objcell.Add(y + ""); });
                objcell.Add(x.ProductVariant.price + "");
                // objcell.Add(x.ImageProduct + "");
                //objcell.Add(x.ProductVariant.id_Product + "");
                //objcell.Add(x.ProductVariant.id_Variant + "");
                objcell.Add(Convert.ToString(x.ProductVariant.price * soluong));

                dgrid_giohang.Rows.Add(objcell.ToArray());

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
                _lstProductDetails.Add(productDetail);
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

            if (_lstOrder_Details.Where(x =>
                    x.id_Product == Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString())).Select(
                    x => x.id_Product).FirstOrDefault() !=
                Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString()))

            {
                //IDHH = Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[0].Value.ToString());
                //ORDER_DETAILS orderDetails = new ORDER_DETAILS()
                //{
                //    id_Order = _iQLOrder.JoinTable().Select(x => x.OrderDetail.id_Order).LastOrDefault() + 1,
                //     = 1,
                //    IdthongTinHangHoa = Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[1].Value.ToString()),
                //    TrangThai = 1,
                //    IdhoaDon = Convert.ToInt32(dgrid_sanpham.Rows[row].Cells[6].Value.ToString())
            }

            ;




        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "" + _iQLOrder.JoinTable().Select(x => x.ProductDetail.Product.id_Product).FirstOrDefault() + "",
                "Thông báo");
        }


    }
}



