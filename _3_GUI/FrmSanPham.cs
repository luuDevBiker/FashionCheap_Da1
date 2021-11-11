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
      
        private List<SanPhamCuThe> _litSanPhamCuThes;
        public FrmSanPham()
        {
            InitializeComponent();
            PS_BUS = new Service_formSP();
            _litSanPhamCuThes = new List<SanPhamCuThe>();
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

            foreach (var x in _litSanPhamCuThes)
            {
                data_Sanpham.Rows.Add(x.TenSp,x.OptionValues,x.SoLuong,x.GiaNhap,x.Giaban);
            }
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
