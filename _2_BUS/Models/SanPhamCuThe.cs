using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Models
{
    public class SanPhamCuThe
    {
        private string tenSp;
        private string option_values;
        private int soLuong;
        private int giaNhap;
        private int giaban;

        public SanPhamCuThe(object enumerable)
        {
            
        }

        public SanPhamCuThe(string tenSp, string optionValues, int soLuong, int giaNhap, int giaban)
        {
            this.tenSp = tenSp;
            option_values = optionValues;
            this.soLuong = soLuong;
            this.giaNhap = giaNhap;
            this.giaban = giaban;
        }

        public string TenSp
        {
            get => tenSp;
            set => tenSp = value;
        }

        public string OptionValues
        {
            get => option_values;
            set => option_values = value;
        }

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }

        public int GiaNhap
        {
            get => giaNhap;
            set => giaNhap = value;
        }

        public int Giaban
        {
            get => giaban;
            set => giaban = value;
        }
    }
}
