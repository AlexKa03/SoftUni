using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int goingHome = int.Parse(Console.ReadLine());
            double gamesTotal = 0.00;

            double gamesSofia = (48 - goingHome) * 0.75;
            double gamesHolidays = holidays * 0.67;
            double games = gamesSofia + goingHome + gamesHolidays;

            if (yearType == "leap")
            {
                gamesTotal = Math.Floor(games * 1.15);
            }
            else
            {
                gamesTotal = Math.Floor(games);
            }

            Console.WriteLine(gamesTotal);
        }
    }
}
