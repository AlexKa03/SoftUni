using System;

namespace _07._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeMeter = double.Parse(Console.ReadLine());

            double timeTotal = meters * timeMeter;
            
            timeTotal += Math.Floor(meters / 15) * 12.5;

            if (record > timeTotal)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeTotal:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeTotal - record:f2} seconds slower.");
            }
        }
    }
}
