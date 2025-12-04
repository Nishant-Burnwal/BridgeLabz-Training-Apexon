using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.GenericCollections
{
    internal class SortedListType
    {
        //Faster than Dictionary for small collections.
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(10, "Ten");
            sl.Add(5, "Five");

            Console.WriteLine(sl.Keys[0]);   // 5
            Console.WriteLine(sl.Values[1]); // Ten
        }
    }
}
