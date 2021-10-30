using System;

namespace cycle_deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal deposit = 0m;
            int months_amount = 0;
            Console.WriteLine("Enter the amount of your deposit:   ");
            try
            {
                deposit = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception ex_1)
            {
                Console.WriteLine($"Something went wrong: {ex_1.Message}");
            }
            Console.WriteLine("Enter the number of months for which the deposit will be valid:   ");
            try
            {
                months_amount = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex_2)
            {
                Console.WriteLine($"Something went wrong: {ex_2.Message}");
            }
            int i = 0;
            while (i < months_amount)
            {
                deposit = Math.Round(deposit * Convert.ToDecimal(1.07), 2);
                i++;
            }
            Console.WriteLine($"By the end of the period your deposit amount will be {deposit} c.u.");
            Console.ReadKey();

        }
    }
}
