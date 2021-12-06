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
using DAL_DataAccessLayers;
using _2_BUS.Models;
using _2_BUS.Service_BUS;
using Microsoft.EntityFrameworkCore.Design;

namespace _3_GUI
{
    public partial class FrmSanPham : Form
    {
        private IProduct_Service PS_BUS;
        private int IdDeleteColumnOP;
        private int id_ProAdd;
        private bool Flag = true;

        private List<ProductDetail> _litSanPhamCuThes;

        public FrmSanPham()
        {
            InitializeComponent();
            PS_BUS = new Service_formSP();
            _litSanPhamCuThes = new List<ProductDetail>();
            _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
            loadata();
            LoadSarnPham();
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
            data_ThongTinSanPham1.ColumnCount = 24 + PS_BUS.getCountOption().Count();
            var row = 0;
            data_ThongTinSanPham1.Columns[row++].Name = "Tên Sản Phẩm";
            data_ThongTinSanPham1.Columns[row++].Name = "Mã sản phẩm";
            data_ThongTinSanPham1.Columns[row++].Name = "Số Lượng";
            data_ThongTinSanPham1.Columns[row++].Name = "Gía Nhập";
            data_ThongTinSanPham1.Columns[row++].Name = "Gía Bán";
            data_ThongTinSanPham1.Columns[row].Name = "Id Sản Phẩm";
            data_ThongTinSanPham1.Columns[row++].Visible = false;
            data_ThongTinSanPham1.Columns[row].Name = "Id variant ";
            data_ThongTinSanPham1.Columns[row++].Visible = false;
            PS_BUS.getCountOption().ForEach(x =>
            {
                data_ThongTinSanPham1.Columns[row].Name = "Id option " + x.id_Option;
                data_ThongTinSanPham1.Columns[row++].Visible = false;
                data_ThongTinSanPham1.Columns[row].Name = "Id Value" + x.id_Option;
                data_ThongTinSanPham1.Columns[row++].Visible = false;
                data_ThongTinSanPham1.Columns[row++].Name = x.option_Name;
            });
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                data_ThongTinSanPham1.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.data_ThongTinSanPham1.Columns.Add(button);
            }
            data_ThongTinSanPham1.Rows.Clear();

            foreach (var x in _litSanPhamCuThes)
            {
                List<string> objcell = new List<string>();
                objcell.Add(x.Product.products_Name);
                objcell.Add(x.ProductVariant.Products_Code);
                objcell.Add(x.ProductVariant.quantity + "");
                objcell.Add(x.ProductVariant.import_Price + "");
                objcell.Add(x.ProductVariant.price + "");
                objcell.Add(x.ProductVariant.id_Product + "");
                objcell.Add(x.ProductVariant.id_Variant + "");
                x.OptionValue.ForEach(i =>
                {
                    objcell.Add(i.id_Option + "");
                    objcell.Add(i.id_Values + "");
                    objcell.Add(i.option_Values + "");
                });
                data_ThongTinSanPham1.Rows.Add(objcell.ToArray());

            }
        }

        #region Danh Sách Sản Phẩm

        void LoadSarnPham()
        {
            data_TenSanPham1.ColumnCount = 2;
            data_TenSanPham1.Columns[0].Name = "Tên Sản Phẩm";
            data_TenSanPham1.Columns[1].Name = "ID_Product";
            data_TenSanPham1.Columns[1].Visible = false;
            data_TenSanPham1.Rows.Clear();
            foreach (var VARIABLE in PS_BUS.GetListProductses().Where(c => c.status_Delete == true))
            {
                data_TenSanPham1.Rows.Add(VARIABLE.products_Name, VARIABLE.id_Product);
            }

        }

        private int rowindexSP;
        private void data_TenSanPham1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private List<ProductDetail> _lstVariantOptionsOfProduct = new List<ProductDetail>();
        private void data_TenSanPham1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindexSP = e.RowIndex;
            if (rowindexSP < 0 || rowindexSP >= PS_BUS.GetListProductses().Where(c => c.status_Delete == true).Count()) return;

