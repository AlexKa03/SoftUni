using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time = (meters * timePerMeter) + (Math.Floor(meters / 50) * 30);

            if (time >= currentRecord)
            {
                Console.WriteLine($"No! He was {time - currentRecord:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
        }
    }
}
