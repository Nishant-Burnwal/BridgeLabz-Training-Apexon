using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class ThreeDArray
    {
        static void Main(string[] args)
        {
            // Create a 3D array of dimension 2, 2, 3
            // int[,,] arr = new int[x, y, z];
            int[,,] array3D = {
                {   // Layer 0
                    {1, 2},
                    {3, 4},
                    {5, 6}
                },
                {   // Layer 1
                    {7, 8},
                    {9, 10},
                    {11, 12}
                }
            };
            /*
             * array3D.GetLength(0) -> 2
             * array3D.GetLength(1) -> 2
             * array3D.GetLength(2) -> 4
             */
            // access elements using for-loop
            // Printing the Dimension

            Console.WriteLine("The Coordinates are: ");
            Console.WriteLine($"X: coordinate: {array3D.GetLength(0)}");
            Console.WriteLine($"Y: coordinate: {array3D.GetLength(1)}");
            Console.WriteLine($"Z: coordinate: {array3D.GetLength(2)}");


            for (int x = 0; x < array3D.GetLength(0); x++)
            {
                Console.WriteLine($"\nLayer {x}:");
                for (int y = 0; y < array3D.GetLength(1); y++)
                {
                    for (int z = 0; z < array3D.GetLength(2); z++)
                    {
                        Console.WriteLine(array3D[x, y, z] + " "); // Layer 0: [0, 0, 0] -> 1 \n [0, 0, 1] -> 2
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
