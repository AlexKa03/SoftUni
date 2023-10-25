using System;

namespace _06._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double face = 0.00;

            if (figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                face = a * a; 
                Console.WriteLine($"{face:f3}");
            }

            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                face = a * b;
                Console.WriteLine($"{face:f3}");
            }

            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                face = (r * r) * Math.PI;
                Console.WriteLine($"{face:f3}");
            }

            else
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                face = (a * h) / 2;
                Console.WriteLine($"{face:f3}");
            }
        }
    }
}
