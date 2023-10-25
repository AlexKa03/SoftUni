using System;

namespace _13._Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();
            double total = 0.00;

            switch (roomType)
            {
                case "room for one person":
                    total = 18.0 * (days - 1);

                    if (grade == "positive")
                    {
                        total += total * 0.25;
                    }
                    else
                    {
                        total -= total * 0.1;
                    }
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        total = (days - 1) * (25 - (25 * 0.3));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = (days - 1) * (25 - (25 * 0.35));
                    }
                    else
                    {
                        total = (days - 1) * (25 - (25 * 0.5));
                    }

                    if (grade == "positive")
                    {
                        total += total * 0.25;
                    }
                    else
                    {
                        total -= total * 0.1;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        total = (days - 1) * (35 - (35 * 0.1));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = (days - 1) * (35 - (35 * 0.15));
                    }
                    else
                    {
                        total = (days - 1) * (35 - (35 * 0.20));
                    }

                    if (grade == "positive")
                    {
                        total += total * 0.25;
                    }
                    else
                    {
                        total -= total * 0.1;
                    }
                    break;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
