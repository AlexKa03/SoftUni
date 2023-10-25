using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleeps = int.Parse(Console.ReadLine());
            double apartment = 0.00;
            double studio = 0.00;

            if (month == "May" || month == "October")
            {
                apartment = 65 * sleeps;
                studio = 50 * sleeps;
                if (sleeps > 7 && sleeps <= 14)
                {
                    studio *= 0.95;
                }
                else if (sleeps > 14)
                {
                    studio *= 0.7;
                    apartment *= 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                apartment = 68.70 * sleeps;
                studio = 75.20 * sleeps;
                if (sleeps > 14)
                {
                    studio *= 0.8;
                    apartment *= 0.9;
                }
            }
            else
            {
                apartment = 77 * sleeps;
                studio = 76 * sleeps;
                if (sleeps > 14)
                {
                    apartment *= 0.9;
                }
            }

            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}