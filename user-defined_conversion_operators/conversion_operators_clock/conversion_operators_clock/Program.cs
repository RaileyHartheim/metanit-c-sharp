using System;

namespace conversion_operators_clock
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clock1 = new Clock { Hours = 9 };
            int val1 = (int)clock1;
            Console.WriteLine(val1);

            int val2 = 37;
            Clock clock2 = val2;
            Console.WriteLine(clock2.Hours);

            Console.ReadKey();
        }
    }

    class Clock
    {
        public int Hours { get; set; }

        public static implicit operator Clock(int x)
        {
            return new Clock { Hours = x % 24 };
        }

        public static explicit operator int(Clock clock)
        {
            return clock.Hours;
        }
    }
}
