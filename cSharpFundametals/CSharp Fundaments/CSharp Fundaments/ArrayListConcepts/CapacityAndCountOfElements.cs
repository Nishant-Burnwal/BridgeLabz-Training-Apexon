using System;
using System.Collections; // import explicitly needed for creating ArrayList
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CSharp_Fundaments.ArrayListConcepts
{
    internal class CapacityAndCountOfElements
    {
        static void Main(string[] args)
        {
            ArrayList phoneSpecs = new ArrayList(); // initially current capacity is 0
            /*
             * When the internal array is full and a new element is added:
               New capacity = old capacity × 2
             */
            /*
             * ArrayList are "dynamic" both in "memory as well as datatypes"
             */
            phoneSpecs.Add("Realme"); // string
            phoneSpecs.Add(6.5); // float
            phoneSpecs.Add("128GB"); // string
            phoneSpecs.Add("6GB"); // string
            phoneSpecs.Add("5G"); // string
            // After adding 5 elements, the internal capacity becomes 8.
            
            foreach(var spec in phoneSpecs)
            {
                Console.WriteLine(spec);
            }

            // Displaying count of elements of ArrayList
            Console.WriteLine("Number of elements: " + phoneSpecs.Count); // 5

            // Displaying Current capacity of ArrayList
            Console.WriteLine("Current Capacity:  " +phoneSpecs.Capacity); //8
        }
    }
}
