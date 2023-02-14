using System;

namespace SelectionSortFindMaxSwapmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 25,30,40,35,50,55,60,85,20,100 };
            int m = arr.Length;


            Console.WriteLine("\n\nEnter The New Original Array: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            selectionSort(arr, m);

            Console.WriteLine("\n\nEnter The Selection Sorted Array: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static int findMax(int[] arr, int m, int open)
        {


            int maxIndexNo = open;
            for (int i = open+ 1; i < m; i++)
            {
                if (arr[i] > arr[maxIndexNo])
                {
                    maxIndexNo = i;
                }
            }
            return maxIndexNo;
        }



        static void swap(ref int c, ref int z)
        {
            int temp = c;
            c =z;
            z = temp;
        }

        static void selectionSort(int[] arr, int m)
        {
            for (int i = m - 1; i >= 0; i--)
            {
                int maxIndexNo = findMax(arr, m, i);
                swap(ref arr[i], ref arr[maxIndexNo]);
            }
        }
    }
}
//.........................T.R.S.Rathnayaka -23912.......................//