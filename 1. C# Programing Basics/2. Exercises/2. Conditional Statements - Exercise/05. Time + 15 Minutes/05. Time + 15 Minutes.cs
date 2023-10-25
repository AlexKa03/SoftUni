using System;

namespace _05._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int plusHour = hour;
            int plusMinutes = minutes + 15;

            if (plusMinutes > 59)
            {
                plusHour = hour + (plusMinutes / 60);
                plusMinutes -= 60;
                if (plusHour > 23)
                {
                    plusHour -= 24;
                }
            }

            if (plusMinutes < 10)
            {
                Console.WriteLine($"{plusHour}:0{plusMinutes}");
            }
            else
            {
                Console.WriteLine($"{plusHour}:{plusMinutes}");
            }
        }
    }
}
