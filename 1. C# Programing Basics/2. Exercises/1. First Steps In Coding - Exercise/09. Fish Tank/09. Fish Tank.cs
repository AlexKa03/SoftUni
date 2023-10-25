using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percents = double.Parse(Console.ReadLine()) / 100;

            int volume = length * width * height;
            double volumeLiters = volume * 0.001;
            double neededLiters = volumeLiters * (1 - percents);

            Console.WriteLine(neededLiters);
        }
    }
}
