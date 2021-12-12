using DAL_DataAccessLayers;
using DAL_DataAccessLayers.IServices;
using DAL_DataAccessLayers.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FormQuenMatKhau : Form
    {
        IEmployeeService employeeService;
        string email;
        public FormQuenMatKhau(string tk)
        {
            InitializeComponent();
            employeeService = new EMPLOYEES_Service();
            email = tk;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            EMPLOYEES eMPLOYEES = employeeService.getListEMPLOYEES().Where(c => c.Email == email).FirstOrDefault();
            if (eMPLOYEES.PassWord == txt_mkc.Text)
            {
                if (txt_mkm.Text == txt_nlmk.Text)
                {
                    eMPLOYEES.PassWord =txt_mkm.Text;

                    employeeService.EditEMPLOYEES(eMPLOYEES);
                    this.Hide();
                    FormDangNhap formDangNhap= new FormDangNhap();
                    formDangNhap.Show();
                }
                else
                {
                    MessageBox.Show("Nhập sai thông tin", "Thông báo");
                }
            }
        }
    }
}
