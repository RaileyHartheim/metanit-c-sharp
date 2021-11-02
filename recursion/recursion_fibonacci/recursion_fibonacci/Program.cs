using System;

namespace recursion_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            //recursion
            bool right_input = false;
            while (right_input == false)
            {
                if (right_input == true)
                {
                    break;
                }
                try
                {
                    Console.Write("Now we are going to use recursion. Enter some natural number:  ");
                    int nat_num = Convert.ToInt32(Console.ReadLine());
                    if (nat_num >= 0)
                    {
                        right_input = true;
                        Console.WriteLine($"Fibonacci Number for {nat_num} is equal to {FibonacciRecursion(nat_num)}.");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"Something went wrong: {exc}");
                }
            }

            //cycle
            bool right_input_cycle = false;
            while (right_input_cycle == false)
            {
                if (right_input_cycle == true)
                {
                    break;
                }
                try
                {
                    Console.Write("And now it's time for cycle. Enter some natural number:  ");
                    int nat_num = Convert.ToInt32(Console.ReadLine());
                    if (nat_num >= 0)
                    {
                        right_input_cycle = true;
                        Console.WriteLine($"Fibonacci Number for {nat_num} is equal to {FibonacciCycle(nat_num)}.");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"Something went wrong: {exc}");
                }
            }

            Console.ReadKey();
        }

        //using recursion for Fibonacci numbers
        static int FibonacciRecursion(int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }

            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        //using cycle for Fibonacci numbers
        static int FibonacciCycle(int n)
        {
            int result = 0;
            int preresult = 1;
            int temporary;

            for (int i = 0; i < n; i++)
            {
                temporary = result;
                result = preresult;
                preresult += temporary;
            }

            return result;
        }
    }
}
