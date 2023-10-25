using System;

namespace _03._Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            double total = 0.0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        total = number * (2 * 56);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    else
                    {
                        total = number * (5 * 28.7);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        total = number * (2 * 36.66);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    else
                    {
                        total = number * (5 * 19.6);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        total = number * (2 * 42.1);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    else
                    {
                        total = number * (5 * 24.8);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        total = number * (2 * 20);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    else
                    {
                        total = number * (5 * 15.2);

                        if (total >= 400 && total <= 1000)
                        {
                            total *= 0.85;
                        }
                        else if (total >= 1000)
                        {
                            total *= 0.5;
                        }
                    }
                    break;
            }

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
