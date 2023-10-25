using System;

namespace _02._Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int dailyWalks = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());

            int caloriesBurned = (minutesWalk * dailyWalks) * 5;

            if (caloriesTaken / 2 <= caloriesBurned)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
