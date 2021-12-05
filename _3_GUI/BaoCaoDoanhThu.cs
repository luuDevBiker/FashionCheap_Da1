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

        public FrmBaoCaoDoanhYhu()
        {
            InitializeComponent();
            _lstProductDetail = new List<ProductDetail>();
            _SP = new Service_formSP();
            _IOder = new QLOrDerService();
        }

        private void loadDataNgay()
        {
            var row = 0;
            dgvDoanhThu.ColumnCount = 4;
            dgvDoanhThu.Columns[row++].Name = "Ngày";
            dgvDoanhThu.Columns[row++].Name = "Doanh thu";
            dgvDoanhThu.Columns[row++].Name = "Tiền vốn";
            dgvDoanhThu.Columns[row++].Name = "Lợi nhuận";
            dgvDoanhThu.Rows.Clear();
            var lstItem = _IOder.JoinTable();
            var item = lstItem.GroupBy(x => x.Order.order_Time).Select(x => x).ToList();
            var listProductVariant = _IOder.getListProduct();
            item.ForEach(x =>
            {
                var countpay = 0;
                var import_money = 0;
                foreach (var i in x)
                {
                    countpay += i.Order.total_pay;
                    var pr = listProductVariant.Where(x => x.id_Variant == i.OrderDetail.id_Variant).FirstOrDefault();
                    import_money = pr.import_Price * i.OrderDetail.quantity;
                }
                dgvDoanhThu.Rows.Add(x.Key, countpay, import_money, countpay - import_money);
            });
        }
        private void loadDataThang()
        {
            var row = 0;
            dgvDoanhThu.ColumnCount = 4;
            dgvDoanhThu.Columns[row++].Name = "Tháng";
            dgvDoanhThu.Columns[row++].Name = "Doanh thu";
            dgvDoanhThu.Columns[row++].Name = "Tiền vốn";
            dgvDoanhThu.Columns[row++].Name = "Lợi nhuận";
            dgvDoanhThu.Rows.Clear();
            var lstItem = _IOder.JoinTable();
            var item = lstItem.Select(i => i.Order).ToList();
            var detail = lstItem.Select(x => x.OrderDetail).ToList();
            var listProductVariant = _IOder.getListProduct();
            var minyear = lstItem.Min(x => x.Order.order_Time.Year);
            var maxyear = lstItem.Max(x => x.Order.order_Time.Year);

            var countpay = 0;
            var import_money = 0;
            for (int mi = minyear; mi < maxyear + 1; mi++)
            {
                for (int ji = 1; ji < 13; ji++)
                {
                    var month = item.Where(x => x.order_Time.Month == ji).ToList();
                    countpay = item.Where(x => x.order_Time.Month == ji).Sum(x => x.total_pay);
                    month.ForEach(x =>
                    {
                        var listDetail = detail.Where(z => z.id_Order == x.id_Order).ToList();
                        listDetail.ForEach(p =>
                        {
                            var pr = listProductVariant.Where(q => q.id_Variant == p.id_Variant).FirstOrDefault();
                            import_money = pr.import_Price * p.quantity;
                        });
                    });
                    dgvDoanhThu.Rows.Add(ji + "/" + mi, countpay, import_money, countpay - import_money);
                }

            }
        }
        private void loadDataNam()
        {
            var row = 0;
            dgvDoanhThu.ColumnCount = 4;
            dgvDoanhThu.Columns[row++].Name = "Năm";
            dgvDoanhThu.Columns[row++].Name = "Doanh thu";
            dgvDoanhThu.Columns[row++].Name = "Tiền vốn";
            dgvDoanhThu.Columns[row++].Name = "Lợi nhuận";
            dgvDoanhThu.Rows.Clear();
            var lstItem = _IOder.JoinTable();
            var item = lstItem.Select(i => i.Order).ToList();
            var detail = lstItem.Select(x => x.OrderDetail).ToList();
            var listProductVariant = _IOder.getListProduct();
            var minyear = lstItem.Min(x => x.Order.order_Time.Year);
            var maxyear = lstItem.Max(x => x.Order.order_Time.Year);

            var countpay = 0;
            var import_money = 0;
            for (int mi = minyear; mi < maxyear + 1; mi++)
            {
                var month = item.Where(x => x.order_Time.Year == mi).ToList();
                countpay = item.Where(x => x.order_Time.Year == mi).Sum(x => x.total_pay);
                month.ForEach(x =>
                    {
                        var listDetail = detail.Where(z => z.id_Order == x.id_Order).ToList();
                        listDetail.ForEach(p =>
                            {
                                var pr = listProductVariant.Where(q => q.id_Variant == p.id_Variant).FirstOrDefault();
                                import_money = pr.import_Price * p.quantity;
                            });
                    });
                dgvDoanhThu.Rows.Add(mi, countpay, import_money, countpay - import_money);
            }
        }
        private void rdbTKNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKNgay.Checked == true)
            {
                loadDataNgay();
            }
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbThang.Checked == true)
            {
                loadDataThang();
            }
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            loadDataNam();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            var time = mcTime.SelectionRange.Start.ToString();
            time = time.Split(" ")[0];

            var row = 0;
            dgvDoanhThu.ColumnCount = 4;
            dgvDoanhThu.Columns[row++].Name = "Ngày";
            dgvDoanhThu.Columns[row++].Name = "Doanh thu";
            dgvDoanhThu.Columns[row++].Name = "Tiền vốn";
            dgvDoanhThu.Columns[row++].Name = "Lợi nhuận";
            dgvDoanhThu.Rows.Clear();
            var lstItem = _IOder.JoinTable();
            var item = lstItem.Select(i => i.Order).ToList();
            var detail = lstItem.Select(x => x.OrderDetail).ToList();
            var listProductVariant = _IOder.getListProduct();
            var minyear = lstItem.Min(x => x.Order.order_Time.Year);
            var maxyear = lstItem.Max(x => x.Order.order_Time.Year);

            var countpay = 0;
            var import_money = 0;
            var month = item.Where(x => x.order_Time.ToString().Split(" ")[0] == time).ToList();
            countpay = item.Where(x => x.order_Time.ToString().Split(" ")[0] == time).Sum(x => x.total_pay);
            month.ForEach(x =>
            {
                var listDetail = detail.Where(z => z.id_Order == x.id_Order).ToList();
                listDetail.ForEach(p =>
                {
                    var pr = listProductVariant.Where(q => q.id_Variant == p.id_Variant).FirstOrDefault();
                    import_money = pr.import_Price * p.quantity;
                });
            });
            dgvDoanhThu.Rows.Add(time, countpay, import_money, countpay - import_money);


            MessageBox.Show(time);
        }
    }
}
