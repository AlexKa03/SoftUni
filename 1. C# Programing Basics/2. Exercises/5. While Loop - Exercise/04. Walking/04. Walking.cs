using System;
using static System.Net.Mime.MediaTypeNames;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;

            while (steps < 10000)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    command = Console.ReadLine();
                    int lastSteps = int.Parse(command);
                    steps += lastSteps;
                    break;
                }
                    int nextSteps = int.Parse(command);
                steps += nextSteps;
            }

            if (steps > 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
        }
    }
}
