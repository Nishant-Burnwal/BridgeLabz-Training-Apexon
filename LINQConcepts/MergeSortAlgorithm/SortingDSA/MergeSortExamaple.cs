using System;

namespace MergeSortAlgorithm.SortingDSA
{
    internal class MergeSortExample
    {
        public static void MergeSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return;
            int[] aux = new int[arr.Length]; // auxiliary array
            MergeSortHelper(arr, aux, 0, arr.Length - 1);
        }

        static void MergeSortHelper(int[] arr, int[] aux, int left, int right)
        {
            if (left >= right) return; // base case
            int mid = left + (right - left) / 2;
            MergeSortHelper(arr, aux, left, mid);       // recursion for left half
            MergeSortHelper(arr, aux, mid + 1, right);  // recursion for right half
            Merge(arr, aux, left, mid, right);          // merge sorted halves
        }

        static void Merge(int[] arr, int[] aux, int left, int mid, int right)
        {
            // Copy to auxiliary array
            for (int i = left; i <= right; i++)
                aux[i] = arr[i];

            int iLeft = left;
            int iRight = mid + 1;
            int current = left;

            // Merge elements from left and right halves
            while (iLeft <= mid && iRight <= right)
            {
                if (aux[iLeft] <= aux[iRight]) // stable merge
                    arr[current++] = aux[iLeft++];
                else
                    arr[current++] = aux[iRight++];
            }

            // Copy any remaining elements from left half
            while (iLeft <= mid)
                arr[current++] = aux[iLeft++];

            // No need to copy right half — already in place
        }

        static void Main(string[] args)
        {
            int[] a = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSort(a);
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
