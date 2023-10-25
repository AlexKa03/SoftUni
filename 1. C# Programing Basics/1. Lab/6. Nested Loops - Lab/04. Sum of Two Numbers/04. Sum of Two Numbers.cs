using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            bool isFound = false;
            int combinationCounter = 0;

            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    combinationCounter++;

                    if (i + j == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicalNumber})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
