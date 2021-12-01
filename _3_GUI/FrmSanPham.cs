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
            data_ThongTinSanPham1.ColumnCount = 15 + PS_BUS.getCountOption().Count();
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
      
    }
}