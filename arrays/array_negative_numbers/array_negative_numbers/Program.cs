using System;

namespace array_negative_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, -2, 3, 4, -5, -6, 7, -8, 9 };
            int result = 0;

            foreach (int a in numbers)
            {
                if (a < 0)
                {
                    result++;
                }
            }

            Console.WriteLine($"The amount of negative numbers in array is {result}.");
        }
    }
}
