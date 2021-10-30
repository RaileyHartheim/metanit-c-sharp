using System;

namespace array_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 52, 5, -632, 19, 0, 28, -47 };

            int temp;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array is sorted.");
            foreach (int n in numbers)
            {
                Console.Write($"{n} \t");
            }
        }
    }
}
