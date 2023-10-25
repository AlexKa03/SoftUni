using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                if (i == floors)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                }
                else if (i % 2 == 1)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                else
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
