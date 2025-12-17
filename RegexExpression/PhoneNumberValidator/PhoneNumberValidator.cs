using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpression.PhoneNumberValidator
{
    internal class PhoneNumberValidator
    {
        static void Main(string[] args)
        {
            string pattern = @"^[6-9]\d{9}$";
            string phone = "9876543210";

            bool isValidPhoneNumber = Regex.IsMatch(phone, pattern);

            Console.WriteLine(isValidPhoneNumber? "Valid Phone Number" : "Invalid Phone Number");
        }
    }
}
