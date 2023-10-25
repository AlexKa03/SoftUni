using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int pieces = length * width;
            string command = Console.ReadLine();
            bool isntEnough = false;

            while (command != "STOP")
            {
                int nextPieces = int.Parse(command);
                pieces -= nextPieces;

                if (pieces <= 1)
                {
                    isntEnough = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isntEnough)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces - 0)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
