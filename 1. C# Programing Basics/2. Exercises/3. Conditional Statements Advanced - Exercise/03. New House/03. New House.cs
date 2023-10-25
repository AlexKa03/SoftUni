using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double total = 0.0;

            switch (typeFlowers)
            {
                case "Roses":
                    total = quantity * 5;
                    if (quantity > 80)
                    {
                        total = total * 0.9;
                    }
                    break;
                case "Dahlias":
                    total = quantity * 3.8;
                    if (quantity > 90)
                    {
                        total = total * 0.85;
                    }
                    break;
                case "Tulips":
                    total = quantity * 2.8;
                    if (quantity > 80)
                    {
                        total = total * 0.85;
                    }
                    break;
                case "Narcissus":
                    total = quantity * 3;
                    if (quantity < 120)
                    {
                        total = total + (total * 0.15);
                    }
                    break;
                case "Gladiolus":
                    total = quantity * 2.5;
                    if (quantity < 80)
                    {
                        total = total + (total * 0.20);
                    }
                    break;
            }

            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlowers} and {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }
        }
    }
}