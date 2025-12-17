using System;
using System.Text.RegularExpressions;

namespace RegexExpression.EmailValidator
{
    internal class EmailValidatorApp
    {
        static void Main(string[] args)
        {
            string email = "nishant+burnwal.09@gmail.com";
            // Some Email allows + and - sign too before "@" so this will be a valid mail too.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // \. here means only . not the \ and . if we write . it means all characters.
            // @[a-zA-Z0-9.-]
            // accepts
            // gmail
            // gmail123
            // my-mail.server

            bool isValid = Regex.IsMatch(email, pattern);

            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        }
    }
}
