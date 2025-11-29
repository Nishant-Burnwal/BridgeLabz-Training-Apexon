using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            /* Mini Docs: 
             * A jagged array is an array of arrays,
             * where each element is itself an array that can
             * have a different length.
             * Rows are fixed at declaration, 
             * but columns can vary. 
             * It can also combine with multidimensional arrays.
             */

            int[][] jaggedArr = new int[3][]; // row 3 fixed

            // Initialize each row with different length
            jaggedArr[0] = new int[] { 1, 2 };
            jaggedArr[1] = new int[] { 3, 4, 5 };
            jaggedArr[2] = new int[] { 6, 7, 8, 9 };

            // jaggedArr.Length -> row (3 here)
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (int num in jaggedArr[i])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
