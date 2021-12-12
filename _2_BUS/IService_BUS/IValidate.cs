using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService_BUS
{
    public interface IValidate
    {
        bool NumberCheck(string a);
        bool WordCheck(string a);
        bool MailCheck(string a);
        public bool checkNull(string text);
    }
}
