using System;

//TODO: to think about IndexOutofRangeException

namespace indexers_football_team
{
    class Program
    {
        static void Main(string[] args)
        {

            Team manchester = new Team();
            manchester[0] = new Player { FullName = "David de Gea", Number = 1 };
            manchester[1] = new Player { FullName = "Victor Lindelof", Number = 2 };
            Console.WriteLine(manchester[0].FullName);
            Console.WriteLine(manchester[1].Number);

            Console.ReadKey();

        }
    }

    class Player
    {
        public string FullName { get; set; }
        public int Number { get; set; }
    }

    class Team
    {
        Player[] players;

        public Team()
        {
            players = new Player[11];
        }

        public Player this[int index]
        {
            get
            {
                return players[index];
            }
            set
            {
                players[index] = value;
            }
        }
    }
}
