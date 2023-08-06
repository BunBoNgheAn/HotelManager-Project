using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLKS
{
    public class Function
    {
        public enum ValidateType
        {
            NUMBER,
            PRICE,
            CMND,
            PHONENUMBER
        }
        public bool CheckPhoneNumber(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, @"^0([0-9]{1,3})(|-|\.|\,)?([0-9]{3,4})(|-|\.|\,)?([0-9]{3,4})$$");
        }
        public bool CheckNumber(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d+$");
        }
        public bool CheckPrice(string text)
        {
            return text.Trim().Equals("0") || text.Trim().Equals("00") || System.Text.RegularExpressions.Regex.IsMatch(text, @"^[0-9]{1,3}(|-|\.|\,)?[0-9]{3}((|-|\.|\,)?[0-9]{3})?((|-|\.|\,)?[0-9]{3})?((|-|\.|\,)?[0-9]{3})?$");
        }
        private static bool CheckCMND(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, @"^[0-9]{12}$");
        }
        public string FormatToPrice(string price)
        {
            return price.Replace(" ", "").Replace(".", "").Replace(",", "").Replace("-", "");
        }

        public bool Check(ValidateType type, string text)
        {
            switch (type)
            {

                case ValidateType.NUMBER:
                    return CheckNumber(text);
                case ValidateType.PRICE:
                    return CheckPrice(text);
                case ValidateType.CMND:
                    return CheckCMND(text);
                case ValidateType.PHONENUMBER:
                    return CheckPhoneNumber(text);
            }
            return false;
        }
    }
}
