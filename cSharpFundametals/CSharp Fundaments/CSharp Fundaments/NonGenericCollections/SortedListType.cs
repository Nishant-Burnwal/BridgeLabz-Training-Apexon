using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.NonGenericCollections
{
    internal class SortedListType
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(3, "C");
            sl.Add(1, "A");
            sl.Add(2, "B");

            foreach (DictionaryEntry entry in sl)
            { 
                Console.WriteLine(entry.Key + " + " + entry.Value);
            }
            /*
             * 1. Auto-sorted by key
               2. Slower than SortedList<TKey, TValue>
               3.  Keys/values can be any type
             */
        }
    }
}
