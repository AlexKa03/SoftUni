using System;

namespace _06._Fishland
{
    internal class Fishland
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double sprinklePrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            double musselsKg = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.6;
            double scadPrice = sprinklePrice * 1.8;
            double musselsPrice = 7.5;

            double bonitoTotal = bonitoKg * bonitoPrice;
            double scadTotal = scadKg * scadPrice;
            double musselsTotal = musselsKg * musselsPrice;

            double total = bonitoTotal + scadTotal + musselsTotal;

            Console.WriteLine($"{total:f2}");
        }
    }
}
