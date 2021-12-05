using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Models
{
    public class DTTam
    {
        private int a;
        private int b;

        public DTTam()
        {
            
        }

        public DTTam(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }
    }
}
