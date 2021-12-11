using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.IService_BUS;
using _2_BUS.Service_BUS;
using DAL_DataAccessLayers;
using DAL_DataAccessLayers.Service;

namespace _3_GUI
{
    public partial class FrmNhanVien : Form
    {
        private IQLEmployeesService _iQlEmployeesService;
        private string _TenNhanVien;
        private string _sdt;
        private List<EMPLOYEES> _lstEmployees;
        private EMPLOYEES NV;

        public FrmNhanVien()
        {
            InitializeComponent();
            _iQlEmployeesService = new QLEmployessService();
            _lstEmployees = new List<EMPLOYEES>();
            Loaddata();
            NV = new EMPLOYEES();
            txt_dataemail.Visible = false;
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
            data_NhanVien.ColumnCount = 8;
            data_NhanVien.Columns[0].Name = "Tên Nhân Viên";
            data_NhanVien.Columns[1].Name = "Giới Tính";
            data_NhanVien.Columns[2].Name = "Số Điện Thoại";
            data_NhanVien.Columns[3].Name = "Địa Chỉ";
            data_NhanVien.Columns[4].Name = "Email";
            data_NhanVien.Columns[5].Name = "NămSinh";
            data_NhanVien.Columns[6].Name = "Trạng Thái";
            data_NhanVien.Columns[7].Name = "Id";
            data_NhanVien.Columns[7].Visible = false;
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
            var lst = _iQlEmployeesService.GetlstEmployeeses();
            MessageBox.Show(lst.Max(i => i.id_Employee) + "");
            foreach (var x in _iQlEmployeesService.GetlstEmployeeses())

            {
                string abc = x.address;
                data_NhanVien.Rows.Add(x.employee_Name, x.sex == true ? "Nam" : "Nữ", x.NumberPhone, x.address, x.Email,
                    x.bridDate, x.status ? "Hoạt Động" : "Không Hoạt Động", x.id_Employee);
                
            }

        }

        void loadataSearch(string ten)
        {
            _iQlEmployeesService.GetlstEmployeeses();
            data_NhanVien.ColumnCount = 8;
            data_NhanVien.Columns[0].Name = "Tên Nhân Viên";
            data_NhanVien.Columns[1].Name = "Giới Tính";
            data_NhanVien.Columns[2].Name = "Số Điện Thoại";
            data_NhanVien.Columns[3].Name = "Địa Chỉ";
            data_NhanVien.Columns[4].Name = "Email";
            data_NhanVien.Columns[5].Name = "Năm Sinh";
            data_NhanVien.Columns[6].Name = "Trạng Thái";
            data_NhanVien.Columns[7].Name = "Id";
            data_NhanVien.Columns[7].Visible = false;
            data_NhanVien.Rows.Clear();
            foreach (var x in _iQlEmployeesService.GetlstEmployeeses())
            {
                data_NhanVien.Rows.Add(x.employee_Name, x.sex == true ? "Nam" : "Nữ", x.NumberPhone, x.address, x.Email,
                    x.bridDate, x.status ? "Hoạt Động" : "Không Hoạt Động" ,x.id_Employee);
            }
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            loadataSearch(tbx_TimKiem.Text);
        }

        private void data_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index<0||index >=_iQlEmployeesService.GetlstEmployeeses().Count) return;
           
            tbx_Ten.Text = data_NhanVien.Rows[index].Cells[0].Value.ToString();
            tbx_SĐT.Text = data_NhanVien.Rows[index].Cells[2].Value.ToString();
            tbx_DiaChi.Text = data_NhanVien.Rows[index].Cells[3].Value.ToString();
            tbx_Email.Text = data_NhanVien.Rows[index].Cells[4].Value.ToString();
            cbx_HoatDong.Checked = data_NhanVien.Rows[index].Cells[6].Value.ToString() == "Hoạt Động" ? true : false;
            cbx_KhongHoatDong.Checked =
                data_NhanVien.Rows[index].Cells[6].Value.ToString() == "Không Hoạt Động" ? true : false;
            string ab = data_NhanVien.Rows[index].Cells[7].Value.ToString();
            NV = _iQlEmployeesService.GetlstEmployeeses().Where(c => c.id_Employee == Convert.ToInt16( data_NhanVien.Rows[index].Cells[7].Value.ToString())).FirstOrDefault();
           cbm_NamSinh.Text = data_NhanVien.Rows[index].Cells[5].Value.ToString();
            cbx_Nam.Checked = data_NhanVien.Rows[index].Cells[1].Value.ToString() == "Nam" ? true : false;
            cbx_Nu.Checked = data_NhanVien.Rows[index].Cells[1].Value.ToString() == "Nữ" ? true : false;

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
                
                 MessageBox.Show(_iQlEmployeesService.add(employes)+ _iQlEmployeesService.Save(),"Thông Báo");
                
            }
            Loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            NV.employee_Name = tbx_Ten.Text;
            NV.address = tbx_DiaChi.Text;
            NV.Email = tbx_Email.Text;
            NV.status = cbx_HoatDong.Checked;
            NV.sex = cbx_Nam.Checked ? true : false;
            if ((MessageBox.Show("Bạn có chắc chắn muốn sửa?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                 MessageBox.Show(_iQlEmployeesService.Update(NV));
            }
            Loaddata();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
           
            cbx_Nam.Checked = true;
            if ((MessageBox.Show("Bạn có chắc chắc sẽ Xóa?",
                "Thông báo !!!!!!!!!!!!!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show(_iQlEmployeesService.Remove(NV));
            }
            Loaddata();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Nam.Checked == true)
            {
                cbx_Nu.Checked = false;
            }
        }

        private void cbx_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Nu.Checked == true)
            {
                cbx_Nam.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromExecl frrFromExecl = new FromExecl();
            frrFromExecl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuiMailHangLoat fmGuiMailHangLoat = new GuiMailHangLoat();
            fmGuiMailHangLoat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_dataemail.Text = saveFileDialog.FileName;
                    //
                    TextWriter textWriter = new StreamWriter(txt_dataemail.Text);
                    for (int i = 0; i < data_NhanVien.RowCount - 1; i++)//row
                    {

                        textWriter.Write(Convert.ToString(data_NhanVien.Rows[i].Cells["Email"].Value + "\n"));

                    }
                    textWriter.Close();
                    for (int i = 0; i < 2; i++)
                    {
                        
                    }
                }
            }
        }
    }

}
