using System;

namespace CustomImplementation.SearchingRevise
{
    internal class LinearSearch
    {
        static int SearchArray(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // index
                }
            }
            return -1; // not found
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int target = 8;

            int index = SearchArray(arr, target);

            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
                Console.WriteLine("Element found at position: " + (index + 1));
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
