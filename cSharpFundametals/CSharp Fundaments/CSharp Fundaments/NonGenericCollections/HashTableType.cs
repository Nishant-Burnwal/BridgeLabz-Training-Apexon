using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.NonGenericCollections
{
    internal class HashTableType
    {
        // 2. Hashtable — Key–Value Store (Any Type Key/Value)
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add("Two", 2);
            ht.Add("One", "1");

            foreach (DictionaryEntry entry in ht) // Note we wrote DictionaryEntry instead of "var"
                Console.WriteLine(entry.Key + " = " + entry.Value);
        }
        /*
         * Keys and values can be any type
           Slower than Dictionary<TKey, TValue>
           No fixed ordering
         */
    }
}
