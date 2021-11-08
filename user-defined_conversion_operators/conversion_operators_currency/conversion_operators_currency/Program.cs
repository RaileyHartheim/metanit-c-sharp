using System;

namespace conversion_operators_currency
{
    class Program
    {
        static void Main(string[] args)
        {

            Dollar dol1 = new Dollar { Sum = 50 };
            Euro eur1 = (Euro)dol1;
            Console.WriteLine($"{dol1.Sum} dollars = {eur1.Sum} euro.");

            Euro eur2 = new Euro { Sum = 50 };
            Dollar dol2 = eur2;
            Console.WriteLine($"{eur2.Sum} euro = {dol2.Sum} dollars.");

            Console.ReadKey();
        }
    }

    //1 dollar = 0.88 euro by condition
    class Dollar
    {
        public decimal Sum { get; set; }
    }

    //1 euro = 1.14 dollars by condition
    class Euro
    {
        public decimal Sum { get; set; }

        //one required implicit conversion operator
        public static implicit operator Dollar(Euro euro)
        {
            return new Dollar { Sum = Math.Round((euro.Sum * 0.88m), 2) };
        }

        //one required explicit conversion operator
        public static explicit operator Euro(Dollar dollar)
        {
            return new Euro { Sum = Math.Round((dollar.Sum * 1.14m), 2) };
        }
    }
}
