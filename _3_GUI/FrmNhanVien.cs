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
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;

namespace _3_GUI
{
    public partial class FrmNhanVien : Form
    {
        private IEmployeeService _iQlEmployeesService;
        private string _TenNhanVien;
        private string _sdt;
        private List<EMPLOYEES> _lstEmployees;

        public FrmNhanVien()
        {
            InitializeComponent();
            _iQlEmployeesService = new EMPLOYEES_Service();
            _lstEmployees = new List<EMPLOYEES>();
            Loaddata();
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

        void Loaddata()
        {
            data_NhanVien.ColumnCount = 7;
            data_NhanVien.Columns[0].Name = "Tên Nhân Viên";
            data_NhanVien.Columns[1].Name = "Giới Tính";
            data_NhanVien.Columns[2].Name = "Số Điện Thoại";
            data_NhanVien.Columns[3].Name = "Địa Chỉ";
            data_NhanVien.Columns[4].Name = "Email";
            data_NhanVien.Columns[5].Name = "NămSinh";
            data_NhanVien.Columns[6].Name = "Trạng Thái";
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            {
                comboBox.Name = "cmb_dgv";
                comboBox.HeaderText = "Chức năng";
                comboBox.Items.Add("Add");
                comboBox.Items.Add("Update");
                comboBox.Items.Add("Delete");
                data_NhanVien.Columns.Add(comboBox);
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btn_dgv";
                button.HeaderText = "OK";
                button.Text = ("OK");
                button.UseColumnTextForButtonValue = true;
                this.data_NhanVien.Columns.Add(button);
            }
            data_NhanVien.Rows.Clear();
            var lst = _iQlEmployeesService.getListEMPLOYEES();
            MessageBox.Show(lst.Max(i => i.id_Employee) + "");
            foreach (var x in _iQlEmployeesService.getListEMPLOYEES())
            {
                data_NhanVien.Rows.Add(x.employee_Name, x.sex ? "Nam" : "Nữ", x.NumberPhone, x.address, x.Email,
                    x.bridDate, x.status ? "Hoạt Động" : "Không Hoạt Động");
            }

        }

        void loadataSearch(string ten)
        {
            _iQlEmployeesService.getListEMPLOYEES();
            data_NhanVien.ColumnCount = 7;
            data_NhanVien.Columns[0].Name = "Tên Nhân Viên";
            data_NhanVien.Columns[1].Name = "Giới Tính";
            data_NhanVien.Columns[2].Name = "Số Điện Thoại";
            data_NhanVien.Columns[3].Name = "Địa Chỉ";
            data_NhanVien.Columns[4].Name = "Email";
            data_NhanVien.Columns[5].Name = "Năm Sinh";
            data_NhanVien.Columns[6].Name = "Trạng Thái";
            data_NhanVien.Rows.Clear();
            foreach (var x in _iQlEmployeesService.getListEMPLOYEES())
            {
                data_NhanVien.Rows.Add(x.employee_Name, x.sex ? "Nam" : "Nữ", x.NumberPhone, x.address, x.Email,
                    x.bridDate, x.status ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbx_TimKiem.Text);
        }

        private void data_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //            tbx_Ten.Text = data_NhanVien.Rows[index].Cells[0].Value.ToString();
            tbx_SĐT.Text = data_NhanVien.Rows[index].Cells[1].Value.ToString();
            tbx_DiaChi.Text = data_NhanVien.Rows[index].Cells[2].Value.ToString();
            tbx_Email.Text = data_NhanVien.Rows[index].Cells[3].Value.ToString();
            cbx_HoatDong.Checked = data_NhanVien.Rows[index].Cells[4].Value.ToString() == "Hoạt Động" ? true : false;
            cbx_KhongHoatDong.Checked =
                data_NhanVien.Rows[index].Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false;
            var NV = _iQlEmployeesService.getListEMPLOYEES().Where(c => c.NumberPhone == tbx_SĐT.Text).FirstOrDefault();
            //if (NV.sex == "Nam")
            //{
            //    cbx_Nam.Checked = true;
            //}
            //else
            //{
            //    cbx_Nu.Checked = true;
            //}
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            EMPLOYEES employes = new EMPLOYEES();
            _sdt = employes.NumberPhone = tbx_SĐT.Text;
            employes.employee_Name = tbx_Ten.Text;
            employes.sex = cbx_Nam.Checked;
            employes.address = tbx_DiaChi.Text;
            employes.Email = tbx_Email.Text;
            if ((MessageBox.Show("Bạn có chắc chắn muốn thêm?",
                 "Thông báo !!!!!!!!!!!!!!!",
                 MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                 MessageBox.Show(_iQlEmployeesService.AddEMPLOYEES(employes));
            }
            Loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var NV = _iQlEmployeesService.getListEMPLOYEES().Where(c => c.employee_Name == _sdt).FirstOrDefault();
            NV.employee_Name = tbx_Ten.Text;
            NV.address = tbx_DiaChi.Text;
            NV.Email = tbx_Email.Text;
            NV.status = cbx_HoatDong.Checked;
            //NV.sex = cbx_Nam.Checked ? "Nam" : "Nữ";
            if ((MessageBox.Show("Bạn có chắc chắn muốn sửa?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                 MessageBox.Show(_iQlEmployeesService.EditEMPLOYEES(NV));
            }
            Loaddata();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var NV = _iQlEmployeesService.getListEMPLOYEES().Where(c => c.employee_Name == _sdt).FirstOrDefault();
           // NV.NumberPhone = 0;
            cbx_Nam.Checked = true;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ Xóa?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iQlEmployeesService.DeleteEMPLOYEES(NV));
            }
            Loaddata();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {

        }
    }

}
