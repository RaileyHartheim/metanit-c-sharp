using System;

namespace recursion_factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            //recursion case
            bool right_input = false;
            while (right_input == false)
            {
                if (right_input == true)
                {
                    break;
                }
                try
                {
                    Console.Write("Let's find factorial by recursion. Enter some natural number:  ");
                    int nat_num = Convert.ToInt32(Console.ReadLine());
                    if (nat_num > 0)
                    {
                        right_input = true;
                        Console.WriteLine($"Factorial of {nat_num} is equal to {FactorialRecursion(nat_num)}");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"Something went wrong: {exc}");
                }
            }

            //cycle case
            bool right_input_cycle = false;
            while (right_input_cycle == false)
            {
                if (right_input_cycle == true)
                {
                    break;
                }
                try
                {
                    Console.Write("Let's find factorial by recursion. Enter some natural number:  ");
                    int nat_num = Convert.ToInt32(Console.ReadLine());
                    if (nat_num > 0)
                    {
                        right_input_cycle = true;
                        Console.WriteLine($"Factorial of {nat_num} is equal to {FactorialCycle(nat_num)}");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"Something went wrong: {exc}");
                }
            }


            Console.ReadKey();
        }

        //using a recursion
        static int FactorialRecursion(int n)
        {
            if (n == 1)
            {
                return n;
            }

            return n * FactorialRecursion(n - 1);
        }

        //using a cycle
        static int FactorialCycle(int n)
        {
            int result = 1;

            for (int i = 1; i < n + 1; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
