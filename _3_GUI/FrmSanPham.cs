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
        private int idVariaant;
        private bool Flag = true;
        private List<ProductDetail> _litSanPhamCuThes;
        private int soOption;
        private List<OPTIONS> listOptionsestoAdd;
        private List<OPTIONS_VALUES> listOP_VAtoAdd;
        public FrmSanPham()
        {
            InitializeComponent();
            PS_BUS = new Service_formSP();
            _litSanPhamCuThes = new List<ProductDetail>();
            _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
            listOptionsestoAdd = new List<OPTIONS>();
            listOP_VAtoAdd = new List<OPTIONS_VALUES>();
            loadOPtionSP(-2);
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
        void loadata(int a)
        {
            data_ThongTinSanPham1.ColumnCount = 7 + PS_BUS.getCountOption(a).Count();
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
            PS_BUS.getCountOption(a).ForEach(x =>
            {
                data_ThongTinSanPham1.Columns[row++].Name = PS_BUS.GetListoOptionses().Where(c => c.id_Option == x.id_Option).Select(c => c.option_Name).FirstOrDefault();
            });
            data_ThongTinSanPham1.Rows.Clear();

            foreach (var x in _lstVariantOptionsOfProduct)
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
            if (rowindexSP < 0 ||
                rowindexSP >= PS_BUS.GetListProductses().Where(c => c.status_Delete == true).Count()) return;
            id_ProAdd = Convert.ToInt16(data_TenSanPham1.Rows[rowindexSP].Cells["ID_Product"].Value.ToString());
            _lstVariantOptionsOfProduct = _litSanPhamCuThes.Where(c =>
                c.Product.id_Product == id_ProAdd).ToList();
            loadata(id_ProAdd);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            var product = new PRODUCTS();
            product.products_Name = data_TenSanPham1.Rows[rowindexSP].Cells[0].Value.ToString();
            if (MessageBox.Show($"bạn có muốn thêm {product.products_Name} không?", " Thông báo!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            if (MessageBox.Show($"bạn có muốn Sửa tên thành {productedited.products_Name} không?", " Thông báo!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            if (MessageBox.Show($"bạn có muốn Xóa {productedited.products_Name} không?", " Thông báo!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(PS_BUS.RemoveNamePro(productedited), $" Bạn đã Xóa {productedited.products_Name}!");
            }

            LoadSarnPham();
            Flag = false;
        }

        #endregion

        #region Phần của các chi tiết Sản Phẩm

        void loadOPtionSP(int Idvariant)
        {
            data_CacPhienBan1.ColumnCount = 4;
            data_CacPhienBan1.Columns[0].Name = "ID_option";
            data_CacPhienBan1.Columns[0].Visible = false;
            data_CacPhienBan1.Columns[1].Name = "ID_vaLue";
            data_CacPhienBan1.Columns[1].Visible = false;
            data_CacPhienBan1.Columns[2].Name = "option_name";
            data_CacPhienBan1.Columns[2].HeaderText = "thuộc tính";
            data_CacPhienBan1.Columns[3].Name = "value_name";
            data_CacPhienBan1.Columns[3].HeaderText = "Đặc Điểm";

            data_CacPhienBan1.Rows.Clear();

            if (Idvariant == -2)
            {
                return;
            }
            else
            {
                var opptionProVar = _lstVariantOptionsOfProduct.Where(c => c.ProductVariant.id_Variant == Idvariant)
                   .FirstOrDefault();
                foreach (var VARIABLE in opptionProVar.OptionValue)
                {
                    data_CacPhienBan1.Rows.Add(VARIABLE.id_Option, VARIABLE.id_Values,
                        opptionProVar.Option.Where(c => c.id_Option == VARIABLE.id_Option).Select(c => c.option_Name).FirstOrDefault(),
                        VARIABLE.option_Values);
                }

                listOptionsestoAdd = opptionProVar.Option;
                listOP_VAtoAdd = opptionProVar.OptionValue;
            }
        }
        private void btn_AddVariant_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"bạn có muốn thêm sản phẩm {txt_Masp.Text} không?", " Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PRODUCTS_VARIANTS b = new PRODUCTS_VARIANTS();
                b.id_Product = id_ProAdd;
                b.Products_Code = txt_Masp.Text;
                b.quantity = Convert.ToInt16(txt_SoLuong.Text);
                b.import_Price = Convert.ToInt32(txt_giaNhap.Text);
                b.price = Convert.ToInt32(txt_giaBan.Text);
                PS_BUS.addVariant(b);
                PS_BUS.save();
                ///========================================================================================================================================================
                //----------------------------------------------------------------------------------------------------------------------------------------------
                for (int i = 1; i < data_CacPhienBan1.Rows.Count; i++)
                {
                    // Thêm Option
                    OPTIONS newoOptions = new OPTIONS();
                    newoOptions.option_Name = data_CacPhienBan1.Rows[i].Cells["option_name"].Value.ToString(); ;
                    PS_BUS.addOPtion(newoOptions);
                    
                    // thêm option_values
                    OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();
                    newOptionsValues.id_Option =
                        PS_BUS.GetListoOptionses().Where(c => c.option_Name == newoOptions.option_Name).Select(c => c.id_Option).FirstOrDefault();
                    string tam = data_CacPhienBan1.Rows[i].Cells["option_name"].Value.ToString();
                    newOptionsValues.option_Values = data_CacPhienBan1.Rows[i].Cells["value_name"].Value.ToString();
                    //string aka = data_CacPhienBan1.Rows[i].Cells[1].Value.ToString();
                    PS_BUS.addOPtion_Value(newOptionsValues);
                    
                    //thêm product_option
                    PRODUCTS_OPTIONS newProductsOptions = new PRODUCTS_OPTIONS();
                    newProductsOptions.id_Product = id_ProAdd;
                    newProductsOptions.id_Option = PS_BUS.GetListoOptionses().Where(c => c.option_Name == newoOptions.option_Name).Select(c => c.id_Option).FirstOrDefault();
                    PS_BUS.addProduct_OPtion(newProductsOptions);
                    
                    //Thêm Variant_values
                    VARIANTS_VALUES newValues = new VARIANTS_VALUES();
                    newValues.id_Product = id_ProAdd;
                    newValues.id_Variant = PS_BUS.GetListProductVariantses()[
                        PS_BUS.GetListProductVariantses().FindIndex(c => c.Products_Code == b.Products_Code)].id_Variant;
                    newValues.id_Option = PS_BUS.GetListoOptionses()[
                        PS_BUS.GetListoOptionses().FindIndex(c => c.option_Name == newoOptions.option_Name)].id_Option;
                    newValues.id_Values = PS_BUS.GetListoOptionvValueses()[
                        PS_BUS.GetListoOptionvValueses().FindIndex(c => c.option_Values == newOptionsValues.option_Values)].id_Values;

                    PS_BUS.addVariant_value(newValues);

                }

                MessageBox.Show(" thành CÔng!", $" Bạn đã thêm {b.Products_Code}!");
            }
            loadata(id_ProAdd);
            loadOPtionSP(1);
            PS_BUS.save();
            Flag = false;

        }

        private void btn_Editvariant_Click(object sender, EventArgs e)
        {
            var productTemp = new ProductDetail();
            productTemp = _litSanPhamCuThes.FirstOrDefault(c =>
                c.Product.id_Product == id_ProAdd && c.ProductVariant.id_Variant == idVariaant);
            productTemp.ProductVariant.Products_Code = txt_Masp.Text;
            productTemp.ProductVariant.quantity = Convert.ToInt16(txt_SoLuong.Text);
            productTemp.ProductVariant.import_Price = Convert.ToInt32(txt_giaNhap.Text);
            productTemp.ProductVariant.price=Convert.ToInt32(txt_giaBan.Text);

            for (int i = 1; i < data_CacPhienBan1.Rows.Count; i++)
            {
                // Thêm Option
                OPTIONS newoOptions = new OPTIONS();
                string SosanhOpDB = data_CacPhienBan1.Rows[i].Cells["option_name"].Value.ToString();
                if (PS_BUS.GetListoOptionses().Any(c=>c.option_Name==SosanhOpDB))
                {
                    newoOptions = PS_BUS.GetListoOptionses().FirstOrDefault(c => c.option_Name == SosanhOpDB);
                    PS_BUS.editOption(newoOptions);
                }
                else
                {
                    newoOptions.option_Name = SosanhOpDB;
                    PS_BUS.addOPtion(newoOptions);

                }
                
                // thêm option_values
                OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();
                string tam = data_CacPhienBan1.Rows[i].Cells["value_name"].Value.ToString();
                if (PS_BUS.GetListoOptionvValueses().Any(c=>c.option_Values==tam))
                {
                    newOptionsValues = PS_BUS.GetListoOptionvValueses().FirstOrDefault(c => c.option_Values==tam);
                    PS_BUS.editOPtion_value(newOptionsValues);
                }
                else
                {
                     newOptionsValues.id_Option =
                    PS_BUS.GetListoOptionses().Where(c => c.option_Name == newoOptions.option_Name).Select(c => c.id_Option).FirstOrDefault();
                     newOptionsValues.option_Values = tam;
                     PS_BUS.addOPtion_Value(newOptionsValues);

                }
                PS_BUS.editOPtion_value(newOptionsValues);

                //thêm product_option
                PRODUCTS_OPTIONS newProductsOptions = new PRODUCTS_OPTIONS();
                newProductsOptions.id_Product = id_ProAdd;
                newProductsOptions.id_Option = newoOptions.id_Option;
                PS_BUS.editProduct_Option(newProductsOptions);

                //Thêm Variant_values
                VARIANTS_VALUES newValues = new VARIANTS_VALUES();
                newValues.id_Product = id_ProAdd;
                newValues.id_Variant = PS_BUS.GetListProductVariantses()[
                    PS_BUS.GetListProductVariantses().FindIndex(c => c.Products_Code == productTemp.ProductVariant.Products_Code)].id_Variant;
                newValues.id_Option = PS_BUS.GetListoOptionses()[
                    PS_BUS.GetListoOptionses().FindIndex(c => c.option_Name == newoOptions.option_Name)].id_Option;
                newValues.id_Values = PS_BUS.GetListoOptionvValueses()[
                    PS_BUS.GetListoOptionvValueses().FindIndex(c => c.option_Values == newOptionsValues.option_Values)].id_Values;

                PS_BUS.editVariant_values(newValues);

            }


        }
        private void btn_xoaVariant_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void data_ThongTinSanPham1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void data_ThongTinSanPham1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (_lstVariantOptionsOfProduct.Count == 0) return;
            int row = e.RowIndex;
            if (row < 0 || row >= _lstVariantOptionsOfProduct.Count)
            {
                txt_Masp.Clear();
                txt_SoLuong.Clear();
                txt_giaNhap.Clear();
                txt_giaBan.Clear();
                loadOPtionSP(-2);
            }
            else
            {
                txt_Masp.Text = data_ThongTinSanPham1.Rows[row].Cells[1].Value.ToString();
                txt_SoLuong.Text = data_ThongTinSanPham1.Rows[row].Cells[2].Value.ToString();
                txt_giaNhap.Text = data_ThongTinSanPham1.Rows[row].Cells[3].Value.ToString();
                txt_giaBan.Text = data_ThongTinSanPham1.Rows[row].Cells[4].Value.ToString();
                idVariaant = Convert.ToInt16(data_ThongTinSanPham1.Rows[row].Cells["Id variant "].Value.ToString());
                loadOPtionSP(idVariaant);
            }
        }
    }
}

