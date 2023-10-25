using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double output = 0.00;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        output = 0.5 * quantity;
                        break;
                    case "water":
                        output = 0.8 * quantity;
                        break;
                    case "beer":
                        output = 1.2 * quantity;
                        break;
                    case "sweets":
                        output = 1.45 * quantity;
                        break;
                    case "peanuts":
                        output = 1.6 * quantity;
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        output = 0.4 * quantity;
                        break;
                    case "water":
                        output = 0.7 * quantity;
                        break;
                    case "beer":
                        output = 1.15 * quantity;
                        break;
                    case "sweets":
                        output = 1.30 * quantity;
                        break;
                    case "peanuts":
                        output = 1.5 * quantity;
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        output = 0.45 * quantity;
                        break;
                    case "water":
                        output = 0.7 * quantity;
                        break;
                    case "beer":
                        output = 1.1 * quantity;
                        break;
                    case "sweets":
                        output = 1.35 * quantity;
                        break;
                    case "peanuts":
                        output = 1.55 * quantity;
                        break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
