using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayWeek = Console.ReadLine();

            double total = 0.00;

            if (dayWeek == "Friday")
            {
                if (typeGroup == "Students")
                {
                    total = 8.45 * countPeople;

                    if (countPeople >= 30)
                    {
                        total *= 0.85;
                    }
                }
                else if (typeGroup == "Business")
                {
                    total = 10.90 * countPeople;

                    if (countPeople >= 100)
                    {
                        total = 10.90 * (countPeople - 10);
                    }
                }
                else if (typeGroup == "Regular")
                {
                    total = 15 * countPeople;

                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        total *= 0.95;
                    }
                }
            }
            else if (dayWeek == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    total = 9.80 * countPeople;

                    if (countPeople >= 30)
                    {
                        total *= 0.85;
                    }
                }
                else if (typeGroup == "Business")
                {
                    total = 15.60 * countPeople;

                    if (countPeople >= 100)
                    {
                        total = 15.60 * (countPeople - 10);
                    }
                }
                else if (typeGroup == "Regular")
                {
                    total = 20 * countPeople;

                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        total *= 0.95;
                    }
                }
            }
            else if (dayWeek == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    total = 10.46 * countPeople;

                    if (countPeople >= 30)
                    {
                        total *= 0.85;
                    }
                }
                else if (typeGroup == "Business")
                {
                    total = 16 * countPeople;

                    if (countPeople >= 100)
                    {
                        total = 16 * (countPeople - 10);
                    }
                }
                else if (typeGroup == "Regular")
                {
                    total = 22.50 * countPeople;

                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        total *= 0.95;
                    }
                }
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
