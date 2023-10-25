using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double total = 0.00;

            if (season == "Spring" || season == "Summer")
            {
                total = (chrysanthemums * 2) + (roses * 4.1) + (tulips * 2.5);
            }
            else
            {
                total = (chrysanthemums * 3.75) + (roses * 4.5) + (tulips * 4.15);
            }

            if (holiday == "Y")
            {
                total *= 1.15;
            }

            if (tulips > 7 && season == "Spring")
            {
                total *= 0.95;
            }
            if (roses >= 10 && season == "Winter")
            {
                total *= 0.9;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                total *= 0.8;
            }

            Console.WriteLine($"{2 + total:f2}");
        }
    }
}
