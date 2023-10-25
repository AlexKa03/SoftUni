using System;

namespace _07._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzelsMoney = puzzels * 2.60;
            double dollsMoney = dolls * 3;
            double bearsMoney = bears * 4.10;
            double minionsMoney = minions * 8.20;
            double trucksMoney = trucks * 2;

            double totalMoney = puzzelsMoney + dollsMoney + bearsMoney + minionsMoney + trucksMoney;
            double toys = puzzels + dolls + bears + minions + trucks;

            if (toys >= 50)
            {
                totalMoney = totalMoney - (totalMoney * 0.25);
            }

            double rent = totalMoney * 0.1;
            totalMoney -= rent;

            if (totalMoney >= trip)
            {
                double moneyLeft = totalMoney - trip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = trip - totalMoney;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
