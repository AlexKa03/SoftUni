using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counterCase = 0;
            int counter = 0;

            while (command != "End")
            {
                double volumeCase = double.Parse(command);

                counter++;

                if (counter % 3 == 0)
                {
                    volumeCase *= 1.1;
                }

                capacity -= volumeCase;

                if (capacity < 0)
                {
                    break;
                }

                counterCase++;

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }

            Console.WriteLine($"Statistic: {counterCase} suitcases loaded.");
        }
    }
}
