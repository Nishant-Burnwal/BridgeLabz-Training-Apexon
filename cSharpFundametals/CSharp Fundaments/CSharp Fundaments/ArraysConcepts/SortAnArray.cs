using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class SortAnArray
    {
        // Array.Sort Method in C# is used to sort elements in a one-dimensional array. 
        static void Main(string[] args)
        {
            string[] arr = new string[] { "A", "D", "X", "G", "M" };

            // Display original array
            Console.WriteLine("Original Array");
            foreach (String g in arr)
            {
                Console.WriteLine(g); 
            }

            Console.WriteLine("\nAfter Sort:");

            // Sorting the array
            Array.Sort(arr);

            // Display sorted array
            foreach (String g in arr)
            {
                Console.WriteLine(g);
            }
        }
    }
}
