using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            while (age >= 0 && age <= 122)
            {
                if (dayOfWeek == "weekday")
                {
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    else if (age >= 19 && age <= 64)
                    {
                        price = 18;
                    }
                    else if (age >= 65 && age <= 122)
                    {
                        price = 12;
                    }
                }
                else if (dayOfWeek == "weekend")
                {
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    else if (age >= 19 && age <= 64)
                    {
                        price = 20;
                    }
                    else if (age >= 65 && age <= 122)
                    {
                        price = 15;
                    }
                }
                else
                {
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age >= 19 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age >= 65 && age <= 122)
                    {
                        price = 10;
                    }
                }

                Console.WriteLine($"{price}$");
                break;
            }

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
