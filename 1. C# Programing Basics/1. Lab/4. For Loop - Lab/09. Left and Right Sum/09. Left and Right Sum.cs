using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                int numberX = int.Parse(Console.ReadLine());
                leftSum += numberX;
            }

            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int numberZ = int.Parse(Console.ReadLine());
                rightSum += numberZ;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
