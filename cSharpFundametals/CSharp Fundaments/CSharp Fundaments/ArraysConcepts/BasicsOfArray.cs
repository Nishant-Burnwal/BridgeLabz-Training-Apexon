using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class BasicsOfArray
    {
        static void Main(string[] args)
        {
            // Declaration: Declare an int array of 5 elements
            Console.WriteLine("Concepts of Array: \n");
            int[] intArray = { 1, 2, 3, 4, 5, };
            // Access elements
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            Console.WriteLine("\n\nAccessing Every Element using for-loop");
            // using for-loop
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("This is 4th Element of itArray");
                }
                Console.WriteLine(intArray[i]);
            }

            Console.WriteLine("\n\nAccessing Every Element using for-loop");
            // using foreach-loop
            foreach (int i in intArray)
                Console.WriteLine(i);

            Console.WriteLine("\n\nAccessing Every Element using while-loop");
            //using while loop
            int j = 0;
            while (j < intArray.Length)
            {
                if (j == intArray.Length - 2)
                {
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput == 0)
                    {
                        Console.WriteLine("You enter 0");
                    }
                    else
                    {
                        Console.WriteLine($"You Entered {userInput}");
                    }
                }
                Console.WriteLine(intArray[j]);
                j++;
            }

            // using do-while
            Console.WriteLine("\n\nAccessing Every Element using do-while-loop");
            int k = 0;
            do
            {
                Console.WriteLine($"This will execute no matter what: {intArray[k]}");
                k++;
            } while(k < 0);
        }
    }
}
