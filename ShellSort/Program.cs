using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // 希尔排序
            // 增量插入排序
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Sort(arr);

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Sort(int[] arr)
        {
            int N = arr.Length;

            int h = 1;
            while (h < N / 3)
                h = 3 * h + 1;

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && arr[j] < arr[j - h]; j -= h)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - h];
                        arr[j - h] = temp;
                    }
                }
                h /= 3;
            }
        }
    }
}
