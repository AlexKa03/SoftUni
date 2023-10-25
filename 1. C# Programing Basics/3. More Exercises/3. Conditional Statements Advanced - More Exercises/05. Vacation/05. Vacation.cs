using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accommodation = "";
            string location = "";
            double total = 0.00;

            if (budget <= 1000)
            {
                accommodation = "Camp";

                if (season == "Summer")
                {
                    location = "Alaska";
                    total = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    total = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                accommodation = "Hut";

                if (season == "Summer")
                {
                    location = "Alaska";
                    total = budget * 0.8;
                }
                else
                {
                    location = "Morocco";
                    total = budget * 0.6;
                }
            }
            else
            {
                accommodation = "Hotel";
                total = budget * 0.9;

                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {accommodation} - {total:f2}");
        }
    }
}
