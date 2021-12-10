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
using DAL_DataAccessLayers;

namespace _3_GUI
{
    public partial class FrmKhachHang : Form
    {
        private IQLCustomerService _iqlcustomersService;
        private string _TenKhachHang;
        private string _sdt;
        private List<CUSTOMERS> _lstCustomerses;
        private IQLCustomerService _iqLCustomer;
        private IQLCustomerService _lstCustomerService;
        public FrmKhachHang()
        {
            InitializeComponent();
            _iqlcustomersService = new QLCustomerService();
            _lstCustomerses = new List<CUSTOMERS>();
            _iqLCustomer = new QLCustomerService();
            _lstCustomerService = new QLCustomerService();
            foreach (var x in _lstCustomerService.GetlstCustomerses())
            {
                cbxTenKhachHang.Items.Add(x.customer_Name);
                cbxTenKhachHang.SelectedIndex = 0;
            }
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
            Data_KhachHang.ColumnCount = 7;
            Data_KhachHang.Columns[0].Name = "Tên Khách Hàng";
            Data_KhachHang.Columns[1].Name = "Giới Tính";
            Data_KhachHang.Columns[2].Name = "Số Điện Thoại";
            Data_KhachHang.Columns[3].Name = "Địa Chỉ";
            Data_KhachHang.Columns[4].Name = "Email";
            Data_KhachHang.Columns[5].Name = "Số Tài Khoản Khách Hàng";
            Data_KhachHang.Columns[6].Name = "Loại Khách Hàng";
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Add");
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                Data_KhachHang.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.Data_KhachHang.Columns.Add(button);
            }
            Data_KhachHang.Rows.Clear();
            foreach (var x in _iqLCustomer.GetlstCustomerses())
            {
                Data_KhachHang.Rows.Add(x.customer_Name, x.sex ? "Nam" : "Nữ", x.numberPhone, x.address, x.email, x.account_Number, x.customer_Type);
            }
        }

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
        }
        void loadataSearch(string ten)
        {
            _iqlcustomersService.GetlstCustomerses();
            Data_KhachHang.ColumnCount = 7;
            Data_KhachHang.Columns[0].Name = "Tên Khách Hàng";
            Data_KhachHang.Columns[1].Name = "Giới Tính";
            Data_KhachHang.Columns[2].Name = "Số Điện Thoại";
            Data_KhachHang.Columns[3].Name = "Địa Chỉ";
            Data_KhachHang.Columns[4].Name = "Email";
            Data_KhachHang.Columns[5].Name = "Số Tài Khoản Khách Hàng";
            Data_KhachHang.Columns[6].Name = "Loại Khách Hàng";
            Data_KhachHang.Rows.Clear();
            foreach (var x in _iqlcustomersService.Search(ten))
            {
                Data_KhachHang.Rows.Add(x.customer_Name, x.sex ? "Nam" : "Nữ", x.numberPhone, x.address, x.email, x.account_Number, x.customer_Type);
            }
        }

        private void Data_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cbxTenKhachHang.Text = Data_KhachHang.Rows[index].Cells[0].Value.ToString();
            cbxNam.Checked = Data_KhachHang.Rows[index].Cells[1].Value.ToString() == "Nam" ? true : false;
            cbxNu.Checked = Data_KhachHang.Rows[index].Cells[1].Value.ToString() == "Nam" ? true : false;
            cbxKhac.Checked = Data_KhachHang.Rows[index].Cells[1].Value.ToString() == "Nam" ? true : false;
            tbxsdt.Text = Data_KhachHang.Rows[index].Cells[2].Value.ToString();
            tbxDiaChi.Text = Data_KhachHang.Rows[index].Cells[3].Value.ToString();
            tbxGmail.Text = Data_KhachHang.Rows[index].Cells[4].Value.ToString();

            var kh = _iqLCustomer.GetlstCustomerses().Where(c => c.account_Number == Convert.ToInt32(tbxsdt.Text)).FirstOrDefault();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var idKh = _iqLCustomer.GetlstCustomerses().Where(c => c.customer_Name == cbxTenKhachHang.Text)
                .Select(c => c.id_Customer).FirstOrDefault();
            CUSTOMERS customers = new CUSTOMERS();
            customers.id_Customer = idKh;
            customers.customer_Name = cbxTenKhachHang.Text;
            customers.sex = cbxNam.Checked;
            customers.account_Number = Convert.ToInt32(tbxsdt.Text);
            customers.address = tbxDiaChi.Text;
            customers.email = tbxGmail.Text;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iqLCustomer.add(customers));
            }
            loadata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = _iqlcustomersService.GetlstCustomerses().Where(c => c.customer_Name == _sdt).FirstOrDefault();
            kh.customer_Name = cbxTenKhachHang.Text;
            kh.address = tbxDiaChi.Text;
            //kh.sex = cbxNam.Checked ? "Nam" : "Nữ";
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iqlcustomersService.EditKH(kh));
            }
            loadata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kh = _iqlcustomersService.GetlstCustomerses().Where(c => c.customer_Name == _sdt).FirstOrDefault();
            kh.address = tbxDiaChi.Text;
            cbxNam.Checked = true;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iqlcustomersService.Remove(kh));
            }
            loadata();
        }

        private void cbxNam_Click(object sender, EventArgs e)
        {
            if (cbxNam.Checked)
            {
                cbxNu.Checked = false;
                cbxKhac.Checked = false;
            }
        }

        private void cbxNu_Click(object sender, EventArgs e)
        {
            if (cbxNu.Checked)
            {
                cbxNam.Checked = false;
                cbxKhac.Checked = false;
            }
        }

        private void cbxKhac_Click(object sender, EventArgs e)
        {
            if (cbxKhac.Checked)
            {
                cbxNam.Checked = false;
                cbxNu.Checked = false;
            }
        }
    }
}
