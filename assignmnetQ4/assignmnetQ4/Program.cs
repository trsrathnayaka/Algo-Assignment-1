using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //display the arrays 
            int[] items = { 1,2,3,4,5,6,7,8,9 };
            int array1 = 3;
            int array2 = 5;
            //display the nuber of arrays
            Console.WriteLine("Enter The Number Of Original Arrays: ");
            foreach (int item in items)
            {
                Console.Write(item + " ");
            }

            SwapNumbers(items, array1, array2);
            //display the after swapping values
            Console.WriteLine("\n\nEnter The Array After Swapping values: ");
            foreach (int item in items)
            {
                Console.Write(item + " ");
            }
        }

        //swap two numbers is given arrays
        static void SwapNumbers(int[] items, int array1, int array2)
        {
            int temp = items[array1];
            items[array1] = items[array2];
            items[array2] = temp;
        }
    }
}

//....................T.R.S.Rathnayaka - 23912...............................//