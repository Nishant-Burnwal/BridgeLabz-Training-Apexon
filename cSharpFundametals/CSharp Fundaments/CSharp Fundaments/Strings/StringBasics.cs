using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Fundaments.Strings
{
    /*
     * 
     * In C#, a string is a sequence of Unicode characters (U+0000 to U+FFFF) used to represent text.
     * It is an object of the System.String class
     * The keyword string and the class name String are both aliases for System.
     * String, so they can be used interchangeably.
     * 
     * Key Characteristics of Strings
        1. Immutable: Once created, the content of a string cannot be altered. Any modification results in the creation of a new string.
        2. Reference Type: Strings are reference types, but they behave like value types in some scenarios, such as comparison.
        3. Unicode Support: Strings can contain any Unicode character, allowing support for multiple languages.
        4. Null and Embedded Nulls: Strings can be null and may also contain embedded null characters (\0).
        5. Operator Overloading: Strings support operator overloading, such as + for concatenation and == for comparison.
      */
    internal class StringBAsics
    {
        static void Main(string[] args)
        {
            // declare using System
            System.String name;
            name = "Nishant";

            String id;
            id = "23";

            string mrk;
            mrk = "97";

            string rank = "1";

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Marks: {0}", mrk);
            Console.WriteLine("Rank: {0}", rank);

        }
    }
}
