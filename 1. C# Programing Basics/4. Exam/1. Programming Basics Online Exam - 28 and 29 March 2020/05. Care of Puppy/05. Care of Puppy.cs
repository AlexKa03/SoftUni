using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            food *= 1000;

            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int eaten = int.Parse(command);

                food -= eaten;

                command = Console.ReadLine();
            }

            if (food >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(food)} grams more.");
            }
        }
    }
}
