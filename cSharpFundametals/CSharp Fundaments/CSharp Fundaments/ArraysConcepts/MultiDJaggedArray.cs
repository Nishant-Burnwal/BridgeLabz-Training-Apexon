using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class MultiDJaggedArray
    {
        static void Main(string[] args)
        {
            int[][,] arr = new int[2][,]
            {
                new int[, ] {{1, 3}, {5, 7}},
                new int[, ] { {0, 2}, { 4, 6}, { 8, 10} }
            };
            // Display the array Elements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    for (int k = 0; k < arr[i].GetLength(1); k++)
                    {
                        Console.Write("arr[" + i + "][" + j + ", " + k + "] => " + arr[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            /*
             * Advantages of Jagged Arrays
                    Flexibility: It allows us to define the variable number of arrays inside each row of an array.
                    Dynamic Size: Allow us to add different array sizes in the run-time.
                    Enhance Readability: It makes code more readable and easy to understand at first look.
                    Memory efficient: Allow each inner array with a different size, they can be more memory-efficient when storing irregular data.
             */

        }
    }
}
