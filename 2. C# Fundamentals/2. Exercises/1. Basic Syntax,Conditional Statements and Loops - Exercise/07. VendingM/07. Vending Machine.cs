using System;

namespace _07._VendingM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double total = 0;

            while (command != "Start")
            {
                double money = double.Parse(command);

                switch (money)
                {
                    case 0.1:
                        total += 0.1;
                        break;
                    case 0.2:
                        total += 0.2;
                        break;
                    case 0.5:
                        total += 0.5;
                        break;
                    case 1:
                        total += 1;
                        break;
                    case 2:
                        total += 2;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {money}");
                        break;
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        if (total >= 2)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                            total -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (total >= 0.7)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                            total -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (total >= 1.5)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                            total -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (total >= 0.8)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                            total -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (total >= 1)
                        {
                            Console.WriteLine($"Purchased {command.ToLower()}");
                            total -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {total:f2}");
        }
    }
}
