using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.Strings
{
    internal class DifferentWaysOfStringCreation
    {
        static void Main(string[] args)
        {   // using string literal
            String str1 = "Basic String";

            // using concatenation
            String str2 = str1 + " Concepts"; // Basic String Concepts

            // using constructor
            char[] chars = { 'S', 'T', 'R', 'I', 'N', 'G' };
            String str3 = new String(chars);
            Console.WriteLine("Method 3: " + str3); // STRING

            //using property or method
            String s = "C# is Fun";

            int start = s.IndexOf(" ") + 1;
            int end = s.IndexOf(" ", start) - start;
            string str4 = s.Substring(start, end);
            Console.WriteLine("Method 4: " + str4);


            // using string formatting
            int i = 1;
            int j = 2;
            int sum = i + j;
            String str5 = string.Format("Addition of {0} with {1} is {2}", i, j, sum);
            Console.WriteLine("Method 5: " + str5);
        }
    }
}
