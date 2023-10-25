using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fansCount = double.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }

            sectorA = 100 * (sectorA / fansCount);
            sectorB = 100 * (sectorB / fansCount);
            sectorV = 100 * (sectorV / fansCount);
            sectorG = 100 * (sectorG / fansCount);
            double fansVsCapacity = 100 * (fansCount / capacity);

            Console.WriteLine($"{sectorA:f2}%");
            Console.WriteLine($"{sectorB:f2}%");
            Console.WriteLine($"{sectorV:f2}%");
            Console.WriteLine($"{sectorG:f2}%");
            Console.WriteLine($"{fansVsCapacity:f2}%");
        }
    }
}
