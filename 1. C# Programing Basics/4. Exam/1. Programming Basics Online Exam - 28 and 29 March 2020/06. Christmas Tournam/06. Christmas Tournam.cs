using System;

namespace _06._Christmas_Tournam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            string sport = Console.ReadLine();

            double total = 0.0;

            int counterDayWon = 0;
            int counterDayLose = 0;

            for (int i = 1; i <= days; i++)
            {
                int counterWin = 0;
                int counterLose = 0;
                
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        counterWin++;
                    }
                    else
                    {
                        counterLose++;
                    }

                    sport = Console.ReadLine();
                }

                total += counterWin * 20;

                if (counterWin > counterLose)
                {
                    counterDayWon++;

                    total *= 1.1;
                }
                else
                {
                    counterDayLose++;
                }
            }

            if (counterDayWon > counterDayLose)
            {
                total *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {total:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {total:f2}");
            }
        }
    }
}
