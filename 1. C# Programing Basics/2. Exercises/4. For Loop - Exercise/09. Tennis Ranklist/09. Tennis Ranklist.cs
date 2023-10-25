using System;

namespace _09._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            double avgPoints = 0.00;
            double winRate = 0.00;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        points += 2000;
                        avgPoints += 2000;
                        winRate++;
                        break;
                    case "F":
                        points += 1200;
                        avgPoints += 1200;
                        break;
                    case "SF":
                        points += 720;
                        avgPoints += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(avgPoints / tournaments)}");
            Console.WriteLine($"{(winRate / tournaments) * 100:f2}%");

        }
    }
}
