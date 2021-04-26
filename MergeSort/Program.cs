using System;
using System.Diagnostics;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            // 归并排序
            var arr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var aux = new int[arr.Length];

            Sort(arr, aux, 0, arr.Length - 1);

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Sort(int[] arr, int[] aux, int lo, int hi)
        {
            if (hi <= lo)
                return;

            int mid = lo + (hi - lo) / 2;
            Sort(arr, aux, lo, mid);
            Sort(arr, aux, mid + 1, hi);
            Merge(arr, aux, lo, mid, hi);
        }

        static void Merge(int[] arr, int[] aux, int lo, int mid, int hi)
        {
            Debug.Assert(IsSorted(arr, lo, mid));
            Debug.Assert(IsSorted(arr, mid + 1, hi));

            for (int k = lo; k <= hi; k++)
            {
                aux[k] = arr[k];
            }

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                    arr[k] = aux[j++];
                else if (j > hi)
                    arr[k] = aux[i++];
                else if (aux[i] < aux[j])
                    arr[k] = aux[i++];
                else
                    arr[k] = aux[j++];
            }

            Debug.Assert(IsSorted(arr, lo, hi));
        }

        static bool IsSorted(int[] arr, int lo, int hi)
        {
            for (int i = lo; i <= hi - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
