using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chang
{
    public partial class _7dangnhap : Form
    {
        public _7dangnhap()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelhome.Controls.Add(childForm);
            this.panelhome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }

        private void btncdg_Click(object sender, EventArgs e)
        {

            OpenChildForm(new _8dangnhap2(), sender);
        }
    }
}
