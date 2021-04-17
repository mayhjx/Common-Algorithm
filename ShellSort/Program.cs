using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // 希尔排序
            // 将数组变成基本有序后
            // 再使用插入排序
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

            int h = 1;
            while (h < N / 3)
                h = 3 * h + 1;
            Console.WriteLine(h);

            while (h >= 1)
            {
                // h-sort the array
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && arr[j] < arr[j - h]; j -= h)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - h];
                        arr[j - h] = temp;
                    }
                }
                h = h / 3;
            }
        }
    }
}
