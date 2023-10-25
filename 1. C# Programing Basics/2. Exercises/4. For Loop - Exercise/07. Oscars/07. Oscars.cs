using System;

namespace _07._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            for (int i = 0; i < judges; i++)
            {
                if (points <= 1250.5)
                {
                    string judgeName = Console.ReadLine();
                    double pointsFromJudge = double.Parse(Console.ReadLine());

                    points += (judgeName.Length * pointsFromJudge) / 2;
                }
                else
                {
                    break;
                }
            }

            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
