using System;

namespace ValueTypeAndReferenceType
{
    internal class Program
    {
        static void promeniVrednostiTip(int a)
        {
            a = 1998;
            Console.WriteLine(a);
        }

        static void promeniReferentniTip(Team teamA)
        {
            teamA.Name = "Lakers";
        }

        static void Main(string[] args)
        {
            int b = 2022;
            Console.WriteLine(b);
            promeniVrednostiTip(b);
            Console.WriteLine(b);

            Team teamB = new Team();
            teamB.Name = "Golden State";

            promeniReferentniTip(teamB);

            Console.WriteLine(teamB.Name);        }
    }
}
