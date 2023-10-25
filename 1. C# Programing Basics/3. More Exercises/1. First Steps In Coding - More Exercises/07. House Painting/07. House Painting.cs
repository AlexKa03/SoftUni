using System;

namespace _07._House_Painting
{
    internal class House_Painting
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWalls = (2 * (x * y)) - 2 * 2.25;
            double frontAndBackWalls = (2 * (x * x)) - 2.4;
            double totalWalls = sideWalls + frontAndBackWalls;

            double rectangleRoof = 2 * (x * y);
            double triangleRoof = 2 * (x * h / 2);
            double totalRoof = rectangleRoof + triangleRoof;

            double greenPaint = totalWalls / 3.4;
            double redRoof = totalRoof / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redRoof:f2}");

        }
    }
}
