using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _2_BUS.IService_BUS;

namespace _2_BUS.Untilitys
{
     public class Validate_Check: IValidate
    {
        public bool NumberCheck(string a)
        {
            return Regex.IsMatch(a, @"[^\d+$]");
        }

        public bool WordCheck(string a)
        {
            if ((a.All(char.IsDigit)))
            {
                return true;
            }
            else if (Regex.IsMatch(a, @"[\d+]"))
            {
                return true;
            }

            return false;
        }

        public bool MailCheck(string a)
        {

            try
            {
                a = a ?? string.Empty;
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(a))
                    return (true);
                else
                    return (false);
            }
            catch
            {
                return false;
            }
        }

        public bool checkNull(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}
