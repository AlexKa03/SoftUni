using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double total = 0.00;
            
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (product)
                    {
                        case "banana":
                            total = 2.5 * quantity;
                            break;
                        case "apple":
                            total = 1.2 * quantity;
                            break;
                        case "orange":
                            total = 0.85 * quantity;
                            break;
                        case "grapefruit":
                            total = 1.45 * quantity;
                            break;
                        case "kiwi":
                            total = 2.7 * quantity;
                            break;
                        case "pineapple":
                            total = 5.5 * quantity;
                            break;
                        case "grapes":
                            total = 3.85 * quantity;
                            break;  
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (product)
                    {
                        case "banana":
                            total = 2.7 * quantity;
                            break;
                        case "apple":
                            total = 1.25 * quantity;
                            break;
                        case "orange":
                            total = 0.9 * quantity;
                            break;
                        case "grapefruit":
                            total = 1.60 * quantity;
                            break;
                        case "kiwi":
                            total = 3.0 * quantity;
                            break;
                        case "pineapple":
                            total = 5.6 * quantity;
                            break;
                        case "grapes":
                            total = 4.2 * quantity;
                            break;
                    }
                    break;
            }

            if (total != 0.00)
            {
                Console.WriteLine($"{total:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
