using System;

namespace _02._Triangle_Area
{
    internal class Triangle_Area
    {
        static void Main(string[] args)
        {
            // Input
            double a = double.Parse(Console.ReadLine()); // side
            double h = double.Parse(Console.ReadLine()); // height

            // Calculate
            double area = a * h / 2;

            // Output
            Console.WriteLine($"{area:f2}");

            // a = 20 ; h = 30 ; area = 20 * 30 / 2 = 600 / 2 = 300
        }
    }
}
