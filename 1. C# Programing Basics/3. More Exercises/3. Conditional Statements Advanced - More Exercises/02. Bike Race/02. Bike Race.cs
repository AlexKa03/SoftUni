using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string tRace = Console.ReadLine();

            double moneyJunior = 0.00;
            double moneySeniors = 0.00;

            if (tRace == "trail")
            {
                moneyJunior = juniors * 5.50;
                moneySeniors = seniors * 7.00;
            }
            else if (tRace == "cross-country")
            {
                moneyJunior = juniors * 8.00;
                moneySeniors = seniors * 9.50;
            }
            else if (tRace == "downhill")
            {
                moneyJunior = juniors * 12.25;
                moneySeniors = seniors * 13.75;
            }
            else if (tRace == "road")
            {
                moneyJunior = juniors * 20.00;
                moneySeniors = seniors * 21.50;
            }

            double total = moneyJunior + moneySeniors;

            if (juniors + seniors >= 50 && tRace == "cross-country")
            {
                total *= 0.75;
            }

            total *= 0.95;

            Console.WriteLine($"{total:f2}");
        }
    }
}
