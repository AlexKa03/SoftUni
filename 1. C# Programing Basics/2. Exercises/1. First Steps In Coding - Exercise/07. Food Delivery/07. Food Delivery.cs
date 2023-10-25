using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMoney = chickenMenu * 10.35;
            double fishMoney = fishMenu * 12.40;
            double vegetarianMoney = vegetarianMenu * 8.15;
            double total = (1.2 * (chickenMoney + fishMoney + vegetarianMoney)) + 2.50;

            Console.WriteLine(total);
        }
    }
}
