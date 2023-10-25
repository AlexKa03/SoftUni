using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int playTime = (restDays * 127) + ((365 - restDays) * 63);

            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(playTime - 30000) / 60} hours and {(playTime - 30000) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000 - playTime) / 60} hours and {(30000 - playTime) % 60} minutes less for play");
            }
        }
    }
}
