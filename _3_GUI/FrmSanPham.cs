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
        private string _TenSP;
        private string _Theloai;

        private List<ProductDetail> _litSanPhamCuThes;
        public FrmSanPham()
        {
            InitializeComponent();
            PS_BUS = new Service_formSP();
            _litSanPhamCuThes = new List<ProductDetail>();
            _litSanPhamCuThes = PS_BUS.LoadDatafromDAL();
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
            data_Sanpham.ColumnCount = 15 + PS_BUS.getCountOption().Count();
            var row = 0;
            data_Sanpham.Columns[row++].Name = "Tên Sản Phẩm";
            data_Sanpham.Columns[row++].Name = "Mã sản phẩm";
            data_Sanpham.Columns[row++].Name = "Số Lượng";
            data_Sanpham.Columns[row++].Name = "Gía Nhập";
            data_Sanpham.Columns[row++].Name = "Gía Bán";
            data_Sanpham.Columns[row].Name = "Id Sản Phẩm";
            data_Sanpham.Columns[row++].Visible = false;
            data_Sanpham.Columns[row].Name = "Id variant ";
            data_Sanpham.Columns[row++].Visible = false;
            PS_BUS.getCountOption().ForEach(x =>
            {
                data_Sanpham.Columns[row].Name = "Id option " + x.id_Option;
                data_Sanpham.Columns[row++].Visible = false;
                data_Sanpham.Columns[row].Name = "Id Value" + x.id_Option;
                data_Sanpham.Columns[row++].Visible = false;
                data_Sanpham.Columns[row++].Name = x.option_Name;
            });
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                data_Sanpham.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.data_Sanpham.Columns.Add(button);
            }
            data_Sanpham.Rows.Clear();

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
                data_Sanpham.Rows.Add(objcell.ToArray());

            }
        }
        private void data_Sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var row = data_Sanpham.Rows[index];
            txtTenSp.Text = row.Cells[0].Value + "";
            txtMaSP.Text = row.Cells[1].Value + "";
            txtSL.Text = row.Cells[2].Value + "";
            txtNhap.Text = row.Cells[3].Value + "";
            txtBan.Text = row.Cells[4].Value + "";
            //txtMau.Text = row.Cells[9].Value + "";
            //txtSize.Text = row.Cells[12].Value + "";
            //txtTheLoai.Text = row.Cells[15].Value + "";
            //txtThuonghieu.Text = row.Cells[18].Value + "";
        }
        private void tbxLocThuongHieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxLocMau_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxLocKichThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_Sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PRODUCTS products = new PRODUCTS();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanloai_Click(object sender, EventArgs e)
        {

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void lblTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewPrd_Click(object sender, EventArgs e)
        {
            if (txtTenSp.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm", "ERROR");
                return;
            }
            var name = txtTenSp.Text;
            MessageBox.Show(PS_BUS.addNewProduct(name));
        }
    }
}