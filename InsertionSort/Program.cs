using System;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // 插入排序
            // 由两部分组成，已排序和未排序部分
            // 每次从未排序部分取出一个元素a
            // 反向遍历已排序部分，和元素a进行比较
            // 将元素a放到正确的位置（使已排序部分保持升序）
            // 类似我们打牌时将手牌排序的方法
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
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    // 将下标i的元素放到已排序部分最后，两两比较使已排序部分重新恢复升序
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
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
