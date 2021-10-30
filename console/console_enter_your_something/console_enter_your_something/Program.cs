using System;

namespace console_enter_your_something
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:  ");
            string name = Console.ReadLine();

            Console.Write("Enter your age:  ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height:  ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight:  ");
            double weight = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Enter your salary:  ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Name: {name} \nAge: {age} \nHeight: {height}  \nWeight: {weight} \nSalary: {salary}");
        }
    }
}
