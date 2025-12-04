using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class SortedSetExample
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>() { 5, 1, 9, 3, 3};

            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}
