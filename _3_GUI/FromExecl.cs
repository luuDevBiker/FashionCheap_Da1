using _2_BUS.IService_BUS;
using _2_BUS.Service_BUS;
using DAL_DataAccessLayers;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FromExecl : Form
    {
        private IQLEmployeesService invser;
        private int id_Employees;
        private string employee_Names = "";
        private bool sexs;
        private DateTime bridDates;
        private string addresss = "";
        private string NumberPhones = "";
        private string Emails = "";
        private string PassWords = "";
        private bool statuss;
        private EMPLOYEES _NV;
        public FromExecl()
        {
            InitializeComponent();
            invser = new QLEmployessService();

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.FileName = txt_File.Text;
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_File.Text = openFileDialog.FileName;
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Import File Excel Lên Hay Không ?", "Thông Báo", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + txt_File.Text + "';Extended Properties=Excel 12.0 Xml;");
                conn.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", conn);
                DataSet theSD = new DataSet();
                DataTable dt = new DataTable();
                //dataAdapter.Fill(dt);
                this.dataGridView1.DataSource = dt.DefaultView;
                for (int i = 0; i < 2; i++)
                {
                  //  this.Alert("Import Thành Công Rực Rỡ");
                }
                return;
            };

            if (dialogResult == DialogResult.No)
            {
                for (int i = 0; i < 2; i++)
                {
                    // this.AlertErr("Import Thất Bại");
                }
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Các Sản Phẩm Ở File Excel Vào Database Hay Không ?", "Thông Báo", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //hh
                    employee_Names = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    sexs = Convert.ToBoolean(dataGridView1.Rows[i].Cells[1].Value);
                    bridDates = Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value);
                    addresss = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    NumberPhones = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);

                    Emails = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    PassWords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    statuss = Convert.ToBoolean(dataGridView1.Rows[i].Cells[7].Value);



                    _NV = new EMPLOYEES
                    {
                        employee_Name = employee_Names,
                        sex = sexs,
                        bridDate = bridDates,
                        address = addresss,
                        NumberPhone = NumberPhones,
                        Email = Emails,
                        PassWord = PassWords,
                        status = statuss

                    };
                    var mess2 = invser.add(_NV);
                    var mess1 =  invser.Save();
                    //    for (int i = 0; i < 2; i++)
                    //    {
                    //      //  this.Alert("Thêm Thành Công");
                    //    }
                    //    return;



                    //};
                    //if (dialogResult == DialogResult.No)
                    //{
                    //    for (int i = 0; i < 2; i++)
                    //    {
                    //      //  this.AlertErr("Thêm Thất Bại");
                    //    }
                    //    return;
                    //}
                }

            }
        }
    }
}

