using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_DataAccessLayers;
using _2_BUS.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace _3_GUI
{
    public partial class FrmSanPham : Form
    {
        //private IQLPRODUCSService _iqlproducsService;
        private string _TenSP;
        private string _Theloai;
        private List<PRODUCTS> _lstProductses;
        private List<PRODUCTS_VARIANTS> _lstProductsVariantses;
        private List<PRODUCTS_OPTIONS> _lsProductsOptionses;
        private List<IMAGES_PRODUCTS> _lstImagesProductses;
        private List<VARIANTS_VALUES> _lstVariantsValueses;
        private List<OPTIONS> _lsOptionses;
        private List<OPTIONS_VALUES> _lstOptionsValueses;
        private List<SanPhamCuThe> _litSanPhamCuThes;
        public FrmSanPham()
        {
            InitializeComponent();
            _lstProductses = new List<PRODUCTS>();
            _lstProductses = new List<PRODUCTS>();
            _lstProductsVariantses = new List<PRODUCTS_VARIANTS>();
            _lsProductsOptionses = new List<PRODUCTS_OPTIONS>();
            _lstImagesProductses = new List<IMAGES_PRODUCTS>();
            _lstVariantsValueses = new List<VARIANTS_VALUES>();
            _lsOptionses = new List<OPTIONS>();
            _lstOptionsValueses = new List<OPTIONS_VALUES>();
            _litSanPhamCuThes = new List<SanPhamCuThe>();
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
            data_Sanpham.ColumnCount = 9;
            data_Sanpham.Columns[0].Name = "Tên Sản Phẩm";
            data_Sanpham.Columns[1].Name = "Thể Loại";
            data_Sanpham.Columns[2].Name = "Đặc Tính";
            data_Sanpham.Columns[3].Name = "Số Lượng";
            data_Sanpham.Columns[4].Name = "Màu sắc";
            data_Sanpham.Columns[5].Name = "Kích Cỡ";
            data_Sanpham.Columns[6].Name = "Thương Hiệu";
            data_Sanpham.Columns[7].Name = "Gía Nhập";
            data_Sanpham.Columns[8].Name = "Gía Bán";
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Add");
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

            //var lisst=( from a in _lstVariantsValueses
            //    join b in _lstOptionsValueses on a.id_Option &a.id_Values equals b.id_Option & b.id_Values
            //                     join c in _lsOptionses on b.id_Option equals c.id_Option
            //    join d in _lsProductsOptionses on a.id_Option&a.id_Product equals d.id_Option&d.id_Product
            //    join e in _lstProductsVariantses on a.id_Variant & a.id_Product equals e.id_Variant & e.id_Product
            //    join f in _lstProductses on e.id_Product equals f.id_Product
            //    select new {f.products_Name, b.option_Values, a.quantity, a.import_Price, a.price}).ToList();
            //foreach (var x in lisst)
            //{
            //    data_Sanpham.Rows.Add(x.products_Name, x.option_Values, x.quantity,x.import_Price,x.price);
            //}
        }

        void loadataSearch(string ten)
        {
            //_iqlproducsService.GetlstProducts();
            data_Sanpham.ColumnCount = 9;
            data_Sanpham.Columns[0].Name = "Tên Sản Phẩm";
            data_Sanpham.Columns[1].Name = "Thể Loại";
            data_Sanpham.Columns[2].Name = "Đặc Tính";
            data_Sanpham.Columns[3].Name = "Số Lượng";
            data_Sanpham.Columns[4].Name = "Màu sắc";
            data_Sanpham.Columns[5].Name = "Kích Cỡ";
            data_Sanpham.Columns[6].Name = "Thương Hiệu";
            data_Sanpham.Columns[7].Name = "Gía Nhập";
            data_Sanpham.Columns[8].Name = "Gía Bán";
            data_Sanpham.Rows.Clear();
            //foreach (var VARIABLE in _iqlproducsService.Search(ten))
            //{
            //     data_Sanpham.Rows.Add(x.products_Name, x.option_Values, x.quantity,x.import_Price,x.price);
            //}
        }

        private void tbxLocThuongHieu_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
        }

        private void tbxLocMau_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
        }

        private void tbxLocKichThuoc_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
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
    }
}
