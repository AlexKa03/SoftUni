using System;

namespace _11._Smart_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            int toyCounter = 0;
            double moneyTotal = 0;
            int counter = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyTotal += 10 * counter;
                    moneyTotal -= 1;
                    counter++;
                }
                else
                {
                    toyCounter += 1;
                }
            }

            moneyTotal += toyCounter * toysPrice;

            if (moneyTotal >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {moneyTotal - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - moneyTotal:f2}");
            }
        }
    }
}
