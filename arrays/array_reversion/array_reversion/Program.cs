using System;

namespace array_reversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int lgth = numbers.Length;
            int half_lgth = lgth / 2;
            int temp;
            for (int i = 0; i < half_lgth; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[lgth - i - 1];
                numbers[lgth - i - 1] = temp;
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }
            Console.WriteLine();
        }
    }
}
