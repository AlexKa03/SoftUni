using System;

namespace _06._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extraActors = int.Parse(Console.ReadLine());
            double clothesCost = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double clothesMoney = extraActors * clothesCost;
            if (extraActors > 150)
            {
                clothesMoney = clothesMoney - (clothesMoney * 0.1);
            }

            double totalExpense = decor + clothesMoney;

            if (totalExpense > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalExpense - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalExpense:f2} leva left.");
            }
        }
    }
}
