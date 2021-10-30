using System;

namespace array_show_in_a_definite_way
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] numbers = { { { 1, 2 }, { 3, 4 } }, { { 4, 5 }, { 6, 7 } }, { { 7, 8 }, { 9, 10 } }, { { 10, 11 }, { 12, 13 } } };

            int x1 = numbers.GetUpperBound(0); // 3
            int x2 = numbers.GetUpperBound(1); // 1
            int x3 = numbers.GetUpperBound(2); // 1

            Console.Write("{");
            for (int i = 0; i <= x1; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= x2; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= x3; k++)
                    {
                        Console.Write($"{numbers[i, j, k]}");
                        if (k < x3)
                            Console.Write(", ");
                    }

                    Console.Write("}");
                    if (j < x2)
                        Console.Write(", ");
                }
                Console.Write("}");

                if (i < x1)
                    Console.Write(", ");
            }
            Console.Write("}");
        }
    }
}
