using System;

namespace cycle_from_zero_to_ten
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int b = -1;
            bool status = false;
            while (status == false)
            {
                if (status == true)
                    break;
                Console.WriteLine("Please, enter first number from zero to ten:  ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter second number from zero to ten:  ");
                b = Convert.ToInt32(Console.ReadLine());
                status = (0 <= a && a <= 10) && (0 <= b && b <= 10);
                if (status == false)
                    Console.WriteLine("Both numbers must be between zero and ten. Try again.");
            }
            if (status == true)
            {
                Console.WriteLine($"Multiplication of these numbers is {a * b}");
            }

        }
    }
}
