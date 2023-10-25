using System;

namespace _05._Training_Lab
{
    internal class Training_Lab
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            w = w * 100;
            h = (h * 100) - 100;
            double workH = Math.Floor(h / 70);
            double workW = Math.Floor(w / 120);
            double workSpace = (workH * workW) - 3;

            Console.WriteLine(workSpace);
        }
    }
}
