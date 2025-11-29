using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.Strings
{
    internal class StringOperations
    {
        static void Main(string[] args)
        {
            String name = "Learning";
            // String Interpolation
            String res = $"{name} C# is fun.";

            Console.WriteLine(res);
            // Length of string str.length
            Console.WriteLine($"Length of '{res}': " + res.Length);

            // Trim trailing spaces
            String spacedString = "   Hello   World   ";
            Console.WriteLine(spacedString.Trim()); // Hello   World

            // checking element at index 2
            Console.WriteLine($"Element at index 2 of {res}: " + res[2]);

            // replacing the element in string
            res = res.Replace("#", " Sharp"); // Created new object of {res} as string is immutable and old res remain intact
            Console.WriteLine($"Created a new object of immutable '{res}': " + res);

            /*
             * Create a Mutable String using StringBuilder "Hello" and append "World" to it.
             */

            Console.WriteLine($"StringBuilder is a Mutable String: ");
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            Console.WriteLine(sb);
            sb.Replace("World", "Nishant");
            Console.WriteLine(sb);
        }
    }
}
