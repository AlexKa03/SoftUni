using System;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double total = 0.0;

            switch (sport)
            {
                case "Gym":
                    if (gender == "m")
                    {
                        total = 42;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    else
                    {
                        total = 35;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    break;
                case "Boxing":
                    if (gender == "m")
                    {
                        total = 41;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    else
                    {
                        total = 37;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    break;
                case "Yoga":
                    if (gender == "m")
                    {
                        total = 45;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    else
                    {
                        total = 42;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    break;
                case "Zumba":
                    if (gender == "m")
                    {
                        total = 34;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    else
                    {
                        total = 31;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    break;
                case "Dances":
                    if (gender == "m")
                    {
                        total = 51;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    else
                    {
                        total = 53;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    break;
                case "Pilates":
                    if (gender == "m")
                    {
                        total = 39;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    else
                    {
                        total = 37;

                        if (age <= 19)
                        {
                            total *= 0.8;
                        }
                        moneyAvailable -= total;
                    }
                    break;
            }

            if (moneyAvailable >= 0)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(moneyAvailable):f2} more.");
            }
        }
    }
}
