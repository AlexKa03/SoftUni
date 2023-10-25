using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double transport = 0.00;
            double total = 0.00;

            switch (ticketType)
            {
                case "VIP":
                    if (count >= 1 && count <= 4)
                    {
                        transport = budget * 0.75;
                        total = transport + (count * 499.99);                        
                    }
                    else if (count >= 5 && count <= 9)
                    {
                        transport = budget * 0.6;
                        total = transport + (count * 499.99);
                    }
                    else if (count >= 10 && count <= 24)
                    {
                        transport = budget * 0.5;
                        total = transport + (count * 499.99);
                    }
                    else if (count >= 25 && count <= 49)
                    {
                        transport = budget * 0.4;
                        total = transport + (count * 499.99);                    
                    }
                    else
                    {
                        transport = budget * 0.25;
                        total = transport + (count * 499.99);
                    }
                    break;
                case "Normal":
                    if (count >= 1 && count <= 4)
                    {
                        transport = budget * 0.75;
                        total = transport + (count * 249.99);
                    }
                    else if (count >= 5 && count <= 9)
                    {
                        transport = budget * 0.6;
                        total = transport + (count * 249.99);
                    }
                    else if (count >= 10 && count <= 24)
                    {
                        transport = budget * 0.5;
                        total = transport + (count * 249.99);
                    }
                    else if (count >= 25 && count <= 49)
                    {
                        transport = budget * 0.4;
                        total = transport + (count * 249.99);
                    }
                    else
                    {
                        transport = budget * 0.25;
                        total = transport + (count * 249.99);
                    }
                    break;
            }

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva.");
            }
        }
    }
}
