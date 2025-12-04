using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class ListType
    {
        // Use Case: When you want a resizable array.
        static void Main()
        {
            List<string> names = new List<string>();

            names.Add("Nishant");
            names.Add("Aman");
            names.Add("Riya");

            names.Remove("Aman");

            Console.WriteLine("List Elements:");
            foreach (var n in names)
                Console.WriteLine(n);
        }
    }
}
