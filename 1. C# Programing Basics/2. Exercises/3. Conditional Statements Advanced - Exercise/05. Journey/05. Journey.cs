using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string where = "";
            double total = 0.00;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    where = "Camp";
                    total = budget * 0.3;
                }
                else
                {
                    where = "Hotel";
                    total = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    where = "Camp";
                    total = budget * 0.4;
                }
                else
                {
                    where = "Hotel";
                    total = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                where = "Hotel";
                total = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{where} - {total:f2}");
        }
    }
}
