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

        private int _IdDeleteColumnOP;
        private int _id_ProAdd;
        private int _idVariaant;
        private bool _Flag = true;
        private List<ProductDetail> _litSanPhamCuThes;
        private int _soOption;
        private List<OPTIONS> _listOptionsestoAdd;
        private List<OPTIONS_VALUES> _listOP_VAtoAdd;
        private List<ProductDetail> _lstVariantOptionsOfProduct;
        private int _rowindexSP;
        private int _countRowDgvOption;
        public FrmSanPham()
        {
            InitializeComponent();
            PS_BUS = new Service_formSP();
            _litSanPhamCuThes = new List<ProductDetail>();
            _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
            _listOptionsestoAdd = new List<OPTIONS>();
            _listOP_VAtoAdd = new List<OPTIONS_VALUES>();
            _lstVariantOptionsOfProduct = new List<ProductDetail>();
            loadOPtionSP(-2);
            LoadSarnPham();
            grbPhienbanMoi.Enabled = false;
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
            PS_BUS.getCountOption(a).Where(x=>x.status_Delete == true).ToList().ForEach(x =>
            {
                data_ThongTinSanPham1.Columns[row++].Name = PS_BUS.GetListoOptionses().Where(c => c.id_Option == x.id_Option).Select(c => c.option_Name).FirstOrDefault();
            });
            data_ThongTinSanPham1.Rows.Clear();

            try
            {
                var lst = PS_BUS.LoadDatafromDAL();
                if (lst == null)
                {
                    return;
                }
                _lstVariantOptionsOfProduct = 
                    lst.Where(c =>c.Product.id_Product == a 
                        && c.Status == true)
                    .ToList();
                foreach (var x in _lstVariantOptionsOfProduct.Where(x=>x.ProductVariant.status_Delete == true).ToList())
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
            catch (Exception e)
            {
                return;
            }
        }

        #region Danh Sách Sản Phẩm
        void loadOPtion(int idProduct)
        {
            data_CacPhienBan1.Columns.Clear();
            data_CacPhienBan1.ColumnCount = 3;
            data_CacPhienBan1.Columns[0].Name = "ID_option";
            data_CacPhienBan1.Columns[0].Visible = false;
            data_CacPhienBan1.Columns[1].Name = "option_name";
            data_CacPhienBan1.Columns[1].HeaderText = "Thuộc tính";
            data_CacPhienBan1.Columns[2].Name = "value";
            data_CacPhienBan1.Columns[2].HeaderText = "Giá trị";

            data_CacPhienBan1.Rows.Clear();
            var product = PS_BUS.GetListProductses()
                .Where(x => x.id_Product == _id_ProAdd).FirstOrDefault();
            var lstOption = PS_BUS.GetListoOptionses().Where(x => x.status_Delete == true);
            var lstProductOption = PS_BUS.GetLisoProductsOptionses().Where(x => x.id_Product == idProduct).ToList();
            if (product != null)
            {
                lstProductOption.Where(x => x.status_Delete == true).ToList().ForEach(x =>
                {
                    var option = lstOption.Where(v => v.id_Option == x.id_Option).FirstOrDefault();
                    data_CacPhienBan1.Rows.Add(
                        option.id_Option, option.option_Name);
                });
            }
        }
        void loadOPtionSP(int Idvariant)
        {
            data_CacPhienBan1.ColumnCount = 4;
            data_CacPhienBan1.Columns[0].Name = "ID_option";
            data_CacPhienBan1.Columns[0].Visible = false;
            data_CacPhienBan1.Columns[1].Name = "ID_vaLue";
            data_CacPhienBan1.Columns[1].Visible = false;
            data_CacPhienBan1.Columns[2].Name = "option_name";
            data_CacPhienBan1.Columns[2].HeaderText = "thuộc tính";
            data_CacPhienBan1.Columns[2].ReadOnly = true;
            data_CacPhienBan1.Columns[3].Name = "value_name";
            data_CacPhienBan1.Columns[3].HeaderText = "Đặc Điểm";
            data_CacPhienBan1.Rows.Clear();
            if (Idvariant == -2)
            {
                return;
            }
            else
            {
                var opptionProVar = _lstVariantOptionsOfProduct
                    .Where(c => c.ProductVariant.id_Variant == Idvariant
                        && c.Status == true)
                   .FirstOrDefault();
                foreach (var VARIABLE in opptionProVar.OptionValue)
                {
                    data_CacPhienBan1.Rows.Add(VARIABLE.id_Option, VARIABLE.id_Values,
                        opptionProVar.Option.Where(c => c.id_Option == VARIABLE.id_Option).Select(c => c.option_Name).FirstOrDefault(),
                        VARIABLE.option_Values);
                }
                grbPhienbanMoi.Enabled = true;
                _listOptionsestoAdd = opptionProVar.Option;
                _listOP_VAtoAdd = opptionProVar.OptionValue;
            }
        }
        void LoadSarnPham()
        {
            data_TenSanPham1.ColumnCount = 2;
            data_TenSanPham1.Columns[0].Name = "Tên Sản Phẩm";
            data_TenSanPham1.Columns[1].Name = "ID_Product";
            data_TenSanPham1.Columns[1].Visible = false;
            var btnAddPhienBanMoi = new DataGridViewButtonColumn();
            btnAddPhienBanMoi.Name = "addVariant";
            btnAddPhienBanMoi.HeaderText = "Thêm mẫu mới";
            btnAddPhienBanMoi.UseColumnTextForButtonValue = true;
            btnAddPhienBanMoi.Text = ("Add");
            data_TenSanPham1.Columns.Add(btnAddPhienBanMoi);
            data_TenSanPham1.Rows.Clear();
            foreach (var VARIABLE in PS_BUS.GetListProductses().Where(c => c.status_Delete == true))
            {
                data_TenSanPham1.Rows.Add(VARIABLE.products_Name, VARIABLE.id_Product);
            }
        }

        private void data_TenSanPham1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _rowindexSP = e.RowIndex;
            var indexcolumn = e.ColumnIndex;
            if (_rowindexSP < 0 ||
                _rowindexSP >= PS_BUS.GetListProductses().Where(c => c.status_Delete == true).Count()) return;
            _id_ProAdd = Convert.ToInt16(data_TenSanPham1.Rows[_rowindexSP].Cells["ID_Product"].Value.ToString());
            txtNameSp.Text = data_TenSanPham1.Rows[_rowindexSP].Cells["Tên Sản Phẩm"].Value.ToString();
            lblTenSpLoad.Text = data_TenSanPham1.Rows[_rowindexSP].Cells["Tên Sản Phẩm"].Value.ToString();
            txt_Masp.Text = default;
            txt_SoLuong.Text = default;
            txt_giaNhap.Text = default;
            txt_giaBan.Text = default;
            loadata(_id_ProAdd);
            loadOPtion(_id_ProAdd);
            button5.Enabled = false;
            if (indexcolumn == 2)
            {
                grbPhienbanMoi.Enabled = true;
                data_CacPhienBan1.AllowUserToAddRows = false;
                data_CacPhienBan1.AllowUserToDeleteRows = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var nameSp = txtNameSp.Text;
            var check = _litSanPhamCuThes
                .Where(x => x.Product.products_Name.ToUpper() == nameSp.ToUpper())
                .FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong hệ thống !", "Cảnh Báo");
                return;
            }
            LoadSarnPham();
            _Flag = false;
            txtNameSp.Text = default;
            var productDetail = new ProductDetail();
            productDetail.Product.products_Name = nameSp;
            for (int i = 0; i < data_CacPhienBan1.Rows.Count - 1; i++)
            {
                var option = new OPTIONS();
                option.option_Name = data_CacPhienBan1.Rows[i].Cells[1].Value.ToString();
                productDetail.Option.Add(option);
            }
            if (MessageBox.Show($"bạn có muốn thêm {nameSp} không?", " Thông báo!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var product = new PRODUCTS();
                product.products_Name = nameSp;
                MessageBox.Show(PS_BUS.addProductDetail(productDetail));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idpro = Convert.ToInt32(data_TenSanPham1.Rows[_rowindexSP].Cells[1].Value.ToString());
            var nameSp = txtNameSp.Text;
            var productDetail = new ProductDetail();
            productDetail.Product.products_Name = nameSp;
            productDetail.Product.id_Product = _id_ProAdd;
            for (int i = 0; i < data_CacPhienBan1.Rows.Count - 1; i++)
            {
                var option = new OPTIONS();
                option.option_Name = data_CacPhienBan1.Rows[i].Cells[1].Value.ToString();
                productDetail.Option.Add(option);
            }
            if (MessageBox.Show($"bạn có muốn Sửa sản phẩm không?", " Thông báo!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(PS_BUS.editProductDetail(productDetail));
            }
            LoadSarnPham();
            _Flag = false;
            txtNameSp.Text = default;
            button5.Enabled = true;
        }

        private void btn_XoaName_Click(object sender, EventArgs e)
        {
            var nameSp = txtNameSp.Text;
            if (MessageBox.Show($"bạn có muốn Xóa không?", " Thông báo!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var productDetail = new ProductDetail();
                productDetail.Product.products_Name = nameSp;
                productDetail.Product.id_Product = _id_ProAdd;
                for (int i = 0; i < data_CacPhienBan1.Rows.Count - 1; i++)
                {
                    var option = new OPTIONS();
                    option.option_Name = data_CacPhienBan1.Rows[i].Cells[1].Value.ToString();
                    productDetail.Option.Add(option);
                }
                MessageBox.Show(PS_BUS.removeProductDetail(productDetail));
                btnClear_Click(null, null);
            }
            LoadSarnPham();
            _Flag = false;
            txtNameSp.Text = default;
            button5.Enabled = true;
        }

        #endregion

        #region Phần của các chi tiết Sản Phẩm


        private void btn_AddVariant_Click(object sender, EventArgs e)
        {
            var productCode = txt_Masp.Text;
            var checkProductCode = _lstVariantOptionsOfProduct
                .Where(x => x.ProductVariant.Products_Code.ToUpper() == productCode.ToUpper())
                .Any();
            if (checkProductCode == true)
            {
                MessageBox.Show($"Mã sản phẩm : {productCode} đã tồn tại trong hệ thống !", "Thông báo");
                return;
            }
            if (MessageBox.Show($"bạn có muốn thêm sản phẩm {productCode} không?", " Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ///========================================================================================================================================================
               var aDetail = new ProductDetail();
                aDetail.Product.id_Product = _id_ProAdd;
                aDetail.ProductVariant.id_Product = _id_ProAdd;
                aDetail.ProductVariant.Products_Code = txt_Masp.Text;
                aDetail.ProductVariant.quantity = int.Parse(txt_SoLuong.Text);
                aDetail.ProductVariant.import_Price = int.Parse(txt_giaNhap.Text);
                aDetail.ProductVariant.price = int.Parse(txt_giaBan.Text);
                //----------------------------------------------------------------------------------------------------------------------------------------------
                for (int i = 0; i < data_CacPhienBan1.Rows.Count; i++)
                {
                    // thêm option_values
                    OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();
                    newOptionsValues.id_Option = int.Parse(data_CacPhienBan1.Rows[i].Cells[0].Value.ToString());
                    newOptionsValues.option_Values = data_CacPhienBan1.Rows[i].Cells[2].Value.ToString();
                    aDetail.OptionValue.Add(newOptionsValues);
                }
                MessageBox.Show(PS_BUS.addProductVariant(aDetail));
                _lstVariantOptionsOfProduct.Clear();
                int a = _id_ProAdd;
                _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
                loadata(_id_ProAdd);
            }
            data_CacPhienBan1.AllowUserToDeleteRows = true;
            data_CacPhienBan1.AllowUserToAddRows = true;
            grbPhienbanMoi.Enabled = false;
            _Flag = false;
            btnClear_Click(null, null);
        }

        private void btn_Editvariant_Click(object sender, EventArgs e)
        {
            ProductDetail aDetail = new ProductDetail();
            aDetail.Product.id_Product = _id_ProAdd;
            aDetail.ProductVariant.id_Product = _id_ProAdd;
            aDetail.ProductVariant.id_Variant = _idVariaant;
            aDetail.ProductVariant.Products_Code = txt_Masp.Text;
            aDetail.ProductVariant.quantity = Convert.ToInt32(txt_SoLuong.Text);
            aDetail.ProductVariant.import_Price = Convert.ToInt32(txt_giaNhap.Text);
            aDetail.ProductVariant.price = Convert.ToInt32(txt_giaBan.Text);
            //----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < data_CacPhienBan1.Rows.Count - 1; i++)
            {
                // thêm option_values
                OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();
                newOptionsValues.id_Option = Convert.ToInt16(data_CacPhienBan1.Rows[i].Cells[0].Value.ToString());
                newOptionsValues.id_Values = Convert.ToInt16(data_CacPhienBan1.Rows[i].Cells[1].Value.ToString());
                newOptionsValues.option_Values = data_CacPhienBan1.Rows[i].Cells[3].Value.ToString();
                aDetail.OptionValue.Add(newOptionsValues);
            }
            MessageBox.Show(PS_BUS.editProductVariant(aDetail));
            _lstVariantOptionsOfProduct.Clear();
            int a = _id_ProAdd;
            _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
            loadata(_id_ProAdd);
            btnClear_Click(null, null);
        }
        private void btn_xoaVariant_Click(object sender, EventArgs e)
        {
            ProductDetail aDetail = new ProductDetail();
            aDetail.Product.id_Product = _id_ProAdd;
            aDetail.ProductVariant.id_Product = _id_ProAdd;
            aDetail.ProductVariant.id_Variant = _idVariaant;
            aDetail.ProductVariant.Products_Code = txt_Masp.Text;
            aDetail.ProductVariant.quantity = Convert.ToInt32(txt_SoLuong.Text);
            aDetail.ProductVariant.import_Price = Convert.ToInt32(txt_giaNhap.Text);
            aDetail.ProductVariant.price = Convert.ToInt32(txt_giaBan.Text);

            //----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < data_CacPhienBan1.Rows.Count - 1; i++)
            {
                // thêm option_values
                OPTIONS_VALUES newOptionsValues = new OPTIONS_VALUES();
                newOptionsValues.id_Option = Convert.ToInt16(data_CacPhienBan1.Rows[i].Cells[0].Value.ToString());
                newOptionsValues.id_Values = Convert.ToInt16(data_CacPhienBan1.Rows[i].Cells[1].Value.ToString());
                newOptionsValues.option_Values = data_CacPhienBan1.Rows[i].Cells[3].Value.ToString();
                aDetail.OptionValue.Add(newOptionsValues);
            }

            MessageBox.Show(PS_BUS.removeProductVariant(aDetail));
            _lstVariantOptionsOfProduct.Clear();
            int a = _id_ProAdd;
            _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
            loadata(_id_ProAdd);
            btnClear_Click(null, null);
        }
        #endregion

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
                _idVariaant = Convert.ToInt16(data_ThongTinSanPham1.Rows[row].Cells["Id variant "].Value.ToString());
                loadOPtionSP(_idVariaant);
            }
        }

        private void data_CacPhienBan1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
        }

        private void txtNameSp_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNameSp.Text.Length == 0)
            {
                loadOPtion(-1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameSp.Text = default;
            loadOPtion(-1);
            button5.Enabled = true;
            grbPhienbanMoi.Enabled = false;
            data_CacPhienBan1.AllowUserToAddRows = true;
            data_CacPhienBan1.AllowUserToDeleteRows = true;
        }
    }
}