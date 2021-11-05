using System;

namespace operators_overloading_states
{
    class Program
    {
        static void Main(string[] args)
        {

            State state1 = new State { Area = 170.3M, Population = 90000 };
            State state2 = new State { Area = 47M, Population = 23000 };

            State united_state = state1 + state2;
            Console.WriteLine($"The area of united state is equal to {united_state.Area}. The population of this state is equal to {united_state.Population}.");

            bool AreaIsLarger = state1 > state2;
            bool AreaIsLess = state1 < state2;
            Console.WriteLine($"The area of the first state is larger than the area of the second? {AreaIsLarger}\nThe area of the first state is less than the area of the second? {AreaIsLess}");


            Console.ReadKey();
        }
    }

    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        //addition operator overload
        public static State operator +(State s1, State s2)
        {
            return new State { Area = s1.Area + s2.Area, Population = s1.Population + s2.Population };
        }


        //comparison operators overload (Area is chosen for comparing parameter)
        public static bool operator >(State s1, State s2)
        {
            return s1.Area > s2.Area;
        }
        public static bool operator <(State s1, State s2)
        {
            return s1.Area < s2.Area;
        }

    }
}
