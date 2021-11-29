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
using _2_BUS.Service_BUS;

namespace _3_GUI
{
    public partial class FormBanHang : Form
    {
        private IProduct_Service SP_BUS;

        public FormBanHang()
        {
            SP_BUS = new Service_formSP();
            InitializeComponent();
            loadSP();
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
        void loadSP()
        {

            DGV_SanPham.ColumnCount = 15 + SP_BUS.getCountOption().Count();
            var row = 0;
            DGV_SanPham.Columns[row++].Name = "Tên Sản Phẩm";
            DGV_SanPham.Columns[row++].Name = "Mã sản phẩm";
            DGV_SanPham.Columns[row++].Name = "Số Lượng";
            DGV_SanPham.Columns[row++].Name = "Gía Nhập";
            DGV_SanPham.Columns[row++].Name = "Gía Bán";
            DGV_SanPham.Columns[row].Name = "Id Sản Phẩm";
            DGV_SanPham.Columns[row++].Visible = false;
            DGV_SanPham.Columns[row].Name = "Id variant ";
            DGV_SanPham.Columns[row++].Visible = false;
            SP_BUS.getCountOption().ForEach(x =>
            {
                DGV_SanPham.Columns[row].Name = "Id option " + x.id_Option;
                DGV_SanPham.Columns[row++].Visible = false;
                DGV_SanPham.Columns[row].Name = "Id Value" + x.id_Option;
                DGV_SanPham.Columns[row++].Visible = false;
                DGV_SanPham.Columns[row++].Name = x.option_Name;
            });
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                DGV_SanPham.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.DGV_SanPham.Columns.Add(button);
            }
            DGV_SanPham.Rows.Clear();

            foreach (var x in SP_BUS.LoadDatafromDAL())
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
                DGV_SanPham.Rows.Add(objcell.ToArray());
            }
        }
        private void theoMãSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLocMaSP(), sender);
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTheoDanhSach(), sender);
        }

        private void thươngHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrnLocThuongHieu(), sender);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
