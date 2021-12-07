using _2_BUS.IService_BUS;
using _2_BUS.Models;
using _2_BUS.Service_BUS;
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
    public partial class FrmBaoCaoDoanhYhu : Form
    {
        private IProduct_Service _SP;
        private List<ProductDetail> _lstProductDetail;
        private IQLOrderService _IOder;
        private List<Order_OrderDetail> _lstItem;
        private List<Order_OrderDetail> _OrderFall;
        public FrmBaoCaoDoanhYhu()
        {
            InitializeComponent();
            _lstProductDetail = new List<ProductDetail>();
            _SP = new Service_formSP();
            _IOder = new QLOrDerService();
            _lstItem = _IOder.JoinTable();
            _OrderFall = new List<Order_OrderDetail>();
        }
        private void loadDGV()
        {
            var row = 0;
            dgvDoanhThu.ColumnCount = 5;
            dgvDoanhThu.Columns[row++].Name = "Thời gian";
            dgvDoanhThu.Columns[row++].Name = "Số đơn bán được";
            dgvDoanhThu.Columns[row++].Name = "Số Sp bán được";
            dgvDoanhThu.Columns[row++].Name = "Số đơn hủy";
            dgvDoanhThu.Columns[row++].Name = "Doanh thu";
            dgvDoanhThu.Rows.Clear();
        }
        private void loadDataNgay(string day)
        {
            var lstDetail = _lstItem
                .Where(x => x.Order.order_Time.ToString()
                .Split(" ")[0] == day)
                .GroupBy(i => i.Order.order_Time)
                .Select(z => z.First())
                .ToList();
            var countpay = lstDetail
                .Sum(x => x.Order.total_pay);
            var countProduct = lstDetail
                .Select(x => x.OrderDetail)
                .ToList().Count;
            var countOrder = lstDetail
                .Select(x => x.Order)
                .ToList().Count;
            var oderFall = lstDetail
                .Where(x => x.Order.order_status == 1)
                .ToList().Count;

            dgvDoanhThu.Rows.Add(day, countOrder, countProduct, oderFall, countpay);
        }
        private void loadDataThang(int month, int year)
        {
            var countpay = _lstItem
                .Where(x => x.Order.order_Time.Month == month)
                .GroupBy(i => i.Order.order_Time)
                .Select(j => j.First())
                .Sum(x => x.Order.total_pay);
            var lstDetail = _lstItem
                .Where(x => x.Order.order_Time.Month == month && x.Order.order_Time.Year == year)
                .ToList();
            var countProduct = lstDetail
                .Select(x => x.OrderDetail)
                .ToList().Count;
            var countOrder = lstDetail
                .Select(c => c.Order)
                .ToList().Count;
            var oderFall = lstDetail
                .Where(x => x.Order.order_status == 1)
                .ToList().Count;
            dgvDoanhThu.Rows.Add(month + "/" + year, countOrder, countProduct, oderFall, countpay);
        }
        private void loadDataNam(int year)
        {
            loadDGV();
            var item = _lstItem
                .Select(i => i.Order)
                .GroupBy(j=>j.order_Time)
                .Select(d=>d.First())
                .ToList();
            var detail = _lstItem
                .Select(x => x.OrderDetail)
                .ToList();
            var month = item
                .Where(x => x.order_Time.Year == year)
                .ToList();
            var countpay = item
                .Where(x => x.order_Time.Year == year)
                .Sum(x => x.total_pay);
            var lstDetail = _lstItem
                .Where(x => x.Order.order_Time.Year == year)
                .ToList();
            var countProduct = lstDetail
                .Select(x => x.OrderDetail)
                .ToList().Count;
            var countOrder = lstDetail
                .Select(x => x.Order)
                .ToList().Count;
            _OrderFall = lstDetail
                .Where(o => o.Order.order_status == 1)
                .ToList();
            dgvDoanhThu.Rows.Add(year, countOrder, countProduct, _OrderFall.Count, countpay);

        }
        private void rdbTKNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKNgay.Checked == true)
            {
                loadDGV();
                var lstDay = _lstItem
                    .GroupBy(x => x.Order.order_Time)
                    .Select(o => o.First())
                    .ToList();
                lstDay.ForEach(x =>
                {
                    loadDataNgay(x.Order.order_Time.ToString().Split(" ")[0]);
                });

            }
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            loadDGV();
            if (rdbThang.Checked == true)
            {
                var minyear = _lstItem.Min(x => x.Order.order_Time.Year);
                var maxyear = _lstItem.Max(x => x.Order.order_Time.Year);

                for (int mi = minyear; mi < maxyear + 1; mi++)
                {
                    for (int ji = 1; ji < 13; ji++)
                    {
                        loadDataThang(ji, mi);
                    }
                }
            }
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            var minyear = _lstItem.Min(x => x.Order.order_Time.Year);
            var maxyear = _lstItem.Max(x => x.Order.order_Time.Year);
            for (int mi = minyear; mi < maxyear + 1; mi++)
            {
                loadDataNam(mi);
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            loadDGV();
            var time = mcTime.SelectionRange.Start.ToString();
            time = time.Split(" ")[0];
            var listProductVariant = _IOder.getListProduct();
            var countpay = 0;
            countpay = _lstItem
                .Where(x => x.Order.order_Time.ToString()
                .Split(" ")[0] == time)
                .GroupBy(f => f.Order.order_Time)
                .Select(s => s.First())
                .Sum(x => x.Order.total_pay);
            var countOrder = _lstItem.
                Where(x => x.Order.order_Time.ToString()
                .Split(" ")[0] == time)
                .ToList().Count;
            var OrderFall = _lstItem
                .Where(x => x.Order.order_status == 1)
                .ToList();
            var countProduct = _lstItem
                .Where(z => z.Order.order_Time.ToString()
                .Split(" ")[0] == time)
                .Select(x => x.OrderDetail)
                .ToList().Count;

            dgvDoanhThu.Rows.Add(time, countOrder, countProduct, OrderFall.Count, countpay);
            lblNgay.Text = "Ngày làm việc : " + time;
            lblSoDon.Text = "Số đơn xuất ra : " + countOrder + "";
            lblSoSP.Text = "Số sản phẩm bán được : " + countProduct;
            lblSoDonHuy.Text = "Số đơn hủy : " + OrderFall.Count;
            lblDoanhThu.Text = "Doanh thu : " + countpay;
        }

        private void rdbNow_CheckedChanged(object sender, EventArgs e)
        {
            loadDGV();
            var time = DateTime.Now.ToString().Split(" ")[0];
            var countpay = 0;
            countpay = _lstItem
                .Where(x => x.Order.order_Time.ToString()
                .Split(" ")[0] == time)
                .Sum(x => x.Order.total_pay);
            var countOrder = _lstItem
                .Where(x => x.Order.order_Time.ToString()
                .Split(" ")[0] == time)
                .ToList().Count;
            var OrderFall = _lstItem
                .Where(x => x.Order.order_status == 1 && x.Order.order_Time.ToString() == time)
                .ToList();
            var countProduct = _lstItem
                .Where(z => z.Order.order_Time.ToString()
                .Split(" ")[0] == time)
                .Select(x => x.OrderDetail)
                .ToList().Count;

            dgvDoanhThu.Rows.Add(time, countOrder, countProduct, OrderFall.Count, countpay);
            lblNgay.Text = "Ngày làm việc : " + time;
            lblSoDon.Text = "Số đơn xuất ra : " + countOrder + "";
            lblSoSP.Text = "Số sản phẩm bán được : " + countProduct;
            lblSoDonHuy.Text = "Số đơn hủy : " + OrderFall.Count;
            lblDoanhThu.Text = "Doanh thu : " + countpay;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDonHuy.Controls.Add(childForm);
            this.pnDonHuy.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lblSoDonHuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDonHuy(_OrderFall), sender);
        }

        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0 || dgvDoanhThu.Rows[index].Cells[0].Value == null)
            {
                return;
            }
            var row = dgvDoanhThu.Rows[index];
            var time = row.Cells[0].Value + "";
            var timeSplit = time.Split('/');
            var test = timeSplit.Length;
            if (timeSplit.Length == 1)
            {
                _OrderFall = _lstItem
                    .Where(x => x.Order.order_Time.Year == int.Parse(time) && x.Order.order_status == 1)
                    .GroupBy(o=>o.Order.order_Time)
                    .Select(d=>d.First())
                    .ToList();
            }
            else if (timeSplit.Length == 2)
            {
                _OrderFall = _lstItem.Where(x =>
                x.Order.order_Time.Month == int.Parse(timeSplit[0])
                && x.Order.order_Time.Year == int.Parse(timeSplit[1])
                && x.Order.order_status == 1).GroupBy(f=>f.Order.order_Time)
                .Select(s=>s.First())
                .ToList();
            }
            else if(timeSplit.Length == 3)
            {
                _OrderFall = _lstItem.Where(x =>
                x.Order.order_Time.ToString()
                .Split(" ")[0] == time
                && x.Order.order_status == 1)
                    .GroupBy(f => f.Order.order_Time)
                    .Select(s => s.First())
                    .ToList();
            }
            else
            {
                _OrderFall.Clear();
            }
            lblNgay.Text = "Ngày làm việc : " + time;
            lblSoDon.Text = "Số đơn xuất ra : " + row.Cells[1].Value + "";
            lblSoSP.Text = "Số sản phẩm bán được : " + row.Cells[2].Value + "";
            lblSoDonHuy.Text = "Số đơn hủy : " + row.Cells[3].Value + "";
            lblDoanhThu.Text = "Doanh thu : " + row.Cells[4].Value + "";
            lblSoDonHuy_Click(null, null);
        }
    }
}
