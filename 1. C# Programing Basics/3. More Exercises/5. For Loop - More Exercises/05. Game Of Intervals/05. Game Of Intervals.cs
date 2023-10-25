using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double intervalOne = 0.00;
            double intervalTwo = 0.00;
            double intervalThree = 0.00;
            double intervalFour = 0.00;
            double intervalFive = 0.00;
            double invalidNumbers = 0.00;
            double points = 0.00;

            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    points += number * 0.2;
                    intervalOne++;
                }
                else if (number >= 10 && number <= 19)
                {
                    points += number * 0.3;
                    intervalTwo++;
                }
                else if (number >= 20 && number <= 29)
                {
                    points += number * 0.4;
                    intervalThree++;
                }
                else if (number >= 30 && number <= 39)
                {
                    points += 50;
                    intervalFour++;
                }
                else if (number >= 40 && number <= 50)
                {
                    points += 100;
                    intervalFive++;
                }
                else
                {
                    points /= 2;
                    invalidNumbers++;
                }
            }

            intervalOne = 100 * (intervalOne / moves);
            intervalTwo = 100 * (intervalTwo / moves);
            intervalThree = 100 * (intervalThree / moves);
            intervalFour = 100 * (intervalFour / moves);
            intervalFive = 100 * (intervalFive / moves);
            invalidNumbers = 100 * (invalidNumbers / moves);

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {intervalOne:f2}%");
            Console.WriteLine($"From 10 to 19: {intervalTwo:f2}%");
            Console.WriteLine($"From 20 to 29: {intervalThree:f2}%");
            Console.WriteLine($"From 30 to 39: {intervalFour:f2}%");
            Console.WriteLine($"From 40 to 50: {intervalFive:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers:f2}%");
        }
    }
}
