using System;

namespace CustomImplementation.SearchingRevise
{
    internal class BinarySearch
    {
        static int BinarySearchMethod(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (target > arr[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1; // target not found
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int target = 40;

            int positionOfArray = BinarySearchMethod(arr, target);

            if (positionOfArray != -1)
                Console.WriteLine($"Element found at index: {positionOfArray}");
            else
                Console.WriteLine("Element not found");
        }
    }
}
