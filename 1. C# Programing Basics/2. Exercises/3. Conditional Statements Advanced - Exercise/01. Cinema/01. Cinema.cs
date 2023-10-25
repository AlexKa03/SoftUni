using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (ticket == "Premiere")
            {
                income = row * colums * 12;
            }
            else if (ticket == "Normal")
            {
                income = row * colums *7.5;
            }
            else
            {
                income = row * colums * 5;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
