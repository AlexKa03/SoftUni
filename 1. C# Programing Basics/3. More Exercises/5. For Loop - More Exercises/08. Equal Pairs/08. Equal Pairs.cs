using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());

            double sum = 0.00;
            double diff = 0.00;
            double maxDiff = 0.00;

            for (int i = 0; i < pairs; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double currentSum = num1 + num2;

                if (i == 0)
                {
                    sum = currentSum;
                }
                else
                {
                    diff = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
