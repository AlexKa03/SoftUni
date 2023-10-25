using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double total = 0.00;

            if (season == "Spring")
            {
                total = 3000;
                if (fishermans <= 6)
                {
                    total = total * 0.9;
                }
                else if (fishermans >= 7 && fishermans <= 11)
                {
                    total = total * 0.85;
                }
                else
                {
                    total = total * 0.75;
                }

                if (fishermans % 2 == 0)
                {
                    total *= 0.95;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                total = 4200;
                if (fishermans <= 6)
                {
                    total = total * 0.9;
                }
                else if (fishermans >= 7 && fishermans <= 11)
                {
                    total = total * 0.85;
                }
                else
                {
                    total = total * 0.75;
                }

                if (fishermans % 2 == 0 && season != "Autumn")
                {
                    total *= 0.95;
                }
            }
            else
            {
                total = 2600;
                if (fishermans <= 6)
                {
                    total = total * 0.9;
                }
                else if (fishermans >= 7 && fishermans <= 11)
                {
                    total = total * 0.85;
                }
                else
                {
                    total = total * 0.75;
                }

                if (fishermans % 2 == 0)
                {
                    total *= 0.95;
                }
            }

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva.");
            }
        }
    }
}
