using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalNumber = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            sum += number;

            while (sum < goalNumber)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
