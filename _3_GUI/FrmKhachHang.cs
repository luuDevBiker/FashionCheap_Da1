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
        public FrmKhachHang()
        {
            InitializeComponent();
            _iqlcustomersService = new QLCustomerService();
            _lstCustomerses = new List<CUSTOMERS>();
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
            foreach (var x in _iqlcustomersService.GetlstCustomerses())
            {
                Data_KhachHang.Rows.Add(x.customer_Name, x.sex ? "Nam" : "Nữ", x.numberPhone, x.address, x.email, x.account_Number, x.customer_Type);
            }
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

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbxTimKiem.Text);
        }

        private void Data_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxsdt.Text = Data_KhachHang.Rows[index].Cells[0].Value.ToString();
            tbxTenKhachHang.Text = Data_KhachHang.Rows[index].Cells[1].Value.ToString();
            tbxDiaChi.Text = Data_KhachHang.Rows[index].Cells[2].Value.ToString();
            tbxGmail.Text = Data_KhachHang.Rows[index].Cells[3].Value.ToString();
            cbxNam.Checked = Data_KhachHang.Rows[index].Cells[4].Value.ToString() == "Nam" ? true : false;
            cbxNu.Checked = Data_KhachHang.Rows[index].Cells[4].Value.ToString() == "Nữ" ? true : false;
            cbxKhac.Checked = Data_KhachHang.Rows[index].Cells[4].Value.ToString() == "Khác" ? true : false;
            var kh = _iqlcustomersService.GetlstCustomerses().Where(c => c.customer_Name == tbxsdt.Text).FirstOrDefault();
            //if (kh.sex == "Nam")
            //{
            //    cbxNam.Checked = true;
            //}
            //else
            //{
            //    cbxNu.Checked = true;
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CUSTOMERS customers = new CUSTOMERS();
            _sdt = customers.numberPhone = tbxsdt.Text;
            customers.customer_Name = tbxTenKhachHang.Text;
            customers.sex = cbxNam.Checked;
            customers.address = tbxDiaChi.Text;
            customers.email = tbxGmail.Text;
            //customers.account_Number
            //customers.customer_Type
            if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                 "Thông báo !!!!!!!!!!!!!!!",
                 MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iqlcustomersService.add(customers));
            }
            loadata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = _iqlcustomersService.GetlstCustomerses().Where(c => c.customer_Name == _sdt).FirstOrDefault();
            kh.customer_Name = tbxTenKhachHang.Text;
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
