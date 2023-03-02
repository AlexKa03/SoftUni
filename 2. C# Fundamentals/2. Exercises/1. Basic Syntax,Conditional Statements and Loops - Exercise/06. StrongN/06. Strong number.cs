using System;

namespace _06._StrongN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int check = number;

            int total = 0;

            while (number > 0)
            {
                int n = number % 10;
                int factorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                total += factorial;
                number = number / 10;
            }

            if (total == check)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