            _lstVariantOptionsOfProduct = _litSanPhamCuThes.Where(c =>
               c.Product.id_Product ==
               Convert.ToInt16(data_TenSanPham1.Rows[rowindexSP].Cells["ID_Product"].Value.ToString())).ToList();
            loadOPtionSP(_lstVariantOptionsOfProduct);
            id_ProAdd = Convert.ToInt16(data_TenSanPham1.Rows[rowindexSP].Cells["ID_Product"].Value.ToString());


        }



        private void button5_Click(object sender, EventArgs e)
        {
            var product = new PRODUCTS();
            product.products_Name = data_TenSanPham1.Rows[rowindexSP].Cells[0].Value.ToString();
            if (MessageBox.Show($"bạn có muốn thêm {product.products_Name} không?", " Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(PS_BUS.addNamePRO(product), $"Thêm tên mặt hàng {product.products_Name} vào Danh Sách");
            }
            LoadSarnPham();
            Flag = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int idpro = Convert.ToInt16(data_TenSanPham1.Rows[rowindexSP].Cells[1].Value.ToString());
            var productedited = PS_BUS.GetListProductses().FirstOrDefault(c => c.id_Product == idpro);
            productedited.products_Name = data_TenSanPham1.Rows[rowindexSP].Cells[0].Value.ToString();
            if (MessageBox.Show($"bạn có muốn Sửa tên thành {productedited.products_Name} không?", " Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(PS_BUS.editNamePro(productedited), $"Đổi tên thành {productedited.products_Name}");
            }
            LoadSarnPham();
            Flag = false;
        }

        private void btn_XoaName_Click(object sender, EventArgs e)
        {
            int idpro = Convert.ToInt16(data_TenSanPham1.Rows[rowindexSP].Cells[1].Value.ToString());
            var productedited = PS_BUS.GetListProductses().FirstOrDefault(c => c.id_Product == idpro);
            if (MessageBox.Show($"bạn có muốn Xóa {productedited.products_Name} không?", " Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(PS_BUS.RemoveNamePro(productedited), $" Bạn đã Xóa {productedited.products_Name}!");
            }
            LoadSarnPham();
            Flag = false;
        }
        #endregion

        #region Phần của các chi tiết Sản Phẩm

        void loadOPtionSP(List<ProductDetail> a)
        {
            List<int> lisPV = new List<int>();
            foreach (var VARIABLE in a)
            {
                lisPV.Add(VARIABLE.ProductVariant.id_Variant);
            }
            if (lisPV.Count != 0)
            {
                data_CacPhienBan1.ColumnCount = 23 + PS_BUS.getCountOption().Count();
                var row = 0;
                // data_CacPhienBan1.Columns[row++].Name = "Tên Sản Phẩm";
                data_CacPhienBan1.Columns[row++].Name = "Mã sản phẩm";
                data_CacPhienBan1.Columns[row++].Name = "Số Lượng";
                data_CacPhienBan1.Columns[row++].Name = "Giá Nhập";
                data_CacPhienBan1.Columns[row++].Name = "Giá Bán";
                data_CacPhienBan1.Columns[row].Name = "Id Sản Phẩm";
                data_CacPhienBan1.Columns[row++].Visible = false;
                data_CacPhienBan1.Columns[row].Name = "Id variant ";
                data_CacPhienBan1.Columns[row++].Visible = false;
                PS_BUS.getCountOption().ForEach(x =>
                {
                   //data_CacPhienBan1.Columns[row].Name = "Id option " + x.id_Option;
                    data_CacPhienBan1.Columns[row++].Visible = false;
                  //  data_CacPhienBan1.Columns[row].Name = "Id Value" + x.id_Option;
                    data_CacPhienBan1.Columns[row++].Visible = false;
                    data_CacPhienBan1.Columns[row++].Name = x.option_Name;
                });

                data_CacPhienBan1.Rows.Clear();
                foreach (var x in a)
                {
                    List<string> objcell = new List<string>();
                    // objcell.Add(x.Product.products_Name);
                    objcell.Add(x.ProductVariant.Products_Code);
                    objcell.Add(x.ProductVariant.quantity + "");
                    objcell.Add(x.ProductVariant.import_Price + "");
                    objcell.Add(x.ProductVariant.price + "");
                    objcell.Add(x.ProductVariant.id_Product + "");
                    objcell.Add(x.ProductVariant.id_Variant + "");
                    x.OptionValue.ForEach(i =>
                    {
                        objcell.Add(i.id_Option + "");
                        objcell.Add(i.id_Values + "");
                        objcell.Add(i.option_Values + "");
                    });
                    data_CacPhienBan1.Rows.Add(objcell.ToArray());
                }
            }
            else
            {
                data_CacPhienBan1.ColumnCount = 6;
                var row = 0;
                // data_CacPhienBan1.Columns[row++].Name = "Tên Sản Phẩm";
                data_CacPhienBan1.Columns[row++].Name = "Mã sản phẩm";
                data_CacPhienBan1.Columns[row++].Name = "Số Lượng";
                data_CacPhienBan1.Columns[row++].Name = "Giá Nhập";
                data_CacPhienBan1.Columns[row++].Name = "Giá Bán";
                data_CacPhienBan1.Columns[row].Name = "Id Sản Phẩm";
                data_CacPhienBan1.Columns[row++].Visible = false;
                data_CacPhienBan1.Columns[row].Name = "Id variant ";
                data_CacPhienBan1.Columns[row++].Visible = false;
                data_CacPhienBan1.Rows.Clear();

            }
            _lstVariantOptionsOfProduct.Clear();
        }


        private int rowIndexVariant;
        private void data_CacPhienBan1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdDeleteColumnOP = e.ColumnIndex;
            int row = e.RowIndex;
            rowIndexVariant = row;
            if (row < 0 || row >= _lstVariantOptionsOfProduct.Count) return;
        }

        private int soOption;
        private void btn_newoption_Click(object sender, EventArgs e)
        {
            int i = 0; i++;
            this.data_CacPhienBan1.Columns.Add($"option{i}", tbx_optionName.Text);
            soOption = i + 1;
        }
        private void btn_XoaDD_Click(object sender, EventArgs e)
        {
            data_CacPhienBan1.Columns.RemoveAt(IdDeleteColumnOP);
        }

        private void btn_AddVariant_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"bạn có muốn thêm sản phẩm {data_CacPhienBan1.Rows[rowIndexVariant].Cells[1].Value.ToString()} không?", " Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PRODUCTS_VARIANTS b = new PRODUCTS_VARIANTS();
                b.id_Product = id_ProAdd;
                b.Products_Code = data_CacPhienBan1.Rows[rowIndexVariant].Cells[0].Value.ToString();
                b.quantity = Convert.ToInt16(data_CacPhienBan1.Rows[rowIndexVariant].Cells[1].Value.ToString());
                b.import_Price = Convert.ToInt32(data_CacPhienBan1.Rows[rowIndexVariant].Cells[2].Value.ToString());
                b.price = Convert.ToInt32(data_CacPhienBan1.Rows[rowIndexVariant].Cells[3].Value.ToString());
                PS_BUS.addVariant(b);
                //----------------------------------------------------------------------------------------------------------------------------------------------
                for (int i = 1; i < soOption; i++)
                {
                    string ddr4 = data_CacPhienBan1.Columns[$"option{i}"].HeaderText;
                    OPTIONS newoOptions = new OPTIONS();
                    newoOptions.option_Name = data_CacPhienBan1.Columns[$"option{i}"].HeaderText;
                    PS_BUS.addOPtion(newoOptions);

                    // thêm option_values
                    OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();

                    newOptionsValues.id_Option =
                        PS_BUS.GetListoOptionses()[
                            PS_BUS.GetListoOptionses().FindIndex(c => c.option_Name == newoOptions.option_Name)].id_Option;

                    string aka = data_CacPhienBan1.Rows[rowIndexVariant].Cells[$"option{i}"].Value.ToString();
                    newOptionsValues.option_Values =
                        data_CacPhienBan1.Rows[rowIndexVariant].Cells[$"option{i}"].Value.ToString();
                    PS_BUS.addOPtion_Value(newOptionsValues);
                    //thêm product_option
                    PRODUCTS_OPTIONS newProductsOptions = new PRODUCTS_OPTIONS();
                    newProductsOptions.id_Product = id_ProAdd;
                    newProductsOptions.id_Option = PS_BUS.GetListoOptionses()[
                        PS_BUS.GetListoOptionses().FindIndex(c => c.option_Name == newoOptions.option_Name)].id_Option;
                    PS_BUS.addProduct_OPtion(new PRODUCTS_OPTIONS());
                    //Thêm Variant_option
                    VARIANTS_VALUES newValues = new VARIANTS_VALUES();
                    newValues.id_Product = id_ProAdd;
                    newValues.id_Variant = PS_BUS.GetListProductVariantses()[
                        PS_BUS.GetListProductVariantses().FindIndex(c => c.Products_Code == b.Products_Code)].id_Variant;
                    newValues.id_Option= PS_BUS.GetListoOptionses()[
                        PS_BUS.GetListoOptionses().FindIndex(c => c.option_Name == newoOptions.option_Name)].id_Option;
                    newValues.id_Variant= PS_BUS.GetListoOptionvValueses()[
                        PS_BUS.GetListoOptionvValueses().FindIndex(c => c.option_Values == newOptionsValues.option_Values)].id_Values;

                    PS_BUS.addVariant_value(newValues);
                }

                MessageBox.Show(" thành CÔng!", $" Bạn đã thêm {b.Products_Code}!");
            }

            loadOPtionSP(PS_BUS.LoadDatafromDAL().Where(c => c.Product.id_Product == id_ProAdd).ToList());
            loadata();
            PS_BUS.save();
            Flag = false;

        }

        private void btn_Editvariant_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoaVariant_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

