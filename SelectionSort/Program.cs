using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // 选择排序
            // 由两部分组成，已排序部分和未排序部分
            // 每次从未排序部分中取出最小的元素，放到已排序部分的最后
            int[] arr = { 5, 6, 8, 3, 1, 4, 9, 7, 2 };
            Sort(arr);

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

        }

        static void Sort(int[] arr)
        {
            int N = arr.Length;
            for (int i = 0; i < N - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                Swap(arr, i, min);
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
