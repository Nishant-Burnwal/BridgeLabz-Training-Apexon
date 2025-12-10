using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortAlgorithm.SortingDSA
{
    internal class MergeSortApplication
    {
        static void Main(String[] args)
        {
            int[] numbers = { 2, 4, 1, 5, 6, 7, 1, 5, 9 };

            Console.WriteLine("Original Array: " + string.Join(",", numbers));

            MergeSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("Sorted Array: " + string.Join(',', numbers));
        }

    public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // 1. Find the middle point
                int middle = left + (right - left) / 2;

                // 2. Recursively sort the first and second halves
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                // 3. Merge the sorted halves
                Merge(array, left, middle, right);
            }
        }

    public static void Merge(int[] array, int left, int middle, int right)
        {
            /// middle 5 here
            // left = 0
            // right = 8
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // create temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temporary arrays
            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0;

            // Initial index of merged subarray array
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // copy remaining elements of leftArray[] if any
            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }

        }

    }
}
