using System;

namespace conversion_operators_temperature
{
    class Program
    {
        static void Main(string[] args)
        {

            Celcius ct1 = new Celcius { Gradus = 0 };
            Fahrenheit ft1 = ct1;
            Console.WriteLine(ft1.Gradus);

            Fahrenheit ft2 = new Fahrenheit { Gradus = 0 };
            Celcius ct2 = ft2;
            Console.WriteLine(ct2.Gradus);


            Console.ReadKey();
        }
    }

    class Celcius
    {
        public double Gradus { get; set; }

        public static implicit operator Celcius(Fahrenheit tf)
        {
            return new Celcius { Gradus = 5.0 / 9 * (tf.Gradus - 32) };
        }

        public static implicit operator Fahrenheit(Celcius tc)
        {
            return new Fahrenheit { Gradus = 9.0 / 5 * tc.Gradus + 32 };
        }
    }

    class Fahrenheit
    {
        public double Gradus { get; set; }
    }
}
