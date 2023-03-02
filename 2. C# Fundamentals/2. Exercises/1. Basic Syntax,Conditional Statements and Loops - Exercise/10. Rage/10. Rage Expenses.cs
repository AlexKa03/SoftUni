using System;

namespace _10._Rage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double monitorPrice = double.Parse(Console.ReadLine());

            double expenses = 0;
            int count = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    count++;
                    expenses += keyboardPrice;

                    if (count % 2 == 0)
                    {
                        expenses += monitorPrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
