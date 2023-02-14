using System;
//for loop to display all the items of a given array 
namespace DisplayArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 , 6  };
            Console.WriteLine("Array elements here:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}

//.................................T.R.S.Rathnayaka - 23912...................//