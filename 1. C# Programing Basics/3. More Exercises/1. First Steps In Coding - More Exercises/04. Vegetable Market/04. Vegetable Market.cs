using System;

namespace _04._Vegetable_Market
{
    internal class Vegetable_Market
    {
        static void Main(string[] args)
        {
            // Input
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());

            // Calculate
            double vegetableTotal = vegetablePrice * vegetableKg;
            double fruitTotal = fruitPrice * fruitKg;

            // Output
            Console.WriteLine($"{(vegetableTotal + fruitTotal) / 1.94:f2}");
        }
    }
}
