using System;

namespace operators_overloading_sandwich
{
    class Program
    {
        static void Main(string[] args)
        {
            //this should work after operators overload
            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight); //100


            Console.ReadKey();
        }
    }

    class Bread
    {
        public int Weight { get; set; }

        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich { Weight = bread.Weight + butter.Weight };
        }
    }

    class Butter
    {
        public int Weight { get; set; }

    }

    class Sandwich
    {
        public int Weight { get; set; }

    }
}
