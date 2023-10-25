using System;

namespace _01._Trapeziod_Area
{
    internal class Trapeziod_Area
    {
        static void Main(string[] args)
        {
            // Input
            double b1 = double.Parse(Console.ReadLine()); // base 1
            double b2 = double.Parse(Console.ReadLine()); // base 2
            double h = double.Parse(Console.ReadLine());  // height

            // Calculation
            double s = (b1 + b2) * h / 2;

            // Output
            Console.WriteLine($"{s:f2}");

            // b1 = 8 ; b2 = 13 ; h = 7 ; s = (8 + 13) * 7 / 2 = 21 * 7 / 2 = 147 / 2 = 73.5
        }
    }
}
