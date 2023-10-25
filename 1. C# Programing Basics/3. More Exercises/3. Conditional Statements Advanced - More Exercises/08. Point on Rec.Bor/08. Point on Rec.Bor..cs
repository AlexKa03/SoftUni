using System;

namespace _08._Point_on_Rec.Bor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            string location = "Inside / Outside";

            if (x == x1 || x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    location = "Border";
                }
            }
            else if (y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    location = "Border";
                }
            }

            Console.WriteLine(location);
        }
    }
}
