using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = length * width * height;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int nextBoxes = int.Parse(command);
                freeSpace -= nextBoxes;

                if (freeSpace < 0)
                {
                    break;
                }
                
                command = Console.ReadLine();
            }

            if (freeSpace < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
