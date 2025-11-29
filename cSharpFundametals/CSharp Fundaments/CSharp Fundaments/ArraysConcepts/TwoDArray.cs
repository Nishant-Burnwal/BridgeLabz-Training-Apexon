using System;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class TwoDArray
    {
        static void Main(string[] args)
        {
            // creates a two-dimensional array of four rows and two columns.
            // Fill the elements taking user input
            // Print the every Elements 


            int[,] twoDArray = new int[4, 2];
            /*
             * - -
             * - -
             * - -
             * - -
             */

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write($"Enter element at position [{i},{j}]: ");
                    twoDArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Optional: print the array to verify
            Console.WriteLine("\nYou entered:");
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write(twoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
