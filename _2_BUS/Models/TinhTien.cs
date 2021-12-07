using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Models
{
    public class TinhTien
    {
        public int TienKhachThanhToan { get; set; }
        public int TongTien { get; set; }
        public int TienThua { get; set; }

        public TinhTien()
        {

        }
        public TinhTien(int tienKhachThanhToan, int tongTien, int tienThua)
        {
            TienKhachThanhToan = tienKhachThanhToan;
            TongTien = tongTien;
            TienThua = tienThua;
        }

        public int tienthua(int TienKhachThanhToan, int TongTien)
        {
            TienThua = TienKhachThanhToan - TongTien;
            return TienThua;
        }
    }
}
