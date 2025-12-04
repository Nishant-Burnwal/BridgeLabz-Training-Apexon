using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class SortedDictionaryByKeys
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sd  = new SortedDictionary<int, string>();

            sd.Add(3, "C");
            sd.Add(1, "A");
            sd.Add(2, "B");

            foreach (var kv in sd)
            {
                Console.WriteLine(kv.Key + " = " + kv.Value);
            }

            // Sorting Alphabatically
            Console.WriteLine("\n\nSorting Alphabatically with Alphabets Keys");
            SortedDictionary<string, int> sdAlpha = new SortedDictionary<string, int>();

            sdAlpha.Add("C", 3);
            sdAlpha.Add("A", 1);
            sdAlpha.Add("B", 2);
            sdAlpha.Add("Nishant", 1);
            sdAlpha.Add("Apple", 2);
            sdAlpha.Add("Cat", 3);

            foreach (var kv in sdAlpha)
                Console.WriteLine(kv.Key + " = " + kv.Value);

        }
    }
}

