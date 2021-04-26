using System;
using System.Diagnostics;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 4, 7, 6, 2 };
            int[] arr = { 4, 7, 6, 2, 3, 9, 1, 8, 0, 5 };
            int[] aux = new int[arr.Length];
            Sort(arr, aux, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Sort(int[] arr, int[] aux, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            Sort(arr, aux, lo, mid);
            Sort(arr, aux, mid + 1, hi);
            Merge(arr, aux, lo, mid, hi);
        }

        static void Merge(int[] arr, int[] aux, int lo, int mid, int hi)
        {
            // 原数组包含两段排好序的子数组
            // 先把原数组copy到另一个数组
            // 然后分别遍历两端已排序的子数组，把其中较小的元素放回原数组中
            // 当两个元素一样大时，把第一个子数组的元素放回原数组中

            //Debug.Assert(IsSorted(arr, lo, mid));
            //Debug.Assert(IsSorted(arr, mid + 1, hi));

            // 将数组复制到辅助数组
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
                else if (Less(aux[j], aux[i]))
                    arr[k] = aux[j++];
                else
                    arr[k] = aux[i++];
            }

            //Debug.Assert(IsSorted(arr, lo, hi));
        }

        static bool IsSorted(int[] arr, int lo, int hi)
        {
            for (int i = lo + 1; i <= hi; i++)
            {
                if (Less(arr[i], arr[i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool Less(int i, int j)
        {
            return i.CompareTo(j) < 0;
        }
    }
}
