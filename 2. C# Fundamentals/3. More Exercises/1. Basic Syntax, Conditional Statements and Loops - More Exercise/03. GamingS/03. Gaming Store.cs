using System;

namespace _03._GamingS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double balanceCopy = balance;
            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                if (balance == 0)
                {
                    break;
                }
                switch (command)
                {
                    case "OutFall 4":
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            balance -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            balance -= 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            balance -= 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            balance -= 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            balance -= 29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            balance -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance == 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Game Time")
            {
                Console.WriteLine($"Total spent: ${balanceCopy - balance:f2}. Remaining: ${balance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
