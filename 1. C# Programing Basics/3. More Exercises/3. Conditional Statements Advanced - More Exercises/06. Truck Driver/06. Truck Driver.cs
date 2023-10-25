using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());

            double total = 0.00;

            if (kilometers <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    total = 0.9 * (4 * (kilometers * 0.75));
                }
                else if (season == "Summer")
                {
                    total = 0.9 * (4 * (kilometers * 0.9));
                }
                else
                {
                    total = 0.9 * (4 * (kilometers * 1.05));
                }
            }
            else if (kilometers > 5000 && kilometers <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    total = 0.9 * (4 * (kilometers * 0.95));
                }
                else if (season == "Summer")
                {
                    total = 0.9 * (4 * (kilometers * 1.1));
                }
                else
                {
                    total = 0.9 * (4 * (kilometers * 1.25));
                }
            }
            else
            {
                total = 0.9 * (4 * (kilometers * 1.45));
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
