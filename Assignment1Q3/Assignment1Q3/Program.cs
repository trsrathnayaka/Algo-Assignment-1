using System;
//the Bucket Sort algorithm using the FindMax method 
namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] items = { 2.5, 1.6, 3.7, 4.8, 4.9 , 6.5, 3.6};
            int length = items.Length;
            Console.WriteLine("Max number is: " + FindMax(items, length));
            Console.ReadLine();
        }

        static double FindMax(double[] items, int length)
        {
            double max = 0;
            if (length == 0)
            {
                Console.WriteLine("Array is empty");
                return max;
            }
            else
            {
                max = items[0];
                for (int i = 1; i < length; i++)
                {
                    if (items[i] > max)
                    {
                        max = items[i];
                    }
                }
                return max;
            }
        }
    }
}

//...................T.R.S.Rathnayaka - 23912............................//