using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0.00;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                double moneyInsert = double.Parse(input);

                if (moneyInsert < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalMoney += moneyInsert;
                Console.WriteLine($"Increase: {moneyInsert:f2}");
            }

            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
