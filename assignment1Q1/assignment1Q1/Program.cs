using System;
//random number generator for given number of input size
namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 50);
                Console.WriteLine("Random number at index " + i + " is: " + array[i]);
            }
            Console.ReadLine();
        }
    }
}

//....................... T.R.S.Rathnayaka - 23912.......................................... 